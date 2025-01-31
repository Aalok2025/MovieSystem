namespace MovieServer
{
    partial class Dashboard
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
            Header = new Label();
            TitleLabel = new Label();
            CastLabel = new Label();
            YearLabel = new Label();
            TitleInputBox = new TextBox();
            CastInputBox = new TextBox();
            DateInputBox = new DateTimePicker();
            BttnAdd = new Button();
            BttnSave = new Button();
            BttnUpdate = new Button();
            BttnClear = new Button();
            BttnLoad = new Button();
            MovieListBox = new TextBox();
            BttnNext = new Button();
            BttnPrevious = new Button();
            BttnFirst = new Button();
            BttnLast = new Button();
            BttnClearFile = new Button();
            button1 = new Button();
            AlertBox = new TextBox();
            label1 = new Label();
            BttnDelete = new Button();
            IDBox = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)IDBox).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.Anchor = AnchorStyles.None;
            Header.BackColor = Color.DarkSlateGray;
            Header.Font = new Font("High Tower Text", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Header.ForeColor = SystemColors.ButtonFace;
            Header.Location = new Point(188, 26);
            Header.Margin = new Padding(3);
            Header.Name = "Header";
            Header.Size = new Size(680, 50);
            Header.TabIndex = 0;
            Header.Text = "MOVIE DASHBOARD";
            Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(188, 224);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(70, 28);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "TITLE : ";
            // 
            // CastLabel
            // 
            CastLabel.AutoSize = true;
            CastLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CastLabel.Location = new Point(188, 266);
            CastLabel.Name = "CastLabel";
            CastLabel.Size = new Size(101, 28);
            CastLabel.TabIndex = 2;
            CastLabel.Text = "DIRECTOR";
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YearLabel.Location = new Point(188, 309);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(67, 28);
            YearLabel.TabIndex = 3;
            YearLabel.Text = "YEAR :";
            // 
            // TitleInputBox
            // 
            TitleInputBox.BorderStyle = BorderStyle.FixedSingle;
            TitleInputBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleInputBox.Location = new Point(298, 222);
            TitleInputBox.Name = "TitleInputBox";
            TitleInputBox.PlaceholderText = " Enter Title Here";
            TitleInputBox.Size = new Size(189, 31);
            TitleInputBox.TabIndex = 4;
            // 
            // CastInputBox
            // 
            CastInputBox.BorderStyle = BorderStyle.FixedSingle;
            CastInputBox.Location = new Point(298, 263);
            CastInputBox.Name = "CastInputBox";
            CastInputBox.PlaceholderText = " Enter Director Name Here";
            CastInputBox.Size = new Size(189, 31);
            CastInputBox.TabIndex = 5;
            // 
            // DateInputBox
            // 
            DateInputBox.CustomFormat = "";
            DateInputBox.Location = new Point(298, 304);
            DateInputBox.Name = "DateInputBox";
            DateInputBox.Size = new Size(189, 31);
            DateInputBox.TabIndex = 6;
            // 
            // BttnAdd
            // 
            BttnAdd.BackColor = Color.DarkSlateGray;
            BttnAdd.BackgroundImageLayout = ImageLayout.None;
            BttnAdd.FlatAppearance.BorderSize = 0;
            BttnAdd.FlatStyle = FlatStyle.Flat;
            BttnAdd.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BttnAdd.ForeColor = SystemColors.ButtonHighlight;
            BttnAdd.Location = new Point(298, 361);
            BttnAdd.Name = "BttnAdd";
            BttnAdd.Size = new Size(85, 30);
            BttnAdd.TabIndex = 7;
            BttnAdd.Text = "ADD";
            BttnAdd.UseVisualStyleBackColor = false;
            BttnAdd.Click += BttnAddToList;
            // 
            // BttnSave
            // 
            BttnSave.BackColor = Color.DarkSlateGray;
            BttnSave.FlatAppearance.BorderSize = 0;
            BttnSave.FlatStyle = FlatStyle.Flat;
            BttnSave.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BttnSave.ForeColor = SystemColors.ButtonHighlight;
            BttnSave.Location = new Point(625, 122);
            BttnSave.Name = "BttnSave";
            BttnSave.Size = new Size(127, 36);
            BttnSave.TabIndex = 8;
            BttnSave.Text = "SAVE TO FILE";
            BttnSave.UseVisualStyleBackColor = false;
            BttnSave.Click += BttnSaveListToFile;
            // 
            // BttnUpdate
            // 
            BttnUpdate.BackColor = Color.DarkSlateGray;
            BttnUpdate.FlatAppearance.BorderSize = 0;
            BttnUpdate.FlatStyle = FlatStyle.Flat;
            BttnUpdate.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BttnUpdate.ForeColor = SystemColors.ButtonHighlight;
            BttnUpdate.Location = new Point(402, 361);
            BttnUpdate.Name = "BttnUpdate";
            BttnUpdate.Size = new Size(85, 30);
            BttnUpdate.TabIndex = 9;
            BttnUpdate.Text = "UPDATE";
            BttnUpdate.UseVisualStyleBackColor = false;
            BttnUpdate.Click += BttnUpdateList;
            // 
            // BttnClear
            // 
            BttnClear.BackColor = Color.DarkSlateGray;
            BttnClear.BackgroundImageLayout = ImageLayout.None;
            BttnClear.FlatAppearance.BorderSize = 0;
            BttnClear.FlatStyle = FlatStyle.Flat;
            BttnClear.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BttnClear.ForeColor = SystemColors.ButtonHighlight;
            BttnClear.Location = new Point(384, 122);
            BttnClear.Name = "BttnClear";
            BttnClear.Size = new Size(103, 36);
            BttnClear.TabIndex = 10;
            BttnClear.Text = "CLEAR DICT";
            BttnClear.UseVisualStyleBackColor = false;
            BttnClear.Click += BttnClearMovieFromList;
            // 
            // BttnLoad
            // 
            BttnLoad.BackColor = Color.DarkSlateGray;
            BttnLoad.FlatAppearance.BorderSize = 0;
            BttnLoad.FlatStyle = FlatStyle.Flat;
            BttnLoad.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BttnLoad.ForeColor = SystemColors.ButtonHighlight;
            BttnLoad.Location = new Point(188, 122);
            BttnLoad.Name = "BttnLoad";
            BttnLoad.Size = new Size(101, 36);
            BttnLoad.TabIndex = 11;
            BttnLoad.Text = "LOAD DICT";
            BttnLoad.UseVisualStyleBackColor = false;
            BttnLoad.Click += BttnLoadLocal;
            // 
            // MovieListBox
            // 
            MovieListBox.BackColor = SystemColors.Window;
            MovieListBox.Location = new Point(525, 182);
            MovieListBox.Multiline = true;
            MovieListBox.Name = "MovieListBox";
            MovieListBox.PlaceholderText = "Find Movies Here !";
            MovieListBox.ScrollBars = ScrollBars.Both;
            MovieListBox.Size = new Size(343, 153);
            MovieListBox.TabIndex = 12;
            MovieListBox.UseWaitCursor = true;
            // 
            // BttnNext
            // 
            BttnNext.BackColor = Color.Teal;
            BttnNext.BackgroundImageLayout = ImageLayout.None;
            BttnNext.FlatAppearance.BorderSize = 0;
            BttnNext.FlatStyle = FlatStyle.Flat;
            BttnNext.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BttnNext.ForeColor = SystemColors.ButtonHighlight;
            BttnNext.Location = new Point(771, 361);
            BttnNext.Name = "BttnNext";
            BttnNext.Size = new Size(95, 30);
            BttnNext.TabIndex = 13;
            BttnNext.Text = "NEXT";
            BttnNext.UseVisualStyleBackColor = false;
            BttnNext.Click += BttnNext_Click;
            // 
            // BttnPrevious
            // 
            BttnPrevious.BackColor = Color.Teal;
            BttnPrevious.BackgroundImageLayout = ImageLayout.None;
            BttnPrevious.FlatAppearance.BorderSize = 0;
            BttnPrevious.FlatStyle = FlatStyle.Flat;
            BttnPrevious.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BttnPrevious.ForeColor = SystemColors.ButtonHighlight;
            BttnPrevious.Location = new Point(524, 360);
            BttnPrevious.Name = "BttnPrevious";
            BttnPrevious.Size = new Size(95, 30);
            BttnPrevious.TabIndex = 14;
            BttnPrevious.Text = "PREVIOUS";
            BttnPrevious.UseVisualStyleBackColor = false;
            BttnPrevious.Click += BttnPrevious_Click;
            // 
            // BttnFirst
            // 
            BttnFirst.BackColor = Color.DarkSlateGray;
            BttnFirst.BackgroundImageLayout = ImageLayout.None;
            BttnFirst.FlatAppearance.BorderSize = 0;
            BttnFirst.FlatStyle = FlatStyle.Flat;
            BttnFirst.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BttnFirst.ForeColor = SystemColors.ButtonHighlight;
            BttnFirst.Location = new Point(623, 361);
            BttnFirst.Name = "BttnFirst";
            BttnFirst.Size = new Size(70, 30);
            BttnFirst.TabIndex = 15;
            BttnFirst.Text = "FIRST";
            BttnFirst.UseVisualStyleBackColor = false;
            BttnFirst.Click += BttnFirst_Click;
            // 
            // BttnLast
            // 
            BttnLast.BackColor = Color.DarkSlateGray;
            BttnLast.BackgroundImageLayout = ImageLayout.None;
            BttnLast.FlatAppearance.BorderSize = 0;
            BttnLast.FlatStyle = FlatStyle.Flat;
            BttnLast.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BttnLast.ForeColor = SystemColors.ButtonHighlight;
            BttnLast.Location = new Point(696, 361);
            BttnLast.Name = "BttnLast";
            BttnLast.Size = new Size(70, 30);
            BttnLast.TabIndex = 16;
            BttnLast.Text = "LAST";
            BttnLast.UseVisualStyleBackColor = false;
            BttnLast.Click += BttnLast_Click;
            // 
            // BttnClearFile
            // 
            BttnClearFile.BackColor = Color.DarkSlateGray;
            BttnClearFile.FlatAppearance.BorderSize = 0;
            BttnClearFile.FlatStyle = FlatStyle.Flat;
            BttnClearFile.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BttnClearFile.ForeColor = SystemColors.ButtonHighlight;
            BttnClearFile.Location = new Point(758, 122);
            BttnClearFile.Name = "BttnClearFile";
            BttnClearFile.Size = new Size(110, 36);
            BttnClearFile.TabIndex = 17;
            BttnClearFile.Text = "CLEAR FILE";
            BttnClearFile.UseVisualStyleBackColor = false;
            BttnClearFile.Click += BttnClearMovieFromFile;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(524, 122);
            button1.Name = "button1";
            button1.Size = new Size(95, 36);
            button1.TabIndex = 18;
            button1.Text = "LOAD FILE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BttnLoadFromFile;
            // 
            // AlertBox
            // 
            AlertBox.BackColor = SystemColors.ScrollBar;
            AlertBox.BorderStyle = BorderStyle.None;
            AlertBox.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AlertBox.Location = new Point(188, 86);
            AlertBox.Name = "AlertBox";
            AlertBox.Size = new Size(680, 22);
            AlertBox.TabIndex = 19;
            AlertBox.Text = "Hello! User, Welcome to our Movie Dashboard, Save your Movies here!";
            AlertBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 185);
            label1.Name = "label1";
            label1.Size = new Size(40, 28);
            label1.TabIndex = 20;
            label1.Text = "ID :";
            // 
            // BttnDelete
            // 
            BttnDelete.BackColor = Color.DarkSlateGray;
            BttnDelete.BackgroundImageLayout = ImageLayout.None;
            BttnDelete.FlatAppearance.BorderSize = 0;
            BttnDelete.FlatStyle = FlatStyle.Flat;
            BttnDelete.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BttnDelete.ForeColor = SystemColors.ButtonHighlight;
            BttnDelete.Location = new Point(188, 361);
            BttnDelete.Name = "BttnDelete";
            BttnDelete.Size = new Size(85, 30);
            BttnDelete.TabIndex = 22;
            BttnDelete.Text = "DELETE";
            BttnDelete.UseVisualStyleBackColor = false;
            BttnDelete.Click += BttnDeleteFromList;
            // 
            // IDBox
            // 
            IDBox.Location = new Point(298, 182);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(189, 31);
            IDBox.TabIndex = 25;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1003, 494);
            Controls.Add(IDBox);
            Controls.Add(BttnDelete);
            Controls.Add(label1);
            Controls.Add(AlertBox);
            Controls.Add(button1);
            Controls.Add(BttnClearFile);
            Controls.Add(BttnLast);
            Controls.Add(BttnFirst);
            Controls.Add(BttnPrevious);
            Controls.Add(BttnNext);
            Controls.Add(MovieListBox);
            Controls.Add(BttnLoad);
            Controls.Add(BttnClear);
            Controls.Add(BttnUpdate);
            Controls.Add(BttnSave);
            Controls.Add(BttnAdd);
            Controls.Add(DateInputBox);
            Controls.Add(CastInputBox);
            Controls.Add(TitleInputBox);
            Controls.Add(YearLabel);
            Controls.Add(CastLabel);
            Controls.Add(TitleLabel);
            Controls.Add(Header);
            Cursor = Cursors.Hand;
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)IDBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Label TitleLabel;
        private Label CastLabel;
        private Label YearLabel;
        private TextBox TitleInputBox;
        private TextBox CastInputBox;
        private DateTimePicker DateInputBox;
        private Button BttnAdd;
        private Button BttnSave;
        private Button BttnUpdate;
        private Button BttnClear;
        private Button BttnLoad;
        private TextBox MovieListBox;
        private Button BttnNext;
        private Button BttnPrevious;
        private Button BttnFirst;
        private Button BttnLast;
        private Button BttnClearFile;
        private Button button1;
        private TextBox AlertBox;
        private Label label1;
        private Button BttnDelete;
        private NumericUpDown IDBox;
    }
}
