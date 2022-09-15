using System.Collections;

namespace SD_340_W22SD_Lab3.Models
{
    public partial class Stop
    {
        public int Number { get; set; }
        public string Street { get; set; }
        public string Name { get; set; }
        public Direction Direction { get; set; }
        public List<ScheduledStop> StopSchedules { get; set; }
}
}
