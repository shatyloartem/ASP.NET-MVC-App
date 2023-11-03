namespace Graph
{
    public class CalculatorModel
    {
        /// <summary>
        /// Used to plus two numbers in string format
        /// </summary>
        /// <param name="input1">First number in string format</param>
        /// <param name="input2">Second number in string format</param>
        public string plusNumbersByString(string input1, string input2)
        {
            if (double.TryParse(input1, out var parsedInput1) && double.TryParse(input2, out var parsedInput2))
                return (parsedInput1 + parsedInput2).ToString();
                
            return null;
        }
        
        /// <summary>
        /// Used to subtract two numbers in string format
        /// </summary>
        /// <param name="input1">First number in string format</param>
        /// <param name="input2">Second number in string format</param>
        public string subtractNumbersByString(string input1, string input2)
        {
            if (double.TryParse(input1, out var parsedInput1) && double.TryParse(input2, out var parsedInput2))
                return (parsedInput1 - parsedInput2).ToString();
                
            return null;
        }
        
        /// <summary>
        /// Used to multiply two numbers in string format
        /// </summary>
        /// <param name="input1">First number in string format</param>
        /// <param name="input2">Second number in string format</param>
        public string multiplyNumbersByString(string input1, string input2)
        {
            if (double.TryParse(input1, out var parsedInput1) && double.TryParse(input2, out var parsedInput2))
                return (parsedInput1 * parsedInput2).ToString();
                
            return null;
        }
        
        /// <summary>
        /// Used to divide two numbers in string format
        /// </summary>
        /// <param name="input1">First number in string format</param>
        /// <param name="input2">Second number in string format</param>
        public string divisionNumbersByString(string input1, string input2)
        {
            if (double.TryParse(input1, out var parsedInput1) && double.TryParse(input2, out var parsedInput2))
                return (parsedInput1 / parsedInput2).ToString();
                
            return null;
        }
    }
}