using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enum.WhatsAppEnums
{
    public class JsonItem
    {
        public List<TokenAndTokenExpireDate> users { get; set; }
        public VersionAndStatus meta { get; set; }
    }
}
