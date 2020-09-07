using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class LoginService
    {

        public static void WriteToFile(List<ILogin> changedItems) 
        {
            foreach (var item in changedItems)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
