using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Locales
    {
        List<Locales> listLocales = new List<Locales>();

        protected string ownerName;
        protected int identifierNum;
        protected string attentionHours;
        protected string localType;

        public int IdentifierNum { get => identifierNum; set => identifierNum = value; }
        public string LocalType { get => localType; set => localType = value; }
    }
}
