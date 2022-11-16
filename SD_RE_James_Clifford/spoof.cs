using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_RE_James_Clifford
{
    class spoof
    {
        private string[] AccName = new string[] {"Mike o Niell", "Thomas o Sullivan","Patrick Griffian"};
        private string[] AccAddress1 = new string[] { "Castleisland", "Kenmare", "Waterville" };
        private string[] AccPhone = new string[] { "087 5498 719", "087 9258 761", "087 5476 349" };
        private string[] AccEmail = new string[] {"None supplied", "TomOS@Hotmail.com", "None supplied" };
        private string getAccName(int num)
        {
            return this.AccName[num];
        }
        private string getAccAddress1(int num)
        {
            return this.AccAddress1[num];
        }
        private string getAccPhone(int num)
        {
            return this.AccPhone[num];
        }
        private string getAccEmail(int num)
        {
            return this.AccEmail[num];
        }
        private void addValues(string name,string address1,string phone,string email,int num)
        {

        }
    }
}
