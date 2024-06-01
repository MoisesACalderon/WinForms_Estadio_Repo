namespace WinForms_Estadio
{
    partial class menuZonas
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
            TituloSeleccion = new Label();
            btnTribunaSur = new Button();
            btnRegresarZ = new Button();
            SuspendLayout();
            // 
            // TituloSeleccion
            // 
            TituloSeleccion.AutoSize = true;
            TituloSeleccion.BackColor = Color.Transparent;
            TituloSeleccion.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TituloSeleccion.Location = new Point(230, 38);
            TituloSeleccion.Name = "TituloSeleccion";
            TituloSeleccion.Size = new Size(308, 25);
            TituloSeleccion.TabIndex = 3;
            TituloSeleccion.Text = "Elija la zona de su preferencia";
            // 
            // btnTribunaSur
            // 
            btnTribunaSur.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTribunaSur.Location = new Point(116, 134);
            btnTribunaSur.Name = "btnTribunaSur";
            btnTribunaSur.Size = new Size(90, 54);
            btnTribunaSur.TabIndex = 4;
            btnTribunaSur.Text = "Tribuna sur";
            btnTribunaSur.UseVisualStyleBackColor = true;
            btnTribunaSur.Click += btnTribunaSur_Click;
            // 
            // btnRegresarZ
            // 
            btnRegresarZ.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegresarZ.Location = new Point(322, 395);
            btnRegresarZ.Name = "btnRegresarZ";
            btnRegresarZ.Size = new Size(146, 43);
            btnRegresarZ.TabIndex = 5;
            btnRegresarZ.Text = "Regresar";
            btnRegresarZ.UseVisualStyleBackColor = true;
            btnRegresarZ.Click += btnRegresarZ_Click;
            // 
            // menuZonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresarZ);
            Controls.Add(btnTribunaSur);
            Controls.Add(TituloSeleccion);
            Name = "menuZonas";
            Text = "menuZonas";
            Load += menuZonas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TituloSeleccion;
        private Button btnTribunaSur;
        private Button btnRegresarZ;
    }
}