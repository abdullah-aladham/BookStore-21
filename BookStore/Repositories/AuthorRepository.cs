using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
    public class AuthorRepository : IBook<Author>
    {
        IList<Author> authors;
        public AuthorRepository()
        {
            authors = new List<Author>()
            {
                new Author{Id=1,Fullname="John doe"},
                new Author{Id=2,Fullname="Jane doe"},
                new Author{Id=3,Fullname="Hamzeh ahmad"},
                new Author{Id=4,Fullname="Elyas Elias"},
            };
        }
        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void delete(int id)
        {
            var author = Find(id);
            authors.Remove(author); 
        }

        public Author Find(int id)
        {
            var author = authors.SingleOrDefault(author => a.id == id);
        }

        public IList<Author> List()
        {
            throw new NotImplementedException();
        }
    }
}
