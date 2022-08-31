using System.ComponentModel.DataAnnotations.Schema;

namespace Rest.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
