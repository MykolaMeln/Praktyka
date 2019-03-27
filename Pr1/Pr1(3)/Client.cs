using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pr1_3_
{
    class Client
    {
        public void Start(string countryId)
        {
            UIAbstractFactory UIFactory = null;
            if (countryId.Equals("JP"))
            { UIFactory = new JapaneseUIFactory(); }
            if (countryId.Equals("US"))
            { UIFactory = new USUIFactory(); }

            if (UIFactory != null)
            {
                Help help = UIFactory.getHelp();
                WriteLine("Help for: " + help.getHelpCountry());

                Images images = UIFactory.getImages();
                WriteLine("UI images for: " + images.getImagesCountry());

                Locale locale = UIFactory.getLocale();
                WriteLine("UI locale for: " + locale.getLocaleCountry());
            }
            else
            {
                WriteLine("Error");
            }
        }
    }
}
