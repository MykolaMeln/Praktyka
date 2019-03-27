using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1_3_
{
    public class USLocaleImpl : Locale
    {
        public string getLocaleCountry()
        {
            return "United States";
        }
    }
    public class USImagesImpl : Images
    {
        public string getImagesCountry()
        {
            return "United States";
        }
    }
    public class USHelpImpl : Help
    {
        public string getHelpCountry()
        {
            return "United States";
        }
    }
}
