using GymDomain.Abstractions;
using GymDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymDomain.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly ApplicationDbContext _context;

        public MemberRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Member> AddMemberAsync(Member member)
        {
            _context.Members.Add(member);
            await _context.SaveChangesAsync();
            return member;
        }

        public async Task<Member> DeleteMemberAsync(int id)
        {
            var member = await _context.Members.FindAsync(id);

            if (member != null)
            {
                _context.Members.Remove(member);
                await _context.SaveChangesAsync();
            }

            return member;
        }

        public async Task<IEnumerable<Member>> ListAsync()
        {
            return await _context.Members.ToListAsync();
        }

        public async Task<Member> UpdateMemberAsync(Member member)
        {
            _context.Members.Update(member);
            await _context.SaveChangesAsync();
            return member;
        }

        public async Task<Member> ViewAsync(int id)
        {
            return await _context.Members.FindAsync(id);
        }
    }
}
