using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropzone_Database_Manager.DataStore
{
    class Rule
    {
        int id;
        string ruleName;
        int amount;

        public Rule()
        {
        }

        public Rule(int id, string ruleName, int amount)
        {
            this.Id = id;
            this.RuleName = ruleName;
            this.Amount = amount;
        }

        public int Id { get => id; set => id = value; }
        public string RuleName { get => ruleName; set => ruleName = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}
