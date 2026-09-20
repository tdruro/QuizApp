using System;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class CreateQuiz : Form
    {
        int picmode = 4;
        Dictionary<int, Question> questionList = new Dictionary<int, Question>();
        int qId = 0;
        bool quizSaved = false;
        string pics = $@"{Application.StartupPath}\pics";

        public CreateQuiz()
        {
            InitializeComponent();
        }

        private void savequiz_Click(object sender, EventArgs e)
        {
            if (quizTitle.Text.Trim().Length > 0 && questionList.Count > 0)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var key in questionList.Keys)
                    sb.Append(questionList[key]);

                sb.AppendLine(quizTitle.Text);
                sb.AppendLine($"{questionList.Count}");

                File.WriteAllText($"quiz_{DateTimeOffset.Now.ToUnixTimeMilliseconds()}.txt", sb.ToString());
                quizSaved = true;
                Close();
                return;
            }

            MessageBox.Show("There is no title or data for this quiz.");
        }

        private async void savequestion_Click(object sender, EventArgs e)
        {
            foreach (var item in new TextBox[] { questionText, answer1, answer2, answer3, answer4, answercorrect })
            {
                if (item.Text.Trim().Length == 0)
                {
                    MessageBox.Show($"{item.Name} must not be empty");
                    return;
                }
            }

            if (linktoimagefile.Text.Trim().Length > 0 && linktoimagefile.Text.Contains("https://"))
            {
                using (HttpClient response = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage message = await response.GetAsync(linktoimagefile.Text.Trim());
                        string subtype = message.Content.Headers.ContentType.MediaType;

                        string[] imgTypes = new string[] { "image/png", "image/jpg", "image/jpeg" };

                        if (message != null && message.StatusCode == HttpStatusCode.OK)
                        {
                            if (Array.Exists(imgTypes, type => type == subtype))
                            {
                                string filePath = $@"{pics}\Quizapp_{DateTimeOffset.Now.ToUnixTimeMilliseconds()}.{subtype.Split('/')[1]}";
                                byte[] image = await message.Content.ReadAsByteArrayAsync();
                                
                                CreateDirectoryIfNotExists();
                                
                                File.WriteAllBytes(filePath, image);
                                linktoimagefile.Text = filePath;
                            }
                            else linktoimagefile.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        linktoimagefile.Text = "";
                    }
                }
            }

            AddQuestionPreview();

            questionList[qId] = new Question(questionText.Text.Trim(),
                                             answer1.Text.Trim(),
                                             answer2.Text.Trim(),
                                             answer3.Text.Trim(),
                                             answer4.Text.Trim(),
                                             answercorrect.Text.Trim(),
                                             linktoimagefile.Text.Trim(),
                                             argument.Text.Trim());

            questionText.Text = answer1.Text = answer2.Text = answer3.Text = answer4.Text = answercorrect.Text = argument.Text = linktoimagefile.Text = "";
            qId++;
        }

        void AddQuestionPreview()
        {
            Panel quizPanelDetail = new Panel
            {
                BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51))))),
                Dock = DockStyle.Top,
                Location = new Point(5, 5),
                Size = new Size(677, 182)
            };

            #region quizItem
            Panel quizItem = new Panel
            {
                BackColor = Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36))))),
                Dock = DockStyle.Top,
                Location = new Point(0, 0),
                Size = new Size(677, 70)
            };

            Label questionTitle = new Label
            {
                BackColor = Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43))))),
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = SystemColors.Control,
                Location = new Point(0, 0),
                Padding = new Padding(8, 0, 61, 0),
                Size = new Size(677, 70),
                TabIndex = 1,
                Text = questionText.Text.Trim(),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Button questionDelete = new Button
            {
                Location = new Point(617, 0),
                BackgroundImageLayout = ImageLayout.Center,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(60, 65),
                Dock = DockStyle.Right,
                UseVisualStyleBackColor = true,
                AccessibleName = $"{qId}",
                Name = "delete"
            };
            questionDelete.FlatAppearance.BorderSize = 0;
            questionDelete.BackgroundImage = global::QuizApp.Properties.Resources.delete;
            questionDelete.Click += DeleteQuestion;

            quizItem.Controls.Add(questionDelete);
            quizItem.Controls.Add(questionTitle);
            #endregion quizItem

            #region questionPicContainer
            Panel questionPicContainer = null;
            if (linktoimagefile.Text.Trim().Length > 0)
            {
                try
                {
                    PictureBox questionPic = new PictureBox
                    {
                        Image = Image.FromFile(linktoimagefile.Text.Trim()),
                        Location = new Point(0, 0),
                        Dock = DockStyle.Fill,
                        Size = new Size(677, 405),
                        SizeMode = PictureBoxSizeMode.Zoom
                    };

                    questionPicContainer = new Panel
                    {
                        Dock = DockStyle.Top,
                        Location = new Point(0, 65),
                        Size = new Size(677, 405),
                    };

                    quizPanelDetail.Size = new Size(677, 587);

                    questionPic.Click += PreviewImageSizeMode;
                    questionPicContainer.Controls.Add(questionPic);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid file or format");
                }
            }
            #endregion

            #region quizAnswers
            SplitContainer quizAnswers = new SplitContainer
            {
                Dock = DockStyle.Top,
                Location = new Point(0, 470),
                Size = new Size(677, 103),
                SplitterDistance = 324,
            };

            // quizAnswers.Panel1
            Button raspuns3 = new Button
            {
                BackColor = Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56))))),
                Dock = DockStyle.Bottom,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                ForeColor = SystemColors.Control,
                Location = new Point(0, 53),
                Size = new Size(324, 50),
                Text = answer3.Text.Trim(),
                UseVisualStyleBackColor = false
            };
            raspuns3.FlatAppearance.BorderSize = 0;

            Button raspuns1 = new Button
            {
                BackColor = Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56))))),
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                ForeColor = SystemColors.Control,
                Location = new Point(0, 0),
                Size = new Size(324, 50),
                Text = answer1.Text.Trim(),
                UseVisualStyleBackColor = false
            };
            raspuns1.FlatAppearance.BorderSize = 0;

            quizAnswers.Panel1.Controls.Add(raspuns3);
            quizAnswers.Panel1.Controls.Add(raspuns1);

            // quizAnswers.Panel2
            Button raspuns4 = new Button
            {
                BackColor = Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56))))),
                Dock = DockStyle.Bottom,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                ForeColor = SystemColors.Control,
                Location = new Point(0, 53),
                Size = new Size(349, 50),
                Text = answer4.Text.Trim(),
                UseVisualStyleBackColor = false
            };
            raspuns4.FlatAppearance.BorderSize = 0;

            Button raspuns2 = new Button
            {
                BackColor = Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56))))),
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                ForeColor = SystemColors.Control,
                Location = new Point(0, 0),
                Size = new Size(349, 50),
                Text = answer2.Text.Trim(),
                UseVisualStyleBackColor = false
            };
            raspuns2.FlatAppearance.BorderSize = 0;

            quizAnswers.Panel2.Controls.Add(raspuns4);
            quizAnswers.Panel2.Controls.Add(raspuns2);
            #endregion

            Label questionArgument = null;
            if (argument.Text.Trim().Length > 0)
            {
                questionArgument = new Label
                {
                    BackColor = Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43))))),
                    Dock = DockStyle.Top,
                    Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                    ForeColor = SystemColors.Control,
                    Location = new Point(0, 573),
                    Padding = new Padding(8, 0, 0, 0),
                    Size = new Size(677, 64),
                    Text = argument.Text.Trim(),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                quizPanelDetail.Size = new Size(677, quizPanelDetail.Size.Height + 64);
            }

            quizPanelDetail.Controls.Add(questionArgument);
            quizPanelDetail.Controls.Add(quizAnswers);
            quizPanelDetail.Controls.Add(questionPicContainer);
            quizPanelDetail.Controls.Add(quizItem);

            splitContainer1.Panel1.Controls.Add(quizPanelDetail);
        }

        private void DeleteQuestion(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            questionList.Remove(int.Parse(button.AccessibleName));
            Panel panel = button.Parent.Parent as Panel;
            panel.Visible = false;
        }

        void PreviewImageSizeMode(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.SizeMode = (PictureBoxSizeMode)picmode;
            toolTip.SetToolTip(pictureBox, pictureBox.SizeMode.ToString());

            if (picmode < 4)
                picmode++;
            else picmode = 0;
        }

        private void CreateQuiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!quizSaved && questionList.Count > 0)
            {
                if (DialogResult.No == MessageBox.Show("If you close now, you'll lose quiz creation data", "Window Action", MessageBoxButtons.YesNo))
                    e.Cancel = true;
                
                return;
            }

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Process.GetCurrentProcess().MainModule.FileName,
                UseShellExecute = false
            };

            Process.Start(psi);
        }

        private void selectLocalImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Filter = "Image Files(*.JPG;*.PNG;*.JPEG)|*.JPG;*.PNG;*.JPEG|All files (*.*)|(*.*)";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string file = ofd.FileName.Substring(ofd.FileName.LastIndexOf(@"\"));

                    CreateDirectoryIfNotExists();

                    File.Copy(ofd.FileName, pics + file);
                    linktoimagefile.Text = pics + file;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        void CreateDirectoryIfNotExists()
        {
            if(!Directory.Exists(pics))
                Directory.Create(pics);
        }
    }
}