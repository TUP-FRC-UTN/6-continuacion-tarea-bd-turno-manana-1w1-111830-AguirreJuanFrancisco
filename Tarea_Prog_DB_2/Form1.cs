using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tarea_Prog_DB_2
{
  public partial class Form1 : Form
  {
    private OleDbConnection conexion = new OleDbConnection();
    private OleDbCommand comando = new OleDbCommand();
    private const int tam = 10;
    private Persona[] aPersona = new Persona[tam];

    public Form1()
    {
      InitializeComponent();
      for (int i = 0; i < aPersona.Length; i++)
      {
        aPersona[i] = null;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      comboCargar(cboTipoDoc, "tipo_documento", "id_tipo_documento", "n_tipo_documento");
      comboCargar(cboEstadoCivil, "tipo_estado_civil", "id_estado_civil", "n_estado_civil");
      comboCargar(cboPersonas, "personas", "documento", "nombres");
      cargarLista(lstPersonas, "personas");
      cargarGrilla(dgvPersonas, "personas");
    }

    private void comboCargar(ComboBox combo, string nombreTabla, string pk, string nombre)
    {
      conexion.ConnectionString = @"Provider=SQLNCLI11;Data Source=MATEBOOK-X-PRO-\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=TUP_PII_2020";
      conexion.Open();
      comando.Connection = conexion;
      comando.CommandType = CommandType.Text;
      comando.CommandText = "select * from " + nombreTabla;
      DataTable table = new DataTable();
      table.Load(comando.ExecuteReader());

      conexion.Close();

      combo.DataSource = table;
      combo.DisplayMember = nombre;
      combo.ValueMember = pk;
    }

    private void cargarLista(ListBox lista, string nombreTabla)
    {
      conexion.ConnectionString = @"Provider=SQLNCLI11;Data Source=MATEBOOK-X-PRO-\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=TUP_PII_2020";
      conexion.Open();
      comando.Connection = conexion;
      comando.CommandType = CommandType.Text;
      comando.CommandText = "select * from " + nombreTabla;

      OleDbDataReader lector;
      lector = comando.ExecuteReader();
      int contador = 0;
      while (lector.Read())
      {
        Persona persona = new Persona();
        if (!lector.IsDBNull(0)) persona.pApellido = lector.GetString(0);
        if (!lector.IsDBNull(1)) persona.pNombres = lector["nombres"].ToString();
        if (!lector.IsDBNull(2)) persona.pTipo_documento = lector.GetInt32(2);
        if (!lector.IsDBNull(3)) persona.pDocumento = lector.GetInt32(3);
        if (!lector.IsDBNull(4)) persona.pTipo_estado_civil = lector.GetInt32(4);

        aPersona[contador] = persona;
        contador++;
      }

      conexion.Close();

      for (int i = 0; i < contador; i++)
      {
        lista.Items.Add(aPersona[i].toStringPersona());
      }
    }

    private void cargarGrilla(DataGridView grilla, string nombreTabla)
    {
      conexion.ConnectionString = @"Provider=SQLNCLI11;Data Source=MATEBOOK-X-PRO-\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=TUP_PII_2020";
      conexion.Open();
      comando.Connection = conexion;
      comando.CommandType = CommandType.Text;
      comando.CommandText = "select * from " + nombreTabla;
      DataTable table = new DataTable();
      table.Load(comando.ExecuteReader());

      conexion.Close();

      grilla.DataSource = table;
    }

    private void cargarDatos(int posicion)
    {
      txtApellido.Text = aPersona[posicion].pApellido;
      txtNombre.Text = aPersona[posicion].pNombres;
      txtDocumento.Text = aPersona[posicion].pDocumento.ToString();
      cboTipoDoc.SelectedValue = aPersona[posicion].pTipo_documento;
      cboEstadoCivil.SelectedValue = aPersona[posicion].pTipo_estado_civil;
    }

    private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
    {
      cargarDatos(lstPersonas.SelectedIndex);
    }
  }
}