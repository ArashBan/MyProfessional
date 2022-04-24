namespace BusinessEntity
{
    public class Million
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Money { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        //public bool IsDeleted { get; set; }

        public Million(string title, int money, string day, string month, string year)
        {
            Title = title;
            Money = money;
            Day = day;
            Month = month;
            Year = year;
        }

        protected Million() { }
    }
}
