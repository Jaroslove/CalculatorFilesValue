using Calculator.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Counter
{
    class Parser : IParser
    {
        private List<int> list;

        public Parser()
        {
            list = new List<int>();
        }

        public List<int> Parse(string path)
        {            
            try
            {
                list.Clear();

                if (File.Exists(path) && Path.GetExtension(path) == ".txt")
                {
                    var stringArray = File.ReadAllLines(path);

                    ParseFromString(stringArray);
                }
            }
            catch { }            

            return list;
        }

        public List<int> ParseFromString(string[] str)
        {
            foreach (string item in str)
            {
                try
                {
                     list.Add(int.Parse(item.Trim(' ')));
                }
                catch (ParseFromStringToIntExeption) { }

                catch (Exception) { }
            }

            return list;
        }
    }
}
