using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMembers();
        MemberObject GetMemberById(int memberId);
        void InsertMember(MemberObject member);
        void UpdateMember(MemberObject member);
        void DeleteMember(int memberId);
        MemberObject CheckLogin(string email, string password);
    }
}
