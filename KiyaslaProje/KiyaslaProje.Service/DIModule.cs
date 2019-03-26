using KiyaslaProje.Domain.Entities;
using KiyaslaProje.Domain.Interfaces;
using KiyaslaProje.Infrasturcture.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Service
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Category>>().To<Repository<Category>>();
            Bind<IRepository<Comment>>().To<Repository<Comment>>();
            Bind<IRepository<CompareComment>>().To<Repository<CompareComment>>();
            Bind<IRepository<Compare>>().To<Repository<Compare>>();
            Bind<IRepository<ProductDetail>>().To<Repository<ProductDetail>>();
            Bind<IRepository<ProductPicture>>().To<Repository<ProductPicture>>();
            Bind<IRepository<Product>>().To<Repository<Product>>();
            Bind<IRepository<ApplicationUser>>().To<Repository<ApplicationUser>>();
            Bind<IRepository<GeneralInformation>>().To<Repository<GeneralInformation>>();
            Bind<IRepository<Complaint>>().To<Repository<Complaint>>();
        }
    }
}
