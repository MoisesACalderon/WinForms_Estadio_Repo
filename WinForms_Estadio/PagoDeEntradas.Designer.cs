namespace WinForms_Estadio
{
    partial class PagoDeEntradas
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
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            btncontinuar = new Button();
            btnRegresarSS = new Button();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(293, 35);
            label4.Name = "label4";
            label4.Size = new Size(227, 16);
            label4.TabIndex = 69;
            label4.Text = "INGRESE LOS DATOS DE LA TARJETA\r\n";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(306, 9);
            label3.Name = "label3";
            label3.Size = new Size(205, 25);
            label3.TabIndex = 68;
            label3.Text = "PAGO DE ENTRADAS\r\n";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(176, 371);
            label5.Name = "label5";
            label5.Size = new Size(441, 25);
            label5.TabIndex = 73;
            label5.Text = "_______________________________________";
            // 
            // btncontinuar
            // 
            btncontinuar.DialogResult = DialogResult.OK;
            btncontinuar.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncontinuar.Location = new Point(404, 399);
            btncontinuar.Name = "btncontinuar";
            btncontinuar.Size = new Size(288, 44);
            btncontinuar.TabIndex = 72;
            btncontinuar.Text = "Continuar";
            btncontinuar.UseVisualStyleBackColor = true;
            // 
            // btnRegresarSS
            // 
            btnRegresarSS.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegresarSS.Location = new Point(111, 399);
            btnRegresarSS.Name = "btnRegresarSS";
            btnRegresarSS.Size = new Size(288, 44);
            btnRegresarSS.TabIndex = 71;
            btnRegresarSS.Text = "Regresar";
            btnRegresarSS.UseVisualStyleBackColor = true;
            btnRegresarSS.Click += btnRegresarSS_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 146);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 74;
            label1.Text = "Nombre del titular:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 50);
            label2.Name = "label2";
            label2.Size = new Size(441, 25);
            label2.TabIndex = 75;
            label2.Text = "_______________________________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(98, 210);
            label6.Name = "label6";
            label6.Size = new Size(186, 21);
            label6.TabIndex = 76;
            label6.Text = "Número de la tarjeta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLight;
            label7.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(238, 273);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 77;
            label7.Text = "CVV:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlLight;
            label8.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(111, 323);
            label8.Name = "label8";
            label8.Size = new Size(190, 42);
            label8.TabIndex = 78;
            label8.Text = "         Fecha de\r\nvencimiento (MM/AA):\r\n";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(223, 225, 255);
            textBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(307, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 26);
            textBox1.TabIndex = 79;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(223, 225, 255);
            textBox2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(307, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 26);
            textBox2.TabIndex = 80;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(223, 225, 255);
            textBox3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(307, 271);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(71, 26);
            textBox3.TabIndex = 81;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(223, 225, 255);
            textBox4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(311, 342);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(67, 26);
            textBox4.TabIndex = 82;
            // 
            // PagoDeEntradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(btncontinuar);
            Controls.Add(btnRegresarSS);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "PagoDeEntradas";
            Text = "PagoDeEntradas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label5;
        private Button btncontinuar;
        private Button btnRegresarSS;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}