using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class СПЕЦИАЛЬНОСТИ : Form
    { 
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Специальности;Integrated Security=True";
        string sql = "SELECT * FROM Users";
        //SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Специальности;Integrated Security=True");
        public СПЕЦИАЛЬНОСТИ()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand agregar = new SqlCommand("insert value(@Шифр специальности, @Название специальности, @Квалификация выпускника, @Продолжительность обучения,@Стоимость года обучения)", connection);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand agregar = new SqlCommand(connectionString);
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        agregar.Parameters.Clear();

                        agregar.Parameters.AddWithValue("@Шифр специальности", Convert.ToString(row.Cells["Column1"].Value));
                        agregar.Parameters.AddWithValue("@Название специальности", Convert.ToString(row.Cells["Column2"].Value));
                        agregar.Parameters.AddWithValue("@Квалификация выпускника", Convert.ToString(row.Cells["Column3"].Value));
                        agregar.Parameters.AddWithValue("@Продолжительность обучения", Convert.ToString(row.Cells["Column4"].Value));
                        agregar.Parameters.AddWithValue("@Стоимость года обучения", Convert.ToString(row.Cells["Column5"].Value));

                        agregar.ExecuteNonQuery();
                    }
                    MessageBox.Show("Агрегированные данные");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlCommand agregar = new SqlCommand("insert value(@Шифр специальности, @Название специальности, @Квалификация выпускника, @Продолжительность обучения,@Стоимость года обучения)", connection);
            //connection.Open();
            //try
            //{
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        agregar.Parameters.Clear();

            //        agregar.Parameters.AddWithValue("@Шифр специальности", Convert.ToString(row.Cells["Column1"].Value));
            //        agregar.Parameters.AddWithValue("@Название специальности", Convert.ToString(row.Cells["Column2"].Value));
            //        agregar.Parameters.AddWithValue("@Квалификация выпускника", Convert.ToString(row.Cells["Column3"].Value));
            //        agregar.Parameters.AddWithValue("@Продолжительность обучения", Convert.ToString(row.Cells["Column4"].Value));
            //        agregar.Parameters.AddWithValue("@Стоимость года обучения", Convert.ToString(row.Cells["Column5"].Value));

            //        agregar.ExecuteNonQuery();
            //    }
            //    MessageBox.Show("Сохраненные данные");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Ошибка");
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (n != -1)
            {
                dataGridView1.Rows.RemoveAt(n);
            }
        }
    }
}
