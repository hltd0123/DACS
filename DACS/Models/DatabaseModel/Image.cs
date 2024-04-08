using System.ComponentModel.DataAnnotations;

namespace DACS.Models.DatabaseModel
{
    public class Image : ValueAttributeDefault
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Url { get; set; }
    }
}
