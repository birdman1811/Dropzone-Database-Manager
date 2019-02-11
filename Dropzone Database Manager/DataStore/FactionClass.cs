using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dropzone_Database_Manager.DataStore
{
    public class FactionClass
    {
        string name;
        string lore;
        string gamePlay;
        string imageurl;
        string _id;

        public FactionClass()
        {
        }

        public FactionClass(string name, string lore, string gamePlay, string imageurl)
        {
            this.Name = name;
            this.Lore = lore;
            this.GamePlay = gamePlay;
            this.Imageurl = imageurl;
        }

        public string Name { get => name; set => name = value; }
        public string Lore { get => lore; set => lore = value; }
        public string GamePlay { get => gamePlay; set => gamePlay = value; }
        public string Imageurl { get => imageurl; set => imageurl = value; }

        public void SetCouchID(string id)
        {
            this._id = id;
        }

        public string GetCouchID()
        {
            return this._id;
        }
    }
}
