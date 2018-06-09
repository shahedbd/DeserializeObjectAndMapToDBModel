using System;

namespace DeserializeObject.Model
{
    public class HoliDay
    {
        public long SL { get; set; }
        public Nullable<System.DateTime> HolidayStartDate { get; set; }
        public Nullable<System.DateTime> HolidayEndDate { get; set; }
        public string Notes { get; set; }
        public int Status { get; set; }
    }
}
