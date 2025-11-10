using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Exception
{
   class FileNotFoundException
    {
        static void Main()
        {
            try
            {
                using (StreamReader sr = new StreamReader("D/j"))
                {
                    string content = sr.ReadToEnd();
                    Console.WriteLine(content);
                }

            }
            catch(System.IO.FileNotFoundException ex)
            {
                Console.Write(ex.ToString());
            }
        }
    }

}
