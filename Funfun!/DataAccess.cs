using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Funfun_
{
    public class DataAccess
    {
        public List<Messages> LoadMessages()
        {
            List<Messages> items = new List<Messages>();
            try
            {
                using (FileStream fs = File.OpenRead(@"C:\Users\Poul Meyer\Dropbox\Vores chat program\Messages.dat"))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    items = formatter.Deserialize(fs) as List<Messages>;
                }
            }
            catch { }
            return items;
        }

        public void SaveMessages(List<Messages> items)
        {
            using (FileStream fs = File.Create(@"C:\Users\Poul Meyer\Dropbox\Vores chat program\Messages.dat", 2048, FileOptions.None))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, items);
            }
        }
    }
}
