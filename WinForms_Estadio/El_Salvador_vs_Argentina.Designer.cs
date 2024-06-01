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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 53);
            label1.Name = "label1";
            label1.Size = new Size(574, 33);
            label1.TabIndex = 2;
            label1.Text = "El Salvador vs Argentina  |  13/6/24  |  18:30";
            label1.Click += label1_Click;
            // 
            // btnverprecios
            // 
            btnverprecios.BackColor = SystemColors.ActiveCaption;
            btnverprecios.FlatStyle = FlatStyle.Flat;
            btnverprecios.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnverprecios.Location = new Point(61, 162);
            btnverprecios.Name = "btnverprecios";
            btnverprecios.Size = new Size(669, 54);
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
            btncomprarentradas.Location = new Point(61, 223);
            btncomprarentradas.Name = "btncomprarentradas";
            btncomprarentradas.Size = new Size(669, 54);
            btncomprarentradas.TabIndex = 4;
            btncomprarentradas.Text = "Comprar Entradas";
            btncomprarentradas.UseVisualStyleBackColor = false;
            // 
            // btnverificarentradas
            // 
            btnverificarentradas.BackColor = SystemColors.ActiveCaption;
            btnverificarentradas.FlatStyle = FlatStyle.Flat;
            btnverificarentradas.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnverificarentradas.Location = new Point(61, 283);
            btnverificarentradas.Name = "btnverificarentradas";
            btnverificarentradas.Size = new Size(669, 54);
            btnverificarentradas.TabIndex = 5;
            btnverificarentradas.Text = "Verificar Entradas";
            btnverificarentradas.UseVisualStyleBackColor = false;
            // 
            // btnregresar
            // 
            btnregresar.BackColor = SystemColors.ActiveCaption;
            btnregresar.FlatStyle = FlatStyle.Flat;
            btnregresar.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnregresar.Location = new Point(61, 343);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(669, 54);
            btnregresar.TabIndex = 6;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // El_Salvador_vs_Argentina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnregresar);
            Controls.Add(btnverificarentradas);
            Controls.Add(btncomprarentradas);
            Controls.Add(btnverprecios);
            Controls.Add(label1);
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
    }
}