using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Project.DAO
{
    /// <summary>
    /// This is the class which save and loads data.
    /// </summary>
    /// <typeparam name="T">type of object</typeparam>
    class Dao<T>
    {
        /// <summary>
        /// path to the file in which data will be stored
        /// </summary>
        public string Path { private set; get; }
        public Dao(string path)
        {
            this.Path = path;
        }

        /// <summary>
        /// This method save collections of objects.
        /// </summary>
        /// <param name="objects">collection of object which will be saved</param>
        public void Save(List<T> objects)
        {
            using (System.IO.Stream stream = System.IO.File.Create(Path))
            {
                var serializer = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                serializer.Serialize(stream, objects);
            }
        }

        /// <summary>
        /// This method loads data from file.
        /// </summary>
        /// <returns>returns collection of loaded objects</returns>
        public List<T> Load()
        {
            if (!System.IO.File.Exists(Path)) return new List<T>();
            using (System.IO.Stream stream = System.IO.File.OpenRead(Path))
            {
                var serializer = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                List<T> list = new List<T>();
                try
                {
                    list = (List<T>)serializer.Deserialize(stream);
                    return list;
                }
                catch
                {
                    string caption = "Error";
                    string message = "Loading Error. Some files were damaged. Some information can be deleted";
                    MessageBox.Show(message, caption);
                    stream.Close();
                    System.IO.File.Delete(Path);
                    
                }
                return list;
            }
        }
    }
}
