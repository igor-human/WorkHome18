using AssemblyA;

namespace AssemblyB
{
    public class DerivedClass : BaseClass
    {
        public void CallBasePublicMethod()
        {
            // Виклик публічного методу базового класу
            PublicMethod();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Інстанціюємо похідний клас
            DerivedClass derived = new DerivedClass();

            // Викликаємо метод базового класу через похідний клас
            derived.CallBasePublicMethod();
        }
    }
}
