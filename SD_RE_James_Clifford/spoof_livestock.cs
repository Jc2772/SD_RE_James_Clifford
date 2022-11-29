using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_RE_James_Clifford
{
    class spoof_livestock
    {
        private string[] livestockType = new string[] {"cattle","sheep","goat" };
        private string[] livestockBreed = new string[] { "Limousin", "Suffolk sheep", "Saanen" };
        private string[] livestockAge = new string[] {"3", "2", "2" };
        private string[] livestockGender = new string[] {"female", "male", "female" };
        private string[] livestockTagNumber = new string[] { "372211234510091", "234558839456932", "645452987631487" };
        private string[] timeslots = new string[] { "Monday 28 November 2022 09:00", "Monday 28 November 2022 09:20", "Monday 28 November 2022 09:40"};
        private int num;
        public void addValues(string livestockType,string livestockBreed,string livestockAge,string livestockGender, string livestockTagNumber, string timeslot)
        {
            this.num = livestockType.Length + 1;
            this.livestockType[num] = livestockType;
            this.livestockBreed[num] = livestockBreed;
            this.livestockAge[num] = livestockAge;
            this.livestockGender[num] = livestockGender;
            this.livestockTagNumber[num] = livestockTagNumber;
            this.timeslots[num] = timeslot;
        }
        public string getTimeslot(int i)
        {
            return this.timeslots[i];
        }
        public int getSize()
        {
            return this.timeslots.Length;
        }
    }
}
