﻿using GymDomain.Abstractions;
using GymDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymDomain.Repositories
{
    public class MemberSubscriptionRepository : IMemberSubscriptionRepository
    {
        private readonly ApplicationDbContext _context;

        public MemberSubscriptionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<MemberSubscription> AddMemberSubAsync(MemberSubscription memberSub)
        {
            _context.MemberSubscriptions.Add(memberSub);
            await _context.SaveChangesAsync();

            return memberSub;
        }

        public async Task<MemberSubscription> DeleteMemberSubAsync(int id)
        {
            var memberSub = await _context.MemberSubscriptions.FirstOrDefaultAsync(s => s.Id == id);

            if (memberSub != null)
            {
                memberSub.IsDeleted = true;  
                await _context.SaveChangesAsync();
            }

            return memberSub;
        }

        public async Task<IEnumerable<MemberSubscription>> ListAsync()
        {
            return await _context.MemberSubscriptions
                .Include(x => x.Member)
                .Include(y => y.Subscription)
                .AsNoTracking()
                .Where(memberSubscription => !memberSubscription.IsDeleted)
                .ToListAsync();
        }

        public async Task<MemberSubscription> UpdateMemberSubAsync(MemberSubscription memberSub)
        {
            _context.MemberSubscriptions.Update(memberSub);
            await _context.SaveChangesAsync();

            return memberSub;
        }

        public async Task<MemberSubscription> ViewAsync(int code)
        {
            return await _context.MemberSubscriptions.FindAsync(code);
        }
    }
}
