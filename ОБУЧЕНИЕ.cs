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

namespace Lab6
{
    public partial class ОБУЧЕНИЕ : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string sql = "SELECT * FROM Users";
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Обучение;Integrated Security=True");
        public ОБУЧЕНИЕ()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            connection.Open();
            adapter = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand agregar = new SqlCommand("insert value(@Шифр специальности, @№ зачетной книжки, @Дата зачисления, @Форма обучения)", connection);
            connection.Open();
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    agregar.Parameters.Clear();

                    agregar.Parameters.AddWithValue("@Шифр специальности", Convert.ToString(row.Cells["Column1"].Value));
                    agregar.Parameters.AddWithValue("@№ зачетной книжки", Convert.ToString(row.Cells["Column2"].Value));
                    agregar.Parameters.AddWithValue("@Дата зачисления", Convert.ToString(row.Cells["Column3"].Value));
                    agregar.Parameters.AddWithValue("@Форма обучения ", Convert.ToString(row.Cells["Column4"].Value));

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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand agregar = new SqlCommand("insert value(@Шифр специальности, @№ зачетной книжки, @Дата зачисления, @Форма обучения)", connection);
            connection.Open();
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    agregar.Parameters.Clear();

                    agregar.Parameters.AddWithValue("@Шифр специальности", Convert.ToString(row.Cells["Column1"].Value));
                    agregar.Parameters.AddWithValue("@№ зачетной книжки", Convert.ToString(row.Cells["Column2"].Value));
                    agregar.Parameters.AddWithValue("@Дата зачисления", Convert.ToString(row.Cells["Column3"].Value));
                    agregar.Parameters.AddWithValue("@Форма обучения ", Convert.ToString(row.Cells["Column4"].Value));

                    agregar.ExecuteNonQuery();
                }
                MessageBox.Show("Сохраненные данные");
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
