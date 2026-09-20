using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class QuizReport : Form
    {
        public QuizReport(Question[] questions)
        {
            foreach (var question in questions)
            {
                Panel answerPanelDetail = new Panel
                {
                    BackColor = Color.FromArgb(43, 43, 43),
                    Dock = DockStyle.Top,
                    Location = new Point(5, 5),
                    Size = new Size(1238, 121),
                };

                PictureBox questionPicture = null;
                if(question.Image != "")
                {
                    try
                    {
                        questionPicture = new PictureBox
                        {
                            Image = Image.FromFile(question.Image),
                            Dock = DockStyle.Fill,
                            Location = new Point(0, 60),
                            Size = new Size(1238, 600),
                            SizeMode = PictureBoxSizeMode.Zoom
                        };
                        answerPanelDetail.Size = new Size(1238, 721);
                    }
                    catch (Exception) { }
                }

                Label questionText = new Label
                {
                    BackColor = Color.FromArgb(50, 50, 50),
                    Dock = DockStyle.Top,
                    Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = SystemColors.Control,
                    Location = new Point(0, 0),
                    Padding = new Padding(16, 8, 8, 0),
                    Size = new Size(1238, 60),
                    Text = question.question
                };

                Panel responses = new Panel
                {
                    BackColor = Color.FromArgb(36, 36, 36),
                    Dock = DockStyle.Bottom,
                    Location = new Point(0, 660),
                    Size = new Size(1238, 58)
                };

                Label correct = new Label
                {
                    BackColor = Color.Green,
                    Dock = DockStyle.Left,
                    Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = SystemColors.Control,
                    Location = new Point(351, 0),
                    Size = new Size(351, 58),
                    Text = question.Correct,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label wrong = null;
                if (question.A1 != question.Correct)
                {
                    wrong = new Label
                    {
                        BackColor = Color.FromArgb(192, 0, 0),
                        Dock = DockStyle.Left,
                        Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = SystemColors.Control,
                        Location = new Point(0, 0),
                        Size = new Size(351, 58),
                        Text = question.A1 == "" ? "No response" : question.A1,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                }

                responses.Controls.Add(correct);
                responses.Controls.Add(wrong);

                Label argument = null;
                if (question.Argument != "")
                {
                    argument = new Label
                    {
                        BackColor = Color.FromArgb(36, 36, 36),
                        Dock = DockStyle.Bottom,
                        Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = SystemColors.Control,
                        Location = new Point(0, 717),
                        Padding = new Padding(16, 8, 8, 0),
                        Size = new Size(1238, 65),
                        Text = question.Argument
                    };
                    answerPanelDetail.Size = new Size(1238, answerPanelDetail.Height + 65);
                }

                answerPanelDetail.Controls.Add(questionPicture);
                answerPanelDetail.Controls.Add(questionText);
                answerPanelDetail.Controls.Add(responses);
                answerPanelDetail.Controls.Add(argument);

                Controls.Add(answerPanelDetail);
            }

            InitializeComponent();
        }
    }
}