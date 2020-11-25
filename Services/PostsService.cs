using blazorPostsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorPostsList.Services
{
    public class PostsService : ICRUD<post>
    {
        List<post> posts { get; set; } = new List<post>();

        public PostsService()
        {
            posts.Add(new post { Name = "Выбор компьютера", Text = "Можно выбрать разные компьютеры", type = "новость" });
            posts.Add(new post { Name = "Зима", Text = "Хорошо, когда на улице снег", type = "объявление" });
            posts.Add(new post { Name = "Любовь", Text = "Хорошо, когда тебя любят", type = "новость" });
            posts.Add(new post { Name = "Научиться любви", Text = "Научись любить других", type="новость" });
        }

        public void add(post item)
        {
            posts.Add(item);
        }

        public Task addAsync(post item)
        {
            throw new NotImplementedException();
        }

        public void delete(post item)
        {
            posts.Remove(item);
        }

        public Task deleteAsync(post item)
        {
            throw new NotImplementedException();
        }

        public List<post> get()
        {
            return posts;
        }

        public Task<List<post>> getAsync()
        {
            throw new NotImplementedException();
        }

        public void update(post item)
        {
            throw new NotImplementedException();
        }

        public Task updateAsync(post item)
        {
            throw new NotImplementedException();
        }
    }
}
