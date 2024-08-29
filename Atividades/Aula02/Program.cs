using System.Reflection.Metadata.Ecma335;
using Aula02;

Person person = new ();
Console.WriteLine(person.Name);

//Person 1:
Person person1       
    = new Person ("Mauricio Gonzatto", 40);
Console.WriteLine(person1.Name);

//Person 2:
Person person2 = new ();
person2.Name = "Vladmir Ilich Ulyanov";
person2.Age = 70;
Console.WriteLine(person2.Name);

//Person 3:
Person person3 = new ()
{
    Name = "Leonel Brizola",
    Age = 80
};
Console.WriteLine(person3.Name);
