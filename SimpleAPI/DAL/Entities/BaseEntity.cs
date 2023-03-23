using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SimpleAPI.DAL.Entities
{
    public abstract class BaseEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [MaxLength(100)]
        public string? Code { get; set; }

        /// <summary>
        ///     userId of created action maker
        /// </summary>
        [MaxLength(100)]
        [JsonIgnore]
        public string CreatedBy { get; set; }

        /// <summary>
        ///     userid of maker user actions
        /// </summary>
        [MaxLength(100)]
        [JsonIgnore]
        public string UpdatedBy { get; set; }

        [JsonIgnore]
        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        ///     will be use to mark element as deleted elements
        /// </summary>
        [Required]
        [JsonIgnore]
        public bool IsActive { get; set; }

        /// <summary>
        ///     use before update entities
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="isActive"></param>
        public void BaseUpdate(string userId, bool isActive)
        {
            UpdatedAt = DateTime.Now;
            UpdatedBy = userId;
            IsActive = isActive;
        }

        /// <summary>
        ///     use before create element un entity
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="isActive"></param>
        public void BaseCreate(string userId, bool isActive)
        {
            CreatedAt = DateTime.Now;
            CreatedBy = userId;
            UpdatedAt = DateTime.Now;
            UpdatedBy = userId;
            this.IsActive = isActive;
        }
    }
}