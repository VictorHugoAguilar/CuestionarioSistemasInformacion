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
        //Creamos un DataSet
        DataSet dsCuestionario;

        //Creamos el DataAdapter
        System.Data.OleDb.OleDbDataAdapter da;

        //Creamos una variable que nos mostrara donde estamos situados
        private int pos;

        //Creamos una variable que mostrara el total de registros
        private int totalRegistros;


        private void Cuestionario_Load(object sender, EventArgs e)
        {
            //Creamos un objeto conexión y le damos la ruta de la bd
            System.Data.OleDb.OleDbConnection con;
            con = new System.Data.OleDb.OleDbConnection();

            //Le pasamos la ruta de la conexión
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Coquis/Source/Repos/CuestionarioSistemasInformacion/Recursos/Database1.accdb";

            //Abrimos la conexión
            con.Open();

            //Creamos el objeto DataSet
            dsCuestionario = new DataSet();

            //Creamos el objeto utilizando una sentencia SQL para seleccionar los registros de la tabla
            string sql = "Select * from Cuestionario";
            da = new System.Data.OleDb.OleDbDataAdapter(sql, con);

            da.Fill(dsCuestionario, "Cuestionario");

            //Nos situamos en la primera posicion
            pos = 0;
            mostrarRegistro(pos);

            //asignamos el total de registros
            totalRegistros = dsCuestionario.Tables["Cuestionario"].Rows.Count;

            //Cerramos la conexión
            con.Close();
        }

        //Creamos un método que nos muestra donde estamos situados
        private void mostrarRegistro(int pos)
        {
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
        }

        private void rbtn1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblPregunta1_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (pos < totalRegistros-1)
                pos++;
			mostrarRegistro(pos);
        }

		private void btnAñadirPregunta_Click(object sender, EventArgs e)
		{
			AnadirPregunta Anadir = new AnadirPregunta();
			Anadir.ShowDialog();
		}
	}
}
