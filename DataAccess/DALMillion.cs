using System.Collections.Generic;
using System.Linq;
using BusinessEntity;
using BusinessEntity.Dto;

namespace DataAccess
{
    public class DALMillion
    {
        private readonly Database _db = new Database();

        public void Create(Million million)
        {
            _db.Millions.Add(million);
            _db.SaveChanges();
        }

        public void Edit(Million million, int id)
        {
            var result = _db.Millions.FirstOrDefault(i => i.Id == id);
            result.Title = million.Title;
            result.Money = million.Money;
            result.Day = million.Day;
            result.Month = million.Month;
            result.Year = million.Year;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            Million million = GetById(id);
            _db.Millions.Remove(million);
            _db.SaveChanges();
        }

        public List<MillionViewModel> ReadAll()
        {
            var result = _db.Millions.Select(x => new MillionViewModel
            {
                Id = x.Id,
                IntMoney = x.Money,
                Title = x.Title,
                Day = x.Day,
                Month = x.Month,
                Year = x.Year
            }).OrderBy(i => i.Year).ToList();

            foreach (var item in result)
            {
                item.Money = item.IntMoney.ToMoney();
            }
            return result;
        }

        public Million GetById(int id)
        {
            return _db.Millions.FirstOrDefault(i => i.Id == id);
        }

        public double SumMoney()
        {
            return _db.Millions.Select(i => i.Money).Sum();
        }
    }
}
