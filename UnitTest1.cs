using NUnit.Framework;

namespace HomeWork6
{

    //СЛОЖЕНИЕ------------------------------------------  
        public class Add
        {
            [Test, TestCaseSource(typeof(Data), "DivideCases")]
            public void Test_sum(double x, double y)
            {
                Calculator.Methods c = new Calculator.Methods();
                double add = c.addition(x, y);

                Assert.IsTrue(x + y == add, "Ошибка при сложении: (x={0}) + (y={1}) ={2}", x, y, add);

            }
        }

    
        // ВЫЧИТАНИЕ-----------------------------------------
        public class Dif
        {
            [Test, TestCaseSource(typeof(Data), "DivideCases")]
            public void Test_dif(double x, double y)
            {
                Calculator.Methods c = new Calculator.Methods();
                double dif = c.difference(x, y);

                Assert.IsTrue(x - y == dif, "Ошибка при вычитании: (x={0}) - (y={1}) ={2}", x, y, dif);

            }
        }


        // УМНОЖЕНИЕ-----------------------------------------
        public class Mult
        {
            [Test, TestCaseSource(typeof(Data), "DivideCases")]
            public void Test_mult(double x, double y)
            {
                Calculator.Methods c = new Calculator.Methods();
                double mul = c.multiplication(x, y);

                Assert.IsTrue(x * y == mul, "Ошибка при умножении: (x={0}) * (y={1}) ={2}", x, y, mul);

            }
        }

        // ДЕЛЕНИЕ -----------------------------------------
        public class Divided
        {
            [Test, TestCaseSource(typeof(Data), "DivideCases")]
            public void Test_div(double x, double y)
            {
                Calculator.Methods c = new Calculator.Methods();
                double div = c.division(x, y);

                Assert.IsTrue(x / y == div, "Ошибка при делении : (x={0}) / (y={1})={2}", x, y, div);

            }
        } 
}





            
        
    

