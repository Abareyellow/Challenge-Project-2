/*int employeeLevel = 201;
string employee = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
      title = "Junior Associate";
      break;
    case 200:
      title = "Senior Associate";
      break;
    case 300:
      title = "Manager";
      break;
    case 400:
      title = "Senior Manager";
      break;
    default:
      title = "Associate";
      break;
}

Console.WriteLine($"{employee}, {title}");*/

/*string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0]) {
    case "01":
      type = "Sweat Shirt";
      break;
    case "02":
      type = "T-Shirt";
      break;
    case "03":
      type = "Sweat pants";
      break;
    default:
      type = "Other";
      break;
}

switch (product[1]) {
    case "BL":
      color = "Black";
      break;
    case "MN":
      color = "Maroon";
      break;
    default:
      color = "White";
      break;
}

switch (product[2]) {
    case "S":
      size = "Small";
      break;
    case "M":
      size = "Medium";
      break;
    case "L":
      size = "Large";
      break;
    default:
      size = "One Size Fits All";
      break;
}

Console.WriteLine($"Product: {size} {color} {type}");*/

/*for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
}

Console.WriteLine();

for (int i = 10; i >= 0; i--) {
    Console.WriteLine(i);
}

Console.WriteLine();

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

Console.WriteLine();

for (int i = 0; i < 10; i++) 
{
    Console.WriteLine(i);
    if (i == 7) break;
}*/


/*for (int i = 1; i <= 100; i++) {
    Console.Write(i);

    if (i % 5 == 0 && i % 3 == 0) {
        Console.WriteLine(" - FizzBuzz");
    } else if (i % 3 == 0) {
        Console.WriteLine(" - Fizz");
    } else if (i % 5 == 0) {
        Console.WriteLine(" - Buzz");
    } else {
        Console.WriteLine();
    }
}*/

/*int current = random.Next(1, 11);

do 
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);*/

/*while (current >= 3) {
    Console.WriteLine(current);
    current = random.Next(1, 11);
}

Console.WriteLine($"Last number: {current}");*/


/*Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;

while (heroHealth > 0 && monsterHealth > 0) {
    int hero = random.Next(1, 11);
    int monster = random.Next(1, 11);

    heroHealth -= hero;
    monsterHealth -= monster;

    if (monsterHealth <= 0) {
        Console.WriteLine($"Monster was damaged and lost {monster} and now has {monsterHealth}.");
        Console.WriteLine("Hero wins!");
    } else if (heroHealth <= 0) {
        Console.WriteLine($"Hero was damaged and lost {hero} and now has {heroHealth}.");
        Console.WriteLine("Monster wins!");
    } else {
        Console.WriteLine($"Monster was damaged and lost {monster} and now has {monsterHealth}.");
        Console.WriteLine($"Hero was damaged and lost {hero} and now has {heroHealth}.");
    }
}*/
