using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommanderWinForm
{
    public static class FileManagerHelper
    {
        public static Task Copy(IEnumerable<string> paths, string destination, IProgress<int> progress)
        {
            return Task.Run(() =>
            {
                if (!paths.Any() || !Directory.Exists(destination))
                    return;

                int i = 0;

                foreach (var path in paths)
                {
                    if (File.Exists(Path.Combine(destination, Path.GetFileName(path))))
                        continue;

                    File.Copy(path,  Path.Combine(destination, Path.GetFileName(path)));
                    
                    i++;
                    if (progress != null)
                    {
                        progress.Report(i / paths.Count());
                    }
                }
            });
        }

        public static Task Move(IEnumerable<string> paths, string destination, IProgress<int> progress)
        {
            return Task.Run(() =>
            {
                if (!paths.Any() || !Directory.Exists(destination))
                    return;

                int i = 0;

                foreach (var path in paths)
                {
                    if (File.Exists(Path.Combine(destination, Path.GetFileName(path))))
                        continue;

                    File.Move(path, Path.Combine(destination, Path.GetFileName(path)));

                    i++;
                    if (progress != null)
                    {
                        progress.Report(i / paths.Count());
                    }
                }
            });
        }

        public static Task CustomCopy(IEnumerable<string> paths, string destination, IProgress<int> progress)
        {
            return Task.Run(() =>
            {
                if (!paths.Any() || !Directory.Exists(destination))
                    return;

                long totalLength = 0;
                long totalCopiedBytes = 0;
                foreach (var path in paths)
                {
                    totalLength += (new FileInfo(path).Length);
                }


                foreach (var path in paths)
                {
                    if (File.Exists(Path.Combine(destination, Path.GetFileName(path))))
                        continue;

                    byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
                    

                    using (FileStream source = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        long fileLength = source.Length;
                        using (FileStream dest = new FileStream(Path.Combine(destination, Path.GetFileName(path)), FileMode.CreateNew, FileAccess.Write))
                        {
                            int currentBlockSize = 0;
                            int latPersentage = 0;
                            while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                totalCopiedBytes += currentBlockSize;
                                int persentage = (int)(totalCopiedBytes * 100 / totalLength);

                                dest.Write(buffer, 0, currentBlockSize);

                                if (progress != null
                                    && latPersentage != persentage)
                                {
                                    progress.Report(persentage);
                                    latPersentage = persentage;
                                }
                            }
                        }
                    }
                }
            });
        }

        public static Task CustomMove(IEnumerable<string> paths, string destination, IProgress<int> progress)
        {
            return Task.Run(() =>
            {
                if (!paths.Any() || !Directory.Exists(destination))
                    return;

                long totalLength = 0;
                long totalCopiedBytes = 0;
                foreach (var path in paths)
                {
                    totalLength += (new FileInfo(path).Length);
                }


                foreach (var path in paths)
                {
                    if (File.Exists(Path.Combine(destination, Path.GetFileName(path))))
                    {
                        totalCopiedBytes += (new FileInfo(path).Length);
                        continue;
                    }

                    byte[] buffer = new byte[1024 * 1024]; // 1MB buffer


                    using (FileStream source = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        long fileLength = source.Length;
                        using (FileStream dest = new FileStream(Path.Combine(destination, Path.GetFileName(path)), FileMode.CreateNew, FileAccess.Write))
                        {
                            int currentBlockSize = 0;
                            int latPersentage = 0;
                            while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                totalCopiedBytes += currentBlockSize;
                                int persentage = (int)(totalCopiedBytes * 100 / totalLength);

                                dest.Write(buffer, 0, currentBlockSize);

                                if (progress != null
                                    && latPersentage != persentage)
                                {
                                    progress.Report(persentage);
                                    latPersentage = persentage;
                                }
                            }
                        }
                    }
                }

                if (totalLength == totalCopiedBytes)
                {
                    foreach (var path in paths)
                    {
                        File.Delete(path);
                    }
                }
            });
        }
    }
}
