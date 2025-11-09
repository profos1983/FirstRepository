const string MyName = "Jane";
WriteLine(MyName);

WriteLine("\t Привет, мир!");
WriteLine("\t Мне 27 года");
WriteLine("\t My name is \nJane");
WriteLine('\x23'); //Символ # в кодировке ASCII

WriteLine(true);
WriteLine(false);

WriteLine(5);

string name = "Alex";
int age = 42;
bool pet = false;
double legSize = 43.5;

WriteLine("My name is {0}", name);
WriteLine("My age is {0}", age);
WriteLine("Do I have a pet? {0}", pet);
WriteLine("My shoe is {0}", legSize);

DayOfWeek MyFavouriteDay = DayOfWeek.Friday;
WriteLine(MyFavouriteDay);
Console.ReadLine();

enum DayOfWeek: byte
{
    Monday = 1,
    Tuesday = 2, 
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
};

enum Semaphore: int
{
    Red = 100,
    Yellow = 200,
    Green = 300
}

