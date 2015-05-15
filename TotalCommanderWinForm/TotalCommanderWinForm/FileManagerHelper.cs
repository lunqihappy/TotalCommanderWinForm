using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TotalCommanderWinForm
{
    public static class FileManagerHelper
    {
        public static Task CopyAsync(IEnumerable<string> paths, string destination, IProgress<int> progress = null)
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

        public static Task MoveAsync(IEnumerable<string> paths, string destination, IProgress<int> progress = null)
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

        public static Task CustomCopyAsync(IEnumerable<string> paths, string destination, CancellationToken cancellationToken, IProgress<int> progress = null)
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

                    if (cancellationToken.IsCancellationRequested)
                    {
                        return;
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
                                if (cancellationToken.IsCancellationRequested)
                                {
                                    return;
                                }

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

        public static Task CustomMoveAsync(IEnumerable<string> paths, string destination, CancellationToken cancellationToken, IProgress<int> progress = null)
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

                    if (cancellationToken.IsCancellationRequested)
                    {
                        return;
                    }

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
                                if (cancellationToken.IsCancellationRequested)
                                {
                                    return;
                                }

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

                if (cancellationToken.IsCancellationRequested)
                {
                    return;
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

        public static Task CustomDeleteAsync(IEnumerable<string> paths, CancellationToken cancellationToken, IProgress<int> progress = null)
        {
            return Task.Run(() =>
            {
                if (!paths.Any())
                    return;

                int i = 0;

                foreach (var path in paths)
                {
                    if (!File.Exists(path))
                        continue;

                    File.Delete(path);

                    i++;
                    if (progress != null)
                    {
                        progress.Report(i / paths.Count());
                    }
                }
            });
        }

        public static bool HasWritePermissionOnDir(string path)
        {
            var writeAllow = false;
            var writeDeny = false;
            var accessControlList = Directory.GetAccessControl(path);
            if (accessControlList == null)
                return false;
            var accessRules = accessControlList.GetAccessRules(true, true,
                                        typeof(System.Security.Principal.SecurityIdentifier));
            if (accessRules == null)
                return false;

            foreach (FileSystemAccessRule rule in accessRules)
            {
                if ((FileSystemRights.Write & rule.FileSystemRights) != FileSystemRights.Write)
                    continue;

                if (rule.AccessControlType == AccessControlType.Allow)
                    writeAllow = true;
                else if (rule.AccessControlType == AccessControlType.Deny)
                    writeDeny = true;
            }

            return writeAllow && !writeDeny;
        }

        public static bool HasReadPermissionOnDir(string path)
        {
            var writeAllow = false;
            var writeDeny = false;
            var accessControlList = Directory.GetAccessControl(path);
            if (accessControlList == null)
                return false;
            var accessRules = accessControlList.GetAccessRules(true, true,
                                        typeof(System.Security.Principal.SecurityIdentifier));
            if (accessRules == null)
                return false;

            foreach (FileSystemAccessRule rule in accessRules)
            {
                if ((FileSystemRights.Read & rule.FileSystemRights) != FileSystemRights.Read)
                    continue;

                if (rule.AccessControlType == AccessControlType.Allow)
                    writeAllow = true;
                else if (rule.AccessControlType == AccessControlType.Deny)
                    writeDeny = true;
            }

            return writeAllow && !writeDeny;
        }
    }
}
