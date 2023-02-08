// Итоговый проект IT-специалист


Console.WriteLine("Пожалуйста введите число элементов");
int ColElement = Convert.ToInt32(Console.ReadLine());
string[] Massiv = new string [ColElement];
int ColPerRav3 = 0;

for (int i = 0; i < ColElement; i++)
{
    Console.WriteLine("Пожалуйста введите текст");
    Massiv[i] = Console.ReadLine();
}

var str = string.Join(" ", Massiv);
Console.WriteLine(str);




















































































