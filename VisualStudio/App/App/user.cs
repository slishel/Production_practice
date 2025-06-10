using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            addRequest addRequest = new addRequest();
            addRequest.Show();
            this.Hide();
        }
    }
}
