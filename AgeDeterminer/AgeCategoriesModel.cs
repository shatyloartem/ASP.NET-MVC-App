namespace Graph
{
    public class AgeCategoriesModel
    {
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