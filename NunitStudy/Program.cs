using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NunitStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLargest t1 = new TestLargest();
            t1.LargestOf3();
        }

        public static void IsTrue(bool condition)
        {
            if (!condition) { 
                throw new Exception("错误");
            }
        }
    }

    public class Cmp
    {
        public static int Largest(int[] list)
        {
            if (list.Length == 0)
                throw new ArgumentException("largest:empty list");
            int index, max = 0;
            for (index = 0; index < list.Length - 1;index++ )
            {
                if (list[index] > max) {
                    max = list[index];
                }
            }

            return max;
        }
    }

    [TestFixture]
    public class TestLargest {
        [Test]
        public void LargestOf3() {
            Assert.AreEqual(9, Cmp.Largest(new int[] { 9, 8, 7 }));
            Assert.AreEqual(9, Cmp.Largest(new int[] { 8, 9, 7 }));
            Assert.AreEqual(9, Cmp.Largest(new int[] { 7, 8, 9 }));
        }
    }

}
