namespace VideoScreensaver
{
    partial class ScreenSaverForm
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
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).BeginInit();
            this.SuspendLayout();
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView1.Location = new System.Drawing.Point(0, 0);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(800, 450);
            this.videoView1.TabIndex = 1;
            this.videoView1.Text = "videoView1";
            this.videoView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.videoView1_KeyDown);
            this.videoView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.videoView1_MouseDown);
            this.videoView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.videoView1_MouseMove);
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.videoView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScreenSaverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VideoScreenSaver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LibVLCSharp.WinForms.VideoView videoView1;
    }
}

