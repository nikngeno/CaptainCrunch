namespace CaptainCrunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string EncordedWord1 = Encoder("NICK");
            Console.WriteLine(EncordedWord1);
            string EncordedWord2 = Encoder("nick");
            Console.WriteLine(EncordedWord2);

            string EncordedWord3 = Encoder2("NICK",5);
            Console.WriteLine(EncordedWord3);
            string EncordedWord4 = Encoder2("nick",5);
            Console.WriteLine(EncordedWord4);
        }
        //First method without a generalizied method the change in code is hardcoded - 13 
        public static string Encoder(string input)
        {
            char[] word = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c >= 'a' && c <= 'z')
                {
                    word[i] = (char)((c - 'a' + 13) % 26 + 'a');
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    word[i] = (char)((c - 'A' + 13) % 26 + 'A');
                }
                else
                {
                    word[i] = c;
                }
            }
            return new string(word);
        }
        //Second Method process which has been generalized has a second parameter that takes into account any given number
        public static string Encoder2(string input, int adder)
        {
            char[] word = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c >= 'a' && c <= 'z')
                {
                    word[i] = (char)((((c - 'a' + adder) % 26) + 26) % 26 + 'a');
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    word[i] = (char)((((c - 'A' + adder) % 26) + 26)% 26 + 'A');
                }
                else
                {
                    word[i] = c;
                }
            }
            return new string(word);
        }
    }
}
