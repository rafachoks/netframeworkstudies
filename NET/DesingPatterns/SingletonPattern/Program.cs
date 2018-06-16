using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*GOF Defination: Ensure a class has one instance, and provide a global point to access*/


namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager.Instance.WriteLog("Hello Singleton Pattern");
        }

        /*advantages: Instace Reuse makes Effective Mmemory Manager*/
    }
}
