using System.Linq;
/*
bool IsEven(int value)
{
    return value % 2 == 0;
}

bool iSEven(int value) => value % 2 == 0; // краткая форма кода выше
Console.Write(IsEven(5)); // выведет false

var IsEven = (int v) => v % 2 == 0; // еще одна форма записи
*/

int a = 12;
Console.WriteLine(a.GetType().Name);

var b = 12;
Console.WriteLine(b.GetType().Name);

/*var data = new int[] { 1, 2, 3, 4 }
            .Where(e => 0)
            .Select(e => new { q = e, w = e + 1 });
Console.WriteLine(data.GetType()); // выдаст непонятно что*/
