using GymDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDomain.Repositories
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        public Task<Subscription> AddSubscriptionAsync(Subscription sub)
        {
            throw new NotImplementedException();
        }

        public Task<Subscription> DeleteSubscriptionAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Subscription>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Subscription> UpdateSubscriptionAsync(Subscription sub)
        {
            throw new NotImplementedException();
        }

        public Task<Subscription> ViewAsync(int code)
        {
            throw new NotImplementedException();
        }
    }
}
