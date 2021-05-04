// -----------------------------------------------------------------------------
// <copyright file="Calculator.cs" company="Nomach Inc">
// Copyright (c) Nomach Inc.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------

namespace Core
{
    /// <summary>
    /// The example Calculator class.
    /// </summary>
    public class Calculator : ICalculator
    {
        private int lastResult;

        /// <summary>
        /// Gets the last result value.  This is just an example to show how
        /// internals can be made visible for tests in all projects (see the
        /// Directory.build.props file in the src folder).
        /// </summary>
        internal int LastResult => lastResult;

        /// <summary>
        /// Intentionally infinite recursion.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>The factorial.</returns>
        public static int CalculateFactorial(int input)
        {
            return input * (input - 1);
        }

        /// <summary>
        /// Adds two integers and returns the sum.
        /// </summary>
        /// <param name="num1">The first integer to add.</param>
        /// <param name="num2">The second integer to add.</param>
        /// <returns>The sum.</returns>
        public int Add(int num1, int num2)
        {
            var sum = num1 + num2;

            lastResult = sum;

            return sum;
        }

        /// <summary>
        /// Subtracts two integers and returns the difference.
        /// </summary>
        /// <param name="num1">The first integer to subtract.</param>
        /// <param name="num2">The second integer to subtract from the first.</param>
        /// <returns>The difference.</returns>
        public int Subtract(int num1, int num2)
        {
            var difference = num1 - num2;

            lastResult = difference;

            return difference;
        }
    }
}
