using System.Text;

Console.Write("Input the string you want to disemvowel: ");
string input = Console.ReadLine();
Console.Write("The disemvoweled string is: " + Disemvowel(input));
Console.ReadKey();

string Disemvowel(string str)
{

    char[] vowels = {'a', 'e', 'i', 'o', 'u',
                            'A', 'E', 'I', 'O', 'U'};
    List<char> list = vowels.OfType<char>().ToList();

    StringBuilder sBuilder = new StringBuilder(str);

    for (int i = 0; i < sBuilder.Length; i++)
    {
        if (list.Contains(sBuilder[i]))
        {
            sBuilder.Replace(sBuilder[i].ToString(), "");
            i--;
        }
    }
    return sBuilder.ToString();
}
