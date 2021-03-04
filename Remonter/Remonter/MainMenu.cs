using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Remonter
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OldOrder oldOrder = new OldOrder();
            oldOrder.Show();
        }

        private void BNPerformer_Click(object sender, EventArgs e)
        {
            Form1 FormPerformer = new Form1();
            FormPerformer.Show();
        }

        private void BNOrder_Click(object sender, EventArgs e)
        {
            NewOrder newOrder = new NewOrder();
            newOrder.Show();
        }

        private void BNC_Click(object sender, EventArgs e)
        {
            NewCust newCust = new NewCust();
            newCust.Show();
        }
    }
}
