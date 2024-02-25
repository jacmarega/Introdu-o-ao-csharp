using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sql server ce

using System.Data.SqlServerCe;
using System.IO;
//SQLite
using System.Data.SQLite;

//mySQL
using MySql.Data.MySqlClient;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            #region SQL Server CE
            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            //SqlCeEngine db = new SqlCeEngine(strConection);

            //if (!File.Exists(baseDados))
            //{
            //    db.CreateDatabase();
            //}
            //db.Dispose();
            //SqlCeConnection conexao = new SqlCeConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    labelResultado.Text = "Conectado sql server ce";
            //}
            //catch (Exception ex)
            //{

            //    labelResultado.Text = "Erro ao conectar Server SQL ce" + ex;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region SQLite

            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";


            //if (!File.Exists(baseDados))
            //{
            //    SQLiteConnection.CreateFile(baseDados);
            //}

            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //       labelResultado.Text = "Conectado sql lite";
            //    }
            //    catch (Exception ex)
            //    {

            //        labelResultado.Text = "Erro ao conectar Server SQLIte" + ex;
            //    }
            //    finally
            //    {
            //        conexao.Close();
            //    }
            #endregion

            #region MySql
            //string strConnection = "server=127.0.0.1;User ID=root;database=curso_db;password=vertrigo";
            ////string strConnection1 = "server=127.0.0.1;User ID=root;password=vertrigo";

            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    labelResultado.Text = "Conectado sql MySql";

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;
            //    comando.CommandText = "CREATE DATABASE IF NOT EXISTS curso_bd";
            //    comando.ExecuteNonQuery();
            //    labelResultado.Text = "Base de dados criada com sucesso";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{

            //    labelResultado.Text = "Erro ao conectar Server MySql" + ex;
            //}
            //finally
            //{

            //    conexao.Close();
            //}
            #endregion

        }

        private void btnCriartabela_Click(object sender, EventArgs e)
        {
            #region sqlserver
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE pessoa ( id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
                comando.ExecuteNonQuery();

                labelResultado.Text = "Tabela criada sql server ce";
                comando.Dispose();

            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;

            }
            finally
            {
                conexao.Close();
            }
            #endregion

            #region SqlServer Lite
            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source = " + baseDados + "; Version = 3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoa ( id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Tabela criada sql server lite";
            //    comando.Dispose();

            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;

            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            #region sqlserver
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0,1000);
                string nome = txtnome.Text;
                string email = txtemail.Text;

                comando.CommandText = "INSERT INTO pessoa VALUES (" + id + ", '" + nome + "', '" + email+ "')";

                comando.ExecuteNonQuery();

                labelResultado.Text = "Registro inserido sql server ce";
                comando.Dispose();

            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;

            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "";
            lista.Rows.Clear();

            #region sqlserver
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);

            try
            {
                string query = "SELECT * FROM pessoa";

                if (txtnome.Text != "")
                {
                    query = "SELECT * FROM pessoa WHERE nome LIKE '" + txtnome.Text + "'";
                }
                DataTable dados = new DataTable();

                SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, strConection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach(DataRow linha in dados.Rows)
                {
                    lista.Rows.Add(linha.ItemArray);
                }

            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;

            }
            finally
            {
                conexao.Close();
            }
            #endregion

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            #region sqlserver
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = (int)lista.SelectedRows[0].Cells[0].Value;

                comando.CommandText = "DELETE FROM pessoa WHERE id = '"+ id+ "'";

                comando.ExecuteNonQuery();

                labelResultado.Text = "Registro Excluido sql server ce";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;

            }
            finally
            {
                conexao.Close();
            }
            #endregion

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            #region sqlserver
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = (int)lista.SelectedRows[0].Cells[0].Value;

                string nome = txtnome.Text;
                string email = txtemail.Text;
                
                string query = "UPDATE pessoa SET nome = '"+ nome+ "', email = '"+ email+"' WHERE id LIKE '" + id + "'";

                comando.CommandText = query;

                comando.ExecuteNonQuery();

                labelResultado.Text = "Registro Alterado sql server ce";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;

            }
            finally
            {
                conexao.Close();
            }
            #endregion
        }
    }
}
    

