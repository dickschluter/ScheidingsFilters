namespace ScheidingsFilters
{
    partial class Form1
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
            this.groupBoxLP = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxTonenLP = new System.Windows.Forms.CheckBox();
            this.numericUpDownOrdeLP = new System.Windows.Forms.NumericUpDown();
            this.textBoxFrequentieLP = new System.Windows.Forms.TextBox();
            this.groupBoxHP = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxTonenHP = new System.Windows.Forms.CheckBox();
            this.numericUpDownOrdeHP = new System.Windows.Forms.NumericUpDown();
            this.textBoxFrequentieHP = new System.Windows.Forms.TextBox();
            this.checkBoxTonenSom = new System.Windows.Forms.CheckBox();
            this.checkBoxTonenVerschil = new System.Windows.Forms.CheckBox();
            this.buttonTonen = new System.Windows.Forms.Button();
            this.groupBoxLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrdeLP)).BeginInit();
            this.groupBoxHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrdeHP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLP
            // 
            this.groupBoxLP.Controls.Add(this.label5);
            this.groupBoxLP.Controls.Add(this.label4);
            this.groupBoxLP.Controls.Add(this.label3);
            this.groupBoxLP.Controls.Add(this.label2);
            this.groupBoxLP.Controls.Add(this.label1);
            this.groupBoxLP.Controls.Add(this.checkBoxTonenLP);
            this.groupBoxLP.Controls.Add(this.numericUpDownOrdeLP);
            this.groupBoxLP.Controls.Add(this.textBoxFrequentieLP);
            this.groupBoxLP.Location = new System.Drawing.Point(1100, 50);
            this.groupBoxLP.Name = "groupBoxLP";
            this.groupBoxLP.Size = new System.Drawing.Size(240, 160);
            this.groupBoxLP.TabIndex = 14;
            this.groupBoxLP.TabStop = false;
            this.groupBoxLP.Text = "LP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "C3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "C2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "C1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Orde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Freq";
            // 
            // checkBoxTonenLP
            // 
            this.checkBoxTonenLP.AutoSize = true;
            this.checkBoxTonenLP.Checked = true;
            this.checkBoxTonenLP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTonenLP.Location = new System.Drawing.Point(30, 120);
            this.checkBoxTonenLP.Name = "checkBoxTonenLP";
            this.checkBoxTonenLP.Size = new System.Drawing.Size(67, 17);
            this.checkBoxTonenLP.TabIndex = 2;
            this.checkBoxTonenLP.Text = "Toon LP";
            this.checkBoxTonenLP.UseVisualStyleBackColor = true;
            this.checkBoxTonenLP.CheckStateChanged += new System.EventHandler(this.ToonCurves);
            // 
            // numericUpDownOrdeLP
            // 
            this.numericUpDownOrdeLP.Location = new System.Drawing.Point(60, 60);
            this.numericUpDownOrdeLP.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownOrdeLP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOrdeLP.Name = "numericUpDownOrdeLP";
            this.numericUpDownOrdeLP.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownOrdeLP.TabIndex = 1;
            this.numericUpDownOrdeLP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOrdeLP.ValueChanged += new System.EventHandler(this.numericUpDownOrdeLP_ValueChanged);
            // 
            // textBoxFrequentieLP
            // 
            this.textBoxFrequentieLP.Location = new System.Drawing.Point(60, 30);
            this.textBoxFrequentieLP.Name = "textBoxFrequentieLP";
            this.textBoxFrequentieLP.Size = new System.Drawing.Size(50, 20);
            this.textBoxFrequentieLP.TabIndex = 0;
            this.textBoxFrequentieLP.Text = "1000";
            // 
            // groupBoxHP
            // 
            this.groupBoxHP.Controls.Add(this.label6);
            this.groupBoxHP.Controls.Add(this.label7);
            this.groupBoxHP.Controls.Add(this.label8);
            this.groupBoxHP.Controls.Add(this.label9);
            this.groupBoxHP.Controls.Add(this.label10);
            this.groupBoxHP.Controls.Add(this.checkBoxTonenHP);
            this.groupBoxHP.Controls.Add(this.numericUpDownOrdeHP);
            this.groupBoxHP.Controls.Add(this.textBoxFrequentieHP);
            this.groupBoxHP.Location = new System.Drawing.Point(1100, 250);
            this.groupBoxHP.Name = "groupBoxHP";
            this.groupBoxHP.Size = new System.Drawing.Size(240, 160);
            this.groupBoxHP.TabIndex = 11;
            this.groupBoxHP.TabStop = false;
            this.groupBoxHP.Text = "HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "C3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "C2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "C1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Orde";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Freq";
            // 
            // checkBoxTonenHP
            // 
            this.checkBoxTonenHP.AutoSize = true;
            this.checkBoxTonenHP.Checked = true;
            this.checkBoxTonenHP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTonenHP.Location = new System.Drawing.Point(30, 120);
            this.checkBoxTonenHP.Name = "checkBoxTonenHP";
            this.checkBoxTonenHP.Size = new System.Drawing.Size(69, 17);
            this.checkBoxTonenHP.TabIndex = 2;
            this.checkBoxTonenHP.Text = "Toon HP";
            this.checkBoxTonenHP.UseVisualStyleBackColor = true;
            this.checkBoxTonenHP.CheckStateChanged += new System.EventHandler(this.ToonCurves);
            // 
            // numericUpDownOrdeHP
            // 
            this.numericUpDownOrdeHP.Location = new System.Drawing.Point(60, 60);
            this.numericUpDownOrdeHP.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownOrdeHP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOrdeHP.Name = "numericUpDownOrdeHP";
            this.numericUpDownOrdeHP.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownOrdeHP.TabIndex = 1;
            this.numericUpDownOrdeHP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOrdeHP.ValueChanged += new System.EventHandler(this.numericUpDownOrdeHP_ValueChanged);
            // 
            // textBoxFrequentieHP
            // 
            this.textBoxFrequentieHP.Location = new System.Drawing.Point(60, 30);
            this.textBoxFrequentieHP.Name = "textBoxFrequentieHP";
            this.textBoxFrequentieHP.Size = new System.Drawing.Size(50, 20);
            this.textBoxFrequentieHP.TabIndex = 0;
            this.textBoxFrequentieHP.Text = "1000";
            // 
            // checkBoxTonenSom
            // 
            this.checkBoxTonenSom.AutoSize = true;
            this.checkBoxTonenSom.Location = new System.Drawing.Point(1130, 460);
            this.checkBoxTonenSom.Name = "checkBoxTonenSom";
            this.checkBoxTonenSom.Size = new System.Drawing.Size(94, 17);
            this.checkBoxTonenSom.TabIndex = 12;
            this.checkBoxTonenSom.Text = "Toon LP + HP";
            this.checkBoxTonenSom.UseVisualStyleBackColor = true;
            this.checkBoxTonenSom.CheckStateChanged += new System.EventHandler(this.ToonCurves);
            // 
            // checkBoxTonenVerschil
            // 
            this.checkBoxTonenVerschil.AutoSize = true;
            this.checkBoxTonenVerschil.Location = new System.Drawing.Point(1130, 490);
            this.checkBoxTonenVerschil.Name = "checkBoxTonenVerschil";
            this.checkBoxTonenVerschil.Size = new System.Drawing.Size(91, 17);
            this.checkBoxTonenVerschil.TabIndex = 13;
            this.checkBoxTonenVerschil.Text = "Toon LP - HP";
            this.checkBoxTonenVerschil.UseVisualStyleBackColor = true;
            this.checkBoxTonenVerschil.CheckStateChanged += new System.EventHandler(this.ToonCurves);
            // 
            // buttonTonen
            // 
            this.buttonTonen.Location = new System.Drawing.Point(1130, 550);
            this.buttonTonen.Name = "buttonTonen";
            this.buttonTonen.Size = new System.Drawing.Size(100, 23);
            this.buttonTonen.TabIndex = 0;
            this.buttonTonen.Text = "Toon curves";
            this.buttonTonen.UseVisualStyleBackColor = true;
            this.buttonTonen.Click += new System.EventHandler(this.ToonCurves);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1390, 750);
            this.Controls.Add(this.buttonTonen);
            this.Controls.Add(this.checkBoxTonenVerschil);
            this.Controls.Add(this.checkBoxTonenSom);
            this.Controls.Add(this.groupBoxHP);
            this.Controls.Add(this.groupBoxLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheidingsFilters";
            this.groupBoxLP.ResumeLayout(false);
            this.groupBoxLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrdeLP)).EndInit();
            this.groupBoxHP.ResumeLayout(false);
            this.groupBoxHP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrdeHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLP;
        private System.Windows.Forms.TextBox textBoxFrequentieLP;
        private System.Windows.Forms.CheckBox checkBoxTonenLP;
        private System.Windows.Forms.NumericUpDown numericUpDownOrdeLP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxTonenHP;
        private System.Windows.Forms.NumericUpDown numericUpDownOrdeHP;
        private System.Windows.Forms.TextBox textBoxFrequentieHP;
        private System.Windows.Forms.CheckBox checkBoxTonenSom;
        private System.Windows.Forms.CheckBox checkBoxTonenVerschil;
        private System.Windows.Forms.Button buttonTonen;

    }
}

