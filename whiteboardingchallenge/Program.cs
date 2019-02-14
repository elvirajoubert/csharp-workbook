using System;

namespace whiteboardingchallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine();
            StringTransform result;
            string reversed;
            result = new StringTransform();
            reversed = result.Transform("hell");
            System.Console.WriteLine(reversed);

        }
    }

    class StringTransform
    {

        public string Transform(string v)
        {
            if (v == null)
            {
                throw new ArgumentNullException("v");
            }

            string result = String.Empty;
            int i;

            for (i = v.Length-1; i >= 0; i--)
            {
                result += v[i];
            }
            return result;

        }
    }

}

