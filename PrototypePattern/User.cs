using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class User : ICloneable
    {
        public string UserId { get; set; }
        public string Password { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

}
