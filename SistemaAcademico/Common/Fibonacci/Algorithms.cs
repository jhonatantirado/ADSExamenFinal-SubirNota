namespace Fibonacci.Common{

    using System;
    public class Algorithms{

        private static long [] f = new long [93];
        public static long FibonacciLineal(int n) {
            long a = 0;
            long b = 1;
            long c = 0;
            for (int k = 0; k < n; k++) {
                c = a + b;
                a = b;
                b = c;
            }
            return a;
	    }

        public static long FibonacciExponencial(int n) {
            if (n < 0) {
                throw new Exception("N can not be less than zero");
            }
            if (n <= 2) {
                return 1;
            }
            return FibonacciExponencial(n - 1) + FibonacciExponencial(n - 2);
	    }

        public static long FibonacciLogaritmica(int n)
        {
            if (n < 0) {
                throw new Exception("N can not be less than zero");
            }
            if (n <= 1) {
                return n;
            }
            f[0]=0;
            f[1]=1;
            if (f[n]>0) return f[n];
            f[n]=FibonacciLogaritmica(n-1) + FibonacciLogaritmica(n-2);
            return f[n];
        }
    }
}