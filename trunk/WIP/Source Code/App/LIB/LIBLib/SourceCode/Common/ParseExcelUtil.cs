using System.Collections.Generic;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;

namespace LIB
{
    public class ParseExcelUtil
    {
        public static List<List<object>> ReadExcelFile(FileStream file)
        {
            HSSFWorkbook wb = new HSSFWorkbook(file);
            List<List<object>> data = new List<List<object>>();

            ISheet sheet = wb.GetSheetAt(0);

            for (int i = 0; i <= sheet.LastRowNum; i++)
            {
                List<object> rowData = new List<object>();

                IRow row = sheet.GetRow(i);
                for (int j = 0; j < row.LastCellNum; j++)
                {
                    ICell cell = row.GetCell(j);

                    switch (cell.CellType)
                    {
                        case CellType.STRING:
                            rowData.Add(cell.StringCellValue);
                            break;

                        case CellType.NUMERIC:
                            if (DateUtil.IsCellDateFormatted(cell))
                            {
                                rowData.Add(DateUtil.GetJavaDate(cell.NumericCellValue));
                            }
                            else
                            {
                                rowData.Add(cell.NumericCellValue);
                            }
                            break;

                        default:
                            rowData.Add(cell.StringCellValue);
                            break;
                    }
                }

                data.Add(rowData);
            }

            return data;
        }
    }
}
