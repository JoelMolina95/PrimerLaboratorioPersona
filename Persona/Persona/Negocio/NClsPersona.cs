using Persona.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Negocio
{
    class NClsPersona
    {
        public String Hablar(ClsPersona persona)
        {

            return " La persona de nombre " + persona.Nombre + " Está hablando ";

        }

        public String Caminar(ClsPersona persona)
        {

            return " La persona de nombre " + persona.Nombre + " Está caminando ";
        }

        public String Reir(ClsPersona persona)
        {

            return " La persona de nombre " + persona.Nombre + " Está ríendo ";
        }

        public String Observar(ClsPersona persona)
        {

            return " La persona de nombre " + persona.Nombre + " Está observando ";
        }
    }
}