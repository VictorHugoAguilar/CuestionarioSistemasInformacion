using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuestionarioSistemasInformacion
{
	public partial class AnadirPregunta : Form
	{
		public AnadirPregunta()
		{
			InitializeComponent();
		}
		//Creamos el dataSet 
		DataSet dsCuestionario;

		//Creamos el DataAdpter
		System.Data.OleDb.OleDbDataAdapter da;

		//creamo un total de registro
		private int totalRegistros;

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			Cuestionario cuest = new Cuestionario();
			cuest.Show();
			this.Close();
		}

		private void AnadirPregunta_Load(object sender, EventArgs e)
		{
			//Creamos un objeto conexión
			System.Data.OleDb.OleDbConnection con;
			con = new System.Data.OleDb.OleDbConnection();

			//le pasamos la ruta de conexión
			con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Coquis/Source/Repos/VersionAlpha/CuestionarioSistemasInformacion/Recursos/Database1.accdb";

			//abrimos la coneccion
			con.Open();

			//creamos un objeto dataset
			dsCuestionario = new DataSet();

			//creamos un objeto utulizando una secuentca SqL para seleccionar los registros de la tabla
			string sql = "Select * from Cuestionario";
			da = new System.Data.OleDb.OleDbDataAdapter(sql, con);

			//rellenamos el dataset con el dataadapter
			da.Fill(dsCuestionario, "Cuestionario");
			
			totalRegistros = dsCuestionario.Tables["Cuestionario"].Rows.Count;
			//cerramos la conexión
			con.Close();
		}

		//creamos un metodo que limpia los textbox
		private void limpiarCuadrosTexto()
		{
			txtPregunta.Clear();
			txtRespuesta1.Clear();
			txtRespuesta2.Clear();
			txtRespuesta3.Clear();
			txtRespuesta4.Clear();
			txtRespuestaCorrecta.Clear();
		}

		//boton para limpiar los cuadro de texto
		private void btnAnadiNuevaPregunta_Click(object sender, EventArgs e)
		{
			limpiarCuadrosTexto();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (compruebaDatos())
			{
				MessageBox.Show("todo ok");

				//reconectamos con la base de datos
				System.Data.OleDb.OleDbCommandBuilder cb;
				cb = new System.Data.OleDb.OleDbCommandBuilder(da);

				//Creamos un nuevo registro
				DataRow dRegistro = dsCuestionario.Tables["Cuestionario"].NewRow();

				//asignamos para cada registro el valor de cada textbox
				dRegistro["Pregunta"] = txtPregunta.Text;
				dRegistro["Respuesta1"] = txtRespuesta1.Text;
				dRegistro["Respuesta2"] = txtRespuesta2.Text;
				dRegistro["Respuesta3"] = txtRespuesta3.Text;
				dRegistro["Respuesta4"] = txtRespuesta4.Text;
				dRegistro["Correcta"] = txtRespuestaCorrecta.Text;

				//añaidmos los nuevos registro al dataset
				dsCuestionario.Tables["Cuestionario"].Rows.Add(dRegistro);

				//actualizamos la base de datos
				da.Update(dsCuestionario, "Cuestionario");

				//actualizamos la lista de registros
				totalRegistros++;
			}
		}

		//creamos una funcion que nos devuelve si falta un campo por rellenar
		private bool compruebaCamposVacios()
		{
			bool comprueba = false;
			if (txtPregunta.TextLength == 0)
				comprueba = true;
			if (txtRespuestaCorrecta.Text == "")
				comprueba = true;
			if (txtRespuesta1.TextLength == 0)
				comprueba = true;
			if (txtRespuesta2.TextLength == 0)
				comprueba = true;
			if (txtRespuesta3.TextLength == 0)
				comprueba = true;
			if (txtRespuesta4.TextLength == 0)
				comprueba = true;

			return comprueba;
		}

		//creamos una funcion que comprebe los datos de entrada
		private bool compruebaDatos()
		{
			bool comprueba = true;
			if (compruebaCamposVacios())
			{
				MessageBox.Show("Datos vacios");
				comprueba = false;
			}
			else {
				if (!compruebaDatosCorreccion())
				{
					MessageBox.Show("Datos Incorrectos");
					comprueba = false;
				}
			}
			return comprueba;
		}

		//creamos una funcion que nos devuelve si los datos de correccion estan en el margen solicitados
		private bool compruebaDatosCorreccion() {
			bool comprueba=false;
			try
			{
				int respuesta = Convert.ToInt32(txtRespuestaCorrecta.Text);
				if (respuesta > 0 && respuesta < 5)
					comprueba = true;
			}
			catch
			{
				MessageBox.Show("Ha introducido un caracter no valido");
				comprueba = false;
			}
			return comprueba;
		}

		private void lblRespuesta3_Click(object sender, EventArgs e)
		{

		}
	}
}
