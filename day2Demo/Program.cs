
Console.WriteLine("Hello World");
Student sObj = new Student(123,"Avinash","Delhi");
sObj.DisplayDetails(sObj);
sObj = new Student(124, "Mohan","Delhi");
sObj.DisplayDetails(sObj);
string[] cities = { "Agra","Pune","Chennai" };
int i = 0;
while (i < cities.Length)
{
Console.WriteLine(cities[i]);
i++;
}