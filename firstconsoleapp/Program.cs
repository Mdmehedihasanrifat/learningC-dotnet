class Test{

  public static int sum(int a,int b){

    return a+b;
  }
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

        string str =Convert.ToString(m);
        Console.WriteLine(str);
        // input from user
        string? userName = Console.ReadLine();
        Console.WriteLine($"Hello {userName}");
        // assignment operator
        int p = 10;
        int q = 20;
        p += q;
        Console.WriteLine(p);
        // conditional operator
        int r = 10; 
        int sInt = 20;
        int t = r > sInt ? r : sInt;
        Console.WriteLine(t);
        // logical operator
        bool u = true;
        bool v = false;
        Console.WriteLine(u && v);
        
    // conditonal statement
         int userAge=19;
    
    if (userAge>=18){
        Console.WriteLine("You are eligible to vote");}
    else{
        Console.WriteLine("You are not eligible to vote");
    }


    // switch statement

    int day=4;

    switch(day){

    case 1: Console.WriteLine("Sunday");
    break;
    case 2: Console.WriteLine("Monday");
    break;
    case 3: Console.WriteLine("Tuesday");
    break;
    case 4: Console.WriteLine("Wednesday");
    break;
    case 5: Console.WriteLine("Thursday");
    break;
    case 6: Console.WriteLine("Friday");
    break;
    case 7: Console.WriteLine("Saturday");
    break;
    default:Console.WriteLine("Invalid day");
    break;

    }



    //  loop
    for(int i=0;i<5;i++){
        Console.WriteLine(i);
    }



    // while loop

    while(userAge<25){
        Console.WriteLine(userAge);
        userAge++;

    }
   Console.WriteLine(sum(10,20));


    }
   

}