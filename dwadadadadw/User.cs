﻿using System;
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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void userzBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userzBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._9_11DataSet1);

        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_9_11DataSet1.userz' table. You can move, or remove it, as needed.
            this.userzTableAdapter.Fill(this._9_11DataSet1.userz);

        }
    }
}
