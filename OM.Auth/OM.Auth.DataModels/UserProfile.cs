using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OM.Auth.DataModels
{
    public class UserProfile: BaseDataModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserProfileId { get; set; }
        
        public Guid PKey { get; set; }
        
        [MaxLength(100)]
        [Column("nick_name", TypeName = "varchar(100)")]
        public string NickName { get; set; }
        
        [MaxLength(100)]
        [Column("first_name", TypeName = "varchar(100)")]
        public string FirstName { get; set; }
        
        [MaxLength(100)]
        [Column("last_name", TypeName = "varchar(100)")]
        public string LastName { get; set; }
        
        [MaxLength(100)]
        [Column("middle_name", TypeName = "varchar(100)")]
        public string MiddleName { get; set; }

        [Column("avatar_id")]
        public int? AvatarId { get; set; }
        
        [ForeignKey("AvatarId")]
        public virtual Avatar Avatar { get; set; }
        
        [Column("application_user_id")]
        public int ApplicationUserId { get; set; }

    }
}