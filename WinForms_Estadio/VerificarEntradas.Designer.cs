namespace WinForms_Estadio
{
    partial class VerificarEntradas
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
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            btncontinuar = new Button();
            btnRegresarSS = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 64);
            label2.Name = "label2";
            label2.Size = new Size(686, 31);
            label2.TabIndex = 48;
            label2.Text = "________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 32);
            label1.Name = "label1";
            label1.Size = new Size(304, 31);
            label1.TabIndex = 47;
            label1.Text = "Verificación de Entrada";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(95, 106);
            label4.Name = "label4";
            label4.Size = new Size(598, 19);
            label4.TabIndex = 85;
            label4.Text = "INGRESE EL CÓDIGO DE VERIFICACIÓN PROPORCIONADO AL REALIZAR SU PAGO";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 323);
            label3.Name = "label3";
            label3.Size = new Size(686, 31);
            label3.TabIndex = 87;
            label3.Text = "________________________________________________";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(167, 211);
            label8.Name = "label8";
            label8.Size = new Size(197, 54);
            label8.TabIndex = 93;
            label8.Text = "Ingrese el Código\r\n  de verificación:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(223, 225, 255);
            textBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(390, 225);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 30);
            textBox1.TabIndex = 94;
            // 
            // btncontinuar
            // 
            btncontinuar.DialogResult = DialogResult.OK;
            btncontinuar.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncontinuar.Location = new Point(403, 378);
            btncontinuar.Margin = new Padding(3, 4, 3, 4);
            btncontinuar.Name = "btncontinuar";
            btncontinuar.Size = new Size(329, 59);
            btncontinuar.TabIndex = 96;
            btncontinuar.Text = "Validar";
            btncontinuar.UseVisualStyleBackColor = true;
            btncontinuar.Click += btncontinuar_Click;
            // 
            // btnRegresarSS
            // 
            btnRegresarSS.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegresarSS.Location = new Point(68, 378);
            btnRegresarSS.Margin = new Padding(3, 4, 3, 4);
            btnRegresarSS.Name = "btnRegresarSS";
            btnRegresarSS.Size = new Size(329, 59);
            btnRegresarSS.TabIndex = 95;
            btnRegresarSS.Text = "Regresar";
            btnRegresarSS.UseVisualStyleBackColor = true;
            btnRegresarSS.Click += btnRegresarSS_Click;
            // 
            // VerificarEntradas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btncontinuar);
            Controls.Add(btnRegresarSS);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VerificarEntradas";
            Text = "VerificarEntradas";
            Load += VerificarEntradas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label8;
        private TextBox textBox1;
        private Button btncontinuar;
        private Button btnRegresarSS;
    }
}