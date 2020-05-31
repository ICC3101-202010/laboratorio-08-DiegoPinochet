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
    public class Cine : Locales
    {
        private int numSala;

        public Cine(string OwnerName, int IdentifierNum, string AttentionHours, int NumSala, string LocalType)
        {
            this.ownerName = OwnerName;
            this.IdentifierNum = IdentifierNum;
            this.attentionHours = AttentionHours;
            this.numSala = NumSala;
            this.localType = LocalType;

        }
        public override string ToString()
        {
            return localType + ":\r\n" + "Dueño: " + ownerName + ", Número identificador: " + IdentifierNum + "\n Horario: " + attentionHours + ", Cantidad de salas: " + numSala.ToString() + ". ";
        }
    }
}
