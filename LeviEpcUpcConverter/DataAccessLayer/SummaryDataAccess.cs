using LeviEpcUpcConverter.Models;

using NPOI.SS.UserModel;

using System;
using System.Collections.Generic;

namespace LeviEpcUpcConverter.DataAccessLayer

{
    class SummaryDataAccess : DataAccess
    {

        public HashSet<Summary> GetSummaries(string fileName)
        {

            HashSet<Summary> summaries = new HashSet<Summary>();
            var sheet = Initiate(fileName);
            var headerRow = sheet.GetRow(0);
            for (int i = 1; i <= sheet.LastRowNum; i++)
            {

                var row = sheet.GetRow(i);
                if (row != null) //null is when the row only contains empty cells 
                {
                    Summary summary = new Summary();
                    foreach (ICell cell in row.Cells)
                    {
                        switch (headerRow.Cells[cell.ColumnIndex].StringCellValue?.Trim())
                        {
                            case "PO":
                                cell.SetCellType(CellType.String);
                                summary.PoNumber = cell.StringCellValue;
                                break;
                            case "Booking Number":
                                summary.BookingNumber = cell.StringCellValue;
                                break;
                            case "Shipper":
                                summary.Shipper = cell.StringCellValue;
                                break;
                            case "Place Of Delivery":
                                summary.PlaceOfDelivery = cell.StringCellValue;
                                break;
                            case "Cartons to be Scanned":
                                summary.CartonToBeScanned = (int)cell.NumericCellValue;
                                break;
                            case "Read Units":
                                summary.ReadUnits = (int)cell.NumericCellValue;
                                break;
                        }
                    }
                    if (!string.IsNullOrEmpty(summary.PoNumber))
                    {
                        summaries.Add(summary);
                    }//MessageBox.Show(string.Format("Row {0} = {1}", row, sheet.GetRow(row).GetCell(0).StringCellValue));
                }
            }
            workbook.Close();
            return summaries;
        }

    }
}
