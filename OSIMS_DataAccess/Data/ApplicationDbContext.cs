
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSIMS_Model.Models;
using System.Security;

namespace OSIMS_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> StudentMaster { get; set; }
        public DbSet<Teacher> TeacherMaster{ get;set; }
        public DbSet<Dept> Dept {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server = DESKTOP-LJN82VR;Database = OSIMS_DB;TrustServerCertificate = True;Trusted_Connection=True;");
            
        }
    }
    
}