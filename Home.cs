using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace QuizApp
{
    public partial class Home : Form
    {
        public Home() => InitializeComponent();

        private void addquiz_Click(object sender, EventArgs e) => CreateProcess("/create");

        private void Home_Shown(object sender, EventArgs e)
        {
            IEnumerable<string> files = Directory.EnumerateFiles(Application.StartupPath, "*.txt");
            foreach (string file in files)
            {
                if (File.Exists(file))
                {
                    string[] title_len = File.ReadAllLines(file);

                    Panel quizItem = new Panel
                    {
                        BackColor = Color.FromArgb(36, ((int)(((byte)(36)))), ((int)(((byte)(36))))),
                        Dock = DockStyle.Top,
                        Location = new Point(0, 0),
                        Name = "quizItem",
                        Size = new Size(687, 67),
                        AccessibleDescription = file
                    };

                    Label quizDetails = new Label
                    {
                        BackColor = Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43))))),
                        Dock = DockStyle.Bottom,
                        Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                        ForeColor = SystemColors.Control,
                        Text = $"{title_len[title_len.Length - 2]}\n{title_len[title_len.Length - 1]} question(s)",
                        TextAlign = ContentAlignment.MiddleLeft,
                        Name = "quizDetails",
                        Location = new Point(0, 0),
                        Size = new Size(539, 60),
                        Padding = new Padding(16, 0, 0, 0)
                    };

                    Button quizPlay = new Button
                    {
                        Location = new Point(539, 0),
                        BackgroundImage = global::QuizApp.Properties.Resources.play,
                        BackgroundImageLayout = ImageLayout.Center,
                        Dock = DockStyle.Right,
                        FlatStyle = FlatStyle.Flat,
                        UseVisualStyleBackColor = true,
                        Size = new Size(74, 67)
                    };
                    quizPlay.Click += PlayOrDelete;
                    quizPlay.FlatAppearance.BorderSize = 0;
                    toolTip1.SetToolTip(quizPlay, "Play this quiz");

                    Button quizDelete = new Button
                    {
                        Dock = DockStyle.Right,
                        BackgroundImage = global::QuizApp.Properties.Resources.delete,
                        BackgroundImageLayout = ImageLayout.Center,
                        FlatStyle = FlatStyle.Flat,
                        Location = new Point(613, 0),
                        Name = "delete",
                        Size = new Size(74, 67),
                        UseVisualStyleBackColor = true
                    };
                    quizDelete.Click += PlayOrDelete;
                    quizDelete.FlatAppearance.BorderSize = 0;
                    toolTip1.SetToolTip(quizDelete, "Delete this quiz");

                    quizItem.Controls.Add(quizDetails);
                    quizItem.Controls.Add(quizPlay);
                    quizItem.Controls.Add(quizDelete);

                    quizList.Controls.Add(quizItem);
                }
            }
        }

        void PlayOrDelete(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Panel panel = button.Parent as Panel;

            if(button.Name == "delete")
            {
                try
                {
                    File.Delete(panel.AccessibleDescription);
                    panel.Visible = false;
                    panel.Controls.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"There was an error.\n{ex.Message}");
                }
                
                return;
            }

            CreateProcess($"/file {panel.AccessibleDescription}");
        }

        void refreshQuizList_Click(object sender, EventArgs e)
        {
            quizList.Controls.Clear();
            Home_Shown(null, null);
        }

        void CreateProcess(string args)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Process.GetCurrentProcess().MainModule.FileName,
                // # processing path here, cause args[] in the main function would break a whole string into an string[]
                // # which would result in an imcomplete and incorect path at args[0]
                // # this line is for paths with empty spaces in the name of a folder
                Arguments = args.StartsWith("/file") ? args.Substring(6).Replace('*', ' ') : args,
                UseShellExecute = false
            };

            Process.Start(psi);
            Application.Exit();
        }
    }
}