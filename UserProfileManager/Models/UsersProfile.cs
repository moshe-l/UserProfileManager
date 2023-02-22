using System;
using System.Collections.Generic;

#nullable disable

namespace UserProfileManager.Models
{
    public partial class UsersProfile
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
