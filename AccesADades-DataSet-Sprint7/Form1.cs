using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AccesADades_DataSet_Sprint7
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        string rutaAcceso = "Data Source=CAFUNEPORTATIL\\SQLEXPRESS;Initial Catalog=DarkCore;Integrated Security=True";
        string consulta = "select* from Users";

        private void bntVT_Click(object sender, EventArgs e)
        {

            //Crear una coneccion
            SqlConnection conect;
            conect = new SqlConnection(rutaAcceso);

            //hacer una select y crear una tabla temporal
            SqlDataAdapter tablaTemporal;
            tablaTemporal = new SqlDataAdapter(consulta, conect);

            conect.Open();

            //Crear dataSet
            DataSet dts = new DataSet();
            tablaTemporal.Fill(dts, "Users");

            conect.Close();

            //Crear la tabla temporal
            dtgMain.DataSource = dts.Tables[0];

            conect.Open();

            //txtbNom.DataBindings.Clear();
            //DataRow att = dts.Tables[0].NewRow();

            //att[txtbNom.Text] = "";

            //dts.Tables[0].Rows.Add(att);

            //Verificar registros en la tabla
            //DataTable dato = dts.Tables[0];

            //if (txtbNom.Text.Length != 0)
            //{
            //    string valor = dts.Tables[0].Rows[0].ToString();//Poner txtbUser.Texto aqui;
            //}
            //int registros = dts.Tables[0].Rows.Count;

            //SqlDataAdapter adapter1;
            //adapter1 = new SqlDataAdapter(consulta, conect);
            //SqlCommandBuilder cmdBuilder;
            //cmdBuilder = new
            //SqlCommandBuilder(adapter1);


        }

        private void bntAtt_Click(object sender, EventArgs e)
        {
            //txtbNom.DataBindings.Clear();
            //DataRow att = dts.Tables[0].NewRow();

            //att[txtbNom.Text] = "";

            //dts.Tables[0].Rows.Add(att);

            //SqlDataAdapter tablaTemp;
            //string consultaAtt;
            //consultaAtt = "select * from Users where codeUser = 'leo' and password = '1234'";
            //tablaTemp = new SqlDataAdapter(tabl)
            //DataTable t = MakeTable();
            //Pagina19 del PPT
        }

    }
}
