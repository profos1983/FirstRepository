partial class Program
{
    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }

    //class Employee
    //{
    //    public Department Department;
    //}

    //class Department
    //{
    //    public Company Company;
    //}

    //class Company
    //{
    //    public string Name;
    //}
}
