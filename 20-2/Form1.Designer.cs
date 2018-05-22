namespace _20_2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VardasBox = new System.Windows.Forms.TextBox();
            this.PavardeBox = new System.Windows.Forms.TextBox();
            this.GimimoDataBox = new System.Windows.Forms.TextBox();
            this.GaunamaDataBox = new System.Windows.Forms.TextBox();
            this.DirbaImonejeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Darbuotojas";
            // 
            // VardasBox
            // 
            this.VardasBox.Location = new System.Drawing.Point(150, 106);
            this.VardasBox.Name = "VardasBox";
            this.VardasBox.Size = new System.Drawing.Size(100, 22);
            this.VardasBox.TabIndex = 2;
            // 
            // PavardeBox
            // 
            this.PavardeBox.Location = new System.Drawing.Point(150, 144);
            this.PavardeBox.Name = "PavardeBox";
            this.PavardeBox.Size = new System.Drawing.Size(100, 22);
            this.PavardeBox.TabIndex = 3;
            // 
            // GimimoDataBox
            // 
            this.GimimoDataBox.Location = new System.Drawing.Point(150, 186);
            this.GimimoDataBox.Name = "GimimoDataBox";
            this.GimimoDataBox.Size = new System.Drawing.Size(100, 22);
            this.GimimoDataBox.TabIndex = 4;
            // 
            // GaunamaDataBox
            // 
            this.GaunamaDataBox.Location = new System.Drawing.Point(150, 225);
            this.GaunamaDataBox.Name = "GaunamaDataBox";
            this.GaunamaDataBox.Size = new System.Drawing.Size(100, 22);
            this.GaunamaDataBox.TabIndex = 5;
            // 
            // DirbaImonejeBox
            // 
            this.DirbaImonejeBox.Location = new System.Drawing.Point(150, 267);
            this.DirbaImonejeBox.Name = "DirbaImonejeBox";
            this.DirbaImonejeBox.Size = new System.Drawing.Size(100, 22);
            this.DirbaImonejeBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vardas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pavardė";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gimimo data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gaunama alga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dirba įmonėje";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "Krauti duomenis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DirbaImonejeBox);
            this.Controls.Add(this.GaunamaDataBox);
            this.Controls.Add(this.GimimoDataBox);
            this.Controls.Add(this.PavardeBox);
            this.Controls.Add(this.VardasBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VardasBox;
        private System.Windows.Forms.TextBox PavardeBox;
        private System.Windows.Forms.TextBox GimimoDataBox;
        private System.Windows.Forms.TextBox GaunamaDataBox;
        private System.Windows.Forms.TextBox DirbaImonejeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

