using Fibonacci.Repository.Interfaces;
using Fibonacci.Common;

namespace Fibonacci.Repository.Implementation{
        public class FibonacciLinealRepository : IFibonacciRepository{
            public long calculateFibonacciSequence (int n){
                return Algorithms.FibonacciLineal(n);
            }
        }
}