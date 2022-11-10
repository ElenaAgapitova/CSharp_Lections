// Рекурсия (дополнительная лекция) - лекция 7.

Console.Clear();

// Собрать строку с числами от а до b, а <= b.

string NumbersFor(int a, int b) // обычный способ решения задачи
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b) // решение с помощью рекурсии
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

// Console.Write(NumbersFor(1, 10));
// Console.WriteLine();
// Console.Write(NumbersRec(1, 10));

// Сумма чисел от 1 до N

int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 1) return 1;
    else return n + SumRec(n - 1);
}
// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));

// Факториал числа

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)
{
    if (n == 1 && n == 0) return 1;
    else return n * FactorialRec(n - 1);
}
// Console.WriteLine(FactorialFor(3));
// Console.WriteLine(FactorialRec(3));

// Вычислить а в степени n

int PowerFor(int a, int n)
{
    int result = a;
    for (int i = 2; i <= n; i++) result *= a;
    return result;
}
//Console.WriteLine(PowerFor(2,10));

int PowerRec(int a, int n)
{
    if (n == 0) return 1; // в данном случае не рассматриваем 0 в степени 0
    else return PowerRec(a, n - 1) * a;
    // тернарный оператор if(n == 0) ? 1 : Power(a, n -1)*a;
}
//Console.WriteLine(PowerRec(2,10));

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
//Console.WriteLine(PowerRecMath(2,10));

// Перебор слов (даны буквы, составить слова)

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++}{new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
// FindWords("аисв", new char[2]);
/*
string path = "C:/Users/User/Desktop/Developer/Лекции Notion/Программирование";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for(int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}
*/
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for(int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();
    for(int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = "C:/Users/User/Desktop/Developer"; 
CatalogInfo(path);

Console.ReadLine();