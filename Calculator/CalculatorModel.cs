namespace Graph
{
    public class CalculatorModel
    {
        public string plusNumbersByString(string input1, string input2)
        {
            if (double.TryParse(input1, out var parsedInput1) && double.TryParse(input2, out var parsedInput2))
                return (parsedInput1 + parsedInput2).ToString();
                
            return null;
        }
        
        public string subtractNumbersByString(string input1, string input2)
        {
            if (double.TryParse(input1, out var parsedInput1) && double.TryParse(input2, out var parsedInput2))
                return (parsedInput1 - parsedInput2).ToString();
                
            return null;
        }
        
        public string multiplyNumbersByString(string input1, string input2)
        {
            if (double.TryParse(input1, out var parsedInput1) && double.TryParse(input2, out var parsedInput2))
                return (parsedInput1 * parsedInput2).ToString();
                
            return null;
        }
        
        public string divisionNumbersByString(string input1, string input2)
        {
            if (double.TryParse(input1, out var parsedInput1) && double.TryParse(input2, out var parsedInput2))
                return (parsedInput1 / parsedInput2).ToString();
                
            return null;
        }
    }
}