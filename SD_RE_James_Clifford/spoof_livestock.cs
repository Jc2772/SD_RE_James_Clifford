using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_RE_James_Clifford
{
    public partial class spoof_livestock
    {
        private List<string> livestockType = new List<string> { "cattle","sheep","goat" };
        private List<string> livestockBreed = new List<string> { "Limousin", "Suffolk sheep", "Saanen" };
        private List<string> livestockAge = new List<string> { "3", "2", "2" };
        private List<string> livestockGender = new List<string> { "female", "male", "female" };
        private List<string> livestockTagNumber = new List<string> { "372211234510091", "234558839456932", "645452987631487" };
        private List<string> timeslots = new List<string> { "Monday 28 November 2022 09:00", "Monday 28 November 2022 09:20", "Monday 28 November 2022 09:40" };
        public void addValues(string livestockType,string livestockBreed,string livestockAge,string livestockGender, string livestockTagNumber, string timeslot)
        {
            this.livestockType.Add(livestockType);
            this.livestockBreed.Add(livestockBreed);
            this.livestockAge.Add(livestockAge);
            this.livestockGender.Add(livestockGender);
            this.livestockTagNumber.Add(livestockTagNumber);
            this.timeslots.Add(timeslot);
        }
        public string getTimeslot(int i)
        {
            return this.timeslots[i];
        }
        public int getSize()
        {
            return this.timeslots.Count;
        }
        
        public void CancelLivestock(String auctionDate)
        {
            for (int i = 0; i < timeslots.Count; i++)
            {
                if (timeslots[i].Contains(auctionDate))
                {
                    livestockType.RemoveAt(i);
                    livestockBreed.RemoveAt(i);
                    livestockAge.RemoveAt(i);
                    livestockGender.RemoveAt(i);
                    livestockTagNumber.RemoveAt(i);
                    timeslots.RemoveAt(i);
                }
            }
        }
    }
}
