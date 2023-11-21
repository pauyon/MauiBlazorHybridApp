using Domain.Entities;

namespace PersistenceinMemory.Services.BlogService
{
    public class BlogService : IBlogService
    {
        private List<Blog> _blogList = new List<Blog>();

        public BlogService()
        {
            _blogList = new List<Blog> { 
                new Blog { Id = 1, Title = "C#", Description = "C# is an object-oriented, component-oriented programming language. C# provides language constructs to directly support these concepts, making C# a natural language in which to create and use software components.", Author = "Jon Doe", Name = "C#", Url="https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Logo_C_sharp.svg/1200px-Logo_C_sharp.svg.png"},
                new Blog { Id = 2, Title = "Blazor", Description = "Blazor is a Single Page Application development framework. The name Blazor is a combination/mutation of the words Browser and Razor (the .NET HTML view generating engine). The implication being that instead of having to execute Razor views on the server in order to present HTML to the browser, Blazor is capable of executing these views on the client.\r\n\r\n", Author = "Jon Doe", Name = "Blazor", Url="https://upload.wikimedia.org/wikipedia/commons/d/d0/Blazor.png" },
                new Blog { Id = 3, Title = ".NET MAUI", Description = ".NET MAUI is open-source and is the evolution of Xamarin.Forms, extended from mobile to desktop scenarios, with UI controls rebuilt from the ground up for performance and extensibility.", Author = "Jon Doe", Name = ".NET MAUI", Url="https://devblogs.microsoft.com/dotnet/wp-content/uploads/sites/10/2021/10/shadow.png" },
            };
        }

        public async Task<Blog> Create(Blog blog)
        {
            await Task.Delay(100);

            _blogList.Add(blog);

            return blog;
        }

        public async Task<int> DeleteById(int id)
        {
            await Task.Delay(100);

            var target = _blogList.Find(x => x.Id == id);

            if (target != null)
            {
                _blogList.Remove(target);
                return 0;
            }

            return -1;
        }

        public async Task<List<Blog>> GetAll()
        {
            await Task.Delay(100);

            return _blogList ?? new List<Blog>();
        }

        public async Task<Blog?> GetById(int id)
        {
            await Task.Delay(100);

            return _blogList.Find(x => x.Id == id);
        }

        public async Task<int> Update(int id, Blog blog)
        {
            await Task.Delay(100);

            var existingBlog = _blogList.Find(x => x.Id == id);

            if (existingBlog != null)
            {
                existingBlog.Name = blog.Name;
                existingBlog.Description = blog.Description;
                existingBlog.Title = blog.Title;
                existingBlog.Author = blog.Author;
                existingBlog.Url = blog.Url;
            }

            return existingBlog?.Id ?? -1;
        }
    }
}
