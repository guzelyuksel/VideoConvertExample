using NReco.VideoConverter;
using System;
using System.Windows.Forms;

namespace VideoConvertExample
{
    public partial class Form1 : Form
    {
        string VideoPath, VideoName, MusicPath, MusicName;
        FFMpegConverter Converter = new FFMpegConverter();


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFromTo_Click(object sender, EventArgs e)
        {
            OpenFileDialog VideoOpenDialog = new OpenFileDialog() { Multiselect = false, Filter = "MP4 File|*.mp4" };
            if (VideoOpenDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(VideoOpenDialog.FileName))
                {
                    VideoPath = VideoOpenDialog.FileName;
                    VideoName = VideoOpenDialog.SafeFileName;
                }
            }
            VideoTxt.Text = VideoPath;
        }
        private void BtnSaveTo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog SaveMusicDialog = new FolderBrowserDialog();
            if (SaveMusicDialog.ShowDialog() == DialogResult.OK)
            {
                MusicPath = SaveMusicDialog.SelectedPath;
                MusicName = VideoName.Substring(0, VideoName.Length - 4);
                MusicPath += ("\\" + MusicName + ".mp3");
            }
            Mp3Txt.Text = MusicPath;
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            Converter.ConvertProgress += UpdateProgress;
            Converter.ConvertMedia(VideoTxt.Text.Trim(), Mp3Txt.Text.Trim(), "mp3");

        }

        private void UpdateProgress(object sender, ConvertProgressEventArgs e)
        {
            double TotalTime = e.TotalDuration.TotalSeconds;
            double ProcessedTime = e.Processed.TotalSeconds;

            double Percent = (ProcessedTime / TotalTime) * 100;
            progressBar1.Invoke(new Action(() =>
            {
                progressBar1.Value = (int)Percent;
            }));
        }
    }
}
