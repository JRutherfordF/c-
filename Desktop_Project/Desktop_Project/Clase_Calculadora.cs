using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Project
{
    class Clase_Calculadora
    {
        decimal num1;

        public decimal Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        decimal num2;

        public decimal Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
        decimal res;

        public decimal Res
        {
            get { return res; }
            set { res = value; }
        }
        char op;

        public char Op
        {
            get { return op; }
            set { op = value; }
        }
        public decimal sumar()
        {
            res = num1 + num2;
            return res;
        }
        public decimal restar()
        {
            res = num1 - num2;
            return res;
        }
        public decimal multiplicar()
        {
            res = num1 * num2;
            return res;
        }
        public decimal dividir()
        {
            res = num1 / num2;
            return res;
        }
        public decimal root()
        {
            double num1d = 0;
            num1d = Convert.ToDouble(num1);
            num2 = Convert.ToDecimal(Math.Sqrt(num1d));
            return num2;
        }
        public decimal percent()
        {
            res = (num1 / num2) * 100;
            return res;
        }
        public Clase_Calculadora(Decimal _num1, Decimal _num2, Decimal _res, Char _op)
        {
            num1 = _num1;
            num2 = _num2;
            res = _res;
            op = _op;
            
        }
    }
}
