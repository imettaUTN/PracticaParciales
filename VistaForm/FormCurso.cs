using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace VistaForm
{
    public partial class FormCurso : Form
    {
        private Curso cur;
        public FormCurso()
        {
            InitializeComponent();
        }

        private void btCrearCurso_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            Profesor p = new Profesor(this.tbNombreAlumo.Text, this.txtApellidoAlumno.Text, this.txtDocumentoAlumno.Text, dtpIngreso.Value.Date);
            cur= new Curso( Convert.ToInt16(this.nudAñoCurso.Value), division, p);
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            if (cur is null)
            {
                MessageBox.Show("No existe curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rtbDatos.Text = (string)cur;
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (cur is null)
            {
                MessageBox.Show("No existe curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Divisiones division;
                Enum.TryParse<Divisiones>(cmbDivisionAlumno.SelectedValue.ToString(), out division);
                cur += new Alumno(this.tbNombreAlumo.Text, this.txtApellidoAlumno.Text, this.txtDocumentoAlumno.Text, Convert.ToInt16(this.nudAlumno.Value), division);
            }
        }

        private void FormCurso_Load(object sender, EventArgs e)
        {
            cmbDivisionAlumno.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
        }
    }
}
