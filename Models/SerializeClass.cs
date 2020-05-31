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
    public class SerializeClass
    {
        public void Save_Locales(List<Locales> listL)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("AllLocales.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, listL);
            formatter.Serialize(stream, "\n");
            stream.Close();
        }
        public List<Locales> Load_Locales()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("AllLocales.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Locales> listL = (List<Locales>)formatter.Deserialize(stream);
            stream.Close();
            return listL;
        }
    }
}
