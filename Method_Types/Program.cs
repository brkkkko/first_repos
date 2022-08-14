Console.Clear();

// Type 1

void Method1()
{
    Console.WriteLine("Text of Method1");
}

Method1();

// Type 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg: "Test of Method2");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21(msg: "Test of Method21", count: 4); // Аргументы можно писать в любом порядке

// Type 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Type 4

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, " Text of Method4 ");
Console.WriteLine(res);