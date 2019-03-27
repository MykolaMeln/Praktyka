using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pr1_3_
{
    public interface Locale
    {
        string getLocaleCountry();
    }
    public interface Images
    {
        string getImagesCountry();
    }
    public interface Help
    {
        string getHelpCountry();
    }
    class Program
    {
      
        static void Main(string[] args)
        {
            Client client = new Client();
            WriteLine("Run for Japan");
            string countryCode = "JP";
            client.Start(countryCode);

            WriteLine("Run example for US");
            countryCode = "US";
            client.Start(countryCode);

            WriteLine("Run for Error");
            countryCode = "DE";
            client.Start(countryCode);

            ReadKey();
        }
    }
}
