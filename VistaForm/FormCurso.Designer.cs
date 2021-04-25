namespace VistaForm
{
    partial class FormCurso
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
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.gpbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDivisionAlumno = new System.Windows.Forms.ComboBox();
            this.lblAñoAlumno = new System.Windows.Forms.Label();
            this.nudAlumno = new System.Windows.Forms.NumericUpDown();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.tbLegajo = new System.Windows.Forms.TextBox();
            this.lblApellidoAlumno = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.tbNombreAlumo = new System.Windows.Forms.TextBox();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.gpbDatosCurso = new System.Windows.Forms.GroupBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.nudAñoCurso = new System.Windows.Forms.NumericUpDown();
            this.txtDocumentoAlumno = new System.Windows.Forms.TextBox();
            this.tbApellidoCurso = new System.Windows.Forms.TextBox();
            this.tbNombreCurso = new System.Windows.Forms.TextBox();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gpbDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlumno)).BeginInit();
            this.gpbDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñoCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(1, 261);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(797, 146);
            this.rtbDatos.TabIndex = 0;
            this.rtbDatos.Text = "";
            // 
            // gpbDatosAlumno
            // 
            this.gpbDatosAlumno.Controls.Add(this.lblDni);
            this.gpbDatosAlumno.Controls.Add(this.btnAgregar);
            this.gpbDatosAlumno.Controls.Add(this.label1);
            this.gpbDatosAlumno.Controls.Add(this.cmbDivisionAlumno);
            this.gpbDatosAlumno.Controls.Add(this.lblAñoAlumno);
            this.gpbDatosAlumno.Controls.Add(this.nudAlumno);
            this.gpbDatosAlumno.Controls.Add(this.lblLegajo);
            this.gpbDatosAlumno.Controls.Add(this.tbLegajo);
            this.gpbDatosAlumno.Controls.Add(this.lblApellidoAlumno);
            this.gpbDatosAlumno.Controls.Add(this.lblNombreAlumno);
            this.gpbDatosAlumno.Controls.Add(this.txtDocumentoAlumno);
            this.gpbDatosAlumno.Controls.Add(this.tbNombreAlumo);
            this.gpbDatosAlumno.Controls.Add(this.txtApellidoAlumno);
            this.gpbDatosAlumno.Location = new System.Drawing.Point(406, 13);
            this.gpbDatosAlumno.Name = "gpbDatosAlumno";
            this.gpbDatosAlumno.Size = new System.Drawing.Size(392, 242);
            this.gpbDatosAlumno.TabIndex = 2;
            this.gpbDatosAlumno.TabStop = false;
            this.gpbDatosAlumno.Text = "Datos Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Division";
            // 
            // cmbDivisionAlumno
            // 
            this.cmbDivisionAlumno.FormattingEnabled = true;
            this.cmbDivisionAlumno.Location = new System.Drawing.Point(93, 167);
            this.cmbDivisionAlumno.Name = "cmbDivisionAlumno";
            this.cmbDivisionAlumno.Size = new System.Drawing.Size(160, 21);
            this.cmbDivisionAlumno.TabIndex = 14;
            // 
            // lblAñoAlumno
            // 
            this.lblAñoAlumno.AutoSize = true;
            this.lblAñoAlumno.Location = new System.Drawing.Point(6, 138);
            this.lblAñoAlumno.Name = "lblAñoAlumno";
            this.lblAñoAlumno.Size = new System.Drawing.Size(26, 13);
            this.lblAñoAlumno.TabIndex = 15;
            this.lblAñoAlumno.Text = "Año";
            // 
            // nudAlumno
            // 
            this.nudAlumno.Location = new System.Drawing.Point(93, 138);
            this.nudAlumno.Name = "nudAlumno";
            this.nudAlumno.Size = new System.Drawing.Size(160, 20);
            this.nudAlumno.TabIndex = 14;
            this.nudAlumno.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(6, 89);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 19;
            this.lblLegajo.Text = "Legajo";
            // 
            // tbLegajo
            // 
            this.tbLegajo.Location = new System.Drawing.Point(93, 86);
            this.tbLegajo.Name = "tbLegajo";
            this.tbLegajo.Size = new System.Drawing.Size(275, 20);
            this.tbLegajo.TabIndex = 18;
            // 
            // lblApellidoAlumno
            // 
            this.lblApellidoAlumno.AutoSize = true;
            this.lblApellidoAlumno.Location = new System.Drawing.Point(6, 61);
            this.lblApellidoAlumno.Name = "lblApellidoAlumno";
            this.lblApellidoAlumno.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoAlumno.TabIndex = 17;
            this.lblApellidoAlumno.Text = "Apellido";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(6, 32);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(44, 13);
            this.lblNombreAlumno.TabIndex = 16;
            this.lblNombreAlumno.Text = "Nombre";
            // 
            // tbNombreAlumo
            // 
            this.tbNombreAlumo.Location = new System.Drawing.Point(93, 29);
            this.tbNombreAlumo.Name = "tbNombreAlumo";
            this.tbNombreAlumo.Size = new System.Drawing.Size(275, 20);
            this.tbNombreAlumo.TabIndex = 14;
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(93, 58);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(275, 20);
            this.txtApellidoAlumno.TabIndex = 15;
            // 
            // gpbDatosCurso
            // 
            this.gpbDatosCurso.Controls.Add(this.lblIngreso);
            this.gpbDatosCurso.Controls.Add(this.lblApellido);
            this.gpbDatosCurso.Controls.Add(this.lblNombre);
            this.gpbDatosCurso.Controls.Add(this.lblDivision);
            this.gpbDatosCurso.Controls.Add(this.lblAño);
            this.gpbDatosCurso.Controls.Add(this.btnMostrar);
            this.gpbDatosCurso.Controls.Add(this.btnCrearCurso);
            this.gpbDatosCurso.Controls.Add(this.nudAñoCurso);
            this.gpbDatosCurso.Controls.Add(this.tbApellidoCurso);
            this.gpbDatosCurso.Controls.Add(this.tbNombreCurso);
            this.gpbDatosCurso.Controls.Add(this.dtpIngreso);
            this.gpbDatosCurso.Controls.Add(this.cmbDivisionCurso);
            this.gpbDatosCurso.Location = new System.Drawing.Point(12, 13);
            this.gpbDatosCurso.Name = "gpbDatosCurso";
            this.gpbDatosCurso.Size = new System.Drawing.Size(388, 242);
            this.gpbDatosCurso.TabIndex = 3;
            this.gpbDatosCurso.TabStop = false;
            this.gpbDatosCurso.Text = "DatosCurso";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(6, 115);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 13;
            this.lblDni.Text = "Dni";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(6, 146);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblIngreso.TabIndex = 12;
            this.lblIngreso.Text = "Ingreso";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 115);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 89);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(6, 58);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 9;
            this.lblDivision.Text = "Division";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(6, 32);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 8;
            this.lblAño.Text = "Año";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(249, 193);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(121, 43);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Location = new System.Drawing.Point(6, 193);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(121, 43);
            this.btnCrearCurso.TabIndex = 6;
            this.btnCrearCurso.Text = "Crear Curso";
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.btCrearCurso_Click);
            // 
            // nudAñoCurso
            // 
            this.nudAñoCurso.Location = new System.Drawing.Point(93, 32);
            this.nudAñoCurso.Name = "nudAñoCurso";
            this.nudAñoCurso.Size = new System.Drawing.Size(160, 20);
            this.nudAñoCurso.TabIndex = 5;
            this.nudAñoCurso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDocumentoAlumno
            // 
            this.txtDocumentoAlumno.Location = new System.Drawing.Point(93, 112);
            this.txtDocumentoAlumno.Name = "txtDocumentoAlumno";
            this.txtDocumentoAlumno.Size = new System.Drawing.Size(275, 20);
            this.txtDocumentoAlumno.TabIndex = 4;
            // 
            // tbApellidoCurso
            // 
            this.tbApellidoCurso.Location = new System.Drawing.Point(93, 112);
            this.tbApellidoCurso.Name = "tbApellidoCurso";
            this.tbApellidoCurso.Size = new System.Drawing.Size(275, 20);
            this.tbApellidoCurso.TabIndex = 3;
            // 
            // tbNombreCurso
            // 
            this.tbNombreCurso.Location = new System.Drawing.Point(93, 86);
            this.tbNombreCurso.Name = "tbNombreCurso";
            this.tbNombreCurso.Size = new System.Drawing.Size(275, 20);
            this.tbNombreCurso.TabIndex = 2;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Location = new System.Drawing.Point(93, 140);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(275, 20);
            this.dtpIngreso.TabIndex = 1;
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(93, 58);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(160, 21);
            this.cmbDivisionCurso.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(247, 193);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 43);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // FormCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbDatosCurso);
            this.Controls.Add(this.gpbDatosAlumno);
            this.Controls.Add(this.rtbDatos);
            this.Name = "FormCurso";
            this.Text = "FormCurso";
            this.Load += new System.EventHandler(this.FormCurso_Load);
            this.gpbDatosAlumno.ResumeLayout(false);
            this.gpbDatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlumno)).EndInit();
            this.gpbDatosCurso.ResumeLayout(false);
            this.gpbDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñoCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDatos;
        private System.Windows.Forms.GroupBox gpbDatosAlumno;
        private System.Windows.Forms.GroupBox gpbDatosCurso;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.NumericUpDown nudAñoCurso;
        private System.Windows.Forms.TextBox txtDocumentoAlumno;
        private System.Windows.Forms.TextBox tbApellidoCurso;
        private System.Windows.Forms.TextBox tbNombreCurso;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.ComboBox cmbDivisionCurso;
        private System.Windows.Forms.Label lblApellidoAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.TextBox tbNombreAlumo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDivisionAlumno;
        private System.Windows.Forms.Label lblAñoAlumno;
        private System.Windows.Forms.NumericUpDown nudAlumno;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox tbLegajo;
        private System.Windows.Forms.Button btnAgregar;
    }
}