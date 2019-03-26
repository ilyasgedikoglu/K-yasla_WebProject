using AutoMapper;
using KiyaslaProje.Common.Extensions;
using KiyaslaProje.Common.ViewModels;
using KiyaslaProje.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiyaslaProje.Common.Mappers
{
    public class ProjectMapper
    {
        static ProjectMapper()
        {
            Mapper.CreateMap<BaseModel, BaseModelVM>().IgnoreAllNonExisting();
            Mapper.CreateMap<BaseModelVM, BaseModel>().IgnoreAllNonExisting();

            Mapper.CreateMap<Category, CategoryVM>().IgnoreAllNonExisting();
            Mapper.CreateMap<CategoryVM, Category>().IgnoreAllNonExisting();

            Mapper.CreateMap<Comment, CommentVM>().IgnoreAllNonExisting();
            Mapper.CreateMap<CommentVM, Comment>().IgnoreAllNonExisting();

            Mapper.CreateMap<CompareComment, CompareCommentVM>().IgnoreAllNonExisting();
            Mapper.CreateMap<CompareCommentVM, CompareComment>().IgnoreAllNonExisting();

            Mapper.CreateMap<Compare, CompareVM>().IgnoreAllNonExisting();
            Mapper.CreateMap<CompareVM, Compare>().IgnoreAllNonExisting();

            Mapper.CreateMap<ProductDetail, ProductDetailVM>().IgnoreAllNonExisting();
            Mapper.CreateMap<ProductDetailVM, ProductDetail>().IgnoreAllNonExisting();

            Mapper.CreateMap<ProductPicture, ProductPictureVM>().IgnoreAllNonExisting();
            Mapper.CreateMap<ProductPictureVM, ProductPicture>().IgnoreAllNonExisting();

            Mapper.CreateMap<Product, ProductVM>().IgnoreAllNonExisting();
            Mapper.CreateMap<ProductVM, Product>().IgnoreAllNonExisting();

            Mapper.CreateMap<GeneralInformation, GeneralInformationVM>().IgnoreAllNonExisting();
            Mapper.CreateMap<GeneralInformationVM, GeneralInformation>().IgnoreAllNonExisting();

            Mapper.CreateMap<Complaint, ComplaintVM>().IgnoreAllNonExisting();
            Mapper.CreateMap<ComplaintVM, Complaint>().IgnoreAllNonExisting();

        }
        public static TDestination ConvertToVM<TDestination>(object from)
             where TDestination : BaseModelVM
        {
            return Mapper.Map<TDestination>(from);
        }

        public static TDestination ConvertToVMList<TDestination>(IEnumerable<object> from)
             where TDestination : IEnumerable<BaseModelVM>
        {
            return Mapper.Map<TDestination>(from);
        }

        public static TDestination ConvertToVM<TSource, TDestination>(TSource from, TDestination to)
            where TSource : class
            where TDestination : BaseModelVM
        {
            if (to == null || to == default(TDestination))
                to = (TDestination)Activator.CreateInstance(typeof(TDestination));
            return Mapper.Map<TSource, TDestination>(from, to);
        }

        public static TDestination ConvertToEntity<TDestination>(BaseModelVM from)
              where TDestination : class
        {
            return Mapper.Map<TDestination>(from);
        }

        public static TDestination ConvertToEntityList<TDestination>(IEnumerable<BaseModelVM> from)
                where TDestination : IEnumerable<object>
        {
            return Mapper.Map<TDestination>(from);
        }

        public static TDestination ConvertToEntity<TSource, TDestination>(TSource from, TDestination to)
             where TSource : BaseModelVM
             where TDestination : class
        {
            if (to == null || to == default(TDestination))
                to = (TDestination)Activator.CreateInstance(typeof(TDestination));
            return Mapper.Map<TSource, TDestination>(from, to);
        }

        internal static TDestination ConvertTo<TDestination>(object from)
            where TDestination : class
        {
            return Mapper.Map<TDestination>(from);
        }
    }
}
