using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_RE_James_Clifford
{
    public partial class spoof_sales
    {
        private List<string> buyer_name = new List<string> {"bull McCabe"};
        private List<string> final_price = new List<string> { "80.00" };
        private List<string> buyer_contact = new List<string> {"087 219 1990" };
        private List<string> tag = new List<string> { "372211234510091"};

        public void setsales(string name,string final_price,string phone,string tag)
        {
            this.buyer_name.Add(name);
            this.buyer_contact.Add(phone);
            this.final_price.Add(final_price);
            this.tag.Add(tag);
        }
    }
}
