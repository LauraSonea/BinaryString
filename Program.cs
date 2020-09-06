using System;

namespace BinaryString
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = "111000";
            var test1 = IsBinaryStringValid(string1);
            Console.WriteLine($"{string1} is {test1}");

            var string2 = "11010";
            var test2 = IsBinaryStringValid(string2);
            Console.WriteLine($"{string2} is {test2}");

            var string3 = "110010";
            var test3 = IsBinaryStringValid(string3);
            Console.WriteLine($"{string3} is {test3}");

            var string4 = "00000";
            var test4 = IsBinaryStringValid(string4);
            Console.WriteLine($"{string4} is {test4}");

            var string5 = "1001";
            var test5 = IsBinaryStringValid(string5);
            Console.WriteLine($"{string5} is {test5}");

            var string6 = "1010";
            var test6 = IsBinaryStringValid(string6);
            Console.WriteLine($"{string6} is {test6}");


            Console.ReadLine();
        }

        private static bool IsBinaryStringValid(string binaryString)
        {
            var stringLength = binaryString.Length;
            int ones = 0;
            int zeroes = 0;
            string substring = null;

            for (int i = 0; i < stringLength; i++)
            {
                if (binaryString[i] == '0')
                {
                     zeroes ++;
                }
                else
                {
                    if (binaryString[i] == '1')
                    {
                        ones ++;
                    }
                    else
                    {
                        return false;
                    }
                }
                substring = binaryString.Substring(0, i + 1);
                if (!IsSubstringValid(substring, i + 1))
                {
                    return false;
                }

            }
            if (ones == zeroes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsSubstringValid(string substring, int length)
        {
            int ones = 0;
            int zeroes = 0;
            for (int i = 0; i < length; i++)
            {
                if (substring[i] == '0')
                {
                    zeroes++;
                }
                else
                {
                    if (substring[i] == '1')
                    {
                        ones++;
                    }
                }
            }
            if (zeroes > ones)
            {
                return false;
            }
            return true;
        }
    }
}
