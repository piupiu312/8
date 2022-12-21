using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8._1
{
    internal class Tablitsa
    {
        public void Sohr(Inform user)
        {
            string json = JsonConvert.SerializeObject(user);
            File.WriteAllText("score.json", json);
            Console.ReadKey();
        }
    }
}
