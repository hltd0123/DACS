using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DACS.Models.DatabaseModel
{
    public class PhoneCase : ValueAttributeDefault
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Không để trống tên")]
        [Length(1, 50, ErrorMessage = "Tên tối thiểu là 1 tối đa 50 ký tự")]
        public string Name { get; set; }
        [Length(0, 100, ErrorMessage = "Tên tối thiểu là 0 tối đa 1-0 ký tự")]
        public string? Description { get; set; }
        public string? ImageUrlMainDisplayImage { get; set; }
        //Khoá ngoại
        public int PhoneID { get; set; }
        public Phone PhoneLink { get; set; }
        public List<PhoneCaseImage> phoneCaseImages { get; set; }
    }
}
