using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService
{
    public class MicrosoftExtensionCachingAdapter : ICacheStorage
    {
        private IMemoryCache _memoryCache;
        public MicrosoftExtensionCachingAdapter(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        public void Remove(string key)
        {
            _memoryCache.Remove(key);
        }

        public T Retrieve<T>(string key)
        {
            T itemStored = (T)_memoryCache.Get(key); 
            if (itemStored == null) 
                itemStored = default(T);
            return itemStored;
        }

        public void Store(string key, object data)
        {
            _memoryCache.Set(key,data);
        }
    }
}
