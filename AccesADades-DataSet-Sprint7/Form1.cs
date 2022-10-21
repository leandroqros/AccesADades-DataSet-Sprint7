using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccesADades_DataSet_Sprint7
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }
        string rutaAcceso = "Data Source=CAFUNEPORTATIL\\SQLEXPRESS;Initial Catalog=Species;Integrated Security=True";
        string consulta = "select * from Species";

        public void bntVT_Click(object sender, EventArgs e)
        {
            //Crear una coneccion
            SqlConnection conect; 
            conect = new SqlConnection(rutaAcceso);

            //hacer una select y crear una tabla temporal
            SqlDataAdapter tablaTemporal;
            tablaTemporal = new SqlDataAdapter(consulta, conect);

            //Conectar
            conect.Open();

            //Crear dataSet/TablaTemporal
            DataSet dts = new DataSet();
            tablaTemporal.Fill(dts, "Species");

            conect.Close();

            //Vizualizar la tabla temporal
            dtgMain.DataSource = dts.Tables[0];
            dtgMain.Columns[0].Visible = false;
            dtgMain.Columns[1].HeaderText = "Codigo";
            dtgMain.Columns[2].HeaderText = "Especie";

            //DataBinding User
            txtbNom.DataBindings.Clear();
            txtbNom.DataBindings.Add("Text", dts.Tables[0], "CodeSpecie");

            //DataBinding Pass
            txtbPass.DataBindings.Clear();
            txtbPass.DataBindings.Add("Text", dts.Tables[0], "DescSpecie");

        }

        public void bntAtt_Click(object sender, EventArgs e)
        {
            
            //Crear una coneccion
            SqlConnection conect;
            conect = new SqlConnection(rutaAcceso);

            //hacer una select y crear una tabla temporal
            SqlDataAdapter tablaTemporal;
            tablaTemporal = new SqlDataAdapter(consulta, conect);


            //Conectar
            conect.Open();

            //Crear dataSet/TablaTemporal
            DataSet dts = new DataSet();
            tablaTemporal.Fill(dts, "Species");

            conect.Close();

            //Vizualizar la tabla temporal
            dtgMain.DataSource = dts.Tables[0];

            //Abrir puerta
            conect.Open();

            DataRow dr = dts.Tables[0].NewRow();

            //Codigo para añadir campos
            dr["CodeSpecie"] = txtbNom.Text;
            txtbNom.Text = "";
            dr["DescSpecie"] = txtbPass.Text;
            txtbPass.Text = "";

            dts.Tables[0].Rows.Add(dr);

            //crea Adapter para actualziar la tabla
            SqlDataAdapter actualizar;
            actualizar = new SqlDataAdapter(consulta, conect);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new
            SqlCommandBuilder(actualizar);

            //verifica cambios y os envia
            if (dts.HasChanges())
            {
                int result = actualizar.Update(dts.Tables[0]);
            }

            conect.Close();
        }
    }
}
