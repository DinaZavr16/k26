using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CurrencyExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = 28.2;
            double eur = 32.8;


            Converter converter = new Converter(usd,eur);
            converter.Conv();
        }
    }
}
