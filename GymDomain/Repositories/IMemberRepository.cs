using GymDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDomain.Repositories
{
    public interface IMemberRepository
    {
        public Member View(int id);
        public Member AddMember(Member member);
        public IEnumerable<Member> List();        
        public Member UpdateMember(Member member);
        public Member DeleteMember(int id);
    }
}
