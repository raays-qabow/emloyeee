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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }
        Connections obj = new Connections();
        TransferMethod trans = new TransferMethod();
        private void Button1_Click(object sender, EventArgs e)
        {
            trans.EmpTransfer= ComboBox1.Text;
            trans.Forwad_appl = ComboBox2.Text;
            trans.Transfer_date = ComboBox4.Text;
            trans.Department = ComboBox4.Text;
            trans.EmpTransfer = ComboBox4.Text;
            obj.con.Open();
            obj.qry = "insert into Transfer  values(@EMT,@Forwapp,@TrDate,@Trdep,@TrSta)";
            obj.cmd = new OleDbCommand(obj.qry, obj.con);
            obj.cmd.Parameters.AddWithValue("@EMT", ComboBox1.Text);
            obj.cmd.Parameters.AddWithValue("@Forwapp", ComboBox2.Text);
            obj.cmd.Parameters.AddWithValue("@TrDate", ComboBox3.Text);
            obj.cmd.Parameters.AddWithValue("@Trdep", DateTimePicker1.Text);
            obj.cmd.Parameters.AddWithValue("@TrSta", ComboBox4.Text);
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
            MessageBox.Show("data saved");
            //obj.con.Close();
            ComboBox1.Text = "";
            ComboBox2.Text = "";
            ComboBox3.Text = "";
            ComboBox4.Text = "";
            //TextBox2.Text = "";
        }
    }
}
