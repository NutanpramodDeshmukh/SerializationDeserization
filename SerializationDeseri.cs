using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Serialization
{
    [Serializable]
    public class Student
    { 
        public int Id { get; set; }

        public string Name { get; set; }

    }
    internal class SerializationDeseri
    {
        string path = @"C:\Users\Uday\OneDrive\Desktop\Serialization\binary.txt";
        public void Serializable()
        {
            List<Student> students = new List<Student>()
            { 
                new Student { Id=1, Name="nutan"},
                new Student { Id = 2, Name = "Nil" },
                new Student { Id = 3, Name = "nilima" }
            };
            FileStream stream = new FileStream(path, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, students);
            stream.Close();
            Console.WriteLine("Converting Object into binary");
            string binarytext = File.ReadAllText(path);
            Console.WriteLine(binarytext);
        }
        public void Deserialization()
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            List<Student> students = (List<Student>)formatter.Deserialize(stream);
            stream.Close();
            Console.WriteLine("Converting binary into object");
            foreach(var student in students)
            {
                Console.WriteLine(student.Id);
                Console.WriteLine(" "+student.Name);
                Console.WriteLine();
            }
        }


    }
}
