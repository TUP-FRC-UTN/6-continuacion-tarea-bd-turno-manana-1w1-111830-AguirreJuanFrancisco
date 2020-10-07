using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Prog_DB_2
{
  internal class Persona
  {
    private string nombres, apellido;
    private int tipo_documento, tipo_estado_civil, documento;

    public Persona()
    {
      nombres = apellido = "";
      tipo_documento = tipo_estado_civil = documento = 0;
    }

    public string pNombres
    {
      get { return nombres; }
      set { nombres = value; }
    }

    public string pApellido
    {
      get { return apellido; }
      set { apellido = value; }
    }

    public int pTipo_documento
    {
      get { return tipo_documento; }
      set { tipo_documento = value; }
    }

    public int pTipo_estado_civil
    {
      get { return tipo_estado_civil; }
      set { tipo_estado_civil = value; }
    }

    public int pDocumento
    {
      get { return documento; }
      set { documento = value; }
    }

    public string toStringPersona()
    {
      return "Apellido: " + apellido + "\nNombres: " + nombres + "\nTipo Documento: " + tipo_documento + "\nDocumento: " + documento + "\nTipo Estado Civil: " + tipo_estado_civil;
    }
  }
}