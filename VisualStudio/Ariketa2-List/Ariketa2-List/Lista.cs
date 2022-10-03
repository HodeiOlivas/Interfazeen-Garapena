using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa2_List
{


    
    

        public class Lista
        {
            public float zenb { get; set; }
            public float zenb2 { get; set; }
            public float zenb3 { get; set; }
            public float zenb4 { get; set; }

            public Lista()
            {

            }
            public static float eragiketa(List<Lista> zenbakiak)
            {
                float emaitza = 0;
            emaitza = (zenbakiak[0].zenb + (2 * zenbakiak[1].zenb2) + (3 * zenbakiak[2].zenb3) + (4 * zenbakiak[3].zenb4)) / 4;
            return emaitza;
            }
        }
    }
