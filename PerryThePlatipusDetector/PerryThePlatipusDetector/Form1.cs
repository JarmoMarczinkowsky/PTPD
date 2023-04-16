namespace PerryThePlatipusDetector
{
    public partial class Form1 : Form
    {
        byte[] getImg;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnGetFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            lblResult.Text = "Loading...";
            lblCertainty.Text = "Loading...";

            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pboxPreview.Image = new Bitmap(ofd.FileName);
                getImg = File.ReadAllBytes(ofd.FileName);
            }

            if (getImg == null)
            {
                MessageBox.Show("Please select an image first!");
                return;
            }

            //Load sample data
            var imageBytes = getImg;
            PerryDetector.ModelInput sampleData = new PerryDetector.ModelInput()
            {
                ImageSource = imageBytes,
            };

            //Load model and predict output
            var result = PerryDetector.Predict(sampleData);

            lblResult.Text = $"Result: {result.PredictedLabel}";
            lblCertainty.Text = $"Certainty {Math.Round(result.Score.Max(), 3) * 100}%";
        }
    }
}