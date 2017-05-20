using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_1
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo dr = new DirectoryInfo("Task 1");
            FileInfo[] infos = dr.GetFiles();

            for(int i =0; i < infos.Length; i++)
            {
                StreamReader sr = new StreamReader(infos[i].FullName);
                string r = sr.ReadToEnd();
                Check(r, infos[i].Name);


            }


            Console.ReadKey();

        }    
        
        static void Check(string s, string name)
        {
            string[] arr = s.Split();

            int c = 0;

            List<int> a = new List<int>();
            List<int> b = new List<int>();

            for (int i = 1; i <= int.Parse(arr[0]); i++)
            {
                
                if(int.Parse(arr[0])%i == 0)
                {
                   a.Add(i);
                    
                }
                
            }
            for (int i = 1; i <= int.Parse(arr[1]); i++)
            {
                if (int.Parse(arr[1]) % i == 0)
                {
                    b.Add(i);
                }
            }

            for(int i =0; i<a.Count; i++)
            {
                for(int j=0; j<b.Count; j++)
                {
                    if(a[i] == b[j])
                    {
                        c++;
                    }
                }
            }


            if (c == 1)
            {
                Console.WriteLine(name + ": yes");
            }
            else
            {
                Console.WriteLine(name + ": no");
            }

            
        }  
    }
}
