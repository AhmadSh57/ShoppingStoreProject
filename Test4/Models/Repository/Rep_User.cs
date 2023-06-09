using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test4.Models.ViewModels;
using AutoMapper;
using Test4.App_Start;
using System.Security.Cryptography;

namespace Test4.Models.Repository
{



    public class Rep_User
    {

        

        WebStoreDbEntities5 db = new WebStoreDbEntities5();

        public object Response { get; private set; }

        public List<VM_CompleteUserInfo> ShowUsers()
        {
            List<VM_CompleteUserInfo> VM_Users = new List<VM_CompleteUserInfo>();    
            List<Tbl_User> tbl_Users = new List<Tbl_User>();

            tbl_Users = db.Tbl_User.ToList();
            VM_Users = AutoMapperConfig.mapper.Map<List<Tbl_User>,List<VM_CompleteUserInfo>>(tbl_Users);    
            return VM_Users;

        } 
        public bool InsertUser(VM_RegisterUser VM_User)
        {


            Tbl_User tbl_User = new Tbl_User();

            tbl_User = AutoMapperConfig.mapper.Map<VM_RegisterUser, Tbl_User>(VM_User);
            bool IsUser = (from u in db.Tbl_User  select u).Any( u => u.Mobile == VM_User.Mobile);
            if (!IsUser)
            {
            db.Tbl_User.Add(tbl_User);
            }
            else
            {
                

                return false;
            }
            return Convert.ToBoolean(db.SaveChanges());
        }

        public bool InsertUserWith_VM_CompleteUserInfo(VM_CompleteUserInfo VM_CompleteUser)
        {
            Tbl_User tbl_User = new Tbl_User();

            tbl_User = AutoMapperConfig.mapper.Map<VM_CompleteUserInfo, Tbl_User>(VM_CompleteUser);
            db.Tbl_User.Add(tbl_User);
            return Convert.ToBoolean(db.SaveChanges()) ;    
        }
        public bool CheckMobile(string mobile)
        {
            var Query =
                (
                from u in db.Tbl_User
                where u.Mobile == mobile
                select u
                ).Count();

            return Convert.ToBoolean(Query);
        }

        public bool CheckUserName(string userName)
        {
            var Query =
                (
                from u in db.Tbl_User

                where u.UserName == userName

                select u
                ).Count();
            return Convert.ToBoolean(Query);
        }

        public bool CheckEmail(string Email)
        {
            var Query = (

                from u in db.Tbl_User

                where u.Email == Email

                select u
                ).Count();

            return Convert.ToBoolean(Query);

        }

        public bool CheckUser(VM_UserLogin vM_UserLogin)
        {
            Tbl_User tbl_User = new Tbl_User();

            tbl_User = AutoMapperConfig.mapper.Map<VM_UserLogin, Tbl_User>(vM_UserLogin);


            var Query = (

                from u in db.Tbl_User
                where u.Mobile == vM_UserLogin.Mobile && u.Password ==vM_UserLogin.Password
                select u
                ).Count();

            if( Query == 1)
            {
                return true;
            }
            return false;
        }



    }
}