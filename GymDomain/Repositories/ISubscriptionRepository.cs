using GymDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDomain.Repositories
{
    public interface ISubscriptionRepository
    {
        public Subscription View(int code);
        public Subscription AddSubsctiption(Subscription sub);
        public IEnumerable<Subscription> List();
        public Subscription UpdateSubscription(Subscription sub);
        public Subscription DeleteSubscription(int id);
    }
}
