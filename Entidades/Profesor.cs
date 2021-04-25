﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public Profesor(string nombre, string apellido, string documento) : base(nombre, apellido, documento)
        {

        }
        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso): this(nombre,apellido,documento)
        {
            this.fechaIngreso = fechaIngreso;
        }
        
        public int Antiguedad
        {
            get {  return (this.fechaIngreso - DateTime.Now).Days;  }
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            return (doc.Length == 8);
        }
    }
}
