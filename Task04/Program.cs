namespace MyNamespace
{
    public class MyClass
    {
        public void MyMethod()
        {
            Console.WriteLine("Це метод з окремого файлу підключеній до 2 проги");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myParam = new MyClass();
            myParam.MyMethod();
        }
    }
}
