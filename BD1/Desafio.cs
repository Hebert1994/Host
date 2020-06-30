using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BD1
{
    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            MySqlConnectionStringBuilder conexao_sql = new MySqlConnectionStringBuilder();
            conexao_sql.Server =   TXTSERVIDOR.Text ;
            conexao_sql.UserID =  TXTUSUARIO.Text;
            conexao_sql.Password = TXTSENHA.Text;
            conexao_sql.Database = TXTBANCO.Text;

            MySqlConnection conectar = new MySqlConnection();
            conexao_sql.ConnectionString = conexao_sql.ConnectionString;

            try
            {
                conectar.Open();
                MessageBox.Show("Conectado!");
                
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = TXTSQL.Text;
                cmd.Connection = conectar;
                cmd.ExecuteNonQuery();
                
            }

            catch (MySqlException)
            {
                MessageBox.Show("Erro ao conectar!");
            }

            finally
            {
                conectar.Close();
            }
        }

        
    }
}
