using System;

namespace OOP_ShapesProject {

    class Program {

        static void Main(string[] args) {

            var sqrcomp = new SquareComp(5);
            var p = sqrcomp.GetPerimeter();
            var a = sqrcomp.GetArea();
            Console.WriteLine($"The SqrComp perimeter is {p} and area is {a}");
             
            var quad1 = new Quad(5, 7, 13, 6);

            var perimeter = quad1.GetPerimeter();

            Console.WriteLine($" The quad perimeter is {perimeter}");

            var rect1 = new Rect(5, 13);

            perimeter = rect1.GetPerimeter();
            var Area = rect1.GetArea();

            Console.WriteLine($" The rect perimeter is {perimeter}; area is {Area}");

            var square1 = new Square(5);

            perimeter = square1.GetPerimeter();
            Area = square1.GetArea();

            Console.WriteLine($" The square perimeter is {perimeter}; area is {Area}"); 
        }
    }
}
