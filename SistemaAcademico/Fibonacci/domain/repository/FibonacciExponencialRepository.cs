using Fibonacci.Repository.Interfaces;
using Fibonacci.Common;

namespace Fibonacci.Repository.Implementation{
        public class FibonacciExponencialRepository : IFibonacciRepository{
            public long calculateFibonacciSequence (int n){
                return Algorithms.FibonacciExponencial(n);
            }
        }
}