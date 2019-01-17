using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropzone_Database_Manager.DataStore
{
    class Unit
    {
        int id;
        string name;
        int armour;
        int move;
        List<string> counterMeasures;
        int damagePoints;
        int points;
        string type;
        string category;
        int cqb;
        int fortitude;
        List<string> squadSizeCoherancy;
        string landingZone;
        List<string> transportOptions;
        List<Rule> special;
        List<Weapon> weapons;
        List<string> extraRules;

        public Unit()
        {
        }

        public Unit(int id, string name, int armour, int move, List<string> counterMeasures, int damagePoints, int points, string type, string category, int cqb, int fortitude, List<string> squadSizeCoherancy, string landingZone, List<string> transportOptions, List<Rule> special, List<Weapon> weapons, List<string> extraRules)
        {
            this.Id = id;
            this.Name = name;
            this.Armour = armour;
            this.Move = move;
            this.CounterMeasures = counterMeasures;
            this.DamagePoints = damagePoints;
            this.Points = points;
            this.Type = type;
            this.Category = category;
            this.Cqb = cqb;
            this.Fortitude = fortitude;
            this.SquadSizeCoherancy = squadSizeCoherancy;
            this.LandingZone = landingZone;
            this.TransportOptions = transportOptions;
            this.Special = special;
            this.Weapons = weapons;
            this.ExtraRules = extraRules;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Armour { get => armour; set => armour = value; }
        public int Move { get => move; set => move = value; }
        public List<string> CounterMeasures { get => counterMeasures; set => counterMeasures = value; }
        public int DamagePoints { get => damagePoints; set => damagePoints = value; }
        public int Points { get => points; set => points = value; }
        public string Type { get => type; set => type = value; }
        public string Category { get => category; set => category = value; }
        public int Cqb { get => cqb; set => cqb = value; }
        public int Fortitude { get => fortitude; set => fortitude = value; }
        public List<string> SquadSizeCoherancy { get => squadSizeCoherancy; set => squadSizeCoherancy = value; }
        public string LandingZone { get => landingZone; set => landingZone = value; }
        public List<string> TransportOptions { get => transportOptions; set => transportOptions = value; }
        public List<string> ExtraRules { get => extraRules; set => extraRules = value; }
        internal List<Rule> Special { get => special; set => special = value; }
        internal List<Weapon> Weapons { get => weapons; set => weapons = value; }
    }
}
