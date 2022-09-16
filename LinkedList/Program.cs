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
                Console.WriteLine("Select Programs\n 1. Create LinkedList \n 2. Add Reversed order of Elements \n 3. Create LinkedList by Appending " +
                    "\n 4. Insert At Required Position \n 5. Deleting First Position Element \n 6. Deleting Last Position Element \n 7. Search the Node" +
                    " \n 8. Insert Node After Particular Node \n 9. Delete Node At Particular Position \n 10. Ascending Order Sort");
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
                    case 4:
                        list.Add(56);
                        list.InsertAtRequiredPosition(2,30);
                        list.Add(70);
                        list.Display();
                        break;
                    case 5:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.DeletingFirstPosition();
                        list.Display();
                        break;
                    case 6:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.DeletingLastPosition();
                        list.Display();
                        break;
                    case 7:
                        list.Search(30);
                        list.Display();
                        break;
                    case 8:
                        list.InsertNodeAfterParticularNode(40, 30);
                        list.Display();
                        break;
                    case 9:
                        list.DeleteNodeAtParticularPosition(2);
                        list.Size();
                        list.Display();
                        break;
                    case 10:
                        list.AscendingOrderSort(56);
                        list.AscendingOrderSort(30);
                        list.AscendingOrderSort(40);
                        list.AscendingOrderSort(70);
                        list.Display();
                        break;
                }
            }
        }
    }
}