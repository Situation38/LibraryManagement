using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SimpleAPI.DAL.Entities
{

    [Table("book")]
    public class Book : BaseEntity
    {
        [MaxLength(50)]
        [Column("name")]
        public string Name { get; set; }

        [MaxLength(50)]
        [Column("editor")]
        public string Editor { get; set; }

        /// <summary>
        ///     Configuration
        /// </summary>

        [Column("library_id")]
        [ForeignKey("Library")]
        public int LibraryId { get; set; }

        /// <summary>
        ///  Object Mapping
        /// </summary>

        [JsonIgnore]
        public virtual Library Library { get; set; }
    }
}
