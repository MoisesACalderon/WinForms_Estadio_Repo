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
            TituloSeleccion.Location = new Point(263, 51);
            TituloSeleccion.Name = "TituloSeleccion";
            TituloSeleccion.Size = new Size(390, 31);
            TituloSeleccion.TabIndex = 3;
            TituloSeleccion.Text = "Elija la zona de su preferencia";
            TituloSeleccion.Click += TituloSeleccion_Click;
            // 
            // btnpreferentenorte
            // 
            btnpreferentenorte.DialogResult = DialogResult.OK;
            btnpreferentenorte.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpreferentenorte.Location = new Point(111, 268);
            btnpreferentenorte.Margin = new Padding(3, 4, 3, 4);
            btnpreferentenorte.Name = "btnpreferentenorte";
            btnpreferentenorte.Size = new Size(329, 59);
            btnpreferentenorte.TabIndex = 35;
            btnpreferentenorte.Text = "Preferente Norte";
            btnpreferentenorte.UseVisualStyleBackColor = true;
            btnpreferentenorte.Click += btncontinuar_Click;
            // 
            // btnpreferentesur
            // 
            btnpreferentesur.DialogResult = DialogResult.OK;
            btnpreferentesur.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpreferentesur.Location = new Point(446, 268);
            btnpreferentesur.Margin = new Padding(3, 4, 3, 4);
            btnpreferentesur.Name = "btnpreferentesur";
            btnpreferentesur.Size = new Size(329, 59);
            btnpreferentesur.TabIndex = 36;
            btnpreferentesur.Text = "Preferente sur";
            btnpreferentesur.UseVisualStyleBackColor = true;
            // 
            // btntribunasur
            // 
            btntribunasur.DialogResult = DialogResult.OK;
            btntribunasur.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btntribunasur.Location = new Point(111, 201);
            btntribunasur.Margin = new Padding(3, 4, 3, 4);
            btntribunasur.Name = "btntribunasur";
            btntribunasur.Size = new Size(329, 59);
            btntribunasur.TabIndex = 37;
            btntribunasur.Text = "Tribuna Sur";
            btntribunasur.UseVisualStyleBackColor = true;
            btntribunasur.Click += btntribunasur_Click_1;
            // 
            // btntribunanorte
            // 
            btntribunanorte.DialogResult = DialogResult.OK;
            btntribunanorte.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btntribunanorte.Location = new Point(446, 201);
            btntribunanorte.Margin = new Padding(3, 4, 3, 4);
            btntribunanorte.Name = "btntribunanorte";
            btntribunanorte.Size = new Size(329, 59);
            btntribunanorte.TabIndex = 38;
            btntribunanorte.Text = "Tribuna Norte";
            btntribunanorte.UseVisualStyleBackColor = true;
            // 
            // btnsombrasur
            // 
            btnsombrasur.DialogResult = DialogResult.OK;
            btnsombrasur.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsombrasur.Location = new Point(111, 134);
            btnsombrasur.Margin = new Padding(3, 4, 3, 4);
            btnsombrasur.Name = "btnsombrasur";
            btnsombrasur.Size = new Size(329, 59);
            btnsombrasur.TabIndex = 39;
            btnsombrasur.Text = "Sombra Sur";
            btnsombrasur.UseVisualStyleBackColor = true;
            // 
            // btnsombranorte
            // 
            btnsombranorte.DialogResult = DialogResult.OK;
            btnsombranorte.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsombranorte.Location = new Point(446, 134);
            btnsombranorte.Margin = new Padding(3, 4, 3, 4);
            btnsombranorte.Name = "btnsombranorte";
            btnsombranorte.Size = new Size(329, 59);
            btnsombranorte.TabIndex = 40;
            btnsombranorte.Text = "Sombra Norte";
            btnsombranorte.UseVisualStyleBackColor = true;
            // 
            // btnplateas
            // 
            btnplateas.DialogResult = DialogResult.OK;
            btnplateas.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnplateas.Location = new Point(446, 335);
            btnplateas.Margin = new Padding(3, 4, 3, 4);
            btnplateas.Name = "btnplateas";
            btnplateas.Size = new Size(329, 59);
            btnplateas.TabIndex = 42;
            btnplateas.Text = "Platea";
            btnplateas.UseVisualStyleBackColor = true;
            // 
            // btnsolgeneral
            // 
            btnsolgeneral.DialogResult = DialogResult.OK;
            btnsolgeneral.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsolgeneral.Location = new Point(111, 335);
            btnsolgeneral.Margin = new Padding(3, 4, 3, 4);
            btnsolgeneral.Name = "btnsolgeneral";
            btnsolgeneral.Size = new Size(329, 59);
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
            btnregresar.Location = new Point(110, 444);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(669, 54);
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
            labelfiguralinea.Location = new Point(103, 398);
            labelfiguralinea.Name = "labelfiguralinea";
            labelfiguralinea.Size = new Size(686, 31);
            labelfiguralinea.TabIndex = 44;
            labelfiguralinea.Text = "________________________________________________";
            labelfiguralinea.Click += labelfiguralinea_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 82);
            label1.Name = "label1";
            label1.Size = new Size(686, 31);
            label1.TabIndex = 45;
            label1.Text = "________________________________________________";
            // 
            // menuZonas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
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