using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Identity;

namespace OM.Auth.DataModels
{
    public class ApplicationUser: IdentityUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("create_date")]
        public DateTime CreateDate { get; set; }
        
        [Column("application_user_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationUserId { get; set; }

        [Column("status")] 
        public bool Status { get; set; } = true;
        
        [Column("email")]
        public override string Email { get; set; }

        [Column("application_user_pkey")]
        public override string Id { get; set; }

        [Column("username")]
        public override string UserName { get; set; }

        [Column("normalized_username")] 
        public override string NormalizedUserName { get; set; }

        [Column("concurrency_stamp")]
        public override string ConcurrencyStamp { get; set; }

        [Column("email_confirmed")]
        public override bool EmailConfirmed { get; set; }

        [Column("lockout_enabled")]
        public override bool LockoutEnabled { get; set; }

        [Column("lockout_end")]
        public override DateTimeOffset? LockoutEnd { get; set; }

        [Column("normalized_email")]
        public override string NormalizedEmail { get; set; }

        [Column("password_hash")]
        public override string PasswordHash { get; set; }

        [Column("phone_number")]
        public override string PhoneNumber { get; set; }

        [Column("security_stamp")]
        public override string SecurityStamp { get; set; }

        [Column("two_factor_enabled")]
        public override bool TwoFactorEnabled { get; set; }

        [Column("access_failed_count")]
        public override int AccessFailedCount { get; set; }

        [Column("phone_number_confirmed")]
        public override bool PhoneNumberConfirmed { get; set; }
        
    }
}