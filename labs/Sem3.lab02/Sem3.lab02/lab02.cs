using System;
using System.Collections.Generic;
using System.Text;
using Figures;

namespace Sem3.lab02
{
        class lab02
        {
            static void Main(string[] args)
            {
                Rectangle rect = new Rectangle(2, 3);
                rect.Print();
                Quadrat quad = new Quadrat(5);
                quad.Print();
                Circle circle = new Circle(3);
                circle.Print();
            }
        }
}
