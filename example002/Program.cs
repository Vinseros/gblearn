// пример метода не возвращает, не принимает
void Method1()
{
    Console.WriteLine("Это метод не вовращает не принимает");
}
Method1();

// пример метода не возвращает, принимает
void Method2(string msg1, string msg2)
{
    Console.WriteLine("Это метод принимает 2 аргумента");
    Console.WriteLine(msg1, msg2);
}
Method2(msg1: "первый аргумент", msg2: "второй аргумент");

// пример метода возвращает, не принимает
int Method3()
{
    return DateTime.Now.Year;
}
Console.WriteLine(Method3());

// пример метода принимает, возвращает
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    for (i = 0; i < count; i++)
    {
        result += c;
    }
    return result;
}
Console.WriteLine(Method4(10, "ТекстN")); 