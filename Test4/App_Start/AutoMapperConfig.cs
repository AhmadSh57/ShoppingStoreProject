using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Test4.Models;
using Test4.Models.ViewModels;

namespace Test4.App_Start
{
    public class AutoMapperConfig
    {
        public static IMapper mapper;

        public static void Configuration()
        {
            MapperConfiguration configuration = new MapperConfiguration(t =>
            {
                t.CreateMap<VM_RegisterUser, Tbl_User>();
            t.CreateMap<Tbl_User, VM_RegisterUser>();
                t.CreateMap<VM_UsertTest,Tbl_UserTest>();
                t.CreateMap<VM_CompleteUserInfo, Tbl_User>();
                t.CreateMap<Tbl_User, VM_CompleteUserInfo>();
                t.CreateMap<VM_UserLogin, Tbl_User>();
            }); 

            mapper = configuration.CreateMapper();
        }
    }
}