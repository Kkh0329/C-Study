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
using System.Security.Cryptography;

namespace WindowsFormsApp4
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
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

            // 비밀번호 복잡도 검사
            if (!IsValidPassword(userPassword))
            {
                MessageBox.Show("비밀번호는 최소 8자 이상이어야 하며, 대문자, 소문자, 숫자, 특수문자를 포함해야 합니다.", "알림");
                return;
            }

            // 비밀번호 암호화
            string hashedPassword = passwordSHA256.HashPassword(userPassword);

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
                            LoginPage showLoginPage = new LoginPage();
                            showLoginPage.ShowDialog();
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


        private bool IsValidPassword(string password)
        // 비밀번호 생성 제약
        {
            // 비밀번호의 최소 길이
            if (password.Length < 8)
            {
                return false;
            }

            // 대문자, 소문자, 숫자, 특수문자가 모두 포함되어 있는지 검사
            bool hasUpperChar = password.Any(c => Char.IsUpper(c));
            bool hasLowerChar = password.Any(c => Char.IsLower(c));
            bool hasNumericChar = password.Any(c => Char.IsDigit(c));
            bool hasSpecialChar = password.Any(c => "!@#$%^&*()_+-=[]{}|;:,.<>?".Contains(c));

            return hasUpperChar && hasLowerChar && hasNumericChar && hasSpecialChar;
        }

        public class passwordSHA256{
            // 비밀번호 암호화
            public static string HashPassword(string password)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    // 비밀번호를 바이트 배열로 변환
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                    // SHA256 해시 생성
                    byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                    // 바이트 배열을 16진수 문자열로 변환하여 반환
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
            }
}
    }

}
