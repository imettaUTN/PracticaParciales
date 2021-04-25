using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;

        public string Apellido
        {
            get { return this.apellido; }
        }
        public string Documento
        {
            get { return this.documento; }
            set {
                if (ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }

        public Persona(string nombre, string apellido, string documento)
        {           
            this.Documento = documento;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);
            sb.AppendLine("Documento: " + this.Documento);
            return sb.ToString();
        }
        protected abstract bool ValidarDocumentacion(string doc);
    }
}
