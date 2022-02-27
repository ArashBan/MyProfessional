using System.Collections.Generic;
using DataAccess;
using BusinessEntity;
using BusinessEntity.Dto;

namespace BusinessLogic
{
    public class BLLMillion
    {
        private readonly DALMillion _dalMillion = new DALMillion();

        public void Create(Million million)
        {
            _dalMillion.Create(million);
        }

        public void Edit(Million million, int id)
        {
            _dalMillion.Edit(million, id);
        }

        public void Delete(int id)
        {
            _dalMillion.Delete(id);
        }

        public List<MillionViewModel> ReadAll()
        {
            return _dalMillion.ReadAll();
        }

        public Million GetById(int id)
        {
            return _dalMillion.GetById(id);
        }

        public double SumMoney()
        {
            return _dalMillion.SumMoney();
        }
    }
}
