namespace Equipo2WF_JJUT_RERC
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            TemporizadorResultados = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 130);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Del Empleado #1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 168);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Nivel:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Manual", "Cualificado", "Oficinista o Directivo" });
            comboBox1.Location = new Point(235, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(251, 326);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TemporizadorResultados
            // 
            TemporizadorResultados.Interval = 5000;
            TemporizadorResultados.Tick += TemporizadorResultados_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 207);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 6;
            label3.Text = "Sueldo Bruto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 240);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 7;
            label4.Text = "Exención De Impuestos:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(235, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 276);
            label5.Name = "label5";
            label5.Size = new Size(156, 15);
            label5.TabIndex = 9;
            label5.Text = "Nº Semanas De Antigüedad:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(235, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(235, 273);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(52, 23);
            textBox4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(479, 130);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 12;
            label6.Text = "Sueldo Bruto Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(448, 168);
            label7.Name = "label7";
            label7.Size = new Size(138, 15);
            label7.TabIndex = 13;
            label7.Text = "Retencion De Impuestos:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(461, 204);
            label8.Name = "label8";
            label8.Size = new Size(125, 15);
            label8.TabIndex = 14;
            label8.Text = "Sueldo Neto A Cobrar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
        private System.Windows.Forms.Timer TemporizadorResultados;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
