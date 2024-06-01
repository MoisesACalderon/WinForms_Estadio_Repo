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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 61);
            label1.Name = "label1";
            label1.Size = new Size(144, 33);
            label1.TabIndex = 1;
            label1.Text = "ENTRADAS";
            // 
            // btnelsalvadorvsargentina
            // 
            btnelsalvadorvsargentina.BackColor = SystemColors.ActiveCaption;
            btnelsalvadorvsargentina.FlatStyle = FlatStyle.Flat;
            btnelsalvadorvsargentina.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnelsalvadorvsargentina.Location = new Point(61, 197);
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
            btnregresar.Location = new Point(61, 258);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(669, 54);
            btnregresar.TabIndex = 3;
            btnregresar.Text = "Regresar ";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // Reservar_Entradas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}