using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork170319
{
    class MyProtectedUniqueList : IEnumerable<string>
    {
        private List<string> words;
        public string MyKey { get; set; }

        public MyProtectedUniqueList (string key)
        {
            words = new List<string>();
            MyKey = key;
        }

        // 1
        public void Add(string s)
        {
            try
            {
                TryAdd(s);
               
            }
            catch (ArgumentNullException a)
            {
                Console.WriteLine(a.StackTrace);
                Console.WriteLine(a.Message);
            }
            catch (InvalidOperationException i)
            {
                Console.WriteLine(i.StackTrace);
                Console.WriteLine(i.Message);
            }
            
        }
            
        //1a + message
        private void TryAdd (string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException($"{s} is null");
            }
            if (words.Contains(s))
            {
                throw new InvalidOperationException($"{s} is alredy exsist");
            }
            else
            {
                words.Add(s);
            }

       
        }

        //2
        public void Remove (string s)
        {
            try
            {
                TryRemove(s);

            }
            catch (ArgumentNullException a)
            {
                Console.WriteLine(a.StackTrace);
                Console.WriteLine(a.Message);
            }
            catch (ArgumentException i)
            {
                Console.WriteLine(i.StackTrace);
                Console.WriteLine(i.Message);
            }
        }

        //2a
        private void TryRemove(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
            if (!words.Contains(s))
            {
                throw new ArgumentException();
            }
            else
            {
                words.Remove(s);
            }


        }

        //3
        public void RemoveAt (int x)
        {
         try
            {
                TryRemoveAt(x);
            }
            catch (ArgumentOutOfRangeException a)
            {
                Console.WriteLine(a.StackTrace);
                Console.WriteLine(a.Message);

            }
        }

        //3a
        private void TryRemoveAt (int x)
        {
            if (x < 0 || x >= words.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                words.RemoveAt(x);
            }
        }

        public void Clear (string key)
        {
            try
            {
                TryClear(key);
            }
            catch (AccessViolationException a)
            {
                Console.WriteLine(a.StackTrace);
                Console.WriteLine(a.Message);

            }
        }
        //4a
        private void TryClear (string key)
        {
             if (MyKey != key || words.Count == 0)
             {
                throw new AccessViolationException();
             }
           else if  (MyKey == key)
           {
                words.Clear();
           }
        
        }

        //5

        public void Sort (string key)
        {
            try
            {
                TrySort(key);
            }
            catch (AccessViolationException a)
            {
                Console.WriteLine(a.StackTrace);
                Console.WriteLine(a.Message);

            }
        }

        //5a 
        private void TrySort(string key)
        {
            if (MyKey != key || words.Count == 0)
            {
                throw new AccessViolationException();
            }
            else if (MyKey == key)
            {
                words.Sort();
            }
        }

        //6
        public override string ToString()
        {
           string result = null;
           foreach (string s in words)
           {
                result += s +"\n";   
           }
           return result;
        }

        //ienumerator interface
        public IEnumerator<string> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();

        }
    }
}
