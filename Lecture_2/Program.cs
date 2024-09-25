//1.
//შემოწმება, რიცხვი დადებითია თუ უარყოფითი
//დაწერეთ პროგრამა, რომელიც იღებს მთელ რიცხვს და ამოწმებს, არის თუ არა რიცხვი დადებითი, უარყოფითი, ან ნულოვანი.


// pirveli varianti 

/*
Console.WriteLine("enter number:");
int num = Convert.ToInt32(Console.ReadLine());
*/


// Meore varianti

/*
Random random = new Random();
int num = random.Next(-1000, 1000);
Console.WriteLine(num);

if (num > 0)
{
    Console.WriteLine($"{num} is a positive");
}
else if (num < 0)
{
    Console.WriteLine($"{num} is a negative");
}
else
{
    Console.WriteLine($"{num} equals to Zero ");
}
*/

//2.
//შემოწმება, რიცხვი ლუწია თუ კენტი
//დაწერეთ პროგრამა, რომელიც იღებს მთელ რიცხვს და ამოწმებს, არის თუ არა ის ლუწი ან კენტი.




/*
Random random = new Random();
int num = random.Next(-1000, 1000);
Console.WriteLine(num);

int nashti = num % 2;

if (nashti == 1)
{
    Console.WriteLine($"{num} is odd");
}
else if (num == 0)
{
    Console.WriteLine($"{num} equals to Zero");
}
else
{
    Console.WriteLine($"{num} is odd ");
}

*/

// 3.
// შეფასების კატეგორიზაცია
//დაწერეთ პროგრამა, რომელიც იღებს სტუდენტის ქულას (0-დან 100-მდე)
//და ბეჭდავს შესაბამის ნიშანს შემდეგი სკალის მიხედვით:

/*
Random random = new Random();
int num = random.Next(0, 101);
Console.WriteLine(num);

if (num >= 90 && num <= 100)
{
    Console.WriteLine("A");
}
else if (num >= 80 && num < 90)
{
    Console.WriteLine("B");
}
else if (num >= 70 && num < 80)
{
    Console.WriteLine("C");
}
else if (num >= 60 && num < 70)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("F");
}
*/


//4.
//ნაკიანი წლის შემოწმება
//დაწერეთ პროგრამა, რომელიც ამოწმებს, არის თუ არა წელი ნაკიანი. წელი ნაკიანია თუ:
//იყოფა 4-ზე, მაგრამ
//არ იყოფა 100-ზე, თუ ის ასევე არ იყოფა 400-ზე.

/* Random random = new Random();
int year = random.Next(100, 3000);
Console.WriteLine(year);

if (year % 4 == 0)
{
    if (year % 100 == 0)
    {
        if (year % 400 == 0)
        {
            Console.WriteLine("Nakiani welia");

        }
        else
        {
            Console.WriteLine("Ar aris Nakiani weli");
        }
    }
    else
    {
        Console.WriteLine("Weli Nakiania");
    }
    }
else
    {
        Console.WriteLine("Ar aris Nakiani");
    }

*/

// 5.
// დაწერეთ პროგრამა, რომელიც იღებს მომხმარებლის შეყვანილ პაროლს და ამოწმებს,
//ემთხვევა თუ არა ის წინასწარ განსაზღვრულ პაროლს (მაგალითად, "secret123").
//თუ ემთხვევა, დაბეჭდეთ "Access Granted", თუ არ ემთხვევა, დაბეჭდეთ "Access Forbidden".

/*
Console.WriteLine("Sheiyvanet momxmareblis paroli");
string password = Console.ReadLine().ToLower();
if (password == "secret123")
{
    Console.WriteLine("Access Granted");
}
else
{
    Console.WriteLine("Access Forbidden");
}
*/


//6.
//სამი რიცხვიდან ყველაზე დიდის პოვნა
//დაწერეთ პროგრამა, რომელიც იღებს სამ რიცხვს და ბეჭდავს მათგან ყველაზე დიდს.

/*
Random random = new Random();

int first = random.Next();
Console.WriteLine($"First is: {first}");

int second = random.Next();
Console.WriteLine($"Second is: {second}");

int third = random.Next();
Console.WriteLine($"Third is: {third}");

if (first >= second && first >= third)
{
    Console.WriteLine($"Biggest is: {first}");
}
else if (second >= third && second >= first)
{
    Console.WriteLine($"Biggest is: {second}");
}
else
{
    Console.WriteLine($"Biggest is: {third}");
}
*/



//7.მარტივი კალკულატორი
//დაწერეთ პროგრამა, რომელიც მომხმარებლის შეყვანის საფუძველზე 
//ასრულებს მარტივ არითმეტიკულ ოპერაციებს (დამატება, გამოკლება, გამრავლება ან გაყოფა) ორ რიცხვზე.

/*
Console.WriteLine("sheiyvanet pirveli ricxvi");
int first = Convert.ToInt32(Console.ReadLine());

char sign = Convert.ToChar(Console.ReadLine());

Console.WriteLine("sheiyvanet meore ricxvi");
int second = Convert.ToInt32(Console.ReadLine());

if (sign == '-')
{
    Console.WriteLine($"First - Second = {first - second}");
}
else if (sign == '+')
{
    Console.WriteLine($"First + Second = {first + second}");
}
else if (sign == '*')
{
    Console.WriteLine($"First * Second = {first * second}");
}
else if (sign == '/')
{
    Console.WriteLine($"First * Second = {first / second}");
}
else if (sign == '%')
{
    Console.WriteLine($"First %(mod) Second = {first % second}");
}
else
{
    Console.WriteLine("Not found operator");
}
*/

//8.
//არჩევნების უფლებამოსილება
//დაწერეთ პროგრამა, რომელიც ამოწმებს, არის თუ არა პირი არჩევნებში ხმის მიცემისთვის უფლებამოსილი.
//პირი უნდა იყოს 18 წლის ან უფროსი.

/*
Random random = new Random();
int age = random.Next(0, 150);

Console.WriteLine(age);

if (age > 18 && age < 130)
{
    Console.WriteLine("Tkven gaqvt hmis micemis ufleba");
}
else
{
    Console.WriteLine("Tkven ar gaqvt hmis micemis ufleba");
}
*/


//9.
//დღის მისალმება საათის მიხედვით
//დაწერეთ პროგრამა, რომელიც იღებს მიმდინარე დროს (საათების მიხედვით) და განსაზღვრავს შესაფერის მისალმებას:
//დილა(5:00 - 11:59)(Good Morning)
//შუადღე(12:00 - 16:59)(Good Afternoon)
//საღამო(17:00 - 20:59)(Good Evening)
//ღამე(21:00 - 4:59)(Good Night)

// am varantshi switch-ებს gamoyeneba jobia

/*
Console.WriteLine("Sheiyvanet dro saatebshi GTM+4 formatshi");
int daytime = Convert.ToInt32(Console.ReadLine());
if (daytime >= 5 && daytime < 12)
{
    Console.WriteLine("Good Morning");
}
else if (daytime >= 12 && daytime < 17)
{
    Console.WriteLine("Good Afternoon)");
}
else if (daytime >= 17 && daytime < 21)
{
    Console.WriteLine("Good Evening)");
}
else if (daytime >= 21 && daytime < 5)
{
    Console.WriteLine("Good Night)");
}
else
{
    Console.WriteLine("cant find info");
}
*/

//10.შოპინგის ფასდაკლების კალკულატორი
//დაწერეთ პროგრამა, რომელიც ითვლის ჯამურ თანხას ფასდაკლების შემდეგ, შემდეგი წესებით:
//თუ შესყიდვის საერთო თანხა ნაკლებია $100-ზე, არ არის ფასდაკლება.
//თუ შესყიდვის საერთო თანხა არის $100 და $500 შორის, გამოიყენეთ 10% ფასდაკლება.
//თუ შესყიდვის საერთო თანხა $500-ზე მეტია, გამოიყენეთ 20% ფასდაკლება.

/*
Random random = new Random();

int check = random.Next(50, 800);
Console.WriteLine("total is :"+check);
if (check <100)
{
    Console.WriteLine("You wont receive a discount");
}
else if (check >= 100 &&  check < 500)
{
    double discount = check - check * 0.1 ;
    Console.WriteLine($"You got a 10% discount , total check is : {discount}");
}
else
{
    double discount = check - check * 0.2;
    Console.WriteLine($"You got a 20% discount , total check is : {discount}");
}
*/


//11.
//ასაკობრივი და ქვეყნის შეზღუდვების მიხედვით პროდუქტის შეძენა
//დაწერეთ პროგრამა, რომელიც ამოწმებს, შეუძლია თუ არა მომხმარებელს პროდუქტის შეძენა ასაკის და ქვეყნის მიხედვით.
//პროდუქტის შეზღუდვები ასეთია:
//აშშ - ში მომხმარებელი უნდა იყოს 21 წლის ან უფროსი.
//სხვა ქვეყნებში, მომხმარებელი უნდა იყოს 18 წლის ან უფროსი.
//თუ მომხმარებელი უფლებამოსილია შეძენისათვის, დაბეჭდეთ "შეძენა ნებადართულია",
//წინააღმდეგ შემთხვევაში "შეძენა აკრძალულია".


/*
Console.WriteLine("Enter Your Country");
string country = Console.ReadLine().ToLower();
Console.WriteLine("Enter Your Age");
int age = Convert.ToInt32(Console.ReadLine());

if (country == "usa" ||  country == "United States of America" || country == "U.S.A")
{
    if (age >= 21)
    {
        Console.WriteLine("შეძენა ნებადართულია");
    }
    else
    {
        Console.WriteLine("შეძენა აკრძალულია");
    }
}
else
{
    if (age > 18)
    {
        Console.WriteLine("შეძენა ნებადართულია");
    }
    else 
    { 
        Console.WriteLine("შეძენა აკრძალულია");
    }
}
*/


//12.
//სესხის უფლებამოსილება
//დაწერეთ პროგრამა, რომელიც განსაზღვრავს, არის თუ არა პირი სესხის მისაღებად უფლებამოსილი. პირობებია:
//პირი უნდა იყოს 18 წლის ან უფროსი.
//პირს უნდა ჰქონდეს მინიმუმ $25,000 წლიური შემოსავალი.
//თუ პირს შემოსავალი ნაკლები აქვს $25,000-ზე, ის შეიძლება იყოს უფლებამოსილი თანამონაწილის
//(თავდების) ყოლის შემთხვევაში.



Console.WriteLine("Enter Your Age");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Your Salary ($)");
int Salary = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    if(Salary >= 25000)
    {
        Console.WriteLine("სესხის მისაღებად უფლებამოსილი ბრძანდებით");
    }
    else
    {
        Console.WriteLine("თქვენი წლიური შემოსავალი არ აკმაყოფილებს მოთხოვნას ");
        Console.WriteLine("თუ გყავთ თანამონაწილე(თავდები) თქვენი მოთხოვნა დაკმაყოფილდება");
        Console.WriteLine("გყავთ თავდამდები? (yes/no)");
        string response = Console.ReadLine().ToLower();
        if (response == "yes")
        {
            Console.WriteLine("შეიყვანეთ თანამონაწილის სახელი და გვარი");
            string tanamonawile = Console.ReadLine();
            Console.WriteLine("თქვენი მოთხოვნა დაკმაყოფილდა თანამონაწილი: " + tanamonawile);
        }
        else
        {
            Console.WriteLine("თქვენი მოთხოვნა არ დაკმაყოფილდა");
        }
    }
}
else
{
    Console.WriteLine("მარტო სრულწოვნებს აქვთ უფლება სესხის აღების ");
}