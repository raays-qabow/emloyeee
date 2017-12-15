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
    public partial class Achievment : Form
    {
        public Achievment()
        {
            InitializeComponent();
        }
        AchievmentConn obj = new AchievmentConn();
        AchievMethod ach = new AchievMethod();
        private void Button3_Click(object sender, EventArgs e)
        {
            ach.Empolyee = ComboBox1.Text;
            ach.Forward_application = ComboBox2.Text;
            ach.Achivment_title = TextBox3.Text;
            ach.Achiveivment_date = TextBox1.Text;
            obj.con.Open();
            obj.qry = "insert into Achiv  values(@Empl,@ForApp,AchTit,@Adate)";
            obj.cmd = new OleDbCommand(obj.qry, obj.con);
            obj.cmd.Parameters.AddWithValue("@Empl", ComboBox1.Text);
            obj.cmd.Parameters.AddWithValue("@ForApp", ComboBox2.Text);
            obj.cmd.Parameters.AddWithValue("@AchTit", TextBox3.Text);
            obj.cmd.Parameters.AddWithValue("@Adate", TextBox1.Text);
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
            MessageBox.Show("data saved");
            //obj.con.Close();
            ComboBox1.Text = "";
            ComboBox2.Text = "";
            TextBox1.Text = "";
            TextBox3.Text = "";
            TextBox2.Text = "";

        }


        private void Achievment_Load(object sender, EventArgs e)
        {

        }
    }
}
