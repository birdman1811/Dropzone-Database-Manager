using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropzone_Database_Manager.DataStore
{
    public class Unit
    {
        string id;
        string faction;
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
        List<string> special;
        List<Weapon> weapons;
        List<string> extraRules;

        public Unit()
        {
            CounterMeasures = new List<string>();
            SquadSizeCoherancy = new List<string>();
            TransportOptions = new List<string>();
            Special = new List<string>();
            Weapons = new List<Weapon>();
            ExtraRules = new List<string>();
        }

        public Unit(string id, string faction, string name, int armour, int move, List<string> counterMeasures, int damagePoints, int points, string type, string category, int cqb, int fortitude, List<string> squadSizeCoherancy, string landingZone, List<string> transportOptions, List<string> special, List<Weapon> weapons, List<string> extraRules)
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
            this.Faction = faction;
        }

        public string Id { get => id; set => id = value; }
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
        public List<string> Special { get => special; set => special = value; }
        public List<Weapon> Weapons { get => weapons; set => weapons = value; }
        public string Faction { get => faction; set => faction = value; }

        public void AddWeapon(Weapon weapon)
        {
            Weapons.Add(weapon);
        }

        public void RemoveWeapon(Weapon weapon)
        {
            Weapons.Remove(weapon);
        }

        public void AddCM(string cm)
        {
            CounterMeasures.Add(cm);
        }

        public void RemoveCM(string cm)
        {
            CounterMeasures.Remove(cm);
        }

        public void AddSC(string sc)
        {
            SquadSizeCoherancy.Add(sc);
        }

        public void RemoveSC(string sc)
        {
            SquadSizeCoherancy.Remove(sc);
        }

        public void AddTransport(string transport)
        {
            TransportOptions.Add(transport);
        }

        public void RemoveTransport(string transport)
        {
            TransportOptions.Remove(transport);
        }

        public void AddExtraRule(string extraRule)
        {
            ExtraRules.Add(extraRule);
        }

        public void RemoveExtraRule(string extraRule)
        {
            ExtraRules.Remove(extraRule);
        }

        public void AddSpecialRule(string specialRule)
        {
            Special.Add(specialRule);
        }

        public void RemoveSpecialRule(string specialRule)
        {
            Special.Remove(specialRule);
        }
    }
}
