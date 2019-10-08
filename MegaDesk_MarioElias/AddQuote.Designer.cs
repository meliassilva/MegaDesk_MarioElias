namespace MegaDesk_MarioElias
{
    partial class AddQuote
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
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.surfaceMaterial = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Location = new System.Drawing.Point(812, 824);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(240, 79);
            this.btnGetQuote.TabIndex = 0;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(434, 824);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(248, 79);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 83);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Quote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(564, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(726, 53);
            this.textBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(209, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 291);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Measures";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lenght";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Width";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(313, 185);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(140, 38);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(313, 85);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(139, 38);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(1202, 413);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(821, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of Drawers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(821, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Surface Material";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(822, 621);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "Shipping Method";
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.FormattingEnabled = true;
            this.surfaceMaterial.Items.AddRange(new object[] {
            "laminate",
            "oak",
            "rosewood",
            "veneer",
            "pine"});
            this.surfaceMaterial.Location = new System.Drawing.Point(1121, 525);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(300, 39);
            this.surfaceMaterial.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "3 day ",
            "5 day",
            "7 days",
            "Normal 14 days"});
            this.comboBox2.Location = new System.Drawing.Point(1121, 614);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(300, 39);
            this.comboBox2.TabIndex = 11;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1567, 1083);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetQuote);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox surfaceMaterial;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}