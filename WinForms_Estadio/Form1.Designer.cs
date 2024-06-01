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
            btnreservarentradas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 250);
            label1.Name = "label1";
            label1.Size = new Size(195, 31);
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
            // btnreservarentradas
            // 
            btnreservarentradas.BackColor = SystemColors.ActiveCaption;
            btnreservarentradas.FlatStyle = FlatStyle.Flat;
            btnreservarentradas.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnreservarentradas.Location = new Point(67, 367);
            btnreservarentradas.Name = "btnreservarentradas";
            btnreservarentradas.Size = new Size(669, 54);
            btnreservarentradas.TabIndex = 2;
            btnreservarentradas.Text = "Reservar entradas";
            btnreservarentradas.UseVisualStyleBackColor = false;
            btnreservarentradas.Click += btnReservarEntradas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnreservarentradas);
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
        private Button btnreservarentradas;
    }
}
