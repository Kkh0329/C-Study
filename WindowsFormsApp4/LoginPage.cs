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
    public partial class LoginPage : Form
    {


        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   // 로그인
            string userId = id.Text;
            string userPassword = password.Text;
            string connectionString = "Data Source=.;Initial Catalog=TEST;Integrated Security=SSPI;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string checkUserQuery = "SELECT COUNT(1) FROM users WHERE username = @userId AND password = @userPassword";
                    using (SqlCommand checkcommand = new SqlCommand(checkUserQuery, connection))
                    {
                        checkcommand.Parameters.AddWithValue("@userId", userId);
                        checkcommand.Parameters.AddWithValue("@userPassword", userPassword);

                        int loginResult = (int)checkcommand.ExecuteScalar();

                        if (loginResult == 1)
                        {
                            this.Visible = false;
                            MainPage showMainPage = new MainPage();
                            showMainPage.ShowDialog();
                        }
                        else {
                            MessageBox.Show("입력 정보가 틀렸습니다. 아이디와 비밀번호를 다시 확인해 주세요.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("로그인 실패 : " + ex.Message);
                }
            }
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
            SignUpPage showSignUpPage = new SignUpPage();
            showSignUpPage.ShowDialog();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
