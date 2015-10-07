namespace Project__IC
{
    partial class KermaColisão
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
            this.components = new System.ComponentModel.Container();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.constanteKermaColisãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proRadDataSet = new Project__IC.ProRadDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.result = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.constanteKermaColisãoTableAdapter = new Project__IC.ProRadDataSetTableAdapters.ConstanteKermaColisãoTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.constanteKermaColisãoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proRadDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.constanteKermaColisãoBindingSource;
            this.comboBox2.DisplayMember = "Material";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(226, 154);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.ValueMember = "Material";
            // 
            // constanteKermaColisãoBindingSource
            // 
            this.constanteKermaColisãoBindingSource.DataMember = "ConstanteKermaColisão";
            this.constanteKermaColisãoBindingSource.DataSource = this.proRadDataSet;
            // 
            // proRadDataSet
            // 
            this.proRadDataSet.DataSetName = "ProRadDataSet";
            this.proRadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0,01",
            "0,015",
            "0,02",
            "0,03",
            "0,04",
            "0,05",
            "0,06",
            "0,08",
            "0,10",
            "0,15",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,8",
            "1,0",
            "1,5",
            "2",
            "3",
            "4",
            "5",
            "6",
            "8",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(226, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(251, 191);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Kerma de Colisão = ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Material =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Energia do fóton =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "MeV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fluência em energia =";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Para calcular o kerma de colisão, indique a fluência em energia, o material\r\npelo" +
    " qual passará a radiação e a energia do fóton";
            // 
            // constanteKermaColisãoTableAdapter
            // 
            this.constanteKermaColisãoTableAdapter.ClearBeforeFill = true;
            // 
            // KermaColisão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 272);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "KermaColisão";
            this.Text = "Kerma de Colisão";
            this.Load += new System.EventHandler(this.KermaColisao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.constanteKermaColisãoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proRadDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private ProRadDataSet proRadDataSet;
        private System.Windows.Forms.BindingSource constanteKermaColisãoBindingSource;
        private ProRadDataSetTableAdapters.ConstanteKermaColisãoTableAdapter constanteKermaColisãoTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}