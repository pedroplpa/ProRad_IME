namespace Project__IC
{
    partial class Kerma
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.proRadDataSet = new Project__IC.ProRadDataSet();
            this.proRadDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.constanteKermaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.constanteKermaTableAdapter = new Project__IC.ProRadDataSetTableAdapters.ConstanteKermaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proRadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proRadDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constanteKermaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Para calcular o kerma, indique a fluência em energia, o material\r\npelo qual passa" +
    "rá a radiação e a energia do fóton";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fluência em energia =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "MeV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Energia do fóton =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Material =";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(258, 189);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Kerma = ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(233, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.constanteKermaBindingSource;
            this.comboBox2.DisplayMember = "Material";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(233, 152);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.ValueMember = "Material";
            // 
            // proRadDataSet
            // 
            this.proRadDataSet.DataSetName = "ProRadDataSet";
            this.proRadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proRadDataSetBindingSource
            // 
            this.proRadDataSetBindingSource.DataSource = this.proRadDataSet;
            this.proRadDataSetBindingSource.Position = 0;
            // 
            // constanteKermaBindingSource
            // 
            this.constanteKermaBindingSource.DataMember = "ConstanteKerma";
            this.constanteKermaBindingSource.DataSource = this.proRadDataSetBindingSource;
            // 
            // constanteKermaTableAdapter
            // 
            this.constanteKermaTableAdapter.ClearBeforeFill = true;
            // 
            // Kerma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 262);
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
            this.Name = "Kerma";
            this.Text = "Kerma";
            this.Load += new System.EventHandler(this.Kerma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proRadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proRadDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constanteKermaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.BindingSource proRadDataSetBindingSource;
        private ProRadDataSet proRadDataSet;
        private System.Windows.Forms.BindingSource constanteKermaBindingSource;
        private ProRadDataSetTableAdapters.ConstanteKermaTableAdapter constanteKermaTableAdapter;
    }
}