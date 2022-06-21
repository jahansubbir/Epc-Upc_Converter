using LeviEpcUpcConverter.DataAccessLayer;
using LeviEpcUpcConverter.Models;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LeviEpcUpcConverter.Services
{
    class ReportingService
    {
        IWorkbook workbook;
        IFont font;
        private void CreateWorkBook(string fileName) => workbook = fileName.EndsWith(".xls") ? new HSSFWorkbook() : (IWorkbook)new XSSFWorkbook();
        private void CreateFont(string fileName)
        {
            font = fileName.EndsWith(".xls") ? (HSSFFont)workbook.CreateFont() : (IFont)(XSSFFont)workbook.CreateFont();
            font.FontHeightInPoints = 12;
            font.FontName = "Courier New";
        }
        public void CreateReport(HashSet<Summary> summaries, string fileName)
        {
            CreateWorkBook(fileName);
            CreateFont(fileName);
            foreach (Summary summary in summaries)
            {
                ISheet sheet = workbook.CreateSheet(summary.PoNumber);
                CreateHeader(sheet, HeaderCellStyle(font));
                CreateData(summary, sheet);
                int numberOfColumns = sheet.GetRow(0).PhysicalNumberOfCells;
                for (int i = 1; i <= numberOfColumns; i++)
                {
                    sheet.AutoSizeColumn(i);
                    GC.Collect(); // Add this line
                }
            }
            SaveAndCloseWorkbook(fileName);

        }
        protected void SaveAndCloseWorkbook(string fileName)
        {
            
            if(!fileName.EndsWith(".xlsx"))
                fileName+= ".xlsx";
            using (var fileData = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fileData);
                // fileData.Close();

                //_workbook = new XSSFWorkbook(fileData);
            }
        }
        private void CreateData(Summary summary, ISheet sheet)
        {
            int i = 1;
            //            var firstRow = sheet.CreateRow(1);
            var borderedCellStyle = BorderedCellStyle(font);
            var numericCellStyle = NumberCellStyle(font);
            if (summary.PoModel != null)
            {
                foreach (Model model in summary.PoModel?.EpcList)
                {
                    IRow row = sheet.CreateRow(i);
                    CreateCell(row, 0, summary.PlaceOfDelivery, borderedCellStyle);
                    CreateCell(row, 1, summary.BookingNumber, borderedCellStyle);
                    CreateCell(row, 2, summary.PoNumber, borderedCellStyle);
                    CreateCell(row, 3, "", borderedCellStyle);
                    CreateCell(row, 4, summary.Shipper, borderedCellStyle);
                    CreateCell(row, 5, summary.CartonToBeScanned, numericCellStyle);
                    CreateCell(row, 6, summary.ReadUnits, borderedCellStyle);
                    CreateCell(row, 7, "", borderedCellStyle);
                    CreateCell(row, 8, "", borderedCellStyle);
                    CreateCell(row, 9, "", borderedCellStyle);
                    CreateCell(row, 10, "", borderedCellStyle);
                    CreateCell(row, 11, model.Epc, borderedCellStyle);
                    CreateCell(row, 12, model.Upc, borderedCellStyle);
                    i++;
                }
            }
        }

        protected void CreateHeader(ISheet sheet, ICellStyle cellStyle)
        {
            IRow headerRow = sheet.CreateRow(0);
            CreateCell(headerRow, 0, "Place Of Delivery", cellStyle);
            CreateCell(headerRow, 1, "Booking Number", cellStyle);
            CreateCell(headerRow, 2, "PO Number", cellStyle);
            CreateCell(headerRow, 3, "SKU (Product code)", cellStyle);
            CreateCell(headerRow, 4, "Shipper", cellStyle);
            CreateCell(headerRow, 5, "Carton To Be Scanned", cellStyle);
            CreateCell(headerRow, 6, "Read Units", cellStyle);
            CreateCell(headerRow, 7, "Order Qty", cellStyle);
            CreateCell(headerRow, 8, "Booked Qty", cellStyle);
            CreateCell(headerRow, 9, "Package", cellStyle);
            CreateCell(headerRow, 10, "UPC digit", cellStyle);
            CreateCell(headerRow, 11, "EPC", cellStyle);
            CreateCell(headerRow, 12, "UPC", cellStyle);
        }
        protected void CreateCell(IRow currentRow, int cellIndex, string value, ICellStyle style)
        {
            ICell cell = currentRow.CreateCell(cellIndex);
            cell.SetCellValue(value);
            cell.CellStyle = style;
            
        }
        protected void CreateCell(IRow currentRow, int cellIndex, double value, ICellStyle style)
        {
            ICell cell = currentRow.CreateCell(cellIndex);
            cell.SetCellValue(value);
            cell.CellStyle = style;
        }
        protected void CreateCell(IRow currentRow, int cellIndex, DateTime value, ICellStyle style)
        {
            ICell cell = currentRow.CreateCell(cellIndex);
            cell.SetCellValue(value);
            cell.CellStyle = style;
        }
        protected ICellStyle HeaderCellStyle(IFont font)
        {
            ICellStyle borderedCellStyle = (XSSFCellStyle)workbook.CreateCellStyle();
            borderedCellStyle.SetFont(font);
            borderedCellStyle.FillPattern = FillPattern.NoFill;
            borderedCellStyle.BorderLeft = BorderStyle.Medium;
            borderedCellStyle.BorderTop = BorderStyle.Medium;
            borderedCellStyle.BorderRight = BorderStyle.Medium;
            borderedCellStyle.BorderBottom = BorderStyle.Medium;
            borderedCellStyle.VerticalAlignment = VerticalAlignment.Center;
            return borderedCellStyle;
        }
        protected ICellStyle BorderedCellStyle(IFont font)
        {
            ICellStyle borderedCellStyle = (XSSFCellStyle)workbook.CreateCellStyle();
            borderedCellStyle.SetFont(font);
            borderedCellStyle.BorderLeft = BorderStyle.Medium;
            borderedCellStyle.BorderTop = BorderStyle.Medium;
            borderedCellStyle.BorderRight = BorderStyle.Medium;
            borderedCellStyle.BorderBottom = BorderStyle.Medium;
            borderedCellStyle.VerticalAlignment = VerticalAlignment.Center;
            return borderedCellStyle;
        }

        protected ICellStyle DateCellStyle(IFont font)
        {
            ICellStyle dateCellStyle = (XSSFCellStyle)workbook.CreateCellStyle();
            IDataFormat dateFormat = (XSSFDataFormat)workbook.CreateDataFormat();
            dateCellStyle.DataFormat = dateFormat.GetFormat("dd-MMM-yyyy");
            dateCellStyle.SetFont(font);
            dateCellStyle.BorderLeft = BorderStyle.Medium;
            dateCellStyle.BorderTop = BorderStyle.Medium;
            dateCellStyle.BorderRight = BorderStyle.Medium;
            dateCellStyle.BorderBottom = BorderStyle.Medium;
            dateCellStyle.VerticalAlignment = VerticalAlignment.Center;
            return dateCellStyle;
        }

        protected ICellStyle NumberCellStyle(IFont font)
        {
            ICellStyle numberCellStyle = (XSSFCellStyle)workbook.CreateCellStyle();
            IDataFormat numberDataFormat = (XSSFDataFormat)workbook.CreateDataFormat();
            numberCellStyle.SetFont(font);
            numberCellStyle.BorderLeft = BorderStyle.Medium;
            numberCellStyle.BorderTop = BorderStyle.Medium;
            numberCellStyle.BorderRight = BorderStyle.Medium;
            numberCellStyle.BorderBottom = BorderStyle.Medium;
            numberCellStyle.VerticalAlignment = VerticalAlignment.Center;
            return numberCellStyle;
        }
    }
}
