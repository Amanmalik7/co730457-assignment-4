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
                string line;
                string ln;
                int number = 0;


                while ((ln = file.ReadLine()) != null)
                    while ((line = file.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                        Beowulf.Add(ln);
                        if (line.Contains("Fare") == true && line.Contains("War") == false || line.Contains("Fare") == true && line.Contains("War") == false)
                        {
                            {
                                int x = counter - 1;

                                number++;
                            }
                            counter++;
                        }
                        Console.WriteLine($"The number of lines that contains *Fare* without the word *War* are {number}");



                        file.Close();
                        counter = File.ReadLines("").Count();
                        Console.WriteLine("total number of lines are" + counter);
                    }
            }
        }
    }
}
