class Employee
{
    public string Name;
    public int Age;
    public int Salary;
}

class ProjectManager: Employee
{
    public string ProjectName;
}

class Developer: Employee
{
    public string ProgrammingLanguage;
}

// Упражнение 7.1.5
class Food 
{
    public string Name;
}
class Vegetable: Food { }

class Fruit: Food { }

class Apple: Fruit { }

class Banana: Fruit { }

class Pear: Fruit { }

class Potato: Vegetable { }

class Carrot: Vegetable { }

// Упражнение 7.1.6
class Obj
{
    private string name;
    private string owner;
    private int lenght;
    private int count;

    public Obj(string name, string ownerName, int obfLenght, int count)
    {
        this.name = name;
        owner = ownerName;
        lenght = obfLenght;
        this.count = count;
    }
}

// Упражнение 7.1.10
class BaseClass
{
    protected string Name;

    public BaseClass(string name)
    {
        Name = name;
    }
}

class DerivedClass : BaseClass
{
    public string Description;

    public int Counter;

    public DerivedClass (string name, string description) : base(name) 
    {
        Description = description;
    }

    public DerivedClass(string name, string description, int counter) : base(name)
    {
        Counter = counter;
        Description = description;
    }

}
