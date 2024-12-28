using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace eKasa.Models
{
    internal class Users
    {
        [Key]
        public int Id { get; set; }
        public string username { get; set; }

        public string password { get; set; }

        public bool is_active { get; set; }

        public Role role { get; set; }

        //public virtual GuestTable GuestTable { get; set; }

        public string Ispis()
        {

            return string.Format("{0};{1};{2};{3};{4};{5};",
                           Id, username, password, is_active, role);
        }

    }
    public enum Role
    {
        Manager,
        Waiter
    }
    internal class UsersDBContext : DbContext
    {
        public UsersDBContext() : base("DBConnection")
        {
        }
        public DbSet<Users> Users { get; set; }
    }

}
