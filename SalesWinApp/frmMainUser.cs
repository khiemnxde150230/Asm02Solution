using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMainUser : Form
    {
        private int memberId;
        IMemberRepository memberRepository = new MemberRepository();

        public frmMainUser(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
        }

        private void btnMemberDetail_Click(object sender, EventArgs e)
        {
            MemberObject memberInfo = memberRepository.GetMemberById(memberId);

            if (memberInfo != null)
            {
                frmMemberDetail fmd = new frmMemberDetail();

                //
                fmd.MemberRepository = memberRepository;
                fmd.MemberInfo = memberInfo;
                fmd.InsertOrUpdate = true;
                fmd.Show();
            }
            else
            {
                MessageBox.Show("Invalid user");
            }
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            frmOrderHistory foh = new frmOrderHistory(memberId);
            foh.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
