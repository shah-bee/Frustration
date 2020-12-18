using System;
using System.Collections.Generic;
using System.Text;

namespace Frustration
{
    public class Diagram
    {
        public virtual void Draw() {
            Console.WriteLine("I am from base");
        }
    }

    public class Rect : Diagram {

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("I am rect");
            
        }
    }

    public class Circle : Diagram
    {
         public override void Draw()
        {
            Console.WriteLine("I am Circle");
            base.Draw();
        }
    }
}
