namespace PerryThePlatipusDetector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnGetFile = new Button();
            pboxPreview = new PictureBox();
            lblResult = new Label();
            lblCertainty = new Label();
            ((System.ComponentModel.ISupportInitialize)pboxPreview).BeginInit();
            SuspendLayout();
            // 
            // btnGetFile
            // 
            btnGetFile.Location = new Point(28, 355);
            btnGetFile.Name = "btnGetFile";
            btnGetFile.Size = new Size(150, 46);
            btnGetFile.TabIndex = 1;
            btnGetFile.Text = "Upload File";
            btnGetFile.UseVisualStyleBackColor = true;
            btnGetFile.Click += btnGetFile_Click;
            // 
            // pboxPreview
            // 
            pboxPreview.Location = new Point(297, 58);
            pboxPreview.Name = "pboxPreview";
            pboxPreview.Size = new Size(459, 291);
            pboxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pboxPreview.TabIndex = 2;
            pboxPreview.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(297, 355);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(102, 32);
            lblResult.TabIndex = 3;
            lblResult.Text = "Nothing";
            // 
            // lblCertainty
            // 
            lblCertainty.AutoSize = true;
            lblCertainty.Location = new Point(297, 387);
            lblCertainty.Name = "lblCertainty";
            lblCertainty.Size = new Size(47, 32);
            lblCertainty.TabIndex = 4;
            lblCertainty.Text = "0%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCertainty);
            Controls.Add(lblResult);
            Controls.Add(pboxPreview);
            Controls.Add(btnGetFile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Perry the Platypus detector";
            ((System.ComponentModel.ISupportInitialize)pboxPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGetFile;
        private PictureBox pboxPreview;
        private Label lblResult;
        private Label lblCertainty;
    }
}