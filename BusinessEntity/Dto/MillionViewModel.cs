using System.Globalization;

namespace BusinessEntity.Dto
{
    public class MillionViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Money { get; set; }
        public int IntMoney { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
    }
}

public static class Tools
{
    public static string ToMoney(this int myMoney)
    {
        return myMoney.ToString("N0", CultureInfo.CreateSpecificCulture("fa-ir"));
    }
}
