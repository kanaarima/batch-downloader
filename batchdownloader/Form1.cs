namespace batchdownloader
{
    public partial class main : Form
    {

        public downloader manager = null;

        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.pathtextbox.Text = fbd.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.FileName))
                {
                    this.listpathtextbox.Text = fbd.FileName;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (manager != null)
            {
                this.manager.started = false;
                this.manager = null;
            }
            else
            {
                try
                {
                    var already_downloaded = new songfolderreader(pathtextbox.Text);
                    var setids = new filereader(listpathtextbox.Text);
                    this.manager = new downloader(updatetextbox, updatelabel, updatebar, pathtextbox.Text, setids.beatmapset_ids, already_downloaded.beatmapset_ids);
                    this.manager.start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void listpathtextbox_TextChanged(object sender, EventArgs e)
        {
            startbutton.Enabled = listpathtextbox.Text.Length > 0;
        }
    }
}