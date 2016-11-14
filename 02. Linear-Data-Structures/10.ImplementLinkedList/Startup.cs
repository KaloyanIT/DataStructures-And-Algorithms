using System;

namespace _10.ImplementLinkedList
{
    public class Startup
    {
        public static void Main()
        {
            var linkedList = new LinkedList<int>();
            var listItem = new ListItem<int>(1);

            linkedList.FirstItem = listItem;
            var newItem = linkedList.FirstItem.NextItem = new ListItem<int>(3);

            newItem.NextItem = new ListItem<int>(2);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}