namespace WinForms_Estadio
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
            label1 = new Label();
            btnproximospartidos = new Button();
            btnReservarEntradas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 263);
            label1.Name = "label1";
            label1.Size = new Size(197, 33);
            label1.TabIndex = 0;
            label1.Text = "¿QUE BUSCAS?";
            label1.Click += label1_Click;
            // 
            // btnproximospartidos
            // 
            btnproximospartidos.BackColor = SystemColors.ActiveCaption;
            btnproximospartidos.FlatStyle = FlatStyle.Flat;
            btnproximospartidos.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnproximospartidos.Location = new Point(67, 307);
            btnproximospartidos.Name = "btnproximospartidos";
            btnproximospartidos.Size = new Size(669, 54);
            btnproximospartidos.TabIndex = 1;
            btnproximospartidos.Text = "Próximos partidos";
            btnproximospartidos.UseVisualStyleBackColor = false;
            btnproximospartidos.Click += btnproximospartidos_Click;
            // 
            // btnReservarEntradas
            // 
            btnReservarEntradas.BackColor = SystemColors.ActiveCaption;
            btnReservarEntradas.FlatStyle = FlatStyle.Flat;
            btnReservarEntradas.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservarEntradas.Location = new Point(67, 367);
            btnReservarEntradas.Name = "btnReservarEntradas";
            btnReservarEntradas.Size = new Size(669, 54);
            btnReservarEntradas.TabIndex = 2;
            btnReservarEntradas.Text = "Reservar entradas";
            btnReservarEntradas.UseVisualStyleBackColor = false;
            btnReservarEntradas.Click += btnReservarEntradas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReservarEntradas);
            Controls.Add(btnproximospartidos);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnproximospartidos;
        private Button btnReservarEntradas;
    }
}
