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
    public class Tienda : Locales
    {
        private string category;

        public Tienda(string OwnerName, int IdentifierNum, string AttentionHours, string Category,string LocalType)
        {
            this.ownerName = OwnerName;
            this.IdentifierNum = IdentifierNum;
            this.attentionHours = AttentionHours;
            this.category = Category;
            this.localType = LocalType;

        }
        public override string ToString()
        {
            return localType + ":\r\n" + "Dueño: " + ownerName + ", Número identificador: " + IdentifierNum + " Horario: " + attentionHours + ", Categorias " + category + ". ";
        }

    }
}
