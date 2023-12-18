using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManager
{
    public class classREPO
    {
        Dictionary<int, idObject> repo;
        public classREPO()
        {
           this.repo = new Dictionary<int, idObject>();
        }

        public void addValueInData(idObject value)
        {
            this.repo.Add(value.getID(), value);
            foreach (KeyValuePair<int, idObject> pair in this.repo)
            {
                Console.WriteLine("Student ID: " + pair.Key + ", Student Name: " + pair.Value);
            }
        }

        public void removeValueInData(int key)
        {
            this.repo.Remove(key);
        }

        public Dictionary<int, idObject> getRepo() {  return this.repo; }

    }
}
