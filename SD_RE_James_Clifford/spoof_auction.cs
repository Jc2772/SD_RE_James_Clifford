using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_RE_James_Clifford
{
    public partial class spoof_auction
    {
        private List<string> auction_date = new List<string> { "Monday 28 November 2022"};
        private List<string> times = new List<string> { "09:00", "09:20", "09:40", "10:00", "10:20", "10:40", "12:00", "12:20", "12:40", "13:00", "13:20", "13:40"};
        private List<string> timeslots = new List<string> { "Monday 28 November 2022 09:00", "Monday 28 November 2022 09:20", "Monday 28 November 2022 09:40", "Monday 28 November 2022 10:00", "Monday 28 November 2022 10:20", "Monday 28 November 2022 10:40", "Monday 28 November 2022 12:00", "Monday 28 November 2022 12:20", "Monday 28 November 2022 12:40", "Monday 28 November 2022 13:00", "Monday 28 November 2022 13:20", "Monday 28 November 2022 13:40" };
        public List<string> getTimeslot()
        {
            return this.timeslots;
        }
        public void addAuction(String auction_date)
        {
            
            this.auction_date.Add(auction_date);
            for (int i = 0; i < times.Count; i++) {
                this.timeslots.Add(auction_date + " " + times[i]);
            }
        }
        public void removeAuction(String auctionDate,spoof_livestock livestock)
        {
            for (int i = timeslots.Count- 1 ; i >= 0; i--)
            {
                if (timeslots[i].Contains(auctionDate))
                {
                    timeslots.RemoveAt(i);
                }
            }
            auction_date.Remove(auctionDate);
            livestock.CancelLivestock(auctionDate);
        }
    }
}
