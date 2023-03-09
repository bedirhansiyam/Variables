namespace Variables;
class Program
{
    static void Main(string[] args)
    {
        string str = "Hello World";
        char ch = '?';
        bool b = false;
        
        byte by = 1;
        sbyte sby = 2;

        int i = 1;
        uint ui = 123;
        Int16 i16 = 16;
        Int64 i64 = 64;

        float f = 10.2f;
        double d = 8.55;
        decimal dec = 4.123m;

        long l = -145123;
        ulong ul = 145123;

        DateTime date = DateTime.Now;
        
        // String sample
        string name = String.Empty;
        name = "Bedirhan";
        string surname = "Siyam";
        string fullName = name + " " + surname;

        // Int sample
        int number1 = 5;
        int number2 = 16;
        int sum = number1 + number2;

        // Boolean sample

        bool b1 = 10<5; // false

        // Variable conversion

        string str1 = "5";
        int i1 = 15;

        string resStr = str1 + i1.ToString();       // 2020
        int resInt = i1 + Convert.ToInt32(str1);    // 40

        string dateString = DateTime.Now.ToString("dd.mm.yyyy");  // 09.13.2023
        string hour = DateTime.Now.ToString("hh:mm");             // 02:33
    }
}
