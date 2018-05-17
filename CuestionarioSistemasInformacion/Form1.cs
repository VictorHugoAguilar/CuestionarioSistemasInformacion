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
	public partial class Cuestionario : Form
	{
		public Cuestionario()
		{
			InitializeComponent();
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
		private static string InputBox(string texto)
		{
			InputBoxDialog ib = new InputBoxDialog();
			ib.FormPrompt = texto;
			ib.DefaultValue = "";
			ib.ShowDialog();
			string s = ib.InputResponse;
			ib.Close();
			return s;
		}

		//Creamos un DataSet
		DataSet dsCuestionario;

		//Creamos el DataAdapter
		System.Data.OleDb.OleDbDataAdapter da;

		//Creamos una variable que nos mostrara donde estamos situados
		private int pos;

		//Creamos una variable que mostrara el total de registros
		private int totalRegistros;

		//creamos unas variables que seran las de datos correctos he incorrectos y total
		//le asignamos un valor
		private int respuestasCorrectas = 0;
		private int respuestasIncorrectas = 0;
		private double totalNota = 0;

		//para el label de las contestadas
		private int preguntasContestadas = 0;

		//variables para la evaluacion
		private int preguntasEvaluacion = 0;
		private int totalPreguntasEvaluacion = 0;


		private void Cuestionario_Load(object sender, EventArgs e)
		{
			//Creamos un objeto conexión y le damos la ruta de la bd
			System.Data.OleDb.OleDbConnection con;
			con = new System.Data.OleDb.OleDbConnection();

			//Le pasamos la ruta de la conexión
			con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Coquis/Source/Repos/Nueva carpeta/CuestionarioSistemasInformacion/Recursos/Database1.accdb";

			//Abrimos la conexión
			con.Open();

			//Creamos el objeto DataSet
			dsCuestionario = new DataSet();

			//Creamos el objeto utilizando una sentencia SQL para seleccionar los registros de la tabla
			string sql = "Select * from Cuestionario";
			da = new System.Data.OleDb.OleDbDataAdapter(sql, con);

			da.Fill(dsCuestionario, "Cuestionario");

			//asignamos el total de registros
			totalRegistros = dsCuestionario.Tables["Cuestionario"].Rows.Count;

			//Nos situamos en la primera posicion
			pos = devolverPosicionAleatoria(totalRegistros);
			mostrarRegistro(pos);

			//Cerramos la conexión
			con.Close();
		}

		//Creamos un método que nos muestra donde estamos situados
		private void mostrarRegistro(int pos)
		{
			if(hayRegistros()){
			//Objeto que nos permite recoger un registro de la tabla
			DataRow dRegistro;

			//Cogemos el registro en la posicion de la tabla cuestionario
			dRegistro = dsCuestionario.Tables["Cuestionario"].Rows[pos];

			//Cogemos el valor de cada una de las columnas del registro 
			//y lo pasamos al labelbox correspondiente

			lblPregunta.Text = dRegistro[1].ToString();
			lblRespuesta1.Text = dRegistro[2].ToString();
			lblRespuesta2.Text = dRegistro[3].ToString();
			lblRespuesta3.Text = dRegistro[4].ToString();
			lblRespuesta4.Text = dRegistro[5].ToString();

			//marcador
			lblPuntuacionCorrecta.Text = respuestasCorrectas.ToString();
			lblPuntuacionIncorrecta.Text = respuestasIncorrectas.ToString();
			if (respuestasCorrectas >= 1 && respuestasIncorrectas >= 1)
				totalNota = respuestasCorrectas - respuestasIncorrectas * 1.33;
			else
				totalNota = respuestasCorrectas;

			lblPuntuacionTotal.Text = totalNota.ToString();

			//label de control
			lblRegistrosprimero.Text = preguntasContestadas.ToString();
			preguntasContestadas++;
			lblRegistroUltimo.Text = totalRegistros.ToString();
			}
			else
			{
				limpiarLabelPreguntas();
			}

		}

		//creamos un método que limpie los contenidos de los label
		private void limpiarLabelPreguntas()
		{
			lblPregunta.Text = "Preguntas";
			lblRespuesta1.Text = "Respuesta 1";
			lblRespuesta2.Text = "Respuesta 2";
			lblRespuesta3.Text = "Respuesta 3";
			lblRespuesta4.Text = "Respuesta 4";
		}

		//creamos un metodo que nos devuelve si hay registros en la tabla
		private bool hayRegistros()
		{
			bool comprueba=false;
			totalRegistros = dsCuestionario.Tables["Cuestionario"].Rows.Count;
			if(totalRegistros>0)
				comprueba=true;
			return comprueba;
		}

		private void lblPregunta1_Click(object sender, EventArgs e)
		{

		}

		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			if (pos < totalRegistros - 1)
				pos++;
			mostrarRegistro(pos);
		}

		private void btnAñadirPregunta_Click(object sender, EventArgs e)
		{
			AnadirPregunta Anadir = new AnadirPregunta();
			Anadir.Show();

			this.Close();

		}

		//creamos un metodo que nos pone los marcadore en 0
		private void marcadoresEnZero()
		{
			respuestasCorrectas = 0;
			respuestasIncorrectas = 0;
			totalNota = 0;
			preguntasContestadas = 0;
		}

		//creamo una funcion que saque una posicion random
		private int devolverPosicionAleatoria(int parTotalRegistro)
		{
			Random rnd = new Random();
			int desde = 0;
			int posicionAleatorioa = rnd.Next(desde, parTotalRegistro);

			return posicionAleatorioa;
		}

		//boton para comenzar de nuevo
		private void btnComenzar_Click(object sender, EventArgs e)
		{
			marcadoresEnZero();
			pos = devolverPosicionAleatoria(totalRegistros);
			mostrarRegistro(pos);
			DeseleccionarRadioButton();
		}

		//Creamos un metodo que nos suma si seleccionamos la opcion correcta 
		private bool PreguntaContestada(int pos)
		{
			bool contestadaCorrectamente = false;
			string repuestaRadioButon = (ObtenerRespuesta());
			int respuestacorrecta = 0;

			//creamos un objeto que recoge los datos del registro
			DataRow dRegistro;

			if (repuestaRadioButon == "rbtn1")
				respuestacorrecta = 1;
			if (repuestaRadioButon == "rbtn2")
				respuestacorrecta = 2;
			if (repuestaRadioButon == "rbtn3")
				respuestacorrecta = 3;
			if (repuestaRadioButon == "rbtn4")
				respuestacorrecta = 4;

			dRegistro = dsCuestionario.Tables["Cuestionario"].Rows[pos];
			int respuestaCorrectaRegistro = Convert.ToInt32(dRegistro["Correcta"]);

			if (respuestaCorrectaRegistro == respuestacorrecta)
				contestadaCorrectamente = true;
			else
				contestadaCorrectamente = false;

			return contestadaCorrectamente;
		}

		//creamos un metodo que obtenemos la respuesta
		private string ObtenerRespuesta()
		{
			string seleccion = "";
			foreach (Control ctrl in grpPregunta.Controls)
			{
				if (ctrl is RadioButton)
				{
					RadioButton radio = ctrl as RadioButton;
					if (radio.Checked)
					{
						seleccion = radio.Name;
						break;
					}
				}
			}
			return seleccion;
		}

		//creamos un metodo que limpia los radio buton
		private void DeseleccionarRadioButton()
		{
			rbtn1.Checked = false;
			rbtn2.Checked = false;
			rbtn3.Checked = false;
			rbtn4.Checked = false;
		}

		//al seleccionar un radiobuton damos paso al evento
		private void rbtn1_CheckedChanged(object sender, EventArgs e)
		{
			if(hayRegistros()){
			//totalRegistros = dsCuestionario.Tables["Cuestionario"].Rows.Count;
			if (rbtn1.Checked == Enabled)
			{
				bool respuesta = PreguntaContestada(pos);
				if (respuesta)
					respuestasCorrectas++;
				if (!respuesta)
					respuestasIncorrectas++;

				//if (pos < totalRegistros - 1)
				//{
				DeseleccionarRadioButton();
				//pos++;
				//}
				pos = devolverPosicionAleatoria(totalRegistros);
				mostrarRegistro(pos);
			}
			}
		}

		private void rbtn2_CheckedChanged(object sender, EventArgs e)
		{
			if(hayRegistros()){
			//totalRegistros = dsCuestionario.Tables["Cuestionario"].Rows.Count;
			if (rbtn2.Checked == Enabled)
			{
				bool respuesta = PreguntaContestada(pos);
				if (respuesta)
					respuestasCorrectas++;
				if (!respuesta)
					respuestasIncorrectas++;
				//if (pos < totalRegistros - 1)
				//{
				DeseleccionarRadioButton();
				//pos++;
				//}
				pos = devolverPosicionAleatoria(totalRegistros);
				mostrarRegistro(pos);
			}
			}
		}

		private void rbtn3_CheckedChanged(object sender, EventArgs e)
		{
			if(hayRegistros()){
			//totalRegistros = dsCuestionario.Tables["Cuestionario"].Rows.Count;
			if (rbtn3.Checked == Enabled)
			{
				bool respuesta = PreguntaContestada(pos);
				if (respuesta)
					respuestasCorrectas++;
				if (!respuesta)
					respuestasIncorrectas++;
				//if (pos < totalRegistros - 1)
				//{
				DeseleccionarRadioButton();
				//pos++;
				//}
				pos = devolverPosicionAleatoria(totalRegistros);
				mostrarRegistro(pos);
			}
			}
		}

		private void rbtn4_CheckedChanged(object sender, EventArgs e)
		{
			if(hayRegistros()){
			//totalRegistros = dsCuestionario.Tables["Cuestionario"].Rows.Count;
			if (rbtn4.Checked == Enabled)
			{
				bool respuesta = PreguntaContestada(pos);
				if (respuesta)
					respuestasCorrectas++;
				if (!respuesta)
					respuestasIncorrectas++;
				//if (pos < totalRegistros - 1)
				//{
				DeseleccionarRadioButton();
				//pos++;
				//}
				pos = devolverPosicionAleatoria(totalRegistros);
				mostrarRegistro(pos);
			}
			}
		}


		//Boton que elimina preguntas
		private void btnEliminarPregunta_Click(object sender, EventArgs e)
		{
			if(!hayRegistros())
				MessageBox.Show("No hay registros");
			else{
			DialogResult deseaEliminar = MessageBox.Show("Esta seguro que desea elimnar el registro",
				"Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (deseaEliminar == DialogResult.Yes)
			{
				//reconectamos con la base de datos
				System.Data.OleDb.OleDbCommandBuilder cb;
				cb = new System.Data.OleDb.OleDbCommandBuilder(da);

				MessageBox.Show(pos.ToString());
				
				if(pos>1){

				//eliminamos el registro en la posicion
				dsCuestionario.Tables["Cuestionario"].Rows[pos].Delete();

				//actualizamos la base de datos el registro de la tabla
				da.Update(dsCuestionario, "Cuestionario");

				//actualizamos el total de registros
				totalRegistros = dsCuestionario.Tables["Cuestionario"].Rows.Count;

				//mostramos una posicion aleatoria
				pos = devolverPosicionAleatoria(totalRegistros);
				mostrarRegistro(pos);
						}
				if (pos==0)
				{
					//eliminamos el registro en la posicion
					dsCuestionario.Tables["Cuestionario"].Rows[pos].Delete();
					
					//actualizamos la base de datos el registro de la tabla
					da.Update(dsCuestionario, "Cuestionario");

					if(hayRegistros())
					{
						totalRegistros = dsCuestionario.Tables["Cuestionario"].Rows.Count;
						pos = devolverPosicionAleatoria(totalRegistros);
						mostrarRegistro(pos);
					}else
					{
							limpiarLabelPreguntas();
					}

				}
			}
			}
		}


		//Boton de evaluar
		private void button1_Click(object sender, EventArgs e)
		{ 
			try
			{
				totalPreguntasEvaluacion =int.Parse(InputBox("Introduzca cuantas preguntas desea contestar"));
				for (int i = 0; i < totalPreguntasEvaluacion; i++)
				{
					preguntasEvaluacion=0+1;
				}
				
			}
			catch
			{
				MessageBox.Show("ERROR COOMPRUEBA");
			}
		}





	}
}