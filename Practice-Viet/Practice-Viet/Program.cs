using Practice_Viet;

internal class Program
{
    static void Main(string[] args)
    {
        List<Student> list = new List<Student>();

        //Tạo 1 lớp trung gian để chứa các xử lý
        IManager m = new Manager(list);

        //Tạo menu các chức năng
        while (true)
        {
            Console.WriteLine("1.Input to list student.");
            Console.WriteLine("2.Show list student.");
            Console.WriteLine("3.Update information of student.");
            Console.WriteLine("4.Remove student by code.");
            Console.WriteLine("5.Save to file.");
            Console.WriteLine("6.Load from file.");
            Console.WriteLine("7.Report.");
            Console.WriteLine("0.Exit.");
            int option = Int32.Parse(Console.ReadLine());
            switch (option)
            {
                case 0:
                    {
                        return;
                    }
                case 1:
                    {
                        m.InputList();
                        break;
                    }
                case 2:
                    {
                        m.ShowList();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter code:");
                        string code = Console.ReadLine();
                        m.Update(code);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter code:");
                        string code = Console.ReadLine();
                        m.Delete(code);
                        break;
                    }
                case 5:
                    {
                        m.SaveFile();
                        break;
                    }
                case 6:
                    {
                        m.LoadFile();
                        break;
                    }
                case 7:
                    {

                        break;
                    }
            }
        }
    }
}