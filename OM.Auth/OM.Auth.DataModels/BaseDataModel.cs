using System.ComponentModel.DataAnnotations.Schema;

namespace OM.Auth.DataModels
{
    public abstract class BaseDataModel
    {
        [Column("status")]
        public virtual bool Status { get; set; } = true;
    }
}