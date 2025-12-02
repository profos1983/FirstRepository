
int x = 5;
int y = 0;
int? z = null;
Calc3(x, y, out z);
Console.WriteLine(z.ToString());
Console.WriteLine("==================");

// реализация шаблонного делегата типа Action:
Action showMassegeDelegate = ShowMessage;
showMassegeDelegate.Invoke();

// реализация шаблонного делегата типа Func:
Func <int, int, int, int> sumDelegate = Sum;
int result = sumDelegate(5, 4, 3);
Console.WriteLine(result);

// реализация шаблонного делегате Prelicate:
Predicate<string> checkLenghtDelegate = CheckLength;
bool status = checkLenghtDelegate("skill_factory");
Console.WriteLine(status);

//ShowMessageDelegate showMessageDelegate = ShowMessage;
//showMessageDelegate.Invoke();

//SumDelegate sumDelegate = Sum;
//int result = sumDelegate.Invoke(1, 30, 120);
//Console.WriteLine(result);

//CheckLengthDelegate checkLengthDelegate = CheckLength;
//bool status = checkLengthDelegate.Invoke("skill_factory");
//Console.WriteLine(status);


delegate void ShowMessageDelegate();
delegate int SumDelegate(int a, int b, int c);
delegate bool CheckLengthDelegate(string _row);


