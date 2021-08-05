using System;

namespace TaskAddTwoNumbers
{

    /*
        Input: l1 = [2,4,3], l2 = [5,6,4]
        Output: [7,0,8]
        Explanation: 342 + 465 = 807.
        Example 2:
        Input: l1 = [0], l2 = [0]
        Output: [0]
        Example 3:
        Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
        Output: [8,9,9,9,0,0,0,1]
     */
    public static class ListNodeExtension
    {
        /// <summary>
        /// Получить значение узла
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static int GetValue(this ListNode node)
        {
            if(node.isEmpty())
                return 0;
            else
                return node.val;
        }
        /// <summary>
        /// Проверка пустой ли узел
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static bool isEmpty(this ListNode node)
        {
            if(node == null)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Длина списка
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static int Lenght(this ListNode node)
        {
            int count = 0;

            while(!node.isEmpty())
            {
                count++;
                node = node.next;
            }

            return count;
        }

        /// <summary>
        /// Печатает число
        /// </summary>
        /// <param name="node"></param>
        public static void Print(this ListNode node)
        { 
            while(!node.isEmpty())
            {
                Console.Write(node.val);
                node = node.next;
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Сравнивает два числа (ListNode) на равенство
        /// </summary>
        /// <param name="firstNode"></param>
        /// <param name="secondNode"></param>
        /// <returns></returns>
        public static bool EqualsValues(this ListNode firstNode, ListNode secondNode)
        {
            if(firstNode.Lenght() != secondNode.Lenght())
                return false;
            while(!firstNode.isEmpty())
            {
                if(firstNode.val != secondNode.val)
                    return false;
                firstNode = firstNode.next;
                secondNode = secondNode.next;
            }
            return true;
        }
        /// <summary>
        /// Неоптимальный метод добавляет Node в конец списка, т.к нет указателя на конец ListNode
        /// Но если добавить в класс указатель на конец списка - метод будет работать оптимально
        /// </summary>
        public static void Add(this ListNode startNode, ListNode value)
        {
            while(!startNode.next.isEmpty())
            {
                startNode = startNode.next;
            }
            startNode.next = value;
        }

    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        /// <summary>
        /// Константа для переноса значения десятка в следующий разряд
        /// </summary>
        public const int digit = 10;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        /// <summary>
        /// Неоптимальный конструктор
        /// </summary>
        /// <param name="arr">массив значений описывающий число</param>
        public ListNode(int[] arr)
        {
            if(arr == null)
                return;
            val = arr[0];
            foreach(var el in arr[1..(arr.Length)])
            {
                this.Add(new ListNode(el));
            }
        }
        /// <summary>
        /// Суммирует два числа представленные в виде списка ListNode
        /// </summary>
        /// <param name="l1">Первое число</param>
        /// <param name="l2">Второе число</param>
        /// <returns>Сумма чисел l1 и l2 в виде ListNode</returns>
        static public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode newNode = new ListNode();
            ListNode headNode = newNode;
            int sum;
            int shiftValue = 0;
            int surPlus;
            while(true)
            {
                sum = l1.GetValue() + l2.GetValue() + shiftValue;
                surPlus = sum % digit;
                shiftValue = sum / digit;
                newNode.val = surPlus;
                if(!l1.isEmpty())
                    l1 = l1.next;
                if(!l2.isEmpty())
                    l2 = l2.next;
                if(!l1.isEmpty() || !l2.isEmpty() || shiftValue != 0)
                {
                    newNode.next = new ListNode();
                    newNode = newNode.next;
                }
                else
                {
                    break;
                }
            }
            newNode = headNode;
            return newNode;
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {

            ListNode l1 = new ListNode(new int[] { 2, 4, 3 });
            ListNode l2 = new ListNode(new int[] { 5, 6, 4 });
            ListNode l4 = new ListNode(new int[] { 7, 0, 8 });
            ListNode l3 = ListNode.AddTwoNumbers(l1, l2);
            l3.Print();
            Console.WriteLine(l3.EqualsValues(l4));

        }
    }
}
