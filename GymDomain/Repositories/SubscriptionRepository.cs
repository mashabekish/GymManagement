﻿using GymDomain.Abstractions;
using GymDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymDomain.Repositories
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly ApplicationDbContext _context;

        public SubscriptionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Subscription> AddSubscriptionAsync(Subscription sub)
        {
            _context.Subscriptions.Add(sub);
            await _context.SaveChangesAsync();

            return sub;
        }

        public async Task<Subscription> DeleteSubscriptionAsync(int id)
        {
            var sub = await _context.Subscriptions.FindAsync(id);

            if (sub != null)
            {
                sub.IsDeleted = true;
                await _context.SaveChangesAsync();
            }

            return sub;
        }

        public async Task<IEnumerable<Subscription>> ListAsync()
        {
            return await _context.Subscriptions
                .AsNoTracking()
                .Where(s => !s.IsDeleted)
                .ToListAsync();
        }

        public async Task<Subscription> UpdateSubscriptionAsync(Subscription sub)
        {
            _context.Subscriptions.Update(sub);
            await _context.SaveChangesAsync();

            return sub;
        }

        public async Task<Subscription> ViewAsync(int code)
        {
            return await _context.Subscriptions.FindAsync(code);
        }
    }
}
