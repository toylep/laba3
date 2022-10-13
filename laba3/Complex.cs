using System;

namespace laba3
{
    class Complex
    {
        private double realnum;
        private double imagenum;
        public Complex(int realnum, int imagenum)
        {
            this.realnum = realnum;
            this.imagenum = imagenum;
        }
        public static Complex operator + (Complex n1, Complex n2)
        {
            Complex sumnum = new Complex(0, 0);
            sumnum.realnum = n1.realnum + n2.realnum;
            sumnum.imagenum = n1.imagenum + n2.imagenum;
            return sumnum;
        }
        public static Complex operator -(Complex n1, Complex n2)
        {
            Complex sumnum = new Complex(0, 0);
            sumnum.realnum = n1.realnum - n2.realnum;
            sumnum.imagenum = n1.imagenum - n2.imagenum;
            return sumnum;
        }
        public static Complex operator * (Complex n1, Complex n2)
        {
            Complex newnum = new Complex(0, 0);
            newnum.realnum = (n1.realnum * n2.realnum) - (n1.imagenum * n2.imagenum);
            newnum.imagenum = (n1.realnum * n2.imagenum) + (n2.imagenum * n1.realnum);
            return newnum;
        }
        public static Complex operator / (Complex n1,Complex n2)
        {
            Complex newnum = new Complex(0, 0);
            newnum.realnum = ((n1.realnum * n2.realnum) + (n1.imagenum * n2.imagenum)) / (Math.Pow(n1.realnum, 2) + Math.Pow(n2.realnum, 2));
            newnum.imagenum = (n1.realnum * n2.imagenum) - (n2.realnum * n1.imagenum)/(Math.Pow(n1.realnum, 2) + Math.Pow(n2.realnum, 2));
            return newnum;

        }
        public static string Comparison(Complex n1, Complex n2)
        { string solve = "";
            double gip1 = (Math.Pow(n1.realnum, 2)) + (Math.Pow(n1.imagenum, 2));
            double gip = (Math.Pow(n2.realnum, 2)) + (Math.Pow(n2.imagenum, 2));
            if (gip1 > gip)
                solve = "Первое число больше";
            // Console.WriteLine("Первое число больше");
            if (gip > gip1)
                // Console.WriteLine("Второе число больше");
                solve = "Второе число больше";
            if (gip == gip1)
                // Console.WriteLine("Числа равны");
                solve = "Числа равны";
            return solve;
        }
        public  string  Message(Complex n1)
        {
            string mesword1 = n1.realnum.ToString();
            string mesword2= n1.imagenum.ToString() ;
           string  mesg = mesword1 + '+' + mesword2 + 'i';
            return mesg;
            
            
        }
    }
}


