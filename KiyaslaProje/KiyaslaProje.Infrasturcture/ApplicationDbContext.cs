using KiyaslaProje.Domain.Entities;
using KiyaslaProje.Domain.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Infrasturcture
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDbContext
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Compare> Compares { get; set; }
        public DbSet<CompareComment> CompareComments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<GeneralInformation> GeneralInformations { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
    }
}
