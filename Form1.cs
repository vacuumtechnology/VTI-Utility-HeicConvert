using ImageMagick;

namespace VTI_Utility_HeicConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(HeicFilePath.Text))
            {
                FileInfo f = new FileInfo(HeicFilePath.Text);
                if (f.Exists)
                {
                    // confirm image still exists
                    SaveFileDialog d = new SaveFileDialog();
                    string format = FormatSelect.SelectedItem != null ? FormatSelect.SelectedItem.ToString() : "";
                    d.Filter = $"Image|{format}";
                    d.FileName = f.FullName.Replace(".heic", format);
                    d.Title = "Save As";
                    d.ShowDialog();
                    bool abort = false;
                    if (!string.IsNullOrEmpty(d.FileName))
                    {
                        using (MagickImage img = new MagickImage(f.FullName))
                        {
                            switch (format)
                            {
                                case ".jpg":
                                    img.Format = MagickFormat.Jpg;
                                    break;
                                case ".bmp":
                                    img.Format = MagickFormat.Bmp;
                                    break;
                                case ".png":
                                    img.Format = MagickFormat.Png;
                                    break;
                                default:
                                    abort = true;
                                    break;
                            }

                            if (abort)
                            {
                                MessageBox.Show("Please select a format");
                                return;
                            }

                            img.Write(d.FileName);
                        }
                    }
                }
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "(*.heic)|*.heic";
            d.Title = "Select a HEIC Image file to convert";
            d.ShowDialog();

            if (!string.IsNullOrEmpty(d.FileName))
            {
                FileInfo f = new FileInfo(d.FileName);
                if (f.Exists)
                {
                    HeicFilePath.Text = f.FullName;
                }
            }
        }

        private void setSaveEnabled()
        {
            saveBtn.Enabled = (FormatSelect.SelectedIndex > -1 && !string.IsNullOrEmpty(HeicFilePath.Text));
        }

        private void FormatSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSaveEnabled();
        }
    }
}