using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace SD_RE_James_Clifford
{
    public partial class livestock
    {
        OracleConnection connection;
        public livestock(OracleConnection connection)
        {
            this.connection = connection;
        }
        private List<string> livestockType = new List<string> { "cattle","sheep","goat" };
        private List<string> livestockBreed = new List<string> { "Limousin", "Suffolk sheep", "Saanen" };
        private List<string> livestockAge = new List<string> { "3", "2", "2" };
        private List<string> livestockGender = new List<string> { "female", "male", "female" };
        private List<string> livestockTagNumber = new List<string> { "372211234510091", "234558839456932", "645452987631487" };
        private List<string> timeslots = new List<string> { "Monday 28 November 2022 09:00", "Monday 28 November 2022 09:20", "Monday 28 November 2022 09:40" };
        private List<string> initial_bid = new List<string> { "75.00", "20.00", "30.00" };
        private List<string> status = new List<string> { "s", "u", "u" };
        private List<string> names = new List<string> { "Mike o Niell", "Thomas o Sullivan", "Patrick Griffian" };
        public void addValues(string livestockType,string livestockBreed,string livestockAge,string livestockGender, string livestockTagNumber, string timeslot,string initial_bid,string owner)
        {
            this.livestockType.Add(livestockType);
            this.livestockBreed.Add(livestockBreed);
            this.livestockAge.Add(livestockAge);
            this.livestockGender.Add(livestockGender);
            this.livestockTagNumber.Add(livestockTagNumber);
            this.timeslots.Add(timeslot);
            this.initial_bid.Add(initial_bid);
            this.status.Add("u");
            this.names.Add(owner);
        }
        
        public List<string> getLivestockType()
        {
            return livestockType;
        }
        public List<string> getLivestockBreed()
        {
            return livestockBreed;
        }
        public List<string> getLivestockAge()
        {
            return livestockAge;
        }
        public List<string> getLivestockGender()
        {
            return livestockGender;
        }
        
        public List<string> getLivestockTagNumber()
        {
            return livestockTagNumber;
        }
        public List<string> getTimeslot()
        {
            return this.timeslots;
        }
        public List<string> getinitialBid()
        {
            return this.initial_bid;
        }
        public List<string> getstatus()
        {
            return status;
        }
        /*public void CancelLivestock(String auctionDate)
        {
            for (int i = timeslots.Count - 1; i >= 0; i--)
            {
                if (timeslots[i].Contains(auctionDate))
                {
                    this.livestockType.RemoveAt(i);
                    this.livestockBreed.RemoveAt(i);
                    this.livestockAge.RemoveAt(i);
                    this.livestockGender.RemoveAt(i);
                    this.livestockTagNumber.RemoveAt(i);
                    this.timeslots.RemoveAt(i);
                    this.initial_bid.RemoveAt(i);
                }
            }
        }*/
        public void soldLivestock(string tag) {
            for(int i = 0; i < livestockTagNumber.Count; i++)
            {
                if (livestockTagNumber[i].Equals(tag))
                {
                    status[i] = "s";
                }
            }
        }
    }
}
