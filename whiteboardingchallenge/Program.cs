using System;

namespace whiteboardingchallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            StringTransform transformer = new StringTransform();
            UpperCaseTransform transformer1 = new UpperCaseTransform();
            LowerCaseTransform transformer2 = new LowerCaseTransform();
            StringTransform[] allTransforms = new StringTransform[]

   {   
                transformer,
                transformer1,
                transformer2,
   };
            foreach (var item in allTransforms)
            {
                var result = item.Transform("cat");
                
                System.Console.WriteLine(result);
            }


        }
        public class StringTransform
        {
            public virtual string Transform(string v)
            {
                if (v == null)
                {
                    throw new ArgumentNullException("v");
                }

                string result = String.Empty;
                int i;

                for (i = v.Length - 1; i >= 0; i--)
                {
                    result += v[i];
                }
                return result;

            }
        }
        public class UpperCaseTransform : StringTransform
        {
            public override string Transform(string input)
            {
                return input.ToUpper();
            }
        }

        public class LowerCaseTransform : StringTransform
        {
            public override string Transform(string input)
            {
                return input.ToLower();
                
            }
        }
    }
}








