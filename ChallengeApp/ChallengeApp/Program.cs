string name;
char sex;
int age;

name = "Ewa";
sex = 'K';
age = 33;
//Console.WriteLine(name +", lat " +  age );

if (sex == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33 ");
}
else if ( sex !='K' && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}



