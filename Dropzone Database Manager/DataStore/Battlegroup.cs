using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropzone_Database_Manager.DataStore
{
    class Battlegroup
    {
        int id;
        string name;
        int standardMin;
        int standardMax;
        int heavyMin;
        int heavyMax;
        int supportMin;
        int supportMax;
        int troopsMin;
        int troopsMax;
        int exoticMin;
        int exoticMax;
        int commandMin;
        int commandMax;
        int scoutMin;
        int scoutMax;
        int max;

        public Battlegroup()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int StandardMin { get => standardMin; set => standardMin = value; }
        public int StandardMax { get => standardMax; set => standardMax = value; }
        public int HeavyMin { get => heavyMin; set => heavyMin = value; }
        public int HeavyMax { get => heavyMax; set => heavyMax = value; }
        public int SupportMin { get => supportMin; set => supportMin = value; }
        public int SupportMax { get => supportMax; set => supportMax = value; }
        public int TroopsMin { get => troopsMin; set => troopsMin = value; }
        public int TroopsMax { get => troopsMax; set => troopsMax = value; }
        public int ExoticMin { get => exoticMin; set => exoticMin = value; }
        public int ExoticMax { get => exoticMax; set => exoticMax = value; }
        public int CommandMin { get => commandMin; set => commandMin = value; }
        public int CommandMax { get => commandMax; set => commandMax = value; }
        public int ScoutMin { get => scoutMin; set => scoutMin = value; }
        public int ScoutMax { get => scoutMax; set => scoutMax = value; }
        public int Max { get => max; set => max = value; }
    }
}
