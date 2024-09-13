using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dwadadadadw
{
    public partial class Sale : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=344-09;Initial Catalog=9/11;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        int proCount = 0;
        string numCash = null;
        public Sale()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._9_11DataSet);

        }

        private void Sale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_9_11DataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this._9_11DataSet.product);

        }

        private void tID_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
               
            }
        }
    }
}
