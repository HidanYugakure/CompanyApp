// See https://aka.ms/new-console-template for more information
using CompanyApp.Helpers;

Console.WriteLine("Hello, World!");
while (true)
{
Enter: string choice = Console.ReadLine();
    int result;
    bool isConvertable = int.TryParse(choice, out result);

    switch (result)
    {
        default:
            Helper.changeTextColor("Wrong Option", ConsoleColor.Red);
            goto Enter;
    }
}