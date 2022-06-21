using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LeviEpcUpcConverter.DataAccessLayer
{
    class DataAccess
    {
       protected IWorkbook workbook;
        protected ISheet Initiate(string fileName)
        {
            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                if (fileName.EndsWith(".xls"))
                {
                    workbook = new HSSFWorkbook(file);
                }
                else
                {
                    workbook = new XSSFWorkbook(file);
                }

            }

            ISheet sheet = workbook.GetSheetAt(0);
            return sheet;
        }
    }
}
