using GymDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDomain.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public async Task<Member> AddMemberAsync(Member member)
        {
            throw new NotImplementedException();
        }

        public async Task<Member> DeleteMemberAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Member>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Member> UpdateMemberAsync(Member member)
        {
            throw new NotImplementedException();
        }

        public async Task<Member> ViewAsync(int id)
        {            
            throw new NotImplementedException();
        }
    }
}
