namespace Tyuiu.PupovAA.Sprint7.Project.V9
{
    partial class FormMainProject_PAA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainProject_PAA));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxVideo_PAA = new GroupBox();
            dataGridViewVideo_PAA = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            buttonOpenFile_PAA = new Button();
            buttonSaveFile_PAA = new Button();
            buttonDelete_PAA = new Button();
            groupBoxWorkFile_PAA = new GroupBox();
            groupBoxTable_PAA = new GroupBox();
            button2 = new Button();
            buttonOpenSearch_PAA = new Button();
            buttonAddRows__PAA = new Button();
            buttonAbout_PAA = new Button();
            groupBoxHelp_PAA = new GroupBox();
            groupBoxVideo_PAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVideo_PAA).BeginInit();
            groupBoxWorkFile_PAA.SuspendLayout();
            groupBoxTable_PAA.SuspendLayout();
            groupBoxHelp_PAA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxVideo_PAA
            // 
            groupBoxVideo_PAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxVideo_PAA.Controls.Add(dataGridViewVideo_PAA);
            groupBoxVideo_PAA.Location = new Point(0, 102);
            groupBoxVideo_PAA.Name = "groupBoxVideo_PAA";
            groupBoxVideo_PAA.Size = new Size(1114, 615);
            groupBoxVideo_PAA.TabIndex = 0;
            groupBoxVideo_PAA.TabStop = false;
            groupBoxVideo_PAA.Text = "Каталог видео";
            // 
            // dataGridViewVideo_PAA
            // 
            dataGridViewVideo_PAA.AllowUserToAddRows = false;
            dataGridViewVideo_PAA.AllowUserToDeleteRows = false;
            dataGridViewVideo_PAA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVideo_PAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVideo_PAA.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewVideo_PAA.Dock = DockStyle.Fill;
            dataGridViewVideo_PAA.Location = new Point(3, 23);
            dataGridViewVideo_PAA.Name = "dataGridViewVideo_PAA";
            dataGridViewVideo_PAA.RowHeadersVisible = false;
            dataGridViewVideo_PAA.RowHeadersWidth = 51;
            dataGridViewVideo_PAA.ScrollBars = ScrollBars.Vertical;
            dataGridViewVideo_PAA.Size = new Size(1108, 589);
            dataGridViewVideo_PAA.TabIndex = 0;
            dataGridViewVideo_PAA.CellContentClick += dataGridViewVideo_PAA_CellContentClick;
            dataGridViewVideo_PAA.SortCompare += dataGridViewVideo_PAA_SortCompare;
            // 
            // Column1
            // 
            Column1.HeaderText = "Код";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column2
            // 
            Column2.HeaderText = "Дата";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.HeaderText = "Длительность(в мин.)";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.True;
            // 
            // Column4
            // 
            Column4.HeaderText = "Тема";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            // 
            // Column5
            // 
            Column5.HeaderText = "Стоимсть(в руб.)";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            // 
            // Column6
            // 
            Column6.HeaderText = "Автор";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Качество видео";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // buttonOpenFile_PAA
            // 
            buttonOpenFile_PAA.Image = Properties.Resources.book_add;
            buttonOpenFile_PAA.Location = new Point(6, 19);
            buttonOpenFile_PAA.Name = "buttonOpenFile_PAA";
            buttonOpenFile_PAA.Size = new Size(112, 79);
            buttonOpenFile_PAA.TabIndex = 1;
            buttonOpenFile_PAA.UseVisualStyleBackColor = true;
            buttonOpenFile_PAA.Click += buttonOpenFile_PAA_Click;
            // 
            // buttonSaveFile_PAA
            // 
            buttonSaveFile_PAA.Image = Properties.Resources.book_edit;
            buttonSaveFile_PAA.Location = new Point(124, 21);
            buttonSaveFile_PAA.Name = "buttonSaveFile_PAA";
            buttonSaveFile_PAA.Size = new Size(112, 78);
            buttonSaveFile_PAA.TabIndex = 2;
            buttonSaveFile_PAA.UseVisualStyleBackColor = true;
            buttonSaveFile_PAA.Click += buttonSaveFile_PAA_Click;
            // 
            // buttonDelete_PAA
            // 
            buttonDelete_PAA.Image = Properties.Resources.bullet_toggle_minus;
            buttonDelete_PAA.Location = new Point(127, 24);
            buttonDelete_PAA.Name = "buttonDelete_PAA";
            buttonDelete_PAA.Size = new Size(105, 71);
            buttonDelete_PAA.TabIndex = 3;
            buttonDelete_PAA.UseVisualStyleBackColor = true;
            buttonDelete_PAA.Click += buttonDelete_PAA_Click;
            // 
            // groupBoxWorkFile_PAA
            // 
            groupBoxWorkFile_PAA.Controls.Add(buttonOpenFile_PAA);
            groupBoxWorkFile_PAA.Controls.Add(buttonSaveFile_PAA);
            groupBoxWorkFile_PAA.Location = new Point(0, 0);
            groupBoxWorkFile_PAA.Name = "groupBoxWorkFile_PAA";
            groupBoxWorkFile_PAA.Size = new Size(266, 105);
            groupBoxWorkFile_PAA.TabIndex = 4;
            groupBoxWorkFile_PAA.TabStop = false;
            groupBoxWorkFile_PAA.Text = "Работа с файлом";
            // 
            // groupBoxTable_PAA
            // 
            groupBoxTable_PAA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTable_PAA.Controls.Add(button2);
            groupBoxTable_PAA.Controls.Add(buttonOpenSearch_PAA);
            groupBoxTable_PAA.Controls.Add(buttonAddRows__PAA);
            groupBoxTable_PAA.Controls.Add(buttonDelete_PAA);
            groupBoxTable_PAA.Location = new Point(248, 0);
            groupBoxTable_PAA.Name = "groupBoxTable_PAA";
            groupBoxTable_PAA.Size = new Size(669, 105);
            groupBoxTable_PAA.TabIndex = 5;
            groupBoxTable_PAA.TabStop = false;
            groupBoxTable_PAA.Text = "Работа с таблицей";
            // 
            // button2
            // 
            button2.Location = new Point(346, 25);
            button2.Name = "button2";
            button2.Size = new Size(99, 69);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonOpenSearch_PAA
            // 
            buttonOpenSearch_PAA.Image = Properties.Resources.report_magnify;
            buttonOpenSearch_PAA.Location = new Point(238, 24);
            buttonOpenSearch_PAA.Name = "buttonOpenSearch_PAA";
            buttonOpenSearch_PAA.Size = new Size(102, 69);
            buttonOpenSearch_PAA.TabIndex = 5;
            buttonOpenSearch_PAA.UseVisualStyleBackColor = true;
            buttonOpenSearch_PAA.Click += buttonOpenSearch_PAA_Click;
            // 
            // buttonAddRows__PAA
            // 
            buttonAddRows__PAA.Image = (Image)resources.GetObject("buttonAddRows__PAA.Image");
            buttonAddRows__PAA.Location = new Point(16, 22);
            buttonAddRows__PAA.Name = "buttonAddRows__PAA";
            buttonAddRows__PAA.Size = new Size(105, 73);
            buttonAddRows__PAA.TabIndex = 4;
            buttonAddRows__PAA.UseVisualStyleBackColor = true;
            buttonAddRows__PAA.Click += buttonAddRows_PAA_Click;
            // 
            // buttonAbout_PAA
            // 
            buttonAbout_PAA.Image = Properties.Resources.information;
            buttonAbout_PAA.Location = new Point(51, 25);
            buttonAbout_PAA.Name = "buttonAbout_PAA";
            buttonAbout_PAA.Size = new Size(94, 70);
            buttonAbout_PAA.TabIndex = 5;
            buttonAbout_PAA.UseVisualStyleBackColor = true;
            buttonAbout_PAA.Click += buttonAbout_PAA_Click;
            // 
            // groupBoxHelp_PAA
            // 
            groupBoxHelp_PAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxHelp_PAA.Controls.Add(buttonAbout_PAA);
            groupBoxHelp_PAA.Location = new Point(918, 0);
            groupBoxHelp_PAA.Name = "groupBoxHelp_PAA";
            groupBoxHelp_PAA.Size = new Size(196, 105);
            groupBoxHelp_PAA.TabIndex = 6;
            groupBoxHelp_PAA.TabStop = false;
            groupBoxHelp_PAA.Text = "Помощь";
            // 
            // FormMainProject_PAA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 717);
            Controls.Add(groupBoxHelp_PAA);
            Controls.Add(groupBoxTable_PAA);
            Controls.Add(groupBoxWorkFile_PAA);
            Controls.Add(groupBoxVideo_PAA);
            Name = "FormMainProject_PAA";
            Text = "Form1";
            groupBoxVideo_PAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVideo_PAA).EndInit();
            groupBoxWorkFile_PAA.ResumeLayout(false);
            groupBoxTable_PAA.ResumeLayout(false);
            groupBoxHelp_PAA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBoxVideo_PAA;
        private DataGridView dataGridViewVideo_PAA;
        private Button buttonOpenFile_PAA;
        private Button buttonSaveFile_PAA;
        private Button buttonDelete_PAA;
        private GroupBox groupBoxWorkFile_PAA;
        private GroupBox groupBoxTable_PAA;
        private GroupBox groupBoxHelp_PAA;
        private Button buttonAbout_PAA;
        private Button buttonAddRows__PAA;
        private Button button2;
        private Button buttonOpenSearch_PAA;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
