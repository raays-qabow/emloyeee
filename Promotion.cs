using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LastProject
{
    public partial class Promotion : Form
    {
        public Promotion()
        {
            InitializeComponent();
        }
        Connections obj = new Connections();
        proMethod pro = new proMethod();

        private void Button1_Click(object sender, EventArgs e)
        {
            pro.Promt_form= ComboBox1.Text;
            pro.Promt_form = ComboBox2.Text;
            pro.Prom_title= TextBox2.Text;
            //pro.Prom_date = TextBox1.Text;
            pro.Descrip = TextBox1.Text;
            obj.con.Open();
            obj.qry = "insert into Pro  values(@proapp,@forapp,@prodate,@desc)";
            obj.cmd = new OleDbCommand(obj.qry, obj.con);
            obj.cmd.Parameters.AddWithValue("@proapp", ComboBox1.Text);
            obj.cmd.Parameters.AddWithValue("@forapp", ComboBox2.Text);
            obj.cmd.Parameters.AddWithValue("@rodate", TextBox2.Text);
            obj.cmd.Parameters.AddWithValue("@desc", TextBox1.Text);
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
            MessageBox.Show("data saved");
            //obj.con.Close();
            ComboBox1.Text = "";
            ComboBox2.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}
