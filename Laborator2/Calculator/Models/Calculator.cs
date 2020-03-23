namespace Calculator.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Calculator
    {
        private static bool _operandSelected;

        public static readonly string[] OperatorsSymbols = { "+", "-", "*", "/" };

        public static Dictionary<string, string> Operation { get; } = 
            new Dictionary<string, string>()
                {
                    { "Plus", "+" },
                    { "Minus", "-" },
                    { "Multiplication", "*" },
                    { "Division", "/" }
                };

        public static Dictionary<string, bool> Type { get; } = 
            new Dictionary<string, bool>()
                {
                    { "Float", false }, 
                    { "PositiveSign", true }
                };

        public int LeftParenthesis { get; set; }

        public Calculator()
        {
            LeftParenthesis = 0;
        }

        public static bool TryGetOperationKey(string value, out string key)
        {
            try
            {
                var operationKey = Operation.Where(item => item.Value.Equals(value))
                    .Select(item => item.Key);
                key = operationKey.FirstOrDefault();
            }
            catch (Exception)
            {
                key = string.Empty;
                return false;
            }
            return true;
        }
        public bool HasOperand()
        {
            return _operandSelected;
        }

        public void NumericSelection()
        {
            _operandSelected = false;
        }

        public void ResetCalculatorBuff()
        {
            _operandSelected = false;
            LeftParenthesis = 0;
        }
    }
}
