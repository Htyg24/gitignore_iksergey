int nomber;
string c;
for(int i = 0; i < 100000; i++)
{
    c = Convert.ToString(i);
    nomber = c.Length;
    while (nomber < 5)
    {
        Console.Write("0");
        nomber++;
    }
    Console.WriteLine(i);
}