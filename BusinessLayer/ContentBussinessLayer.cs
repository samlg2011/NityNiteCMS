using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities;
using System.Data.Entity;

namespace BusinessLayer
{
    public class ContentBussinessLayer
    {
        private CMSDBDAL cmsDal = new CMSDBDAL();
        public List<Content> GetPage()
        {

            return cmsDal.Contents.ToList();
        }
        public Content FindPage(int? id)
        {
            return cmsDal.Contents.Find(id);
        }
        public Content FindPage(string pageName)
        {
            return cmsDal.Contents.SqlQuery("SELECT * FROM dbo.TblContent WHERE pageName='" + pageName+"'").Single();
            //return cmsDal.Contents.Find(1);
        }
        public bool CheckExistPage(string pageName)
        {
            if(cmsDal.Contents.Where(o => o.PageName == pageName).Count() == 0)
            {
                return false;
            }else
            {
                return true;
            }
            
        }
        public void CreatePage(Content content)
        {
            cmsDal.Contents.Add(content);
            cmsDal.SaveChanges();
        }

        public void EditPage(Content content)
        {
            cmsDal.Entry(content).State = EntityState.Modified;
            cmsDal.SaveChanges();
        }
        public void DeletePage(int id)
        {
            Content content = FindPage(id);
            cmsDal.Contents.Remove(content);
            cmsDal.SaveChanges();
        }
        public void DeletePage(Content content)
        {
            cmsDal.Contents.Remove(content);
            cmsDal.SaveChanges();
        }
    }
}
