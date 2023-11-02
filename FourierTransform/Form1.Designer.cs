namespace FourierTransform
{
    partial class Form1
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
            cmbSignalTypeChoice = new ComboBox();
            btnAddSignalToList = new Button();
            listView1 = new ListView();
            colName = new ColumnHeader();
            colFreq = new ColumnHeader();
            colPhase = new ColumnHeader();
            colDc = new ColumnHeader();
            numAmplitude = new NumericUpDown();
            numFrequency = new NumericUpDown();
            numPhase = new NumericUpDown();
            numDutyCycle = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnClearList = new Button();
            btnDeleteOne = new Button();
            chkLowFreq = new CheckBox();
            chkHighFreq = new CheckBox();
            numLowFreq = new NumericUpDown();
            numHighFreq = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            btnGenerate = new Button();
            chkFFT = new CheckBox();
            frmValues = new ScottPlot.FormsPlot();
            frmAmplitude = new ScottPlot.FormsPlot();
            frmPhase = new ScottPlot.FormsPlot();
            lblTime = new Label();
            ((System.ComponentModel.ISupportInitialize)numAmplitude).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFrequency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPhase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDutyCycle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLowFreq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHighFreq).BeginInit();
            SuspendLayout();
            // 
            // cmbSignalTypeChoice
            // 
            cmbSignalTypeChoice.FormattingEnabled = true;
            cmbSignalTypeChoice.Items.AddRange(new object[] { "Sine", "Impulse", "Triangle", "Sawtooth", "Noise" });
            cmbSignalTypeChoice.Location = new Point(33, 253);
            cmbSignalTypeChoice.Margin = new Padding(5);
            cmbSignalTypeChoice.Name = "cmbSignalTypeChoice";
            cmbSignalTypeChoice.Size = new Size(208, 33);
            cmbSignalTypeChoice.TabIndex = 0;
            // 
            // btnAddSignalToList
            // 
            btnAddSignalToList.Location = new Point(278, 246);
            btnAddSignalToList.Name = "btnAddSignalToList";
            btnAddSignalToList.Size = new Size(165, 50);
            btnAddSignalToList.TabIndex = 1;
            btnAddSignalToList.Text = "Add";
            btnAddSignalToList.UseVisualStyleBackColor = true;
            btnAddSignalToList.Click += btnAddSignalToList_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { colName, colFreq, colPhase, colDc });
            listView1.Location = new Point(33, 421);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(634, 457);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 250;
            // 
            // colFreq
            // 
            colFreq.Text = "Freq";
            colFreq.TextAlign = HorizontalAlignment.Center;
            colFreq.Width = 125;
            // 
            // colPhase
            // 
            colPhase.Text = "Phase";
            colPhase.TextAlign = HorizontalAlignment.Center;
            colPhase.Width = 125;
            // 
            // colDc
            // 
            colDc.Text = "DC";
            colDc.TextAlign = HorizontalAlignment.Center;
            colDc.Width = 125;
            // 
            // numAmplitude
            // 
            numAmplitude.DecimalPlaces = 2;
            numAmplitude.Increment = new decimal(new int[] { 2, 0, 0, 65536 });
            numAmplitude.Location = new Point(33, 81);
            numAmplitude.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numAmplitude.Name = "numAmplitude";
            numAmplitude.Size = new Size(150, 32);
            numAmplitude.TabIndex = 3;
            numAmplitude.Value = new decimal(new int[] { 100, 0, 0, 131072 });
            // 
            // numFrequency
            // 
            numFrequency.DecimalPlaces = 2;
            numFrequency.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            numFrequency.Location = new Point(33, 185);
            numFrequency.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numFrequency.Name = "numFrequency";
            numFrequency.Size = new Size(150, 32);
            numFrequency.TabIndex = 4;
            numFrequency.Value = new decimal(new int[] { 220, 0, 0, 0 });
            // 
            // numPhase
            // 
            numPhase.DecimalPlaces = 2;
            numPhase.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            numPhase.Location = new Point(293, 81);
            numPhase.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPhase.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numPhase.Name = "numPhase";
            numPhase.Size = new Size(150, 32);
            numPhase.TabIndex = 5;
            // 
            // numDutyCycle
            // 
            numDutyCycle.DecimalPlaces = 2;
            numDutyCycle.Increment = new decimal(new int[] { 2, 0, 0, 131072 });
            numDutyCycle.Location = new Point(293, 185);
            numDutyCycle.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numDutyCycle.Name = "numDutyCycle";
            numDutyCycle.Size = new Size(150, 32);
            numDutyCycle.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 37);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 7;
            label1.Text = "Amplitude";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 146);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 8;
            label2.Text = "Frequency";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 37);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 9;
            label3.Text = "Phase";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 146);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 10;
            label4.Text = "Duty Cycle";
            // 
            // btnClearList
            // 
            btnClearList.Location = new Point(278, 349);
            btnClearList.Name = "btnClearList";
            btnClearList.Size = new Size(165, 51);
            btnClearList.TabIndex = 11;
            btnClearList.Text = "Delete all";
            btnClearList.UseVisualStyleBackColor = true;
            btnClearList.Click += btnClearList_Click;
            // 
            // btnDeleteOne
            // 
            btnDeleteOne.Location = new Point(33, 349);
            btnDeleteOne.Name = "btnDeleteOne";
            btnDeleteOne.Size = new Size(208, 51);
            btnDeleteOne.TabIndex = 12;
            btnDeleteOne.Text = "Delete selected";
            btnDeleteOne.UseVisualStyleBackColor = true;
            btnDeleteOne.Click += btnDeleteOne_Click;
            // 
            // chkLowFreq
            // 
            chkLowFreq.AutoSize = true;
            chkLowFreq.Location = new Point(482, 89);
            chkLowFreq.Name = "chkLowFreq";
            chkLowFreq.Size = new Size(15, 14);
            chkLowFreq.TabIndex = 13;
            chkLowFreq.UseVisualStyleBackColor = true;
            // 
            // chkHighFreq
            // 
            chkHighFreq.AutoSize = true;
            chkHighFreq.Location = new Point(482, 193);
            chkHighFreq.Name = "chkHighFreq";
            chkHighFreq.Size = new Size(15, 14);
            chkHighFreq.TabIndex = 14;
            chkHighFreq.UseVisualStyleBackColor = true;
            // 
            // numLowFreq
            // 
            numLowFreq.DecimalPlaces = 2;
            numLowFreq.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            numLowFreq.Location = new Point(503, 81);
            numLowFreq.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numLowFreq.Name = "numLowFreq";
            numLowFreq.Size = new Size(143, 32);
            numLowFreq.TabIndex = 15;
            // 
            // numHighFreq
            // 
            numHighFreq.DecimalPlaces = 2;
            numHighFreq.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            numHighFreq.Location = new Point(503, 185);
            numHighFreq.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numHighFreq.Name = "numHighFreq";
            numHighFreq.Size = new Size(143, 32);
            numHighFreq.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(503, 37);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
            label5.TabIndex = 17;
            label5.Text = "Low Freq Filter";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(503, 146);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 18;
            label6.Text = "High Freq Filter";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(482, 281);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(173, 68);
            btnGenerate.TabIndex = 19;
            btnGenerate.Text = "Сгенерировать спектры";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // chkFFT
            // 
            chkFFT.AutoSize = true;
            chkFFT.Location = new Point(536, 246);
            chkFFT.Name = "chkFFT";
            chkFFT.Size = new Size(59, 29);
            chkFFT.TabIndex = 20;
            chkFFT.Text = "FFT";
            chkFFT.UseVisualStyleBackColor = true;
            // 
            // frmValues
            // 
            frmValues.Location = new Point(714, 12);
            frmValues.Margin = new Padding(4, 3, 4, 3);
            frmValues.Name = "frmValues";
            frmValues.Size = new Size(819, 284);
            frmValues.TabIndex = 21;
            // 
            // frmAmplitude
            // 
            frmAmplitude.Location = new Point(714, 302);
            frmAmplitude.Margin = new Padding(4, 3, 4, 3);
            frmAmplitude.Name = "frmAmplitude";
            frmAmplitude.Size = new Size(819, 284);
            frmAmplitude.TabIndex = 22;
            // 
            // frmPhase
            // 
            frmPhase.Location = new Point(714, 592);
            frmPhase.Margin = new Padding(4, 3, 4, 3);
            frmPhase.Name = "frmPhase";
            frmPhase.Size = new Size(819, 284);
            frmPhase.TabIndex = 23;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(553, 362);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 25);
            lblTime.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 903);
            Controls.Add(lblTime);
            Controls.Add(frmPhase);
            Controls.Add(frmAmplitude);
            Controls.Add(frmValues);
            Controls.Add(chkFFT);
            Controls.Add(btnGenerate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numHighFreq);
            Controls.Add(numLowFreq);
            Controls.Add(chkHighFreq);
            Controls.Add(chkLowFreq);
            Controls.Add(btnDeleteOne);
            Controls.Add(btnClearList);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numDutyCycle);
            Controls.Add(numPhase);
            Controls.Add(numFrequency);
            Controls.Add(numAmplitude);
            Controls.Add(listView1);
            Controls.Add(btnAddSignalToList);
            Controls.Add(cmbSignalTypeChoice);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Преобразования Фурье";
            ((System.ComponentModel.ISupportInitialize)numAmplitude).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFrequency).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPhase).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDutyCycle).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLowFreq).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHighFreq).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSignalTypeChoice;
        private Button btnAddSignalToList;
        private ListView listView1;
        private NumericUpDown numAmplitude;
        private NumericUpDown numFrequency;
        private NumericUpDown numPhase;
        private NumericUpDown numDutyCycle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ColumnHeader colName;
        private ColumnHeader colFreq;
        private ColumnHeader colPhase;
        private ColumnHeader colDc;
        private Button btnClearList;
        private Button btnDeleteOne;
        private CheckBox chkLowFreq;
        private CheckBox chkHighFreq;
        private NumericUpDown numLowFreq;
        private NumericUpDown numHighFreq;
        private Label label5;
        private Label label6;
        private Button btnGenerate;
        private CheckBox chkFFT;
        private ScottPlot.FormsPlot frmValues;
        private ScottPlot.FormsPlot frmAmplitude;
        private ScottPlot.FormsPlot frmPhase;
        private Label lblTime;
    }
}