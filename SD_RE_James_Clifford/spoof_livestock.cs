using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_RE_James_Clifford
{
    class spoof_livestock
    {
        private string[] livestockType = new string[] { };
        private string[] livestockBreed = new string[] { };
        private string[] livestockAge = new string[] { };
        private string[] livestockGender = new string[] { };
        private string[] livestockTagNumber = new string[] { };
        private int num;
        public void addValues(string livestockType,string livestockBreed,string livestockAge,string livestockGender, string livestockTagNumber)
        {
            this.num = livestockType.Length + 1;
            this.livestockType[num] = livestockType;
            this.livestockBreed[num] = livestockBreed;
            this.livestockAge[num] = livestockAge;
            this.livestockGender[num] = livestockGender;
            this.livestockTagNumber[num] = livestockTagNumber;
        }
    }
}
