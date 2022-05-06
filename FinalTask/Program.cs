using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace FinalTask
{
        class Program
        {
            static void Main(string[] args)
            {

            string Path = @"C:\Users\peyur\OneDrive\Рабочий стол\Students";
            string Group150 = @"C:\Users\peyur\OneDrive\Рабочий стол\Students\Group150.txt";
            string Group151 = @"C:\Users\peyur\OneDrive\Рабочий стол\Students\Group151.txt"; 
            string Group152 = @"C:\Users\peyur\OneDrive\Рабочий стол\Students\Group152.txt"; 
            string Group153 = @"C:\Users\peyur\OneDrive\Рабочий стол\Students\Group153.txt"; 

            BinaryFormatter bf = new BinaryFormatter();
               
                using (var fs = new FileStream(@"Students.dat", FileMode.OpenOrCreate))
                {
                    Student[] students = (Student[])bf.Deserialize(fs);
                    Console.WriteLine("Десериализовано");
                    foreach (var stud in students)
                  {
                    Console.WriteLine($"{stud.Name} {stud.Group} {stud.DateOfBirth}");
                    
                    if (stud.Group == "G-150")
                    {
                        using (BinaryWriter writer = new BinaryWriter(File.Open(Group150, FileMode.Append)))
                        {
                            
                            writer.Write($"Имя {stud.Name} дата рождения {stud.DateOfBirth} {Environment.NewLine}");    
                        }

                    }
                    if (stud.Group == "G-151")
                    {
                        using (BinaryWriter writer = new BinaryWriter(File.Open(Group151, FileMode.Append)))
                        {
                            
                            writer.Write($"Имя {stud.Name} дата рождения {stud.DateOfBirth}{Environment.NewLine}");
                        }
                    }
                    if (stud.Group == "G-152")
                    {
                        using (BinaryWriter writer = new BinaryWriter(File.Open(Group152, FileMode.Append)))
                        {
                              
                            writer.Write($"Имя {stud.Name} дата рождения {stud.DateOfBirth}{Environment.NewLine}");
                        }
                    }
                    if (stud.Group == "G-153")
                    {
                        using (BinaryWriter writer = new BinaryWriter(File.Open(Group153, FileMode.Append)))
                        {
                            
                            writer.Write($"Имя {stud.Name} дата рождения {stud.DateOfBirth}{Environment.NewLine}");
                        }
                    }

                 }

                }
            }
        }

        [Serializable]
        class Student
        {
            public string Name { get; set; }
            public string Group { get; set; }
            public DateTime DateOfBirth { get; set; }
        }
    
}


