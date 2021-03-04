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
    public partial class NewCust : Form
    {
        public NewCust()
        {
            InitializeComponent();
        }

        private void ButEnt_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(get_cs()))
            {
                connection.Open();
                string sqlIn ="INSERT INTO Customer VALUES ('" + IdCust.Text + "', '" + FioCust.Text + "', '" + TelCust.Text + "', '0')";
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
