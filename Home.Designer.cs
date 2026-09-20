namespace QuizApp
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidemenu = new System.Windows.Forms.Panel();
            this.refreshQuizList = new System.Windows.Forms.Button();
            this.addquiz = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.quizList = new System.Windows.Forms.Panel();
            this.quizlistTitle = new System.Windows.Forms.Label();
            this.sidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();

            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sidemenu.Controls.Add(this.refreshQuizList);
            this.sidemenu.Controls.Add(this.addquiz);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(5, 5);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(41, 803);
            this.sidemenu.TabIndex = 0;

            this.refreshQuizList.BackgroundImage = global::QuizApp.Properties.Resources.refresh;
            this.refreshQuizList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshQuizList.FlatAppearance.BorderSize = 0;
            this.refreshQuizList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshQuizList.Location = new System.Drawing.Point(0, 387);
            this.refreshQuizList.Name = "refreshQuizList";
            this.refreshQuizList.Size = new System.Drawing.Size(41, 40);
            this.refreshQuizList.TabIndex = 1;
            this.toolTip1.SetToolTip(this.refreshQuizList, "Refresh quiz list");
            this.refreshQuizList.UseVisualStyleBackColor = true;
            this.refreshQuizList.Click += new System.EventHandler(this.refreshQuizList_Click);

            this.addquiz.BackgroundImage = global::QuizApp.Properties.Resources.add;
            this.addquiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addquiz.FlatAppearance.BorderSize = 0;
            this.addquiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addquiz.Location = new System.Drawing.Point(0, 344);
            this.addquiz.Name = "addquiz";
            this.addquiz.Size = new System.Drawing.Size(41, 40);
            this.addquiz.TabIndex = 0;
            this.toolTip1.SetToolTip(this.addquiz, "Create a new quiz");
            this.addquiz.UseVisualStyleBackColor = true;
            this.addquiz.Click += new System.EventHandler(this.addquiz_Click);

            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(46, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(1267, 803);
            this.splitContainer1.SplitterDistance = 687;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;

            this.splitContainer1.Panel1.Controls.Add(this.quizList);
            this.splitContainer1.Panel1.Controls.Add(this.quizlistTitle);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);

            this.quizList.AutoScroll = true;
            this.quizList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizList.Location = new System.Drawing.Point(0, 72);
            this.quizList.Name = "quizList";
            this.quizList.Size = new System.Drawing.Size(687, 731);
            this.quizList.TabIndex = 1;

            this.quizlistTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.quizlistTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.quizlistTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizlistTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.quizlistTitle.Location = new System.Drawing.Point(0, 0);
            this.quizlistTitle.Name = "quizlistTitle";
            this.quizlistTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.quizlistTitle.Size = new System.Drawing.Size(687, 72);
            this.quizlistTitle.TabIndex = 0;
            this.quizlistTitle.Text = "Select the quiz you want to start with";
            this.quizlistTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.quizList.AutoScroll = true;
            this.quizList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizList.Location = new System.Drawing.Point(0, 72);
            this.quizList.Name = "quizList";
            this.quizList.Size = new System.Drawing.Size(687, 731);
            this.quizList.TabIndex = 1;

            this.quizlistTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.quizlistTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.quizlistTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizlistTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.quizlistTitle.Location = new System.Drawing.Point(0, 0);
            this.quizlistTitle.Name = "quizlistTitle";
            this.quizlistTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.quizlistTitle.Size = new System.Drawing.Size(687, 72);
            this.quizlistTitle.TabIndex = 0;
            this.quizlistTitle.Text = "Select the quiz you want to start with";
            this.quizlistTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1318, 813);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.sidemenu);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Home";
            this.Shown += new System.EventHandler(this.Home_Shown);
            this.sidemenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel sidemenu;
        private System.Windows.Forms.Button addquiz;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label quizlistTitle;
        private System.Windows.Forms.Panel quizList;
        private System.Windows.Forms.Button refreshQuizList;
    }
}