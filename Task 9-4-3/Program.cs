ChildInfo childInfo = GetParentInfo;
childInfo.Invoke(new Child());

static void GetParentInfo(Parent p)
{
    Console.WriteLine(p.GetType());
}