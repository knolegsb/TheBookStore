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

                
            });
            //Mapper.CreateMap<Book, BookDto>()
            //    .ForMember(b => b.Authors, m => m.MapFrom(a => a.Authors));
            //Mapper.CreateMap<Author, BookAuthorsDto>()
            //    .ForMember(b => b.FullName, m => m.MapFrom(a => a.Name + " " + a.Surname))
            //    .ForSourceMember(b => b.Books, m => m.Ignore());
        }
    }
}