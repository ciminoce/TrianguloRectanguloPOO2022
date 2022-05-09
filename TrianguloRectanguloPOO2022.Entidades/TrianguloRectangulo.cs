using System;

namespace TrianguloRectanguloPOO2022.Entidades
{
    public class TrianguloRectangulo
    {
        public int? CatetoA { get; set; }
        public int? CatetoB { get; set; }
        public int? Hipotenusa { get; set; }

        public TrianguloRectangulo()
        {
            
        }

        public TrianguloRectangulo(int? catetoA, int? catetoB, int? hipotenusa)
        {
            this.CatetoA = catetoA;
            this.CatetoB = catetoB;
            this.Hipotenusa = hipotenusa;
        }

        public bool Validar()
        {
            //Valido si todos son nulos
            if (CatetoA==null && CatetoB==null && Hipotenusa==null)
            {
                return false;
            }
            //Valido sin 2 son nulos
            if ((CatetoA==null && CatetoB==null) || (CatetoA==null && Hipotenusa==null) ||
                      (CatetoB==null && Hipotenusa==null))
            {
                return false;
            }
            //Si tiene valor el mismo debe ser mayor a cero

            if ((CatetoA.HasValue && CatetoA.Value<=0) ||(CatetoB.HasValue && CatetoB.Value<=0) ||(Hipotenusa.HasValue && Hipotenusa.Value<=0))
            {
                return false;
            }
            //Si los 3 valores son mayores a 0
            if (CatetoA.HasValue && CatetoB.HasValue && Hipotenusa.HasValue)
            {
                if (CatetoA.Value > 0 && CatetoB.Value > 0 && Hipotenusa.Value > 0)
                {
                    //Verifico que sea un triangulo rectángulo por Pitágoras
                    return Math.Pow(Hipotenusa.Value, 2) == Math.Pow(CatetoA.Value, 2) + Math.Pow(CatetoB.Value, 2);

                }

            }
            return true;
        }

        public void CompletarTriangulo()
        {
            if (Hipotenusa==null)
            {
                Hipotenusa = CalcularHipotenusa();
            }else if (CatetoA == null)
            {
                CatetoA = CalcularCatetoA();
            }else if (CatetoB == null)
            {
                CatetoB = CalcularCatetoB();
            }

        }

        private int? CalcularCatetoB()
        {
            return (int)Math.Sqrt(Math.Pow(Hipotenusa.Value, 2) - Math.Pow(CatetoA.Value, 2));
        }

        private int? CalcularCatetoA()
        {
            return (int)Math.Sqrt(Math.Pow(Hipotenusa.Value, 2) - Math.Pow(CatetoB.Value, 2));
        }
        private int? CalcularHipotenusa()
        {
            return(int) Math.Sqrt(Math.Pow(CatetoA.Value, 2) + Math.Pow(CatetoB.Value, 2));
        }

        public double GetPerimetro => CatetoA.Value + CatetoB.Value + Hipotenusa.Value;

        public double GetSuperficie => (CatetoA.Value * CatetoB.Value) / 2;
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
