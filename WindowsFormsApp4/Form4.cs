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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=TEST;Integrated Security=SSPI;";

            string userId = id.Text;
            string userPassword = password.Text;

            // 아이디와 비밀번호가 모두 입력됐는지 확인 
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(userPassword))
            {
                MessageBox.Show("아이디와 비밀번호를 모두 입력해주세요.", "알림");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 아이디 중복 확인
                    string checkUserQuery = "SELECT COUNT(*) FROM users WHERE username = @userId";
                    using (SqlCommand checkCommand = new SqlCommand(checkUserQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@userId", userId);

                        int userExists = (int)checkCommand.ExecuteScalar();

                        if (userExists > 0)
                        {
                            // 아이디가 이미 존재하는 경우
                            MessageBox.Show("이미 사용 중인 아이디입니다. 다른 아이디를 입력해주세요.", "알림");
                            return;
                        }
                    }


                    string signUpQuery = "INSERT INTO users(username, password, created_at) VALUES(@userId, @userPassword, GETDATE())";

                    using (SqlCommand command = new SqlCommand(signUpQuery, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        command.Parameters.AddWithValue("@userPassword", userPassword);

                        int effectnum;
                        effectnum = command.ExecuteNonQuery();

                        if (effectnum > 0)
                        {
                            MessageBox.Show("회원가입 성공", "알림");

                            this.Visible = false;
                            Form1 showForm1 = new Form1();
                            showForm1.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("회원가입 실패", "알림");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex.Message);
                }
            }

        }
    }
}
