using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dwadadadadw
{
    public partial class Form1 : Form
    {
        // ประกาศตัวแปรเหล่านี้ภายใน class Form1
        SqlConnection conn = new SqlConnection("Data Source=344-09;Initial Catalog=9/11;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from userz where UserName = '" + textBox1.Text + "' AND userPassword = '" + textBox2.Text + "'", conn);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Form2 formmain = new Form2();
                formmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid username or password", "ไม่ถูก", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }
    }
}
