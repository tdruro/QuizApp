using System.Windows.Forms;
using System.Drawing;

namespace QuizApp
{
    partial class CreateQuiz
    {
        System.ComponentModel.IContainer components = null;
        SplitContainer splitContainer1;
        Panel quesTextContent;
        Label label7;
        TextBox questionText;
        Panel panel10;
        TextBox answer1;
        Label label8;
        SplitContainer options;
        Button selectLocalImage;
        Button savequiz;
        Button savequestion;
        Panel panel17;
        TextBox linktoimagefile;
        Label label15;
        Panel panel15;
        TextBox argument;
        Label label13;
        Panel panel14;
        TextBox answercorrect;
        Label label12;
        Panel panel13;
        TextBox answer4;
        Label label11;
        Panel panel12;
        TextBox answer3;
        Label label10;
        Panel panel11;
        TextBox answer2;
        Label label9;
        Panel panel16;
        TextBox quizTitle;
        Label label14;
        ToolTip toolTip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new SplitContainer();
            this.panel16 = new Panel();
            this.quizTitle = new TextBox();
            this.label14 = new Label();
            this.options = new SplitContainer();
            this.selectLocalImage = new Button();
            this.savequiz = new Button();
            this.savequestion = new Button();
            this.panel17 = new Panel();
            this.linktoimagefile = new TextBox();
            this.label15 = new Label();
            this.panel15 = new Panel();
            this.argument = new TextBox();
            this.label13 = new Label();
            this.panel14 = new Panel();
            this.answercorrect = new TextBox();
            this.label12 = new Label();
            this.panel13 = new Panel();
            this.answer4 = new TextBox();
            this.label11 = new Label();
            this.panel12 = new Panel();
            this.answer3 = new TextBox();
            this.label10 = new Label();
            this.panel11 = new Panel();
            this.answer2 = new TextBox();
            this.label9 = new Label();
            this.panel10 = new Panel();
            this.answer1 = new TextBox();
            this.label8 = new Label();
            this.quesTextContent = new Panel();
            this.questionText = new TextBox();
            this.label7 = new Label();
            this.toolTip = new ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.options)).BeginInit();
            this.options.Panel1.SuspendLayout();
            this.options.Panel2.SuspendLayout();
            this.options.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.quesTextContent.SuspendLayout();
            this.SuspendLayout();

            // splitContainer1
            this.splitContainer1.BackColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.Location = new Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            
            // splitContainer1.Panel1
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Padding = new Padding(5);

            // splitContainer1.Panel2
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.panel16);
            this.splitContainer1.Panel2.Controls.Add(this.options);
            this.splitContainer1.Panel2.Controls.Add(this.panel17);
            this.splitContainer1.Panel2.Controls.Add(this.panel15);
            this.splitContainer1.Panel2.Controls.Add(this.panel14);
            this.splitContainer1.Panel2.Controls.Add(this.panel13);
            this.splitContainer1.Panel2.Controls.Add(this.panel12);
            this.splitContainer1.Panel2.Controls.Add(this.panel11);
            this.splitContainer1.Panel2.Controls.Add(this.panel10);
            this.splitContainer1.Panel2.Controls.Add(this.quesTextContent);
            this.splitContainer1.Size = new Size(1317, 854);
            this.splitContainer1.SplitterDistance = 687;
            this.splitContainer1.TabIndex = 0;

            // panel16
            this.panel16.Controls.Add(this.quizTitle);
            this.panel16.Controls.Add(this.label14);
            this.panel16.Dock = DockStyle.Bottom;
            this.panel16.Location = new Point(0, 786);
            this.panel16.Name = "panel16";
            this.panel16.Size = new Size(626, 68);
            this.panel16.TabIndex = 18;

            // quizTitle
            this.quizTitle.BackColor = Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.quizTitle.BorderStyle = BorderStyle.None;
            this.quizTitle.Dock = DockStyle.Top;
            this.quizTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.quizTitle.ForeColor = SystemColors.Control;
            this.quizTitle.Location = new Point(0, 18);
            this.quizTitle.Multiline = true;
            this.quizTitle.Name = "quizTitle";
            this.quizTitle.Size = new Size(626, 45);
            this.quizTitle.TabIndex = 1;
            this.quizTitle.TextAlign = HorizontalAlignment.Center;

            // label14
            this.label14.Dock = DockStyle.Top;
            this.label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = SystemColors.Control;
            this.label14.Location = new Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new Size(626, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Quiz title";
            this.label14.TextAlign = ContentAlignment.MiddleLeft;

            // options
            this.options.Dock = DockStyle.Top;
            this.options.Location = new Point(0, 649);
            this.options.Name = "options";

            // options.Panel1
            this.options.Panel1.Controls.Add(this.selectLocalImage);

            // options.Panel2
            this.options.Panel2.Controls.Add(this.savequiz);
            this.options.Panel2.Controls.Add(this.savequestion);
            this.options.Size = new Size(626, 103);
            this.options.SplitterDistance = 300;
            this.options.TabIndex = 17;

            // selectLocalImage
            this.selectLocalImage.BackColor = Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.selectLocalImage.BackgroundImageLayout = ImageLayout.Center;
            this.selectLocalImage.Dock = DockStyle.Top;
            this.selectLocalImage.FlatAppearance.BorderSize = 0;
            this.selectLocalImage.FlatStyle = FlatStyle.Flat;
            this.selectLocalImage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            this.selectLocalImage.ForeColor = SystemColors.Control;
            this.selectLocalImage.Location = new Point(0, 0);
            this.selectLocalImage.Name = "selectLocalImage";
            this.selectLocalImage.Size = new Size(300, 50);
            this.selectLocalImage.TabIndex = 2;
            this.selectLocalImage.Text = "Select a local image file";
            this.selectLocalImage.UseVisualStyleBackColor = false;
            this.selectLocalImage.Click += new System.EventHandler(this.selectLocalImage_Click);

            // savequiz
            this.savequiz.BackColor = Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.savequiz.BackgroundImageLayout = ImageLayout.Center;
            this.savequiz.Dock = DockStyle.Bottom;
            this.savequiz.FlatAppearance.BorderSize = 0;
            this.savequiz.FlatStyle = FlatStyle.Flat;
            this.savequiz.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            this.savequiz.ForeColor = SystemColors.Control;
            this.savequiz.Location = new Point(0, 53);
            this.savequiz.Name = "savequiz";
            this.savequiz.Size = new Size(322, 50);
            this.savequiz.TabIndex = 4;
            this.savequiz.Text = "Save this quiz";
            this.savequiz.UseVisualStyleBackColor = false;
            this.savequiz.Click += new System.EventHandler(this.savequiz_Click);
        
            // savequestion
            this.savequestion.BackColor = Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.savequestion.BackgroundImageLayout = ImageLayout.Center;
            this.savequestion.Dock = DockStyle.Top;
            this.savequestion.FlatAppearance.BorderSize = 0;
            this.savequestion.FlatStyle = FlatStyle.Flat;
            this.savequestion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            this.savequestion.ForeColor = SystemColors.Control;
            this.savequestion.Location = new Point(0, 0);
            this.savequestion.Name = "savequestion";
            this.savequestion.Size = new Size(322, 50);
            this.savequestion.TabIndex = 3;
            this.savequestion.Text = "Save the question";
            this.savequestion.UseVisualStyleBackColor = false;
            this.savequestion.Click += new System.EventHandler(this.savequestion_Click);

            // panel17
            this.panel17.Controls.Add(this.linktoimagefile);
            this.panel17.Controls.Add(this.label15);
            this.panel17.Dock = DockStyle.Top;
            this.panel17.Location = new Point(0, 560);
            this.panel17.Name = "panel17";
            this.panel17.Size = new Size(626, 89);
            this.panel17.TabIndex = 16;

            // linktoimagefile
            this.linktoimagefile.BackColor = Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.linktoimagefile.BorderStyle = BorderStyle.None;
            this.linktoimagefile.Dock = DockStyle.Top;
            this.linktoimagefile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.linktoimagefile.ForeColor = SystemColors.Control;
            this.linktoimagefile.Location = new Point(0, 18);
            this.linktoimagefile.Multiline = true;
            this.linktoimagefile.Name = "linktoimagefile";
            this.linktoimagefile.Size = new Size(626, 64);
            this.linktoimagefile.TabIndex = 1;

            // label15
            this.label15.Dock = DockStyle.Top;
            this.label15.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = SystemColors.Control;
            this.label15.Location = new Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new Size(626, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Link to an image on the web (png, jpg, jpeg)";
            this.label15.TextAlign = ContentAlignment.MiddleLeft;

            // panel15
            this.panel15.Controls.Add(this.argument);
            this.panel15.Controls.Add(this.label13);
            this.panel15.Dock = DockStyle.Top;
            this.panel15.Location = new Point(0, 471);
            this.panel15.Name = "panel15";
            this.panel15.Size = new Size(626, 89);
            this.panel15.TabIndex = 15;

            // argument
            this.argument.BackColor = Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.argument.BorderStyle = BorderStyle.None;
            this.argument.Dock = DockStyle.Top;
            this.argument.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.argument.ForeColor = SystemColors.Control;
            this.argument.Location = new Point(0, 18);
            this.argument.Multiline = true;
            this.argument.Name = "argument";
            this.argument.Size = new Size(626, 64);
            this.argument.TabIndex = 1;

            // label13
            this.label13.Dock = DockStyle.Top;
            this.label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = SystemColors.Control;
            this.label13.Location = new Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new Size(626, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Argument";
            this.label13.TextAlign = ContentAlignment.MiddleLeft;

            // panel14
            this.panel14.Controls.Add(this.answercorrect);
            this.panel14.Controls.Add(this.label12);
            this.panel14.Dock = DockStyle.Top;
            this.panel14.Location = new Point(0, 396);
            this.panel14.Name = "panel14";
            this.panel14.Size = new Size(626, 75);
            this.panel14.TabIndex = 14;

            // answercorrect
            this.answercorrect.BackColor = Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.answercorrect.BorderStyle = BorderStyle.None;
            this.answercorrect.Dock = DockStyle.Top;
            this.answercorrect.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.answercorrect.ForeColor = SystemColors.Control;
            this.answercorrect.Location = new Point(0, 18);
            this.answercorrect.Multiline = true;
            this.answercorrect.Name = "answercorrect";
            this.answercorrect.Size = new Size(626, 48);
            this.answercorrect.TabIndex = 1;
            this.answercorrect.TextAlign = HorizontalAlignment.Center;

            // label12
            this.label12.Dock = DockStyle.Top;
            this.label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = SystemColors.Control;
            this.label12.Location = new Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new Size(626, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Correct answer";
            this.label12.TextAlign = ContentAlignment.MiddleLeft;

            // panel13
            this.panel13.Controls.Add(this.answer4);
            this.panel13.Controls.Add(this.label11);
            this.panel13.Dock = DockStyle.Top;
            this.panel13.Location = new Point(0, 321);
            this.panel13.Name = "panel13";
            this.panel13.Size = new Size(626, 75);
            this.panel13.TabIndex = 13;

            // answer4
            this.answer4.BackColor = Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.answer4.BorderStyle = BorderStyle.None;
            this.answer4.Dock = DockStyle.Top;
            this.answer4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.answer4.ForeColor = SystemColors.Control;
            this.answer4.Location = new Point(0, 18);
            this.answer4.Multiline = true;
            this.answer4.Name = "answer4";
            this.answer4.Size = new Size(626, 48);
            this.answer4.TabIndex = 1;
            this.answer4.TextAlign = HorizontalAlignment.Center;

            // label11
            this.label11.Dock = DockStyle.Top;
            this.label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = SystemColors.Control;
            this.label11.Location = new Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new Size(626, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Answer 4";
            this.label11.TextAlign = ContentAlignment.MiddleLeft;

            // panel12
            this.panel12.Controls.Add(this.answer3);
            this.panel12.Controls.Add(this.label10);
            this.panel12.Dock = DockStyle.Top;
            this.panel12.Location = new Point(0, 246);
            this.panel12.Name = "panel12";
            this.panel12.Size = new Size(626, 75);
            this.panel12.TabIndex = 12;

            // answer3
            this.answer3.BackColor = Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.answer3.BorderStyle = BorderStyle.None;
            this.answer3.Dock = DockStyle.Top;
            this.answer3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.answer3.ForeColor = SystemColors.Control;
            this.answer3.Location = new Point(0, 18);
            this.answer3.Multiline = true;
            this.answer3.Name = "answer3";
            this.answer3.Size = new Size(626, 48);
            this.answer3.TabIndex = 1;
            this.answer3.TextAlign = HorizontalAlignment.Center;

            // label10
            this.label10.Dock = DockStyle.Top;
            this.label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = SystemColors.Control;
            this.label10.Location = new Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new Size(626, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Answer 3";
            this.label10.TextAlign = ContentAlignment.MiddleLeft;

            // panel11
            this.panel11.Controls.Add(this.answer2);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Dock = DockStyle.Top;
            this.panel11.Location = new Point(0, 171);
            this.panel11.Name = "panel11";
            this.panel11.Size = new Size(626, 75);
            this.panel11.TabIndex = 11;

            // answer2
            this.answer2.BackColor = Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.answer2.BorderStyle = BorderStyle.None;
            this.answer2.Dock = DockStyle.Top;
            this.answer2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.answer2.ForeColor = SystemColors.Control;
            this.answer2.Location = new Point(0, 18);
            this.answer2.Multiline = true;
            this.answer2.Name = "answer2";
            this.answer2.Size = new Size(626, 48);
            this.answer2.TabIndex = 1;
            this.answer2.TextAlign = HorizontalAlignment.Center;

            // label9
            this.label9.Dock = DockStyle.Top;
            this.label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = SystemColors.Control;
            this.label9.Location = new Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new Size(626, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Answer 2";
            this.label9.TextAlign = ContentAlignment.MiddleLeft;

            // panel10
            this.panel10.Controls.Add(this.answer1);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Dock = DockStyle.Top;
            this.panel10.Location = new Point(0, 96);
            this.panel10.Name = "panel10";
            this.panel10.Size = new Size(626, 75);
            this.panel10.TabIndex = 1;

            // answer1
            this.answer1.BackColor = Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.answer1.BorderStyle = BorderStyle.None;
            this.answer1.Dock = DockStyle.Top;
            this.answer1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.answer1.ForeColor = SystemColors.Control;
            this.answer1.Location = new Point(0, 18);
            this.answer1.Multiline = true;
            this.answer1.Name = "answer1";
            this.answer1.Size = new Size(626, 48);
            this.answer1.TabIndex = 1;
            this.answer1.TextAlign = HorizontalAlignment.Center;

            // label8
            this.label8.Dock = DockStyle.Top;
            this.label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = SystemColors.Control;
            this.label8.Location = new Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new Size(626, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Answer 1";
            this.label8.TextAlign = ContentAlignment.MiddleLeft;

            // quesTextContent
            this.quesTextContent.Controls.Add(this.questionText);
            this.quesTextContent.Controls.Add(this.label7);
            this.quesTextContent.Dock = DockStyle.Top;
            this.quesTextContent.Location = new Point(0, 0);
            this.quesTextContent.Name = "quesTextContent";
            this.quesTextContent.Size = new Size(626, 96);
            this.quesTextContent.TabIndex = 0;

            // questionText
            this.questionText.BackColor = Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.questionText.BorderStyle = BorderStyle.None;
            this.questionText.Dock = DockStyle.Top;
            this.questionText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.questionText.ForeColor = SystemColors.Control;
            this.questionText.Location = new Point(0, 18);
            this.questionText.Multiline = true;
            this.questionText.Name = "questionText";
            this.questionText.Size = new Size(626, 68);
            this.questionText.TabIndex = 1;

            // label7
            this.label7.Dock = DockStyle.Top;
            this.label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = SystemColors.Control;
            this.label7.Location = new Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new Size(626, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type question text";
            this.label7.TextAlign = ContentAlignment.MiddleLeft;

            // CreateQuiz
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1317, 854);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CreateQuiz";
            this.Text = "CreateQuiz";
            this.FormClosing += new FormClosingEventHandler(this.CreateQuiz_FormClosing);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.options.Panel1.ResumeLayout(false);
            this.options.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.options)).EndInit();
            this.options.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.quesTextContent.ResumeLayout(false);
            this.quesTextContent.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}