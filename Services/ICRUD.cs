using blazorPostsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorPostsList.Services
{
    public interface ICRUD<Type>
    {
        List<Type> get();        
        void add(Type item);        
        void update(Type item);
        void delete(Type item);
        
        Task<List<Type>> getAsync();
        Task addAsync(Type item);
        Task updateAsync(Type item);
        Task deleteAsync(Type item);
    }
}
