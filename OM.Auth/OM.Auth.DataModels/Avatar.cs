using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OM.Auth.DataModels
{
    public class Avatar
    {
        [Column("avatar_id")]
        public ulong AvatarId { get; set; }
        
        [Column("pkey")]
        public Guid PKey { get; set; }
        
        [Column("avatar_url")]
        [Required]
        [MaxLength(500)]
        public string AvatarUrl { get; set; }
    }
}