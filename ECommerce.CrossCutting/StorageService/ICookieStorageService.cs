using System;

namespace ECommerce.CrossCutting.StorageService 
{
    public interface ICookieStorageService
    {
        void Save(string key, string value, DateTime expires);
        string Retrieve(string key);
    }
}
