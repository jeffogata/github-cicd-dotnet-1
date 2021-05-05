// -----------------------------------------------------------------------------
// <copyright file="ICalculator.cs" company="Nomach Inc">
// Copyright (c) Nomach Inc.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------

namespace Core
{
    /// <summary>
    /// Defines an interface for basic math operations.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Adds two integers and returns the sum.
        /// </summary>
        /// <param name="num1">The first integer to add.</param>
        /// <param name="num2">The second integer to add.</param>
        /// <returns>The sum.</returns>
        int Add(int num1, int num2);

        /// <summary>
        /// Subtracts two integers and returns the difference.
        /// </summary>
        /// <param name="num1">The first integer to subtract.</param>
        /// <param name="num2">The second integer to subtract from the first.</param>
        /// <returns>The difference.</returns>
        int Subtract(int num1, int num2);

        /// <summary>
        /// Multiplies two integers and returns the difference.
        /// </summary>
        /// <param name="num1">The first integer to multiply.</param>
        /// <param name="num2">The second integer to multiply.</param>
        /// <returns>The product.</returns>
        int Muliply(int num1, int num2);
    }
}
