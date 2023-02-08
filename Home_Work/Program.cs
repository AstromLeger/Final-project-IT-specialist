// Итоговый проект IT-специалист


Console.WriteLine("Пожалуйста введите число элементов");
int ColElement = Convert.ToInt32(Console.ReadLine());
string[] Massiv = new string[ColElement];
int ColPerProm03 = 0;
string Text = null;
int ColVhod = 0;

for (int i = 0; i < ColElement; i++)
{
    Console.WriteLine("Пожалуйста введите текст");
    Massiv[i] = Console.ReadLine();
}

var str = string.Join(" ", Massiv);
Console.WriteLine(str);


for (int i = 0; i < ColElement; i++)
{
    Text = Massiv[i];
    if (Text.Length < 4 && Text.Length >= 0)
    {
        ColPerProm03 = ColPerProm03 + 1;
    }
}

string[] Massiv1 = new string[ColPerProm03];

for (int i = 0; i < ColElement; i++)
{
    Text = Massiv[i];
    if (Text.Length < 4 && Text.Length >= 0)
    {
        // int str2 = Text.Length;
        // Console.WriteLine(str2);
        Massiv1[0 + ColVhod] = Massiv[i];
        ColVhod = ColVhod + 1;
    }
}

var str1 = string.Join(" ", Massiv1);
Console.WriteLine(str1);












































































