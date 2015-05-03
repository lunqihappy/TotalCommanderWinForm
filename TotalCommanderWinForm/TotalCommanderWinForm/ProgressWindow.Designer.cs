namespace TotalCommanderWinForm
{
    partial class ProgressWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.v_ProgressBar_Progress = new System.Windows.Forms.ProgressBar();
            this.v_Button_Background = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // v_ProgressBar_Progress
            // 
            this.v_ProgressBar_Progress.Location = new System.Drawing.Point(29, 12);
            this.v_ProgressBar_Progress.Name = "v_ProgressBar_Progress";
            this.v_ProgressBar_Progress.Size = new System.Drawing.Size(463, 23);
            this.v_ProgressBar_Progress.TabIndex = 0;
            // 
            // v_Button_Background
            // 
            this.v_Button_Background.AutoSize = true;
            this.v_Button_Background.Location = new System.Drawing.Point(211, 44);
            this.v_Button_Background.Name = "v_Button_Background";
            this.v_Button_Background.Size = new System.Drawing.Size(94, 27);
            this.v_Button_Background.TabIndex = 1;
            this.v_Button_Background.Text = "Background";
            this.v_Button_Background.UseVisualStyleBackColor = true;
            this.v_Button_Background.Click += new System.EventHandler(this.v_Button_Background_Click);
            // 
            // ProgressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 83);
            this.Controls.Add(this.v_Button_Background);
            this.Controls.Add(this.v_ProgressBar_Progress);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressWindow";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar v_ProgressBar_Progress;
        private System.Windows.Forms.Button v_Button_Background;
    }
}