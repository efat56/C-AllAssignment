using static AssignmentDay3Level_1.Program;

namespace AssignmentDay3Level_1
{
    internal class Program
    {
        //delegate declaration....
        public delegate void voidDelegate();
        static void Main(string[] args)
        {
            voidDelegate del1 = print1;
            //print1();
            MyClass.ExecuteDelegate(del1);
           
        }

        private static void print1()
        {
            Console.WriteLine("This is a print1 method......");
        }
    }

    class MyClass
    {

        public static void ExecuteDelegate(voidDelegate del)
        {

            del();
        }

    }





}