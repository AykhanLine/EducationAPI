using Business.Abstract;
using Core.Helper.Results.Abstract;
using Core.Helper.Results.Concrete.SuccessResults;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddBlog(Blog blog)
        {
            _blogDal.AddBlog(blog);
        }

        public List<Blog> GetAll()
        {

            return _blogDal.GetAll(); 
        }

        public Blog GetBlogById(int id)
        {
           return _blogDal.Get(x => x.Id == id);
        }

        public void RemoveBlog(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public void UpdateBlog(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
