using System.Collections.Generic;
using DataAccess;
using BusinessEntity;
using BusinessEntity.Dto;

namespace BusinessLogic
{
    public class BLLPassword
    {
        private readonly DALPassword _dalPassword = new DALPassword();

        public void Create(Password password)
        {
            _dalPassword.Create(password);
        }

        public void Edit(Password passsword, int id)
        {
            _dalPassword.Edit(passsword, id);
        }

        public void Delete(int id)
        {
            _dalPassword.Delete(id);
        }

        public Password GetById(int id)
        {
            return _dalPassword.GetById(id);
        }

        public List<Password> ReadAll()
        {
            return _dalPassword.ReadAll();
        }

        public List<string> CopyRows()
        {
            return _dalPassword.CopyRows();
        }
    }
}
