//string name;
//char sex;
//int age;

//name = "Ewa";
//sex = 'K';
//age = 33;
////Console.WriteLine(name +", lat " +  age );

//if (sex == 'K' && age < 30)
//{
//    Console.WriteLine("Kobieta poniżej 30 lat");
//}
//else if (age == 33 && name == "Ewa")
//{
//    Console.WriteLine("Ewa, lat 33 ");
//}
//else if ( sex !='K' && age < 18)
//{
//    Console.WriteLine("Niepełnoletni Mężczyzna");
//}


//Policz ile razy wystąpiła liczba 


int number = 4566;
string numberAsString = number.ToString();
char[] letter = numberAsString.ToCharArray();

int[] counter = new int[10];

int[] wynik = new int[10];

List<int> list = new List<int>();

foreach (char letterChar in letter)
{

    for (int i = 0; i < 10; i++)
    {

        if (letterChar.ToString() == i.ToString())
        {
            counter[i] = counter[i] + 1;
        }
        else if (counter[i] == 0)
        {
            counter[i] = 0;
        }
        Console.WriteLine(counter[i]);
    }

}


for (int i = 0; i < wynik.Length; i++)
{
    Console.WriteLine(i + " wystąpiło " + counter[i] + " razy");
}