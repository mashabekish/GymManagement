using GymDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDomain.Repositories
{
    public interface IMemberSubscriptionRepository
    {
        public MemberSubscription View(int code);
        public MemberSubscription AddMemberSub(MemberSubscription memberSub);
        public IEnumerable<MemberSubscription> List();
        public MemberSubscription UpdateMemberSub(MemberSubscription memberSub);
        public MemberSubscription DeleteMemberSub(int id);
    }
}
