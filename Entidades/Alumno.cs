using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones divisiones;

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division) : base(nombre,apellido,documento)
        {
            this.anio = anio;
            this.divisiones = division;
            }
        public string AnioDivision
        {
            get { return anio.ToString() + this.divisiones.ToString();}
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            string[] documentoSplit = doc.Split('-');
            if(documentoSplit.Length != 3)
            {
                return false;
            }
            return ((documentoSplit[0].Length == 2) && (documentoSplit[1].Length == 4) && (documentoSplit[2].Length == 1));
        }
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine("Anio :" + this.anio.ToString());
            sb.AppendLine("Division :" + this.divisiones.ToString());
            return sb.ToString();
        }
    }
}
