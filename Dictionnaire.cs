using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionnaire
{
    class Dictionnaire
    {
        public static void Dictio()
        {
            Dictionary<char,List<string>> dictionnaire = new Dictionary<char, List<string>>();
            dictionnaire['b'] = new List<string> { "battre","boire","barboter" };
            dictionnaire['a'] = new List<string> {"adorer","apporter","améliorer"};
            dictionnaire['c'] = new List<string> { "croire", "crier", "cracher" };

            dictionnaire.Remove('c');

            Console.WriteLine(dictionnaire['a']);
            Console.WriteLine(dictionnaire['b']);


        }



    }
}
