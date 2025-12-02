ShowMessageDelegate showMessageDelegate = (_message) =>
{
    Console.WriteLine(_message);
};
showMessageDelegate.Invoke("Hello World!");



//static void ShowMessage(string _message)
//{
//    Console.WriteLine(_message);
//}
//delegate void ShowMessageDelegate(string _message);


RandomNumberDelegate randomNumberDelegate = () =>
{
    return new Random().Next(0, 100);
};
int result = randomNumberDelegate.Invoke();
Console.WriteLine(result);
Console.Read();

delegate void ShowMessageDelegate(string name);
delegate int RandomNumberDelegate();