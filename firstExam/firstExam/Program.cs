namespace firstExam;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Natija :");
        var number = int.Parse(Console.ReadLine());

        
    }

    /*// 1-misol
    public static int AmountOfEvenElements(int number)
    {
        var resault = new List<int>();

        if (number % 2 == 0)
        {
            resault.Add(number);
        }
        return number;
    }*/

    /*// 2-misol
    public static bool BoolElementsLength(string[] text)
    {
        var resault = new List<bool>();
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Length >= 5 )
            {
                resault.Add(true);
                if (text[i].Length < 5)
                {
                    return false;
                }
            }
        }
        return false;
    }*/

    /*// 3-misol
    public static string ThreeFromTheStart (string text)
    {
        if (text.Length > 3)
        {
            text.Substring(0, 3);
        }
        return text;
    }*/

    /*// 4-misol
    public static bool StartingFromPdp(string text)
    {
        if (text.Length > 3 && text.StartsWith("PDP"))
        {
            text.Substring(0, 3);
            return true;
        }
        return false;
    }*/
}
