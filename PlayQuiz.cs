using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuizApp
{
    public partial class PlayQuiz : Form
    {
        int picmode;
        Question[] questions, report;
        int startIn = 3, qpos = -1;

        public PlayQuiz(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int len = int.Parse(lines[lines.Length - 1]);
            int pos = 0;

            questions = new Question[len];
            report = new Question[len];

            for (int i = 0; i < len; i++)
            {
                questions[i] = new Question(question: lines[pos++],
                                            a1: lines[pos++],
                                            a2: lines[pos++],
                                            a3: lines[pos++],
                                            a4: lines[pos++],
                                            correct: lines[pos++],
                                            image: lines[pos++],
                                            argument: lines[pos++]);
                pos++;
            }

            InitializeComponent();
            this.startTimer.Enabled = true;
        }

        private void chPicSizeMode_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.SizeMode = (PictureBoxSizeMode)picmode;

                if (picmode < 4)
                    picmode++;
                else picmode = 0;
            }
        }

        private void AnswerQuestion(object sender, EventArgs e)
        {
            playTimer.Enabled = false;
            raspuns1.Enabled = raspuns2.Enabled = raspuns3.Enabled = raspuns4.Enabled = false;

            Button btn = (Button)sender;

            if (btn.Text == questions[qpos].Correct)
                btn.BackColor = Color.Green;
            else
            {
                btn.BackColor = Color.Red;
                foreach (var btn2 in new Button[] { raspuns1, raspuns2, raspuns3, raspuns4 })
                    if (btn2.Text == questions[qpos].Correct)
                        btn2.BackColor = Color.Green;
            }

            report[qpos] = new Question(question: questions[qpos].question,
                                            correct: questions[qpos].Correct,
                                            given: btn.Text,
                                            image: questions[qpos].Image,
                                            arg: questions[qpos].Argument);
            showQuestions.Enabled = true;
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            questionText.Text = $"Starting in {startIn--}...";

            if (startIn < 0)
            {
                startTimer.Enabled = false;
                questionText.Text = $"GO!";
                showQuestions.Enabled = true;
            }
        }

        private void CreateQuiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Process.GetCurrentProcess().MainModule.FileName,
                UseShellExecute = false
            };

            Process.Start(psi);
        }

        private void showQuestions_Tick(object sender, EventArgs e)
        {
            showQuestions.Enabled = false;
            Thread.Sleep(600);

            qpos++;

            if (qpos < questions.Length)
            {
                Question current = questions[qpos];

                questionText.Text = $"{qpos + 1}. {current.question}";
                raspuns1.Text = current.A1;
                raspuns2.Text = current.A2;
                raspuns3.Text = current.A3;
                raspuns4.Text = current.A4;

                if (current.Image != "")
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(current.Image);
                        pictureBox1.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        pictureBox1.Image = null;
                        MessageBox.Show(ex.Message);
                    }
                }
                else pictureBox1.Image = null;

                startIn = 15;
                raspuns1.BackColor = raspuns2.BackColor = raspuns3.BackColor = raspuns4.BackColor = ColorTranslator.FromHtml("#383838");
                playTimer.Enabled = true;
            }
            else new QuizReport(report).Show();
        }

        private void playTimer_Tick(object sender, EventArgs e)
        {
            if (startIn < 16)
                raspuns1.Enabled = raspuns2.Enabled = raspuns3.Enabled = raspuns4.Enabled = true;

            if (startIn < 0)
            {
                playTimer.Enabled = false;
                raspuns1.Enabled = raspuns2.Enabled = raspuns3.Enabled = raspuns4.Enabled = false;

                foreach (var btn2 in new Button[] { raspuns1, raspuns2, raspuns3, raspuns4 })
                {
                    if (btn2.Text == questions[qpos].Correct)
                    {
                        btn2.BackColor = Color.Green;
                        break;
                    }
                }

                report[qpos] = new Question(question: questions[qpos].question,
                                            correct: questions[qpos].Correct,
                                            given: "",
                                            image: questions[qpos].Image,
                                            arg: questions[qpos].Argument);

                showQuestions.Enabled = true;
            }
            else
            {
                questionCounter.Text = startIn < 10 ? $"00:0{startIn}" : $"00:{startIn}";
                startIn--;
            }
        }
    }
}