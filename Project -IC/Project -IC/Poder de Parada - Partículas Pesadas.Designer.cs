namespace Project__IC
{
    partial class Poder_de_Parada___Partículas_Pesadas
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
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.proRadDataSet = new Project__IC.ProRadDataSet();
            this.potencialExcitaçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.potencialExcitaçãoTableAdapter = new Project__IC.ProRadDataSetTableAdapters.PotencialExcitaçãoTableAdapter();
            this.resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proRadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potencialExcitaçãoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.potencialExcitaçãoBindingSource;
            this.comboBox2.DisplayMember = "Material";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(222, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 47;
            this.comboBox2.ValueMember = "Potêncial de Excitação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Poder de Parada = ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Material =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Número atômico do meio potencial =";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 39);
            this.label1.TabIndex = 37;
            this.label1.Text = "Para calcular o poder de parada, indique o número atômico do\r\nmeio potencial, a c" +
    "arga da partícula, o número de massa do meio\r\nabsorvedor, a velocidade da partíc" +
    "ula e o material do meio absorvedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Carga da Partícula =";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(241, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Número de massa do meio absorvedor =";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(241, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Velocidade da partícula =";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(241, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "m / s";
            // 
            // proRadDataSet
            // 
            this.proRadDataSet.DataSetName = "ProRadDataSet";
            this.proRadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // potencialExcitaçãoBindingSource
            // 
            this.potencialExcitaçãoBindingSource.DataMember = "PotencialExcitação";
            this.potencialExcitaçãoBindingSource.DataSource = this.proRadDataSet;
            // 
            // potencialExcitaçãoTableAdapter
            // 
            this.potencialExcitaçãoTableAdapter.ClearBeforeFill = true;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(238, 218);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 13);
            this.resultado.TabIndex = 55;
            // 
            // Poder_de_Parada___Partículas_Pesadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 291);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Poder_de_Parada___Partículas_Pesadas";
            this.Text = "Poder de Parada - Partículas Pesadas";
            this.Load += new System.EventHandler(this.Poder_de_Parada___Partículas_Pesadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proRadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potencialExcitaçãoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private ProRadDataSet proRadDataSet;
        private System.Windows.Forms.BindingSource potencialExcitaçãoBindingSource;
        private ProRadDataSetTableAdapters.PotencialExcitaçãoTableAdapter potencialExcitaçãoTableAdapter;
        private System.Windows.Forms.Label resultado;
    }
}