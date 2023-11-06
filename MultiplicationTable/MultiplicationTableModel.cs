namespace Graph
{
    public class MultiplicationTableModel
    {
        public string CalculateTableByNumberString(string input)
        {
            if (!double.TryParse(input, out var parsedInput) || parsedInput <= 0)
                return null;

            string result = "";

            for (int i = 1; i <= 10; i++)
                result += i + " * " + parsedInput + " = " + i * parsedInput + "\n";
            
            return result;
        }
    }
}