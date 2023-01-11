Console.WriteLine("Введите предложение без знаков препинания, которое является палиндромом без учета пробелов и регистра");
string str = Console.ReadLine();
string str2 = "";
foreach (char c in str)
{
    str2= c + str2;
}
Console.WriteLine(str2);