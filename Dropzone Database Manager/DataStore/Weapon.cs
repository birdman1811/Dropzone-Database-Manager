using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropzone_Database_Manager.DataStore
{
    public class Weapon
    {
        
        string name;
        int energy;
        int shots;
        int accuracy;
        string rangeFull;
        string rangeCountered;
        int moveFire;
        string arc;
        List<string> special;
        bool optional;
        int optionalCost;

        public Weapon()
        {
            Special = new List<string>();
        }

        public Weapon(string name, int energy, int shots, int accuracy, string rangeFull, string rangeCountered, int moveFire, string arc, List<string> special, bool optional, int optionalCost)
        {
            
            this.Name = name;
            this.Energy = energy;
            this.Shots = shots;
            this.Accuracy = accuracy;
            this.RangeFull = rangeFull;
            this.RangeCountered = rangeCountered;
            this.MoveFire = moveFire;
            this.Arc = arc;
            this.Special = special;
            this.Optional = optional;
            this.OptionalCost = optionalCost;
        }

        
        public string Name { get => name; set => name = value; }
        public int Energy { get => energy; set => energy = value; }
        public int Shots { get => shots; set => shots = value; }
        public int Accuracy { get => accuracy; set => accuracy = value; }
        public string RangeFull { get => rangeFull; set => rangeFull = value; }
        public string RangeCountered { get => rangeCountered; set => rangeCountered = value; }
        public int MoveFire { get => moveFire; set => moveFire = value; }
        public string Arc { get => arc; set => arc = value; }
        public bool Optional { get => optional; set => optional = value; }
        public int OptionalCost { get => optionalCost; set => optionalCost = value; }
        public List<string> Special { get => special; set => special = value; }

        public void AddRule(string rule)
        {
            Special.Add(rule);
        }

        public void RemoveRule(string rule)
        {
            Special.Remove(rule);
        }

        public string FullString
        {
            get
            {
                if (this.Optional == true)
                {
                    return Name + "(Optional " +OptionalCost + "pts)";
                }
                else
                {
                    return Name;
                }
            }


        }


    }
}
