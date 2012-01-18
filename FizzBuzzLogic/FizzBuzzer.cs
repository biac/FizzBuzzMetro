namespace FizzBuzzLogic
{
    public class FizzBuzzer
    {
        private int count;

        public string Say()
        {
            count++;

            bool is3の倍数 = (count % 3 == 0);
            bool is5の倍数 = (count % 5 == 0);

            if (is3の倍数 && is5の倍数)
                return string.Format("{0} - Fizz Buzz", count);

            if (is3の倍数)
                return string.Format("{0} - Fizz", count);

            if (is5の倍数)
                return string.Format("{0} - Buzz", count);

            return string.Format( "{0} - {1}", count, count);

            //TODO: string.Format()は、ひとつにまとめたい! (リファクタリング予定)
        }
    }
}
