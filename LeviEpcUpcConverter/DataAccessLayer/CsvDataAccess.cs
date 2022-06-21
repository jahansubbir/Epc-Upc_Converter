using LeviEpcUpcConverter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LeviEpcUpcConverter.DataAccessLayer
{
    class CsvDataAccess
    {
        public PoModel GetPoModel(string filePath)
        {
            var fileName = Path.GetFileNameWithoutExtension(filePath);
            PoModel poModel = new PoModel(fileName);
            using (StreamReader reader=new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    poModel.EpcList.Add(new Model() { Epc = line.Trim('\t',' ','"') });


                }
               
            }
            poModel.EpcList.RemoveAt(0);
            return poModel;
        }
    }
}
