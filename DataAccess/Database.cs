using System.Data.Entity;
using BusinessEntity;

namespace DataAccess
{
    public class Database : DbContext
    {
        public Database() : base("conMyProfessional") { }
        public DbSet<Password> Passwords { set; get; }
        public DbSet<Million> Millions { set; get; }
    }
}
