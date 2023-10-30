using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;


namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        private IConfiguration config;
        IMemberRepository memberRepository = new MemberRepository();

        public frmLogin()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            config = builder.Build();
        }

        bool checkLoginAdmin(string email, string password)
        {
            string configEmail = config["account:adminAccount:email"];
            string configPassword = config["account:adminAccount:password"];

            if (email == configEmail && password == configPassword)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Login", "Admin Login");
            }
            return false;
        }

        bool checkLogin(string email, string password, out int memberId)
        {
            MemberObject member = memberRepository.CheckLogin(email, password);

            if (member != null)
            {
                memberId = member.MemberId;
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Login", "User Login");
                memberId = -1;
            }
            return false;
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (checkLoginAdmin(txtEmail.Text, txtPassword.Text))
            {
                frmMain f = new frmMain();
                f.Show();
                this.Hide();
            }
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            int memberId;
            if (checkLogin(txtEmail.Text, txtPassword.Text, out memberId))
            {
                frmMainUser fmu = new frmMainUser(memberId);
                fmu.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

