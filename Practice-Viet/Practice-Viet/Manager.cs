using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Viet
{
    public class Manager : IManager
    {
        public Manager(List<Student> list)
        {
            List = list;
        }

        public List<Student> List { get; }

        public void Delete(string? code)
        {
            Student S = null;
            foreach (Student student in List)
            {
                if (student.Code == code)
                {
                    S = student;
                }
            }
            List.Remove(S);
        }

        public void InputList()
        {
            Console.WriteLine("Enter code:");
            string code = Console.ReadLine();
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            List.Add(new Student(code, name, age));
        }

        public void LoadFile()
        {
            try
            {
                string filename = @"..\..\..\data.txt";
                using (StreamReader sr = new StreamReader(filename))
                {
                    string item = sr.ReadLine();
                    while (item != null)
                    {
                        if (!item.Trim().Equals(""))
                        {
                            string[] s = item.Split('\t');
                            if (s.Length == 3)
                            {
                                string code = s[0];
                                string name = s[1];
                                int age;
                                if (CheckInt(s[2]))
                                {
                                    age = Convert.ToInt32(s[2]);
                                    if (!CheckCode(code))
                                    {
                                        List.Add(new Student(code, name, age));
                                    }
                                }
                            }
                        }

                        item = sr.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Load error:" + ex.Message);
            }
        }

        private bool CheckInt(string v)
        {
            try
            {
                int n = Convert.ToInt32(v);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool CheckCode(string code)
        {
            foreach (Student item in List)
            {
                if (item.Code.ToLower().Equals(code.ToLower().Trim()))
                {
                    return true;
                }
            }
            return false;
        }

        public void SaveFile()
        {
            try
            {
                string filename = @"..\..\..\data.txt";
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (Student student in List)
                        sw.WriteLine(student);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Save error:" + ex.Message);
            }
        }

        public void ShowList()
        {
            foreach (Student student in List)
                Console.WriteLine(student);
        }

        public void Update(string? code)
        {
            foreach (Student student in List)
            {
                if (student.Code == code)
                {
                    student.Name = Console.ReadLine();
                }
            }
        }
    }
}
