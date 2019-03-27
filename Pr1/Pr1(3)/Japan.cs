using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1_3_
{
    public class JapaneseLocaleImpl : Locale
    {
        public string getLocaleCountry()
        {
            return "Japan";
        }
    }
    public class JapaneseImagesImpl : Images
    {
        public string getImagesCountry()
        {
            return "Japan";
        }
    }
    public class JapaneseHelpImpl : Help
    {
        public string getHelpCountry()
        {
            return "Japan";
        }
    }
}
