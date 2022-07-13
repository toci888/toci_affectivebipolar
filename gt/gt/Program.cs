// See https://aka.ms/new-console-template for more information
using gt;

Console.WriteLine("Hello, World!");


DateValidator dateValidator = new DateValidator();

for (; ; )
{
    Console.WriteLine(" poadaj date ");
    string input = Console.ReadLine();
    string montht = dateValidator.GetMonth (input);  
    Console.WriteLine(montht);
}

PeselValidator peselValidator = new PeselValidator();

peselValidator.Validate("83093043212");
peselValidator.Validate("83083243212");

Miesiace tu = new Miesiace();

tu.GetCharacter("Tomek", 2);
tu.GetCharacter("Tomek Mirosław", 8);

tu.GetMonth("820524653");
tu.GetMonth("8209322653");

string pal = "abccba";

for (int i = 0, j=pal.Length-1; i < j; i++, j--)
{
    if (pal[i] != pal[j])
    {
        Console.WriteLine("nie");
    }
}

Console.WriteLine(pal);

Dictionary<int, string> dic = new Dictionary<int, string>()
{
    { 1, "styczeń" },
    { 7, "lipiec"},
    { 8, "sierpień"}
};

int month = 7;

if (dic.ContainsKey(month))
{
    DateTime dt = DateTime.Now;
    Int64 lol = DateTime.Now.Ticks;
    Console.WriteLine(dt);
    Console.WriteLine(dic[month]);
}