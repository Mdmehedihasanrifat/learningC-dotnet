class Test{


    public static void Main(string[] args){
        System.Console.WriteLine("Hello World");
        // varibale declaration
        int a = 10;
        int b = 20;
        double c = 10.5;
        float e = 10.5f;
        string d= "Hello";
        bool f = true;

        Console.WriteLine($"{a}, {b}, {c}, {d}, {e}, {f}");

        // Type conversion

        // Implicit conversion  
        int x = 10;
        double y = x;
        Console.WriteLine(y);

        // Explicit conversion
        double m = 10.5;
        int n = (int)m;
        Console.WriteLine(n);

        string s =Convert.ToString(m);
        Console.WriteLine(s);
        // input from user
        string? userName = Console.ReadLine();
        Console.WriteLine($"Hello {userName}");
    }
}