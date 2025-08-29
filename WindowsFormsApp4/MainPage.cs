using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PostPage showPostPage = new PostPage();
            showPostPage.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible=false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
             
        }

        private void managerPageButton_Click(object sender, EventArgs e)
        {
            ManagerPage showManagerPage = new ManagerPage();
            showManagerPage.ShowDialog();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
