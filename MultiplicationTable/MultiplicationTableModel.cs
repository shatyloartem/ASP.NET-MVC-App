namespace Graph
{
    public class MultiplicationTableModel
    {
        /// <summary>
        /// Used to generate multiplication table from 1 to 10 by input number in string format
        /// </summary>
        /// <param name="input">input number in string format</param>
        /// <returns>multiplication table from 1 to 10</returns>
        public string CalculateTableByNumberString(string input)
        {
            if (!double.TryParse(input, out var parsedInput) || parsedInput <= 0)
                return null;

            string result = "";

            for (int i = 1; i <= 10; i++)
                result += $"{i} * {parsedInput} = {i * parsedInput}\n";
            
            return result;
        }
    }
}