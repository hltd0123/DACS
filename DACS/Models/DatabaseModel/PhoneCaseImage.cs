using System.ComponentModel.DataAnnotations.Schema;

namespace DACS.Models.DatabaseModel
{
    public class PhoneCaseImage : Image
    {
        //Khoá ngoại
        public int PhoneCaseID { get; set; }
        public PhoneCase PhoneCaseLink { get; set; }
    }
}
