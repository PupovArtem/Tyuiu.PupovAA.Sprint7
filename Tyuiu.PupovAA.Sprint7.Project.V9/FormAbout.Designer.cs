namespace Tyuiu.PupovAA.Sprint7.Project.V9
{
    partial class FormAbout_PAA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_PAA));
            pictureBoxAvatar_PAA = new PictureBox();
            labelInfo_PAA = new Label();
            buttonCloseAbout_PAA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_PAA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_PAA
            // 
            pictureBoxAvatar_PAA.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxAvatar_PAA.Image = Properties.Resources.photo_5350377671759696328_x;
            pictureBoxAvatar_PAA.Location = new Point(12, 12);
            pictureBoxAvatar_PAA.Name = "pictureBoxAvatar_PAA";
            pictureBoxAvatar_PAA.Size = new Size(256, 426);
            pictureBoxAvatar_PAA.TabIndex = 0;
            pictureBoxAvatar_PAA.TabStop = false;
            // 
            // labelInfo_PAA
            // 
            labelInfo_PAA.AutoSize = true;
            labelInfo_PAA.Location = new Point(274, 39);
            labelInfo_PAA.Name = "labelInfo_PAA";
            labelInfo_PAA.Size = new Size(487, 200);
            labelInfo_PAA.TabIndex = 1;
            labelInfo_PAA.Text = resources.GetString("labelInfo_PAA.Text");
            // 
            // buttonCloseAbout_PAA
            // 
            buttonCloseAbout_PAA.BackColor = Color.RosyBrown;
            buttonCloseAbout_PAA.Location = new Point(622, 376);
            buttonCloseAbout_PAA.Name = "buttonCloseAbout_PAA";
            buttonCloseAbout_PAA.Size = new Size(139, 45);
            buttonCloseAbout_PAA.TabIndex = 2;
            buttonCloseAbout_PAA.Text = "Закрыть";
            buttonCloseAbout_PAA.UseVisualStyleBackColor = false;
            buttonCloseAbout_PAA.Click += buttonCloseAbout_PAA_Click;
            // 
            // FormAbout_PAA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCloseAbout_PAA);
            Controls.Add(labelInfo_PAA);
            Controls.Add(pictureBoxAvatar_PAA);
            Name = "FormAbout_PAA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_PAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_PAA;
        private Label labelInfo_PAA;
        private Button buttonCloseAbout_PAA;
    }
}