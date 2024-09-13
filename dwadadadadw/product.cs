using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dwadadadadw
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }

        private void product_1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.product_1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._9_11DataSet1);

        }

        private void product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_9_11DataSet1.product_1' table. You can move, or remove it, as needed.
            this.product_1TableAdapter.Fill(this._9_11DataSet1.product_1);

        }
    }
}
