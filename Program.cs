using System;

namespace StractHomework
{
    struct NewStruct
    {
        public int number; // haytarareluc chi kareli arjeq tal

        public void Method()
        {
            Console.WriteLine(number);
        }
        //public NewStruct() // aranc arjeqi kanstruktor Strukturayum chi linum
        //{

        //}
        public NewStruct(int x) // strukturayi bolor popoxakannerin petq e kanstruktorum arjeq tal
        {
            number = x;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            NewStruct structure; // = new NewStruct(); // ekzemplyar karelie stexcel nayev aranc new-i

            structure.number = 9; // minjev ogtagorcely partadir petq e arjeq tal

            structure.Method();

            Console.WriteLine(structure.number);
        }
    }
}
