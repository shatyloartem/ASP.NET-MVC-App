namespace Graph
{
    public class AgeCategoriesModel
    {
        /// <summary>
        /// Used to calculate stage by age
        /// </summary>
        /// <param name="input">Age number in string format</param>
        /// <returns>Age stage</returns>
        public string CalculateByAgeString(string input)
        {
            if (!double.TryParse(input, out var parsedAge) || parsedAge <= 0)
                return null;

            if (parsedAge <= 10)
                return "Child";
            
            return parsedAge < 17 ? "Teenager" : "Adult";
        }
    }
}