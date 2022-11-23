using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_RE_James_Clifford
{
    class spoof_accounts
    {
        private string[] AccName = new string[] {"Mike o Niell", "Thomas o Sullivan","Patrick Griffian"};
        private string[] AccAddress1 = new string[] { "Castleisland", "Kenmare", "Waterville" };
        private string[] AccPhone = new string[] { "087 4667 264", "087 9258 761", "087 5476 349" };
        private string[] AccEmail = new string[] {"None supplied", "TomOS@Hotmail.com", "None supplied" };
        public string getAccName(int num)
        {
            return this.AccName[num];
        }
        public string getAccAddress1(int num)
        {
            return this.AccAddress1[num];
        }
        public string getAccPhone(int num)
        {
            return this.AccPhone[num];
        }
        public string getAccEmail(int num)
        {
            return this.AccEmail[num];
        }
        public void addValues(string name,string address1,string phone,string email)
        {
            int num = AccName.Length + 1;
            this.AccName[num] = name;
            this.AccAddress1[num] = address1;
            this.AccPhone[num] = phone;
            this.AccEmail[num] = email;
        }
        public void updateValues(string name, string address1, string phone, string email,int id)
        {
            int num = id;
            this.AccName[num] = name;
            this.AccAddress1[num] = address1;
            this.AccPhone[num] = phone;
            this.AccEmail[num] = email;
        }
        public int getSize()
        {
            return this.AccName.Length;
        }
    }
}
