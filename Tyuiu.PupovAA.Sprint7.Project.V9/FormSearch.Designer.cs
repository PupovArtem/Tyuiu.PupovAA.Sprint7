namespace Tyuiu.PupovAA.Sprint7.Project.V9
{
    partial class FormSearch_PAA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxSearchResult_PAA = new TextBox();
            buttonSearchword_PAA = new Button();
            buttonCloseSearch_PAA = new Button();
            SuspendLayout();
            // 
            // textBoxSearchResult_PAA
            // 
            textBoxSearchResult_PAA.Location = new Point(154, 83);
            textBoxSearchResult_PAA.Name = "textBoxSearchResult_PAA";
            textBoxSearchResult_PAA.Size = new Size(220, 27);
            textBoxSearchResult_PAA.TabIndex = 0;
            // 
            // buttonSearchword_PAA
            // 
            buttonSearchword_PAA.Location = new Point(37, 81);
            buttonSearchword_PAA.Name = "buttonSearchword_PAA";
            buttonSearchword_PAA.Size = new Size(111, 29);
            buttonSearchword_PAA.TabIndex = 1;
            buttonSearchword_PAA.Text = "Найти";
            buttonSearchword_PAA.UseVisualStyleBackColor = true;
            buttonSearchword_PAA.Click += buttonSearchword_PAA_Click;
            // 
            // buttonCloseSearch_PAA
            // 
            buttonCloseSearch_PAA.BackColor = Color.RosyBrown;
            buttonCloseSearch_PAA.Location = new Point(361, 148);
            buttonCloseSearch_PAA.Name = "buttonCloseSearch_PAA";
            buttonCloseSearch_PAA.Size = new Size(117, 40);
            buttonCloseSearch_PAA.TabIndex = 2;
            buttonCloseSearch_PAA.Text = "Закрыть";
            buttonCloseSearch_PAA.UseVisualStyleBackColor = false;
            buttonCloseSearch_PAA.Click += buttonCloseSearch_PAA_Click;
            // 
            // FormSearch_PAA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 200);
            Controls.Add(buttonCloseSearch_PAA);
            Controls.Add(buttonSearchword_PAA);
            Controls.Add(textBoxSearchResult_PAA);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSearch_PAA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поиск";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearchResult_PAA;
        private Button buttonSearchword_PAA;
        private Button buttonCloseSearch_PAA;
    }
}