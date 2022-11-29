using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_RE_James_Clifford
{
    class spoof_auction
    {
        private string[] auction_date = new string[] {"Monday 28 November 2022"};
        private string[] times = new string[] { "09:00", "09:20", "09:40", "10:00", "10:20", "10:40", "12:00", "12:20", "12:40", "13:00", "13:20", "13:40"};
        private string[] timeslots = new string[] { "Monday 28 November 2022 09:00", "Monday 28 November 2022 09:20", "Monday 28 November 2022 09:40", "Monday 28 November 2022 10:00", "Monday 28 November 2022 10:20", "Monday 28 November 2022 10:40", "Monday 28 November 2022 12:00", "Monday 28 November 2022 12:20", "Monday 28 November 2022 12:40", "Monday 28 November 2022 13:00", "Monday 28 November 2022 13:20", "Monday 28 November 2022 13:40" };
        public string getTimeslot(int i)
        {
            return this.timeslots[i];
        }
        public int getSize()
        {
            return this.timeslots.Length;
        }
        public void addAuction()
        {

        }
    }
}
