using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {

        public void DeleteMember(int memberId)
        {
            MemberDAO.Instance.Remove(memberId);
        }

        public MemberObject GetMemberById(int memberId)
        {
            return MemberDAO.Instance.GetMemberByID(memberId);
        }

        public IEnumerable<MemberObject> GetMembers()
        {
            return MemberDAO.Instance.GetMemberList();
        }

        public void InsertMember(MemberObject member)
        {
            MemberDAO.Instance.AddNew(member);
        }

        public void UpdateMember(MemberObject member)
        {
            MemberDAO.Instance.Update(member);
        }
        public MemberObject CheckLogin(string email, string password)
        {
            return MemberDAO.Instance.CheckLogin(email, password);
        }
    }
}
