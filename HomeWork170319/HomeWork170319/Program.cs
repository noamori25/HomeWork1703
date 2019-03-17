using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork170319
{
    class Program
    {
        static void Main(string[] args)
        {
            MyProtectedUniqueList m = new MyProtectedUniqueList("noam");
            MyProtectedUniqueList n = new MyProtectedUniqueList("shubi dubi");
            string a = "nomm";
            string b = "noamm";
            string c = "noamm";
            string d = null;
            string e = "no";
            string f = "sd";
            string h = "ret";


            m.Add(a);
            m.Add(b);
            m.Add(c);
            m.Add(d);
            m.Add(e);
            m.Add(f);
            m.Add(h);



            m.Remove(a);
            m.Remove(d);
            m.Remove(e);

            m.RemoveAt(3);
            m.RemoveAt(-1);
            m.RemoveAt(0);

            m.Clear("noa");
            n.Clear("shubi dubi");
            m.Clear("noam");


            string aa = "b";
            string cc = "a";
            string bb = "L";
            string hh = "c";

            m.Add(aa);
            m.Add(cc);
            m.Add(bb);
            m.Add(hh);
            m.Sort("noam");
            Console.WriteLine(m);


        }
    }
}
