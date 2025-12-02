//На основе скринкаста создайте консольное приложение, в котором реализуйте 
//демонстрацию ковариантности делегатов при помощи следующей модели классов:
partial class Program
{
    delegate Car HandlerMetod();

    static Lexus LexusHandler()
    {
        return null;
    }
    static Car CarHandler()
    {
        return null;
    }

    class Car { }
    class Lexus : Car { }

}