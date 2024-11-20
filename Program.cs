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
        }
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
    }
}
