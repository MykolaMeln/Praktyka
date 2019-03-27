using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1_3_
{
    public interface UIAbstractFactory
    {
        Help getHelp();
        Images getImages();
        Locale getLocale();
    }
    class USUIFactory : UIAbstractFactory
    {
        public Help getHelp()
        {
            return new USHelpImpl();
        }

        public Images getImages()
        {
            return new USImagesImpl();
        }

        public Locale getLocale()
        {
            return new USLocaleImpl();
        }

    }
}

