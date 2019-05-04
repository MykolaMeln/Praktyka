using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6_3_
{
    public class SimpleSpellChecker
    {
        public bool Check(string word) {
            if (word != "")
                return true;
            else
                return false;
        }
    }
}
