using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1_3_
{ 
    public class JapaneseUIFactory : UIAbstractFactory
    {
        public Help getHelp()
        {
            return new JapaneseHelpImpl();
        }
        public Images getImages()
        {
            return new JapaneseImagesImpl();
        }
        public Locale getLocale()
        {
            return new JapaneseLocaleImpl();
        }
    }
}
