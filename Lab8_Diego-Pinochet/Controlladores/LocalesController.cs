using Lab8_Diego_Pinochet.CustomArgs;
using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_Diego_Pinochet.Controlladores
{
    public class LocalesController
    {
        List<Locales> localesList = new List<Locales>();
        SerializeClass serializeClass = new SerializeClass();

        Form1 form1;

        public LocalesController(Form form1)
        {
            Initialize();
            this.form1 = form1 as Form1;
            this.form1.AddLocalCreateLocalButton_Clicked += AddLocals;
            this.form1.InfoPanelChooseButton_Clicked += ShowLocals;
        }
        public void Initialize()
        {
            if (File.Exists("AllLocales.bin") == true) localesList = serializeClass.Load_Locales();
        }

        public static int ToInt32(string value)
        {
            if (value == null)
                return 0;
            return int.Parse(value, (IFormatProvider)CultureInfo.CurrentCulture);
        }

        private List<Locales> ShowLocals(object sender, LocalesEventArgs e)
        {
            return localesList;
        }
        private string AddLocals(object sender, LocalesEventArgs e)
        {
            string esp = e.EspecificText;
            string description = null;
            int parsedResult;

            if (localesList.Count != 0)
            {
                foreach (Locales local in localesList)
                {
                    if (e.IdentNumText == local.IdentifierNum)
                    {
                        description = "ERROR[!] No se pudo crear la restaurant";
                        return description;

                    }
                }
            }
            if (esp == "True" || esp == "False")
            {
                bool espBool = bool.Parse(esp);
                Restaurant restaurant = new Restaurant(e.NameText, e.IdentNumText, e.HoursText, espBool, "Rest");
                localesList.Add(restaurant);
                if (restaurant != null)
                {
                    serializeClass.Save_Locales(localesList);
                    return description;
                }
                else
                {
                    description = "ERROR[!] No se pudo crear la restaurant";

                }
            }
            else if (int.TryParse(esp, out parsedResult) == true)
            {
                int espInt = int.Parse(esp);
                Cine cine = new Cine(e.NameText, e.IdentNumText, e.HoursText, espInt, "Cine");
                localesList.Add(cine);
                if (cine != null)
                {
                    serializeClass.Save_Locales(localesList);
                    return description;
                }
                else
                {
                    description = "ERROR[!] No se pudo crear la cine";

                }
            }
            else
            {
                Tienda tienda = new Tienda(e.NameText, e.IdentNumText, e.HoursText, e.EspecificText, "Tienda");
                localesList.Add(tienda);
                if (tienda != null)
                {
                    serializeClass.Save_Locales(localesList);
                    return description;
                }
                else
                {
                    description = "ERROR[!] No se pudo crear la tienda";

                }
            }
            return description;    
        }
    }
}
