using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using DataAccessLayer;
using System.Data.Entity;

namespace BusinessLayer
{
    public class AuthBusinessLayer
    {
        private CMSDBDAL cmdDal = new CMSDBDAL();

        public Auth FindUser(int id)
        {
            return cmdDal.Auths.Find(id);
        }
        public Auth FindUser(string UserName)
        {
            return cmdDal.Auths.SqlQuery("SELECT * FROM tblAuth WHERE UserName = '" + UserName + "'").Single();
        }
        public bool IsValidUser(Auth user)
        {
            if (user.UserType == AuthStatus.AuthenticatedAdmin)
                return true;
            else
                return false;
        }
    }
}
