using N32_T6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N32_T6.Services
{
    internal class BlogService
    {
        List<Blog> blogs = new();
        public void Create(Blog model)
        {
            if (Isvalid(model.Title) && Isvalid(model.Body))
                blogs.Add(model);
            throw new ValidationException("Model's argument is invalid!");
        }

        public Blog Get(int id)
        {
            var result = blogs.FirstOrDefault(item  => item.Id == id);
            if (result == null)
                throw new ArgumentOutOfRangeException("Id is not found!");
            return result;
        }

        public void Update(Blog model)
        {
            if (!Isvalid(model.Title) && !Isvalid(model.Body))
                throw new ValidationException("Model's argument is invalid!");
            var result = blogs.FirstOrDefault(item => item.Id == model.Id);
            if (!Isvalid(result.Title) && !Isvalid(result.Body))
                throw new InvalidOperationException("Model's in List arguments is invalid!");

        }

        public void Delete(int id)
        {
            var result = blogs.FirstOrDefault(item => item.Id == id);
            if (result == null)
                throw new ArgumentOutOfRangeException("Id is not found!");
            blogs.Remove(result);
        }

        public bool Isvalid(string item)
        {
            if (string.IsNullOrWhiteSpace(item) || item == null) return false;
            return true;
        }
    }
}
