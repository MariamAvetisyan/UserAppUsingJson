using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface ISerializer
    {
        string Serialize<T>(T t);

        T DeSerialize<T>(string json) where T : class;
    }
}
