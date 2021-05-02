// -----------------------------------------------------------------------------
// <copyright file="InputParser.cs" company="Nomach Inc">
// Copyright (c) Nomach Inc.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------

namespace Client
{
    using System;

    /// <summary>
    /// Parses an input string into calculator input.
    /// </summary>
    public class InputParser
    {
        private string? lastInput;

        /// <summary>
        /// Gets the last input string.
        /// </summary>
        internal string? LastInput => lastInput;

        /// <summary>
        /// Parses in input string into input for a calculator operation.
        /// </summary>
        /// <param name="input">The input to parse.</param>
        /// <returns>The parsed input.</returns>
        public CalculatorInput ParseInput(string? input)
        {
            lastInput = input;

            // input expected to be in the format:  op num1 num2
            var tokens = input?.Split(' ', StringSplitOptions.RemoveEmptyEntries & StringSplitOptions.TrimEntries);

            if (tokens?.Length != 3)
            {
                throw new ArgumentException("Input must be in the format: <operation> <num1> <num2>", nameof(input));
            }

            var operation = tokens[0]?.ToUpperInvariant() switch
            {
                "ADD" => Operation.Add,
                "SUBTRACT" or "SUB" => Operation.Subtract,
                _ => throw new ArgumentException($"Unrecognized operation '{tokens[0]}'"),
            };

            if (!int.TryParse(tokens[1], out var num1))
            {
                throw new ArgumentException($"'{tokens[1]} cannot be parsed to an integer.");
            }

            if (!int.TryParse(tokens[2], out var num2))
            {
                throw new ArgumentException($"'{tokens[2]} cannot be parsed to an integer.");
            }

            return new CalculatorInput
            {
                Operation = operation,
                Operand1 = num1,
                Operand2 = num2,
            };
        }
    }
}
