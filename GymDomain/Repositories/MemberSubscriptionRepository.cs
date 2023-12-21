using GymDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDomain.Repositories
{
    internal class MemberSubscriptionRepository : IMemberSubscriptionRepository
    {
        public Task<MemberSubscription> AddMemberSubAsync(MemberSubscription memberSub)
        {
            throw new NotImplementedException();
        }

        public Task<MemberSubscription> DeleteMemberSubAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MemberSubscription>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MemberSubscription> UpdateMemberSubAsync(MemberSubscription memberSub)
        {
            throw new NotImplementedException();
        }

        public Task<MemberSubscription> ViewAsync(int code)
        {
            throw new NotImplementedException();
        }
    }
}
