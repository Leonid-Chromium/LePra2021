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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var connection = new SqlConnection(get_cs()))
            {
                connection.Open();
                using (var cmd = new SqlCommand("SELECT performer_FIO FROM [RemonDV].[dbo].[Performer] WHERE id_performer = 1", connection))
                {
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            listBox1.Text = rd.GetValue(0).ToString();
                            label1.Text = rd.GetValue(0).ToString();
                        }
                    }
                }
                connection.Close();
            }
        }
        public string get_cs()
        {
            return "Data Source=LAPTOP-LEONID; Initial Catalog = RemonDV; User ID = sa; Password = 123456";
        }
    }
}
