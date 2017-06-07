using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryProject {

    public class Square : Quadrillateral {

        public void SetSideLength(int a) {
            Side1 = a;
            Side2 = a;
            Side3 = a;
            Side4 = a;
        }
    }
}
