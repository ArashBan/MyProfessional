using System.Collections.Generic;
using System.Linq;
using BusinessEntity;
using BusinessEntity.Dto;

namespace DataAccess
{
    public class DALPassword
    {
        private readonly Database _db = new Database();

        public void Create(Password password)
        {
            _db.Passwords.Add(password);
            _db.SaveChanges();
        }

        public void Edit(Password password, int id)
        {
            var result = _db.Passwords.FirstOrDefault(i => i.Id == id);
            result.SiteName = password.SiteName;
            result.Username = password.Username;
            result.Email = password.Email;
            result.TextPassword = password.TextPassword;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            Password password = GetById(id);
            _db.Passwords.Remove(password);
            _db.SaveChanges();
        }

        public List<Password> ReadAll()
        {
            return _db.Passwords.OrderBy(i => i.SiteName).ToList();
        }

        public Password GetById(int id)
        {
            return _db.Passwords.FirstOrDefault(i => i.Id == id);
        }

        public List<string> CopyRows()
        {
            return _db.Passwords.OrderBy(i => i.Id).Select(i =>i.SiteName + " : " + i.TextPassword).ToList();
        }
    }
}
