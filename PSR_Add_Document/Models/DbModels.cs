using Microsoft.EntityFrameworkCore;
using System.Reflection;
using PSR_Add_Document.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSR_Add_Document.Models
{


    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<OtpVerificationOptions> OtpVerificationOptions { get; set; }
        public DbSet<OTPManage>? OTPManage { get; set; }
        public DbSet<CustomerDocument> CustomerDocuments { get; set; }
        //public DbSet<SubUser> SubUsers { get; set; }
    }
}
