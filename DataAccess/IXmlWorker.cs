using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IXmlWorker
    {
        string Serialize<T>(T t);

        T Deserilize<T>(string xml) where T : class;

        string Read();

        void Save(string xml, string path);
    }
}
