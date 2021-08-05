using NUnit.Framework;
using TaskAddTwoNumbers;

namespace NUnitTestTaskAddTwoNumbers
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ListNode l1 = new ListNode(new int[] { 2, 4, 3 });
            ListNode l2 = new ListNode(new int[] { 5, 6, 4 });
            ListNode l3 = new ListNode(new int[] { 7, 0, 8 });
            Assert.IsTrue(ListNode.AddTwoNumbers(l1,l2).EqualsValues(l3));
        }

        [Test]
        public void Test2()
        {
            ListNode l1 = new ListNode(new int[] { 0 });
            ListNode l2 = new ListNode(new int[] { 0 });
            ListNode l3 = new ListNode(new int[] { 0 });
            Assert.IsTrue(ListNode.AddTwoNumbers(l1, l2).EqualsValues(l3));
        }

        [Test]
        public void Test3()
        {
            ListNode l1 = new ListNode(new int[] { 9, 9, 9, 9, 9, 9, 9 });
            ListNode l2 = new ListNode(new int[] { 9, 9, 9, 9 });
            ListNode l3 = new ListNode(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 });
            Assert.IsTrue(ListNode.AddTwoNumbers(l1, l2).EqualsValues(l3));
        }

        [Test]
        public void Test4()
        {
            ListNode l1 = new ListNode(new int[] { 5 });
            ListNode l2 = new ListNode(new int[] { 5, 0, 0 , 5 });
            ListNode l3 = new ListNode(new int[] { 0, 1, 0, 5});
            Assert.IsTrue(ListNode.AddTwoNumbers(l1, l2).EqualsValues(l3));
        }
    }
}