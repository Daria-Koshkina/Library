using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Project.DAO
{
    class Dao<T>
    {
        public string Path { private set; get; }
        public Dao(string path)
        {
            this.Path = path;
        }

        public void Save(List<T> objects)
        {
            using (System.IO.Stream stream = System.IO.File.Create(Path))
            {
                var serializer = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                serializer.Serialize(stream, objects);
            }
        }

        public List<T> Load()
        {
            if (!System.IO.File.Exists(Path)) return new List<T>();
            using (System.IO.Stream stream = System.IO.File.OpenRead(Path))
            {
                var serializer = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                List<T> list = (List<T>)serializer.Deserialize(stream);
                return list;

            }
        }
    }
}
