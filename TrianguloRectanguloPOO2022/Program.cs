using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrianguloRectanguloPOO2022.Entidades;

namespace TrianguloRectanguloPOO2022
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Lote de prueba
             * CatetoA=12
             * CatetoB=5
             * Hipotenusa=13
             */
            try
            {
                //TrianguloRectangulo tr = new TrianguloRectangulo(null, null, null);
                //tr.CatetoA = 12;
                //tr.CatetoB = 5;
                TrianguloRectangulo tr=new TrianguloRectangulo(12,5,null);
                if (tr.Validar())
                {
                    Console.WriteLine($"Perímetro: {tr.GetPerimetro()}");
                    Console.WriteLine($"Superficie: {tr.GetSuperficie()}");
                }
                else
                {
                    Console.WriteLine("Triángulo no válido");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
