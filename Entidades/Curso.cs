using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        public string  AnioDivision
        {
            get{ return anio.ToString(); }
        }
        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }
        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static bool operator ==(Curso c, Alumno a)
        {
           string anioDivisionCurso = c.anio.ToString() + c.division.ToString();
           return anioDivisionCurso.Equals(a.AnioDivision);
        }
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }
        public static Curso operator +(Curso c, Alumno a)
        {
            if(c==a)
            {
                c.alumnos.Add(a);
            }
            return c;
        }
        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Anio division :" + c.AnioDivision);
            sb.AppendLine("Profesor :" + c.profesor.ExponerDatos());
            sb.AppendLine("Division :" + c.division.ToString());
            foreach (Alumno alu in c.alumnos)
            {
                sb.AppendLine(alu.ExponerDatos());
            }
            return sb.ToString();
        }

    }
}
