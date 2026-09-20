namespace QuizApp
{
    partial class QuizReport
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        public void InitializeComponent()
        {
            this.SuspendLayout();

            // QuizReport
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1248, 859);
            this.Name = "QuizReport";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "QuizReport";
            this.ResumeLayout(false);
        }
    }
}