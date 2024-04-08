using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DACS.Models.DatabaseModel
{
    public class Phone : ValueAttributeDefault
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Không để trống tên")]
        [Length(1, 50, ErrorMessage = "Tên tối thiểu là 1 tối đa 50 ký tự")]
        public string Name { get; set; }
        //Khoá ngoại
        public List<PhoneCase> PhoneCases { get; set; }
        public List<PhoneImage> phoneImages { get; set; }
    }
}
