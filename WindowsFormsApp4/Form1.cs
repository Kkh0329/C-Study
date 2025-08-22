using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            // 로그인 버튼
            // 클릭 시 로그인
            /*
            string setId = "test";
            string setPw = "a1234";

            string userId = id.Text;
            string userPw = password.Text;

            if (userId == setId && userPw == setPw)
            {
                MessageBox.Show("로그인 성공", "알림");
                this.Visible = false;
                Form2 showForm2 = new Form2();
                showForm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("로그인 실패", "알림");
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // DB 연동 테스트

            string connectionString = "Data Source=.;Initial Catalog=TEST;Integrated Security=SSPI;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    connection.Open();
                    MessageBox.Show("DB연결 성공");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB연결 실패 : " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 showForm4 = new Form4();
            showForm4.ShowDialog();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
