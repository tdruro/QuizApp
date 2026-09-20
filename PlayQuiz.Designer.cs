using System.Windows.Forms;
using System.Drawing;
using System;

namespace QuizApp
{
    partial class PlayQuiz
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
            this.components = new System.ComponentModel.Container();
            this.sidemenu = new Panel();
            this.chPicSizeMode = new Button();
            this.panel1 = new Panel();
            this.questionText = new Label();
            this.questionCounter = new Label();
            this.quizAnswers = new SplitContainer();
            this.raspuns3 = new Button();
            this.raspuns1 = new Button();
            this.raspuns4 = new Button();
            this.raspuns2 = new Button();
            this.pictureBox1 = new PictureBox();
            this.startTimer = new Timer(this.components);
            this.playTimer = new Timer(this.components);
            this.showQuestions = new Timer(this.components);
            this.sidemenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizAnswers)).BeginInit();
            this.quizAnswers.Panel1.SuspendLayout();
            this.quizAnswers.Panel2.SuspendLayout();
            this.quizAnswers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // sidemenu
            this.sidemenu.BackColor = Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sidemenu.Controls.Add(this.chPicSizeMode);
            this.sidemenu.Dock = DockStyle.Left;
            this.sidemenu.Location = new Point(5, 5);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new Size(41, 827);
            this.sidemenu.TabIndex = 1;

            // chPicSizeMode
            this.chPicSizeMode.BackgroundImage = global::QuizApp.Properties.Resources.resize;
            this.chPicSizeMode.BackgroundImageLayout = ImageLayout.Center;
            this.chPicSizeMode.FlatAppearance.BorderSize = 0;
            this.chPicSizeMode.FlatStyle = FlatStyle.Flat;
            this.chPicSizeMode.Location = new Point(0, 344);
            this.chPicSizeMode.Name = "chPicSizeMode";
            this.chPicSizeMode.Size = new Size(41, 40);
            this.chPicSizeMode.TabIndex = 0;
            this.chPicSizeMode.UseVisualStyleBackColor = true;
            this.chPicSizeMode.Click += new EventHandler(this.chPicSizeMode_Click);
            
            // panel1
            this.panel1.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.questionText);
            this.panel1.Controls.Add(this.questionCounter);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(46, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1269, 72);
            this.panel1.TabIndex = 2;

            // questionText
            this.questionText.BackColor = Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.questionText.Dock = DockStyle.Fill;
            this.questionText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.questionText.ForeColor = SystemColors.Control;
            this.questionText.Location = new Point(0, 0);
            this.questionText.Name = "questionText";
            this.questionText.Padding = new Padding(16, 8, 16, 0);
            this.questionText.Size = new Size(1182, 72);
            this.questionText.TabIndex = 4;
        
            // questionCounter
            this.questionCounter.BackColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.questionCounter.Dock = DockStyle.Right;
            this.questionCounter.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.questionCounter.ForeColor = SystemColors.Control;
            this.questionCounter.Location = new Point(1182, 0);
            this.questionCounter.Name = "questionCounter";
            this.questionCounter.Size = new Size(87, 72);
            this.questionCounter.TabIndex = 3;
            this.questionCounter.Text = "00:16";
            this.questionCounter.TextAlign = ContentAlignment.MiddleCenter;

            // quizAnswers
            this.quizAnswers.Dock = DockStyle.Bottom;
            this.quizAnswers.Location = new Point(46, 714);
            this.quizAnswers.Name = "quizAnswers";

            // quizAnswers.Panel1
            this.quizAnswers.Panel1.Controls.Add(this.raspuns3);
            this.quizAnswers.Panel1.Controls.Add(this.raspuns1);

            // quizAnswers.Panel2
            this.quizAnswers.Panel2.Controls.Add(this.raspuns4);
            this.quizAnswers.Panel2.Controls.Add(this.raspuns2);
            this.quizAnswers.Size = new Size(1269, 118);
            this.quizAnswers.SplitterDistance = 607;
            this.quizAnswers.TabIndex = 9;
        
            // raspuns3
            this.raspuns3.BackColor = Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.raspuns3.BackgroundImageLayout = ImageLayout.Center;
            this.raspuns3.Dock = DockStyle.Bottom;
            this.raspuns3.Enabled = false;
            this.raspuns3.FlatAppearance.BorderSize = 0;
            this.raspuns3.FlatStyle = FlatStyle.Flat;
            this.raspuns3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            this.raspuns3.ForeColor = SystemColors.Control;
            this.raspuns3.Location = new Point(0, 62);
            this.raspuns3.Name = "raspuns3";
            this.raspuns3.Size = new Size(607, 56);
            this.raspuns3.TabIndex = 3;
            this.raspuns3.UseVisualStyleBackColor = false;
            this.raspuns3.Click += new EventHandler(this.AnswerQuestion);

            // raspuns1
            this.raspuns1.BackColor = Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.raspuns1.BackgroundImageLayout = ImageLayout.Center;
            this.raspuns1.Dock = DockStyle.Top;
            this.raspuns1.Enabled = false;
            this.raspuns1.FlatAppearance.BorderSize = 0;
            this.raspuns1.FlatStyle = FlatStyle.Flat;
            this.raspuns1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            this.raspuns1.ForeColor = SystemColors.Control;
            this.raspuns1.Location = new Point(0, 0);
            this.raspuns1.Name = "raspuns1";
            this.raspuns1.Size = new Size(607, 56);
            this.raspuns1.TabIndex = 2;
            this.raspuns1.UseVisualStyleBackColor = false;
            this.raspuns1.Click += new EventHandler(this.AnswerQuestion);

            // raspuns4
            this.raspuns4.BackColor = Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.raspuns4.BackgroundImageLayout = ImageLayout.Center;
            this.raspuns4.Dock = DockStyle.Bottom;
            this.raspuns4.Enabled = false;
            this.raspuns4.FlatAppearance.BorderSize = 0;
            this.raspuns4.FlatStyle = FlatStyle.Flat;
            this.raspuns4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            this.raspuns4.ForeColor = SystemColors.Control;
            this.raspuns4.Location = new Point(0, 62);
            this.raspuns4.Name = "raspuns4";
            this.raspuns4.Size = new Size(658, 56);
            this.raspuns4.TabIndex = 4;
            this.raspuns4.UseVisualStyleBackColor = false;
            this.raspuns4.Click += new EventHandler(this.AnswerQuestion);

            // raspuns2
            this.raspuns2.BackColor = Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.raspuns2.BackgroundImageLayout = ImageLayout.Center;
            this.raspuns2.Dock = DockStyle.Top;
            this.raspuns2.Enabled = false;
            this.raspuns2.FlatAppearance.BorderSize = 0;
            this.raspuns2.FlatStyle = FlatStyle.Flat;
            this.raspuns2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            this.raspuns2.ForeColor = SystemColors.Control;
            this.raspuns2.Location = new Point(0, 0);
            this.raspuns2.Name = "raspuns2";
            this.raspuns2.Size = new Size(658, 56);
            this.raspuns2.TabIndex = 3;
            this.raspuns2.UseVisualStyleBackColor = false;
            this.raspuns2.Click += new EventHandler(this.AnswerQuestion);

            // pictureBox1
            this.pictureBox1.Dock = DockStyle.Fill;
            this.pictureBox1.Location = new Point(46, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(1269, 637);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;

            // startTimer
            this.startTimer.Interval = 1000;
            this.startTimer.Tick += new EventHandler(this.startTimer_Tick);

            // playTimer
            this.playTimer.Interval = 1000;
            this.playTimer.Tick += new EventHandler(this.playTimer_Tick);

            // showQuestions
            this.showQuestions.Interval = 1000;
            this.showQuestions.Tick += new EventHandler(this.showQuestions_Tick);

            // PlayQuiz
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new Size(1320, 837);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quizAnswers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidemenu);
            this.Name = "PlayQuiz";
            this.Padding = new Padding(5);
            this.Text = "PlayQuiz";
            this.FormClosing += new FormClosingEventArgs(this.PlayQuiz_FormClosing);
            this.sidemenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.quizAnswers.Panel1.ResumeLayout(false);
            this.quizAnswers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quizAnswers)).EndInit();
            this.quizAnswers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private Panel sidemenu;
        private Button chPicSizeMode;
        private Panel panel1;
        private Label questionCounter;
        private SplitContainer quizAnswers;
        private Button raspuns3;
        private Button raspuns1;
        private Button raspuns4;
        private Button raspuns2;
        private Label questionText;
        private PictureBox pictureBox1;
        private Timer startTimer;
        private Timer playTimer;
        private Timer showQuestions;
    }
}