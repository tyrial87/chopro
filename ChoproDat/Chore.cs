using System;
using System.Collections.Generic;
using System.Text;

namespace ChoproDat
{
    public class Chore
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastCompletion { get; set; }
        public DateTime Added { get; set; }
        public decimal Cooldown { get; set; }
    }
}
