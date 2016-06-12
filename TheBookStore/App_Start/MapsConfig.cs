using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBookStore.DataTransferObjects;
using TheBookStore.Models;

namespace TheBookStore.App_Start
{
    public static class MapsConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<Book, BookDto>()
                    .ForMember(b => b.Authors, m => m.MapFrom(a => a.Authors));

                config.CreateMap<Author, BookAuthorsDto>()
                    .ForMember(b => b.FullName, m => m.MapFrom(a => a.Name + " " + a.Surname))
                    .ForSourceMember(b => b.Books, m => m.Ignore());

                config.CreateMap<Author, AuthorBooksDto>();

                config.CreateMap<Author, AuthorDto>()
                    .ForMember(b => b.FullName, m => m.MapFrom(a => a.Name + " " + a.Surname))
                    .ForMember(a => a.Books, m => m.MapFrom(b => b.Books))
                    .ForMember(a => a.Books, m => m.Ignore());

                config.CreateMap<Review, ReviewDto>()
                    .ForMember(r => r.BookId, m => m.MapFrom(s => s.BookId));
            });           
        }
    }
}