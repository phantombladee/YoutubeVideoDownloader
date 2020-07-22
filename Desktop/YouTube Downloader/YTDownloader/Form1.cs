using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using VideoLibrary;

namespace YTDownloader
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelProgram_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelDownloadButton_Click(object sender, EventArgs e)
        {
            string video_url = textBoxURL.Text;

            async void downloadVideo()
            {
                var youtube = YouTube.Default;
                try
                {
                    var video = youtube.GetVideo(video_url);
                    var client = new HttpClient();
                    long? totalByte = 0;
                    var writePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + video.FullName;


                    using (Stream output = File.OpenWrite(writePath))
                    {
                        using (var request = new HttpRequestMessage(HttpMethod.Head, video.Uri))
                        {
                            totalByte = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result.Content.Headers.ContentLength;
                        }
                        using (var input = await client.GetStreamAsync(video.Uri))
                        {
                            byte[] buffer = new byte[16 * 1024];
                            int read;
                            int totalRead = 0;
                            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                output.Write(buffer, 0, read);
                                totalRead += read;
                                Invoke(new Action(() =>
                                {
                                    textBoxProgress.Text = Convert.ToString($"{totalRead}/{totalByte}");
                                    textBoxProgress.Update();
                                }));
                            }
                            Invoke(new Action(() =>
                            {
                                textBoxProgress.Text = $"\tDownload Complete";
                            }));
                        }
                    }
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("The Link / URL you have entered is invalid!", "Error - Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            Thread thread = new Thread(new ThreadStart(downloadVideo));
            thread.Start();

        }

        private void pictureBoxDownload_Click(object sender, EventArgs e)
        {
            panelDownloadButton_Click(sender, e);
        }

        private void labelDownloadText_Click(object sender, EventArgs e)
        {
            panelDownloadButton_Click(sender, e);
        }

        private void pictureBoxLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
