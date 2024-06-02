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
            btnpreferentenorte = new Button();
            btnpreferentesur = new Button();
            btntribunasur = new Button();
            btntribunanorte = new Button();
            btnsombrasur = new Button();
            btnsombranorte = new Button();
            btnplateas = new Button();
            btnsolgeneral = new Button();
            btnregresar = new Button();
            labelfiguralinea = new Label();
            label1 = new Label();
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
            TituloSeleccion.Click += TituloSeleccion_Click;
            // 
            // btnpreferentenorte
            // 
            btnpreferentenorte.DialogResult = DialogResult.OK;
            btnpreferentenorte.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpreferentenorte.Location = new Point(97, 201);
            btnpreferentenorte.Name = "btnpreferentenorte";
            btnpreferentenorte.Size = new Size(288, 44);
            btnpreferentenorte.TabIndex = 35;
            btnpreferentenorte.Text = "Preferente Norte";
            btnpreferentenorte.UseVisualStyleBackColor = true;
            btnpreferentenorte.Click += btncontinuar_Click;
            // 
            // btnpreferentesur
            // 
            btnpreferentesur.DialogResult = DialogResult.OK;
            btnpreferentesur.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpreferentesur.Location = new Point(390, 201);
            btnpreferentesur.Name = "btnpreferentesur";
            btnpreferentesur.Size = new Size(288, 44);
            btnpreferentesur.TabIndex = 36;
            btnpreferentesur.Text = "Preferente sur";
            btnpreferentesur.UseVisualStyleBackColor = true;
            btnpreferentesur.Click += btnpreferentesur_Click;
            // 
            // btntribunasur
            // 
            btntribunasur.DialogResult = DialogResult.OK;
            btntribunasur.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btntribunasur.Location = new Point(97, 151);
            btntribunasur.Name = "btntribunasur";
            btntribunasur.Size = new Size(288, 44);
            btntribunasur.TabIndex = 37;
            btntribunasur.Text = "Tribuna Sur";
            btntribunasur.UseVisualStyleBackColor = true;
            btntribunasur.Click += btntribunasur_Click_1;
            // 
            // btntribunanorte
            // 
            btntribunanorte.DialogResult = DialogResult.OK;
            btntribunanorte.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btntribunanorte.Location = new Point(390, 151);
            btntribunanorte.Name = "btntribunanorte";
            btntribunanorte.Size = new Size(288, 44);
            btntribunanorte.TabIndex = 38;
            btntribunanorte.Text = "Tribuna Norte";
            btntribunanorte.UseVisualStyleBackColor = true;
            btntribunanorte.Click += btntribunanorte_Click;
            // 
            // btnsombrasur
            // 
            btnsombrasur.DialogResult = DialogResult.OK;
            btnsombrasur.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsombrasur.Location = new Point(97, 100);
            btnsombrasur.Name = "btnsombrasur";
            btnsombrasur.Size = new Size(288, 44);
            btnsombrasur.TabIndex = 39;
            btnsombrasur.Text = "Sombra Sur";
            btnsombrasur.UseVisualStyleBackColor = true;
            btnsombrasur.Click += btnsombrasur_Click;
            // 
            // btnsombranorte
            // 
            btnsombranorte.DialogResult = DialogResult.OK;
            btnsombranorte.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsombranorte.Location = new Point(390, 100);
            btnsombranorte.Name = "btnsombranorte";
            btnsombranorte.Size = new Size(288, 44);
            btnsombranorte.TabIndex = 40;
            btnsombranorte.Text = "Sombra Norte";
            btnsombranorte.UseVisualStyleBackColor = true;
            btnsombranorte.Click += btnsombranorte_Click;
            // 
            // btnplateas
            // 
            btnplateas.DialogResult = DialogResult.OK;
            btnplateas.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnplateas.Location = new Point(390, 251);
            btnplateas.Name = "btnplateas";
            btnplateas.Size = new Size(288, 44);
            btnplateas.TabIndex = 42;
            btnplateas.Text = "Platea";
            btnplateas.UseVisualStyleBackColor = true;
            btnplateas.Click += btnplateas_Click;
            // 
            // btnsolgeneral
            // 
            btnsolgeneral.DialogResult = DialogResult.OK;
            btnsolgeneral.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsolgeneral.Location = new Point(97, 251);
            btnsolgeneral.Name = "btnsolgeneral";
            btnsolgeneral.Size = new Size(288, 44);
            btnsolgeneral.TabIndex = 41;
            btnsolgeneral.Text = "Sol General";
            btnsolgeneral.UseVisualStyleBackColor = true;
            btnsolgeneral.Click += button7_Click;
            // 
            // btnregresar
            // 
            btnregresar.BackColor = SystemColors.ActiveCaption;
            btnregresar.FlatStyle = FlatStyle.Flat;
            btnregresar.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnregresar.Location = new Point(96, 333);
            btnregresar.Margin = new Padding(3, 2, 3, 2);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(585, 40);
            btnregresar.TabIndex = 43;
            btnregresar.Text = "Regresar ";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // labelfiguralinea
            // 
            labelfiguralinea.AutoSize = true;
            labelfiguralinea.BackColor = Color.Transparent;
            labelfiguralinea.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelfiguralinea.Location = new Point(90, 298);
            labelfiguralinea.Name = "labelfiguralinea";
            labelfiguralinea.Size = new Size(540, 25);
            labelfiguralinea.TabIndex = 44;
            labelfiguralinea.Text = "________________________________________________";
            labelfiguralinea.Click += labelfiguralinea_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 62);
            label1.Name = "label1";
            label1.Size = new Size(540, 25);
            label1.TabIndex = 45;
            label1.Text = "________________________________________________";
            // 
            // menuZonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(labelfiguralinea);
            Controls.Add(btnregresar);
            Controls.Add(btnplateas);
            Controls.Add(btnsolgeneral);
            Controls.Add(btnsombranorte);
            Controls.Add(btnsombrasur);
            Controls.Add(btntribunanorte);
            Controls.Add(btntribunasur);
            Controls.Add(btnpreferentesur);
            Controls.Add(btnpreferentenorte);
            Controls.Add(TituloSeleccion);
            Name = "menuZonas";
            Text = "menuZonas";
            Load += menuZonas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TituloSeleccion;
        private Button btnpreferentenorte;
        private Button btnpreferentesur;
        private Button btntribunasur;
        private Button btntribunanorte;
        private Button btnsombrasur;
        private Button btnsombranorte;
        private Button btnplateas;
        private Button btnsolgeneral;
        private Button btnregresar;
        private Label labelfiguralinea;
        private Label label1;
    }
}