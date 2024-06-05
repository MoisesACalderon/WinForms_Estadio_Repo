namespace WinForms_Estadio
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            label1 = new Label();
            btnproximospartidos = new Button();
            btnreservarentradas = new Button();
            label2 = new Label();
            FotoEstadio = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)FotoEstadio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 241);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "¿QUE BUSCAS?";
            label1.Click += label1_Click;
            // 
            // btnproximospartidos
            // 
            btnproximospartidos.BackColor = SystemColors.ActiveCaption;
            btnproximospartidos.FlatStyle = FlatStyle.Flat;
            btnproximospartidos.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnproximospartidos.Location = new Point(49, 304);
            btnproximospartidos.Margin = new Padding(3, 2, 3, 2);
            btnproximospartidos.Name = "btnproximospartidos";
            btnproximospartidos.Size = new Size(585, 40);
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
            btnreservarentradas.Location = new Point(49, 360);
            btnreservarentradas.Margin = new Padding(3, 2, 3, 2);
            btnreservarentradas.Name = "btnreservarentradas";
            btnreservarentradas.Size = new Size(585, 40);
            btnreservarentradas.TabIndex = 2;
            btnreservarentradas.Text = "Reservar entradas";
            btnreservarentradas.UseVisualStyleBackColor = false;
            btnreservarentradas.Click += btnReservarEntradas_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 266);
            label2.Name = "label2";
            label2.Size = new Size(540, 25);
            label2.TabIndex = 47;
            label2.Text = "________________________________________________";
            // 
            // FotoEstadio
            // 
            FotoEstadio.Image = (Image)resources.GetObject("FotoEstadio.Image");
            FotoEstadio.Location = new Point(150, 9);
            FotoEstadio.Name = "FotoEstadio";
            FotoEstadio.Size = new Size(415, 229);
            FotoEstadio.TabIndex = 48;
            FotoEstadio.TabStop = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 411);
            Controls.Add(FotoEstadio);
            Controls.Add(label2);
            Controls.Add(btnreservarentradas);
            Controls.Add(btnproximospartidos);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)FotoEstadio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnproximospartidos;
        private Button btnreservarentradas;
        private Label label2;
        private PictureBox FotoEstadio;
    }
}
