using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Restaurant: Locales
    {
        private bool vipTables;

        public Restaurant(string OwnerName, int IdentifierNum, string AttentionHours, bool VipTables, string LocalType)
        {
            this.ownerName = OwnerName;
            this.IdentifierNum = IdentifierNum;
            this.attentionHours = AttentionHours;
            this.vipTables = VipTables;
            this.localType = LocalType;
        }

        public override string ToString()
        {
            return "Restaurante: " + " Dueño: " + ownerName + ", Número identificador: " + IdentifierNum + "\n Horario: " + attentionHours + ", Mesas VIP: " + vipTables.ToString() + ". ";
        }
    }
}
