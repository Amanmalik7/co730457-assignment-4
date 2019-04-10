using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace co730457_assignment_4
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
           

        }
        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:/Users/730457/beowulf.txt"))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                    {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();
                counter = File.ReadLines("").Count();
                Console.WriteLine("total number of lines are"+counter);
            }
        }
        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;
            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
        }
    }
}
