using System.ComponentModel;

namespace DACS.Models.DatabaseModel
{
    public class ValueAttributeDefault
    {
        public ValueAttributeDefault() { }
        [DefaultValue(false)]
        public bool isBlocked { get; set; }
    }
}
