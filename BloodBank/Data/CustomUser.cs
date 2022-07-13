using Microsoft.AspNetCore.Identity;

namespace BloodBank.Data
{
    public class CustomUser:IdentityUser
    {
        public int? Sex { get; set; }

        public string Address { get; set; }

        public int? BloodGroupId { get; set; }

        public float? Weight { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
