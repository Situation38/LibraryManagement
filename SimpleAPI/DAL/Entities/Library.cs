using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Text.Json.Serialization;

namespace SimpleAPI.DAL.Entities
{
    [Table("library")]
    public class Library : BaseEntity
    {
        [MaxLength(50)]
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        ///     relation mapping 
        /// </summary>

        [JsonIgnore]
        public ICollection<Book> Book { get; set; }
    }
}
