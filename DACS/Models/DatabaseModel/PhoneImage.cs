using System.ComponentModel.DataAnnotations.Schema;

namespace DACS.Models.DatabaseModel
{
    public class PhoneImage : Image
    {
        //Khoá ngoại
        public int PhoneID { get; set; }
        public Phone PhoneLink {  get; set; }
    }
}
