using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Remonter
{
    public partial class OldOrder : Form
    {
        public OldOrder()
        {
            InitializeComponent();
        }
        public string get_cs()
        {
            return "Data Source=LAPTOP-LEONID; Initial Catalog = RemonDV; User ID = sa; Password = 123456";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(get_cs()))
            {
                connection.Open();
                using (var cmd = new SqlCommand("SELECT id_breaking FROM [RemonDV].[dbo].[Order] WHERE id_customer=" + textBox1.Text, connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox3.Text = rd.GetValue(0).ToString();
                        }
                    }
                }
                using (var cmd = new SqlCommand("SELECT id_status FROM [RemonDV].[dbo].[Order] WHERE id_customer=" + textBox1.Text, connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox4.Text = rd.GetValue(0).ToString();
                        }
                    }
                }
                using (var cmd = new SqlCommand("SELECT id_customer FROM [RemonDV].[dbo].[Order] WHERE id_customer=" + textBox1.Text, connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            Customer.Text = rd.GetValue(0).ToString();
                        }
                    }
                }
                using (var cmd = new SqlCommand("SELECT id_performer FROM [RemonDV].[dbo].[Order] WHERE id_customer=" + textBox1.Text, connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox6.Text = rd.GetValue(0).ToString();
                        }
                    }
                }
                using (var cmd = new SqlCommand("SELECT date FROM [RemonDV].[dbo].[Order] WHERE id_customer=" + textBox1.Text, connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            Date.Text = rd.GetValue(0).ToString();
                        }
                    }
                }
                using (var cmd = new SqlCommand("SELECT id_order FROM [RemonDV].[dbo].[Order] WHERE id_customer=" + textBox1.Text, connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox2.Text = rd.GetValue(0).ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(get_cs()))
            {
                connection.Open();
                using (var cmd = new SqlCommand("SELECT id_breaking FROM [RemonDV].[dbo].[Order] WHERE id_order=" + textBox2.Text, connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox3.Text = rd.GetValue(0).ToString();
                        }
                    }
                }
                using (var cmd = new SqlCommand("SELECT id_status FROM [RemonDV].[dbo].[Order] WHERE id_order=" + textBox2.Text, connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox4.Text = rd.GetValue(0).ToString();
                        }
                    }
                }
                using (var cmd = new SqlCommand("SELECT id_customer FROM [RemonDV].[dbo].[Order] WHERE id_order=" + textBox2.Text, connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            Customer.Text = rd.GetValue(0).ToString();
                        }
                    }
                }
                using (var cmd = new SqlCommand("SELECT id_performer FROM [RemonDV].[dbo].[Order] WHERE id_order=" + textBox2.Text, connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox6.Text = rd.GetValue(0).ToString();
                        }
                    }
                }
                using (var cmd = new SqlCommand("SELECT date FROM [RemonDV].[dbo].[Order] WHERE id_order=" + textBox2.Text, connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            Date.Text = rd.GetValue(0).ToString();
                        }
                    }
                }
                using (var cmd = new SqlCommand("SELECT id_customer FROM [RemonDV].[dbo].[Order] WHERE id_order=" + textBox2.Text, connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            textBox1.Text = rd.GetValue(0).ToString();
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
