using System.Runtime.CompilerServices;

namespace class_0508_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caller call = new Caller();

            call.CallName(new Person());
            call.CallName(new Student());
        }
    }
}
