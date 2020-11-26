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
            posts.Add(new post { Name = "Выбор компьютера", Text = "Можно выбрать разные компьютеры", type = "новость", cover_image= "https://i.ucrazy.ru/files/pics/2017.04/photo14915494424.jpg" });
            posts.Add(new post { Name = "Зима", Text = "Хорошо, когда на улице снег", type = "объявление", cover_image= "https://www.zaggo.ru/sas/image/01_lake_joseph_boathouse_by_altius_architects_12.jpg" });
            posts.Add(new post { Name = "Любовь", Text = "Хорошо, когда тебя любят", type = "новость", cover_image= "https://drasler.ru/wp-content/uploads/2019/05/%D0%94%D0%BE%D0%BC-%D0%B2-%D0%BB%D0%B5%D1%81%D1%83-%D0%BD%D0%B0-%D0%B1%D0%B5%D1%80%D0%B5%D0%B3%D1%83-%D0%BE%D0%B7%D0%B5%D1%80%D0%B0-%D1%84%D0%BE%D1%82%D0%BE-3.jpg" });
            posts.Add(new post { Name = "Научиться любви", Text = "Научись любить других", type="новость", cover_image= "https://evermotion.org/files/EVRprfolio/Untitled1.jpg" });
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
