using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GeometryProject {

    public class Program {

        void Run1() {
            Square s1 = new Square();
            s1.SetSideLength(2);
            int perimeter = s1.CalcPerimeter();
            Debug.WriteLine(perimeter.ToString());
        }
        void Run() {
            Quadrillateral q1 = new Quadrillateral();
            q1.SetSideLength(8, 7, 4, 5);
            int perimiter = q1.CalcPerimeter();
            Debug.WriteLine(perimiter.ToString());
        }

        static void Main(string[] args) {
            (new Program()).Run1();
        }
    }
}
