// -----------------------------------------------------------------------------
// <copyright file="CalculatorInput.cs" company="Nomach Inc">
// Copyright (c) Nomach Inc.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------

namespace Client
{
    /// <summary>
    /// An immutable type representing Calculator input.
    /// </summary>
    public record CalculatorInput
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorInput"/> record.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1642:Constructor summary documentation should begin with standard text", Justification = "StyleCop doesn't understand records yet.")]
        public CalculatorInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorInput"/> record.
        /// </summary>
        /// <param name="operation">The operation.</param>
        /// <param name="operand1">The first oprand.</param>
        /// <param name="operand2">The second operand.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1642:Constructor summary documentation should begin with standard text", Justification = "StyleCop doesn't understand records yet.")]
        public CalculatorInput(Operation operation, int operand1, int operand2)
        {
            Operation = operation;
            Operand1 = operand1;
            Operand2 = operand2;
        }

        /// <summary>
        /// Gets the operation.
        /// </summary>
        public Operation Operation { get; init; }

        /// <summary>
        /// Gets the first operand.
        /// </summary>
        public int Operand1 { get; init; }

        /// <summary>
        /// Gets the second operand.
        /// </summary>
        public int Operand2 { get; init; }
    }
}
