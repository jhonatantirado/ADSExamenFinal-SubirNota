using Common;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Fibonacci.Common;
using Fibonacci.Repository.Interfaces;

namespace Fibonacci.API
{


    public class FibonacciController: Controller{
        private static string numberIsTooBig = $"Número máximo permitido: {Constants.maxNumber}";
        private static string numberIsTooBigLogaritmica = $"Número máximo permitido: {Constants.maxNumberLogaritmica}";
        private readonly IFibonacciRepository  _fibonacciRepository;
        public FibonacciController(IFibonacciRepository fibonacciRepository)
        {
            _fibonacciRepository = fibonacciRepository;
        }


        [Route("/api/Fibonacci/{n}")]
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public ActionResult<long> Fibonacci(int n)
        {
            if (n>Constants.maxNumber){
                return BadRequest(numberIsTooBig);
            } 

            if (n<0){
                return BadRequest(Constants.numberIsNegative + n);
            }

            try
            {
                return _fibonacciRepository.calculateFibonacciSequence(n);
            }
            catch (ArgumentException ex){
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [Route("/api/Fibonacci/Lineal/{n}")]
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public ActionResult<long> Lineal(int n)
        {
            if (n>Constants.maxNumber){
                return BadRequest(numberIsTooBig);
            } 

            if (n<0){
                return BadRequest(Constants.numberIsNegative + n);
            }

            try
            {
                return Algorithms.FibonacciLineal(n);
            }
            catch (ArgumentException ex){
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [Route("/api/Fibonacci/Exponencial/{n}")]
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public ActionResult<long> Exponencial(int n)
        {
            if (n>Constants.maxNumber){
                return BadRequest(numberIsTooBig);
            } 

            if (n<0){
                return BadRequest(Constants.numberIsNegative + n);
            }

            try
            {
                return Algorithms.FibonacciExponencial(n);
            }
            catch (ArgumentException ex){
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }


        [Route("/api/Fibonacci/Logaritmica/{n}")]
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public ActionResult<long> Logaritmica(int n)
        {
            if (n>Constants.maxNumberLogaritmica){
                return BadRequest(numberIsTooBigLogaritmica);
            } 

            if (n<0){
                return BadRequest(Constants.numberIsNegative + n);
            }

            try
            {
                return Algorithms.FibonacciLogaritmica(n);
            }
            catch (ArgumentException ex){
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

    }
}