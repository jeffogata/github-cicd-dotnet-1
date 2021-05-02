// -----------------------------------------------------------------------------
// <copyright file="Program.cs" company="Nomach Inc">
// Copyright (c) Nomach Inc.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------

namespace Client
{
    using System;
    using Core;

    /// <summary>
    /// The entry point class for the console client.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The entry point method for the console client.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "This is just an demo project to test CICD.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "This is a demo project for CICD.")]
        public static void Main()
        {
            var calc = new Calculator();
            var parser = new InputParser();

            do
            {
                Console.Write("Enter a calculator operation: ");

                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                try
                {
                    var parsed = parser.ParseInput(input);

                    var result = parsed.Operation switch
                    {
                        Operation.Add => calc.Add(parsed.Operand1, parsed.Operand2),
                        Operation.Subtract => calc.Subtract(parsed.Operand1, parsed.Operand2),
                        _ => throw new InvalidOperationException($"Unhandled parsed operation '{parsed.Operation}'"),
                    };

                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true);
        }
    }
}
