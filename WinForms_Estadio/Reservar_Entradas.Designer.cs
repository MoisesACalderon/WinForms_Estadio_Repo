namespace WinForms_Estadio
{
    partial class Reservar_Entradas
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
            btnelsalvadorvsargentina = new Button();
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
            label1.Location = new Point(325, 77);
            label1.Name = "label1";
            label1.Size = new Size(142, 31);
            label1.TabIndex = 1;
            label1.Text = "ENTRADAS";
            // 
            // btnelsalvadorvsargentina
            // 
            btnelsalvadorvsargentina.BackColor = SystemColors.ActiveCaption;
            btnelsalvadorvsargentina.FlatStyle = FlatStyle.Flat;
            btnelsalvadorvsargentina.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnelsalvadorvsargentina.Location = new Point(61, 182);
            btnelsalvadorvsargentina.Name = "btnelsalvadorvsargentina";
            btnelsalvadorvsargentina.Size = new Size(669, 54);
            btnelsalvadorvsargentina.TabIndex = 2;
            btnelsalvadorvsargentina.Text = "El Salvador vs Argentina //  13/6/24 | 18:30";
            btnelsalvadorvsargentina.UseVisualStyleBackColor = false;
            btnelsalvadorvsargentina.Click += btnelsalvadorvsargentina_Click;
            // 
            // btnregresar
            // 
            btnregresar.BackColor = SystemColors.ActiveCaption;
            btnregresar.FlatStyle = FlatStyle.Flat;
            btnregresar.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnregresar.Location = new Point(61, 326);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(669, 54);
            btnregresar.TabIndex = 3;
            btnregresar.Text = "Regresar ";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 114);
            label2.Name = "label2";
            label2.Size = new Size(686, 31);
            label2.TabIndex = 46;
            label2.Text = "________________________________________________";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 264);
            label3.Name = "label3";
            label3.Size = new Size(686, 31);
            label3.TabIndex = 47;
            label3.Text = "________________________________________________";
            // 
            // Reservar_Entradas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnregresar);
            Controls.Add(btnelsalvadorvsargentina);
            Controls.Add(label1);
            Name = "Reservar_Entradas";
            Text = "Reservar_Entradas";
            Load += Reservar_Entradas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnelsalvadorvsargentina;
        private Button btnregresar;
        private Label label2;
        private Label label3;
    }
}