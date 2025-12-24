namespace Tyuiu.PupovAA.Sprint7.Project.V9
{
    partial class FormStatistics_PAA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonResultat_PAA = new Button();
            textBoxCount_PAA = new TextBox();
            textBoxSumCol_PAA = new TextBox();
            textBoxMean_PAA = new TextBox();
            textBoxMin_PAA = new TextBox();
            textBoxMax_PAA = new TextBox();
            labelSumRow_PAA = new Label();
            labelSum_PAA = new Label();
            LabelAvarege_PAA = new Label();
            labelMin = new Label();
            labelMax_PAA = new Label();
            chartresult_PAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartresult_PAA).BeginInit();
            SuspendLayout();
            // 
            // buttonResultat_PAA
            // 
            buttonResultat_PAA.Location = new Point(15, 367);
            buttonResultat_PAA.Name = "buttonResultat_PAA";
            buttonResultat_PAA.Size = new Size(182, 59);
            buttonResultat_PAA.TabIndex = 0;
            buttonResultat_PAA.Text = "Подсчёт";
            buttonResultat_PAA.UseVisualStyleBackColor = true;
            buttonResultat_PAA.Click += button1_Click;
            // 
            // textBoxCount_PAA
            // 
            textBoxCount_PAA.Location = new Point(12, 54);
            textBoxCount_PAA.Name = "textBoxCount_PAA";
            textBoxCount_PAA.ReadOnly = true;
            textBoxCount_PAA.Size = new Size(185, 27);
            textBoxCount_PAA.TabIndex = 1;
            // 
            // textBoxSumCol_PAA
            // 
            textBoxSumCol_PAA.Location = new Point(12, 117);
            textBoxSumCol_PAA.Name = "textBoxSumCol_PAA";
            textBoxSumCol_PAA.ReadOnly = true;
            textBoxSumCol_PAA.Size = new Size(185, 27);
            textBoxSumCol_PAA.TabIndex = 2;
            // 
            // textBoxMean_PAA
            // 
            textBoxMean_PAA.Location = new Point(12, 180);
            textBoxMean_PAA.Name = "textBoxMean_PAA";
            textBoxMean_PAA.ReadOnly = true;
            textBoxMean_PAA.Size = new Size(185, 27);
            textBoxMean_PAA.TabIndex = 3;
            // 
            // textBoxMin_PAA
            // 
            textBoxMin_PAA.Location = new Point(12, 245);
            textBoxMin_PAA.Name = "textBoxMin_PAA";
            textBoxMin_PAA.ReadOnly = true;
            textBoxMin_PAA.Size = new Size(185, 27);
            textBoxMin_PAA.TabIndex = 4;
            // 
            // textBoxMax_PAA
            // 
            textBoxMax_PAA.Location = new Point(15, 309);
            textBoxMax_PAA.Name = "textBoxMax_PAA";
            textBoxMax_PAA.ReadOnly = true;
            textBoxMax_PAA.Size = new Size(182, 27);
            textBoxMax_PAA.TabIndex = 5;
            // 
            // labelSumRow_PAA
            // 
            labelSumRow_PAA.AutoSize = true;
            labelSumRow_PAA.Location = new Point(12, 31);
            labelSumRow_PAA.Name = "labelSumRow_PAA";
            labelSumRow_PAA.Size = new Size(136, 20);
            labelSumRow_PAA.TabIndex = 6;
            labelSumRow_PAA.Text = "Количество видео";
            // 
            // labelSum_PAA
            // 
            labelSum_PAA.AutoSize = true;
            labelSum_PAA.Location = new Point(15, 94);
            labelSum_PAA.Name = "labelSum_PAA";
            labelSum_PAA.Size = new Size(133, 20);
            labelSum_PAA.TabIndex = 7;
            labelSum_PAA.Text = "Общая стоимость";
            // 
            // LabelAvarege_PAA
            // 
            LabelAvarege_PAA.AutoSize = true;
            LabelAvarege_PAA.Location = new Point(15, 157);
            LabelAvarege_PAA.Name = "LabelAvarege_PAA";
            LabelAvarege_PAA.Size = new Size(138, 20);
            LabelAvarege_PAA.TabIndex = 8;
            LabelAvarege_PAA.Text = "Среднее значение";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new Point(12, 222);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(185, 20);
            labelMin.TabIndex = 9;
            labelMin.Text = "Минимальная стоимость";
            // 
            // labelMax_PAA
            // 
            labelMax_PAA.AutoSize = true;
            labelMax_PAA.Location = new Point(15, 286);
            labelMax_PAA.Name = "labelMax_PAA";
            labelMax_PAA.Size = new Size(189, 20);
            labelMax_PAA.TabIndex = 10;
            labelMax_PAA.Text = "Максимальная стоимость";
            // 
            // chartresult_PAA
            // 
            chartArea2.Name = "ChartArea1";
            chartresult_PAA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartresult_PAA.Legends.Add(legend2);
            chartresult_PAA.Location = new Point(267, 31);
            chartresult_PAA.Name = "chartresult_PAA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartresult_PAA.Series.Add(series2);
            chartresult_PAA.Size = new Size(666, 399);
            chartresult_PAA.TabIndex = 11;
            chartresult_PAA.Text = "Стоимость видео";
            // 
            // FormStatistics_PAA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 444);
            Controls.Add(chartresult_PAA);
            Controls.Add(labelMax_PAA);
            Controls.Add(labelMin);
            Controls.Add(LabelAvarege_PAA);
            Controls.Add(labelSum_PAA);
            Controls.Add(labelSumRow_PAA);
            Controls.Add(textBoxMax_PAA);
            Controls.Add(textBoxMin_PAA);
            Controls.Add(textBoxMean_PAA);
            Controls.Add(textBoxSumCol_PAA);
            Controls.Add(textBoxCount_PAA);
            Controls.Add(buttonResultat_PAA);
            Name = "FormStatistics_PAA";
            Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)chartresult_PAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonResultat_PAA;
        private TextBox textBoxCount_PAA;
        private TextBox textBoxSumCol_PAA;
        private TextBox textBoxMean_PAA;
        private TextBox textBoxMin_PAA;
        private TextBox textBoxMax_PAA;
        private Label labelSumRow_PAA;
        private Label labelSum_PAA;
        private Label LabelAvarege_PAA;
        private Label labelMin;
        private Label labelMax_PAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartresult_PAA;
    }
}