using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrianguloRectanguloPOO2022.Entidades;

namespace TrianguloRectanguloPOO2022.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var tr = new TrianguloRectangulo(3, 4, null);
            if (tr.Validar())
            {
                tr.CompletarTriangulo();

            }
        }
    }
}
