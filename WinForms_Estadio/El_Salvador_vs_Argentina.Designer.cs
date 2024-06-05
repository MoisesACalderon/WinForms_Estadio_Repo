namespace WinForms_Estadio
{
    partial class El_Salvador_vs_Argentina
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
            label1 = new Label();
            btnverprecios = new Button();
            btncomprarentradas = new Button();
            btnverificarentradas = new Button();
            btnregresar = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 38);
            label1.Name = "label1";
            label1.Size = new Size(454, 25);
            label1.TabIndex = 2;
            label1.Text = "El Salvador vs Argentina  |  13/6/24  |  18:30";
            // 
            // btnverprecios
            // 
            btnverprecios.BackColor = SystemColors.ActiveCaption;
            btnverprecios.FlatStyle = FlatStyle.Flat;
            btnverprecios.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnverprecios.Location = new Point(53, 111);
            btnverprecios.Margin = new Padding(3, 2, 3, 2);
            btnverprecios.Name = "btnverprecios";
            btnverprecios.Size = new Size(585, 40);
            btnverprecios.TabIndex = 3;
            btnverprecios.Text = "Ver precios";
            btnverprecios.UseVisualStyleBackColor = false;
            btnverprecios.Click += btnverprecios_Click;
            // 
            // btncomprarentradas
            // 
            btncomprarentradas.BackColor = SystemColors.ActiveCaption;
            btncomprarentradas.FlatStyle = FlatStyle.Flat;
            btncomprarentradas.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncomprarentradas.Location = new Point(53, 157);
            btncomprarentradas.Margin = new Padding(3, 2, 3, 2);
            btncomprarentradas.Name = "btncomprarentradas";
            btncomprarentradas.Size = new Size(585, 40);
            btncomprarentradas.TabIndex = 4;
            btncomprarentradas.Text = "Comprar Entradas";
            btncomprarentradas.UseVisualStyleBackColor = false;
            btncomprarentradas.Click += btncomprarentradas_Click;
            // 
            // btnverificarentradas
            // 
            btnverificarentradas.BackColor = SystemColors.ActiveCaption;
            btnverificarentradas.FlatStyle = FlatStyle.Flat;
            btnverificarentradas.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnverificarentradas.Location = new Point(53, 202);
            btnverificarentradas.Margin = new Padding(3, 2, 3, 2);
            btnverificarentradas.Name = "btnverificarentradas";
            btnverificarentradas.Size = new Size(585, 40);
            btnverificarentradas.TabIndex = 5;
            btnverificarentradas.Text = "Verificar Entradas";
            btnverificarentradas.UseVisualStyleBackColor = false;
            btnverificarentradas.Click += btnverificarentradas_Click;
            // 
            // btnregresar
            // 
            btnregresar.BackColor = SystemColors.ActiveCaption;
            btnregresar.FlatStyle = FlatStyle.Flat;
            btnregresar.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnregresar.Location = new Point(53, 280);
            btnregresar.Margin = new Padding(3, 2, 3, 2);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(585, 40);
            btnregresar.TabIndex = 6;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 62);
            label2.Name = "label2";
            label2.Size = new Size(540, 25);
            label2.TabIndex = 46;
            label2.Text = "________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 253);
            label3.Name = "label3";
            label3.Size = new Size(540, 25);
            label3.TabIndex = 47;
            label3.Text = "________________________________________________";
            // 
            // El_Salvador_vs_Argentina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnregresar);
            Controls.Add(btnverificarentradas);
            Controls.Add(btncomprarentradas);
            Controls.Add(btnverprecios);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "El_Salvador_vs_Argentina";
            Text = "El_Salvador_vs_Argentina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnverprecios;
        private Button btncomprarentradas;
        private Button btnverificarentradas;
        private Button btnregresar;
        private Label label2;
        private Label label3;
    }
}