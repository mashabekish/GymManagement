﻿using GymDomain.Entities;
using GymWebApp.Models.MemberSubscription;

namespace GymWebApp.Models.Member
{
    public class MemberViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string IdCardNumber { get; set; }
        public string Email { get; set; }
    }
}
