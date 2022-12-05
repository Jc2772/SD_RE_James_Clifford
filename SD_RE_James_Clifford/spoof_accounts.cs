using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_RE_James_Clifford
{
    public partial class spoof_accounts
    {
        private List<string> AccName = new List<string> { "Mike o Niell", "Thomas o Sullivan", "Patrick Griffian" };
        private List<string> AccAddress1 = new List<string> { "BallyHea", "Lisbabe", "Baslicon" };
        private List<string> AccAddress2 = new List<string> { "Castleisland", "Kenmare", "Waterville" };
        private List<string> AccAddress3 = new List<string> { "Kerry", "Kerry", "Kerry" };
        private List<string> AccPhone = new List<string> { "087 4667 264", "087 9258 761", "087 5476 349" };
        private List<string> AccEmail = new List<string> { "None supplied", "TomOS@Hotmail.com", "None supplied" };
        public List<string> getAccName()
        {
            return this.AccName;
        }
        public List<string> getAccAddress1()
        {
            return this.AccAddress1;
        }
        public List<string> getAccAddress2()
        {
            return this.AccAddress2;
        }
        public List<string> getAccAddress3()
        {
            return this.AccAddress3;
        }
        public List<string> getAccPhone()
        {
            return this.AccPhone;
        }
        public List<string> getAccEmail()
        {
            return this.AccEmail;
        }
        public void addValues(string name,string address1, string address2, string address3, string phone,string email)
        {
            
            this.AccName.Add(name);
            this.AccAddress1.Add(address1);
            this.AccAddress2.Add(address2);
            this.AccAddress3.Add(address3);
            this.AccPhone.Add(phone);
            this.AccEmail.Add(email);
            
        }
        public void updateValues(string name, string address1, string address2, string address3, string phone, string email,int id)
        {
            int num = id;
            this.AccName[num] = name;
            this.AccAddress1[num] = address1;
            this.AccAddress2[num] = address2;
            this.AccAddress3[num] = address3;
            this.AccPhone[num] = phone;
            this.AccEmail[num] = email;
        }
        public int getSize()
        {
            return this.AccName.Count;
        }
        public void removeAccounts(int id)
        {
            this.AccName.RemoveAt(id);
            this.AccAddress1.RemoveAt(id);
            this.AccAddress2.RemoveAt(id);
            this.AccAddress3.RemoveAt(id);
            this.AccPhone.RemoveAt(id);
            this.AccEmail.RemoveAt(id);
        }
    }
}
