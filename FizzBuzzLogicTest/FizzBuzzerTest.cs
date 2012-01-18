using NUnit.Framework;
using FizzBuzzLogic;

namespace FizzBuzzLogicTest
{
    [TestFixture]
    public class FizzBuzzerTest
    {
        [TestCase(1, "1 - 1")]  //仮実装
        [TestCase(2, "2 - 2")]  //三角測量(上の仮実装と合わせて)
        [TestCase(3, "3 - Fizz")]   //明白な実装
        [TestCase(5, "5 - Buzz")]   //〃
        [TestCase(15, "15 - Fizz Buzz")]    //〃
        public void SayTest(int count, string expected)
        {
            //準備
            FizzBuzzer fb = new FizzBuzzer();
            string result = null;

            //実行
            for(int i = 0; i<count; i++)
                result = fb.Say();

            //検証
            Assert.AreEqual(expected, result);
        }
    }
}
