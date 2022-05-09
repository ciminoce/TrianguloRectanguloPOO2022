using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrianguloRectanguloPOO2022.Entidades;

namespace TrianguloRectanguloPOO2022.Testing
{
    [TestClass]
    public class TrianguloRectanguloTest
    {
        [TestMethod]
        public void Test_CrearTriangulo_ValidoTresValores()
        {
            //Arrange
            int? catetoA = 3;
            int? catetoB = 4;
            int? hipotenusa = 5;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            Assert.IsTrue(tr.Validar());

        }

        [TestMethod]
        public void Test_CrearTriangulo_ValidoDosValoresHipoNull()
        {
            //Arrange
            int? catetoA = 3;
            int? catetoB = 4;
            int? hipotenusa = null;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            Assert.IsTrue(tr.Validar());

        }

        [TestMethod]
        public void Test_CrearTriangulo_ValidoDosValoresCatetoANull()
        {
            //Arrange
            int? catetoA = null;
            int? catetoB = 4;
            int? hipotenusa = 5;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            Assert.IsTrue(tr.Validar());

        }

        [TestMethod]
        public void Test_CrearTriangulo_ValidoDosValoresCatetoBNull()
        {
            //Arrange
            int? catetoA = 3;
            int? catetoB = null;
            int? hipotenusa = 5;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            Assert.IsTrue(tr.Validar());

        }

        [TestMethod]
        public void Test_CrearTriangulo_NoValidoNullCatetoA_NullCatetoB()
        {
            //Arrange
            int? catetoA = null;
            int? catetoB = null;
            int? hipotenusa = 5;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            Assert.IsFalse(tr.Validar());

        }

        [TestMethod]
        public void Test_CrearTriangulo_NoValidoNullCatetoB_NullHipotenusa()
        {
            //Arrange
            int? catetoA = 3;
            int? catetoB = null;
            int? hipotenusa = null;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            Assert.IsFalse(tr.Validar());

        }
        [TestMethod]
        public void Test_CrearTriangulo_NoValidoNullCatetoA_NullHipotenusa()
        {
            //Arrange
            int? catetoA = null;
            int? catetoB = 4;
            int? hipotenusa = null;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            Assert.IsFalse(tr.Validar());

        }

        [TestMethod]
        public void Test_CrearTriangulo_NoValidoNoNullCatetoA_MenorIgualCero()
        {
            //Arrange
            int? catetoA = -1;
            int? catetoB = 4;
            int? hipotenusa = 5;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            Assert.IsFalse(tr.Validar());

        }

        [TestMethod]
        public void Test_CrearTriangulo_NoValidoNoNullCatetoB_MenorIgualCero()
        {
            //Arrange
            int? catetoA = 3;
            int? catetoB = -4;
            int? hipotenusa = 5;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            Assert.IsFalse(tr.Validar());

        }

        [TestMethod]
        public void Test_CrearTriangulo_NoValidoNoNullHipotenusa_MenorIgualCero()
        {
            //Arrange
            int? catetoA = 3;
            int? catetoB = 4;
            int? hipotenusa = -5;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            Assert.IsFalse(tr.Validar());

        }

        [TestMethod]
        public void Test_CrearTriangulo_NoValidoTresValores()
        {
            //Arrange
            int? catetoA = 3;
            int? catetoB = 4;
            int? hipotenusa = 15;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            Assert.IsFalse(tr.Validar());

        }

        [TestMethod]
        public void Test_CompletarTriangulo_Hipotenusa()
        {
            //Arrange
            int? catetoA = 3;
            int? catetoB = 4;
            int? hipotenusa = null;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            tr.CompletarTriangulo();
            Assert.AreEqual(5,tr.Hipotenusa);

        }

        [TestMethod]
        public void Test_CompletarTriangulo_CatetoA()
        {
            //Arrange
            int? catetoA = null;
            int? catetoB = 4;
            int? hipotenusa = 5;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            tr.CompletarTriangulo();
            Assert.AreEqual(3, tr.CatetoA);

        }

        [TestMethod]
        public void Test_CompletarTriangulo_CatetoB()
        {
            //Arrange
            int? catetoA = 3;
            int? catetoB =null;
            int? hipotenusa = 5;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            tr.CompletarTriangulo();
            Assert.AreEqual(4, tr.CatetoB);

        }

        [TestMethod]
        public void Test_GetPerimetro()
        {
            //Arrange
            int? catetoA = 3;
            int? catetoB = 4;
            int? hipotenusa = 5;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert
            
            Assert.AreEqual(12, tr.GetPerimetro);

        }

        [TestMethod]
        public void Test_GetSuperficie()
        {
            //Arrange
            int? catetoA = 3;
            int? catetoB = 4;
            int? hipotenusa = 5;

            //Act
            var tr = new TrianguloRectangulo(catetoA, catetoB, hipotenusa);

            //Assert

            Assert.AreEqual(6, tr.GetSuperficie);

        }



    }
}
