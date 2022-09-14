namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedLists list = new LinkedLists();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs\n 1.Create LinkedList \n 2.Add Reversed order of Elements \n 3.Create LinkedList by Appending");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;
                    case 2:
                        list.AddInReverseOrder(56);
                        list.AddInReverseOrder(30);
                        list.AddInReverseOrder(70);
                        list.Display();
                        break;
                    case 3:
                        list.Appending(56);
                        list.Appending(30);
                        list.Appending(70);
                        list.Display();
                        break;
                }
            }
        }
    }
}