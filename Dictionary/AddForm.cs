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

namespace Dictionary
{
    public partial class AddForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=localhost;Database=Dictionary;Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public AddForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
                }

        private void addFrmWrd_Click(object sender, EventArgs e)
        {

        }

        private void updateFrmWrd_Click(object sender, EventArgs e)
        {

        }

        private void searchFrmBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
