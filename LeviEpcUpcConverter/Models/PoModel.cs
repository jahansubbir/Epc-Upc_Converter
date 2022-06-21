using System;
using System.Collections.Generic;
using System.Text;

namespace LeviEpcUpcConverter.Models
{
    class PoModel
    {
       
        public PoModel(string po):this()
        {
            this.Po = po;
        }
        public string Po { get; set; }
        public List<Model> EpcList { get; set; }
        public PoModel()
        {
            EpcList = new List<Model>();
        }
    }
}
