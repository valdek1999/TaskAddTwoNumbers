using System;

namespace TaskAddTwoNumbers
{

    
    class Program
    {
        static void Main(string[] args)
        {
            // Лог в консоли. 
            ListNode l1 = new ListNode(new int[] { 2, 4, 3 });
            ListNode l2 = new ListNode(new int[] { 5, 6, 4 });
            ListNode l4 = new ListNode(new int[] { 7, 0, 8 });
            ListNode l3 = ListNode.AddTwoNumbers(l1, l2);
            l3.Print();
            Console.WriteLine(l3.EqualsValues(l4));

        }
    }
}
