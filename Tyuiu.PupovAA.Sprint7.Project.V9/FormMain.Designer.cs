namespace Tyuiu.PupovAA.Sprint7.Project.V9
{
    partial class FormMain
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
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
            button3 = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button4 = new Button();
            buttonAbout_PAA = new Button();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVideo_PAA).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridViewVideo_PAA);
            groupBox1.Location = new Point(0, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1090, 615);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Каталог видео";
            // 
            // dataGridViewVideo_PAA
            // 
            dataGridViewVideo_PAA.AllowUserToDeleteRows = false;
            dataGridViewVideo_PAA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVideo_PAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVideo_PAA.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewVideo_PAA.Dock = DockStyle.Fill;
            dataGridViewVideo_PAA.Location = new Point(3, 23);
            dataGridViewVideo_PAA.Name = "dataGridViewVideo_PAA";
            dataGridViewVideo_PAA.RowHeadersVisible = false;
            dataGridViewVideo_PAA.RowHeadersWidth = 51;
            dataGridViewVideo_PAA.Size = new Size(1084, 589);
            dataGridViewVideo_PAA.TabIndex = 0;
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
            Column3.HeaderText = "Длительность";
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
            Column5.HeaderText = "Стоимсть";
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
            Column7.HeaderText = "Разрешение";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // buttonOpenFile_PAA
            // 
            buttonOpenFile_PAA.Image = Properties.Resources.book_add;
            buttonOpenFile_PAA.Location = new Point(12, 19);
            buttonOpenFile_PAA.Name = "buttonOpenFile_PAA";
            buttonOpenFile_PAA.Size = new Size(112, 79);
            buttonOpenFile_PAA.TabIndex = 1;
            buttonOpenFile_PAA.UseVisualStyleBackColor = true;
            buttonOpenFile_PAA.Click += buttonOpenFile_PAA_Click;
            // 
            // buttonSaveFile_PAA
            // 
            buttonSaveFile_PAA.Image = Properties.Resources.book_edit;
            buttonSaveFile_PAA.Location = new Point(130, 20);
            buttonSaveFile_PAA.Name = "buttonSaveFile_PAA";
            buttonSaveFile_PAA.Size = new Size(112, 79);
            buttonSaveFile_PAA.TabIndex = 2;
            buttonSaveFile_PAA.UseVisualStyleBackColor = true;
            buttonSaveFile_PAA.Click += buttonSaveFile_PAA_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 21);
            button3.Name = "button3";
            button3.Size = new Size(102, 79);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonOpenFile_PAA);
            groupBox2.Controls.Add(buttonSaveFile_PAA);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 105);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Работа с файлом";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(248, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(645, 105);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Работа с таблицей";
            // 
            // button4
            // 
            button4.Location = new Point(114, 23);
            button4.Name = "button4";
            button4.Size = new Size(94, 76);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox4.Controls.Add(buttonAbout_PAA);
            groupBox4.Location = new Point(894, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(196, 105);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Помощь";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 717);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVideo_PAA).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private DataGridView dataGridViewVideo_PAA;
        private Button buttonOpenFile_PAA;
        private Button buttonSaveFile_PAA;
        private Button button3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button buttonAbout_PAA;
        private Button button4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
