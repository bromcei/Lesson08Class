// See https://aka.ms/new-console-template for more information
using Lesson08_04Miskas;


Miskas Juozapine = new Miskas();

Juozapine.PasodintiMedi();
Juozapine.PasodintiMedi();
Juozapine.PasodintiMedi();

string res_string = "";
foreach (string medis in Juozapine.MedziuList)
{
    res_string += $"{medis}, ";
}

Console.WriteLine(res_string);
