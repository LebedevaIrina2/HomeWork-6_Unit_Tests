using NUnit.Framework;

namespace HomeWork6
{

    //��������------------------------------------------  
        public class Add
        {
            [Test, TestCaseSource(typeof(Data), "DivideCases")]
            public void Test_sum(double x, double y)
            {
                Calculator.Methods c = new Calculator.Methods();
                double add = c.addition(x, y);

                Assert.IsTrue(x + y == add, "������ ��� ��������: (x={0}) + (y={1}) ={2}", x, y, add);

            }
        }

    
        // ���������-----------------------------------------
        public class Dif
        {
            [Test, TestCaseSource(typeof(Data), "DivideCases")]
            public void Test_dif(double x, double y)
            {
                Calculator.Methods c = new Calculator.Methods();
                double dif = c.difference(x, y);

                Assert.IsTrue(x - y == dif, "������ ��� ���������: (x={0}) - (y={1}) ={2}", x, y, dif);

            }
        }


        // ���������-----------------------------------------
        public class Mult
        {
            [Test, TestCaseSource(typeof(Data), "DivideCases")]
            public void Test_mult(double x, double y)
            {
                Calculator.Methods c = new Calculator.Methods();
                double mul = c.multiplication(x, y);

                Assert.IsTrue(x * y == mul, "������ ��� ���������: (x={0}) * (y={1}) ={2}", x, y, mul);

            }
        }

        // ������� -----------------------------------------
        public class Divided
        {
            [Test, TestCaseSource(typeof(Data), "DivideCases")]
            public void Test_div(double x, double y)
            {
                Calculator.Methods c = new Calculator.Methods();
                double div = c.division(x, y);

                Assert.IsTrue(x / y == div, "������ ��� ������� : (x={0}) / (y={1})={2}", x, y, div);

            }
        } 
}





            
        
    

