namespace YTDownloader
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelProgram = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelDownloadText = new System.Windows.Forms.Label();
            this.panelDownloadButton = new System.Windows.Forms.Panel();
            this.pictureBoxDownload = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProgress = new System.Windows.Forms.TextBox();
            this.panelProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDownloadButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownload)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProgram
            // 
            this.panelProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panelProgram.Controls.Add(this.pictureBoxLogo);
            this.panelProgram.Controls.Add(this.panel2);
            this.panelProgram.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProgram.Location = new System.Drawing.Point(0, 0);
            this.panelProgram.Name = "panelProgram";
            this.panelProgram.Size = new System.Drawing.Size(130, 379);
            this.panelProgram.TabIndex = 0;
            this.panelProgram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelProgram_MouseDown);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(98, 88);
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLogo_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(136, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 74);
            this.panel2.TabIndex = 1;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTitle.Controls.Add(this.pictureBox2);
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(130, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(475, 100);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::YTDownloader.Properties.Resources.minimizeImage;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(408, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 30);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(443, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Yu Gothic Light", 27.25F);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(9, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(356, 48);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "YouTube Downloader";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(147, 187);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(203, 20);
            this.textBoxURL.TabIndex = 3;
            // 
            // labelDownloadText
            // 
            this.labelDownloadText.AutoSize = true;
            this.labelDownloadText.Font = new System.Drawing.Font("Yu Gothic Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDownloadText.Location = new System.Drawing.Point(42, 6);
            this.labelDownloadText.Name = "labelDownloadText";
            this.labelDownloadText.Size = new System.Drawing.Size(156, 42);
            this.labelDownloadText.TabIndex = 4;
            this.labelDownloadText.Text = "Download";
            this.labelDownloadText.Click += new System.EventHandler(this.labelDownloadText_Click);
            // 
            // panelDownloadButton
            // 
            this.panelDownloadButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDownloadButton.Controls.Add(this.pictureBoxDownload);
            this.panelDownloadButton.Controls.Add(this.labelDownloadText);
            this.panelDownloadButton.Location = new System.Drawing.Point(147, 222);
            this.panelDownloadButton.Name = "panelDownloadButton";
            this.panelDownloadButton.Size = new System.Drawing.Size(203, 50);
            this.panelDownloadButton.TabIndex = 5;
            this.panelDownloadButton.Click += new System.EventHandler(this.panelDownloadButton_Click);
            // 
            // pictureBoxDownload
            // 
            this.pictureBoxDownload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDownload.BackgroundImage")));
            this.pictureBoxDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDownload.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxDownload.Name = "pictureBoxDownload";
            this.pictureBoxDownload.Size = new System.Drawing.Size(43, 42);
            this.pictureBoxDownload.TabIndex = 2;
            this.pictureBoxDownload.TabStop = false;
            this.pictureBoxDownload.Click += new System.EventHandler(this.pictureBoxDownload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "YouTube Link";
            // 
            // textBoxProgress
            // 
            this.textBoxProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProgress.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxProgress.Location = new System.Drawing.Point(147, 287);
            this.textBoxProgress.Name = "textBoxProgress";
            this.textBoxProgress.ReadOnly = true;
            this.textBoxProgress.Size = new System.Drawing.Size(203, 20);
            this.textBoxProgress.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(605, 379);
            this.Controls.Add(this.textBoxProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDownloadButton);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Video Downloader";
            this.panelProgram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDownloadButton.ResumeLayout(false);
            this.panelDownloadButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProgram;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxDownload;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelDownloadText;
        private System.Windows.Forms.Panel panelDownloadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxProgress;
    }
}

