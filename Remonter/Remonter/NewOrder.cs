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
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }

        private void ButEnt_Click(object sender, EventArgs e)
        {
            
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();
                    DateTime thisDay = DateTime.Today;
                    string sqlIn = "INSERT INTO [RemonDV].[dbo].[Order] VALUES ('" + id_o.Text + "', '0', '0', '" + id_c.Text + "', '0', '" + thisDay + "')";
                    using (var cmd = new SqlCommand(sqlIn, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            ActiveForm.Close();
        }
        public string get_cs()
        {
            return "Data Source=LAPTOP-LEONID; Initial Catalog = RemonDV; User ID = sa; Password = 123456";
        }
    }
}
