using System;

namespace DataAccess
{
    public interface IJsonWorker
    {
        void Serialize<T>(T t, string path);

        T DeSerialize<T>(string jsonPath) where T : class;
    }
}
