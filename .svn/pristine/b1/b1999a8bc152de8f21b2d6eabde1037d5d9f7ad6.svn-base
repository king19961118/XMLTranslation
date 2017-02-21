using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace XMLTranslation
{
    class ExcelOperate
    {
        /// <summary>
        /// 将xml对象添加到Excel文件内
        /// </summary>
        /// <param name="xmlObject">xml对象</param>
        /// <param name="FilePath">xml文件夹路径，错误日志路径</param>
        /// <returns></returns>
        public bool XMLObjectAddToExcel(List<XMLObject> xmlObjectList, String FilePath)
        {
            try
            {
                System.Data.DataTable dataTable = ListToDataTable<XMLObject>(xmlObjectList);
                int columnNumber = dataTable.Columns.Count;
                int rowNumber = dataTable.Rows.Count;
                //建立Excel对象 
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                //excel.Application.Workbooks.Add(true);
                Workbook workbook = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                Worksheet worksheet = (Worksheet)workbook.Worksheets[1];
                excel.Visible = true;
                //Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excel.Worksheets[1];
                Range range;

                //生成字段名称 
                for (int i = 0; i < columnNumber; i++)
                {
                    excel.Cells[1, i + 1] = Enum.Parse(typeof(ExcelTitleEnum), i.ToString()).ToString(); ;
                }

                object[,] objData = new object[rowNumber, columnNumber];
                for (int r = 0; r < rowNumber; r++)
                {

                    for (int c = 0; c < columnNumber; c++)
                    {
                        objData[r, c] = dataTable.Rows[r][c];
                    }
                }

                // 写入Excel 
                range = worksheet.Range[excel.Cells[2, 1], excel.Cells[rowNumber + 1, columnNumber]];
                //range.NumberFormat = "@";//设置单元格为文本格式
                range.Value2 = objData;
                //行高列宽
                worksheet.Rows.RowHeight = 25;
                worksheet.Columns.ColumnWidth = 24;
                //设置自动换行
                range.WrapText = true;
                worksheet.Range[excel.Cells[2, 1], excel.Cells[rowNumber + 1, 1]].NumberFormat = "yyyy-m-d h:mm";
                return true;
            }
            catch (Exception ex)
            {
                ErrorLog.RecordExceptionToFile(ex, FilePath, "excel 文件");
                MessageBox.Show("xml文件数据添加到excel时异常，请查看错误日志ErrorLog", "确定");
                return false;
            }
        }
        /// <summary>
        /// 将Excel文件生成无数个xml对象
        /// </summary>
        /// <param name="FilePath">excel文件的路径</param>
        /// <returns></returns>
        public List<XMLObject> ExcelToXMLObject(String FilePath)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                object missing = System.Reflection.Missing.Value;
                excel.Visible = false; 
                excel.UserControl = true;
                // 以只读的形式打开EXCEL文件
                Workbook wb = excel.Application.Workbooks.Open(FilePath, missing, true, missing, missing, missing,
                     missing, missing, missing, true, missing, missing, missing, missing, missing);
                //取得第一个工作薄
                Worksheet ws = (Worksheet)wb.Worksheets.get_Item(1);
                //取得总记录行数   (包括标题列)
                int rowsint = ws.UsedRange.Cells.Rows.Count; //得到行数
                int columnsint = ws.UsedRange.Cells.Columns.Count;//得到列数
                //取得数据范围区域 (不包括标题列) 
                XMLObject xmlObject = new XMLObject();
                List<XMLObject> xmlObjectList = new List<XMLObject>();
                System.Data.DataTable dataTable = new System.Data.DataTable();
                Type entityType = xmlObject.GetType();
                System.Reflection.PropertyInfo[] entityProperties = entityType.GetProperties();
                for (int i = 0; i < entityProperties.Length; i++)
                {
                    dataTable.Columns.Add(entityProperties[i].Name);
                }
                for (int i = 2; i <= rowsint; i++)//除去标题行开始，excel从1开始
                {
                    Range xml = ws.Cells.Range[excel.Cells[i, 1], excel.Cells[i, columnsint]];//一行excel
                    object[,] objData = new object[1, xml.Count];
                    objData = xml.Value2;//二维数据
                    object[] entityValues = new object[entityProperties.Length];
                    dataTable.Rows.Add();
                    for (int j = 0; j < entityProperties.Length; j++)
                    {
                        dataTable.Rows[i - 2][j] = objData[1, j + 1] == null ? "" : objData[1, j + 1];//datatable从0,0开始
                    }
                }
                return DataTableToList(dataTable);
            }
            catch(Exception ex){
                ErrorLog.RecordExceptionToFile(ex, FilePath,"excel 文件 转 object时");
                MessageBox.Show("excel文件读取数据时异常，请查看错误日志ErrorLog", "确定");
                return null;
            }
            finally
            {
                excel.Quit();
                excel = null;
                GC.Collect();
            }
        }

        /// <summary>
        /// 将泛类型集合List类转换成DataTable
        /// </summary>
        /// <param name="list">泛类型集合</param>
        /// <returns></returns>
        public static System.Data.DataTable ListToDataTable<T>(List<T> entitys)
        {
            //检查实体集合不能为空
            if (entitys == null || entitys.Count < 1)
            {
                throw new Exception("需转换的集合为空");
            }
            //取出第一个实体的所有Propertie
            Type entityType = entitys[0].GetType();
            System.Reflection.PropertyInfo[] entityProperties = entityType.GetProperties();

            //生成DataTable的structure
            //生产代码中，应将生成的DataTable结构Cache起来，此处略
            System.Data.DataTable dt = new System.Data.DataTable();
            for (int i = 0; i < entityProperties.Length; i++)
            {
                dt.Columns.Add(entityProperties[i].Name);
            }
            //将所有entity添加到DataTable中
            foreach (object entity in entitys)
            {
                //检查所有的的实体都为同一类型
                if (entity.GetType() != entityType)
                {
                    throw new Exception("要转换的集合元素类型不一致");
                }
                object[] entityValues = new object[entityProperties.Length];
                for (int i = 0; i < entityProperties.Length; i++)
                {
                    entityValues[i] = entityProperties[i].GetValue(entity, null);
                }
                dt.Rows.Add(entityValues);
            }
            return dt;
        }
        /// <summary>
        /// datatable 转List<object>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<XMLObject> DataTableToList(System.Data.DataTable table)
        {
            List<XMLObject> ts = new List<XMLObject>();// 定义集合
            Type type = typeof(XMLObject); // 获得此模型的类型
            string tempName = "";
            foreach (System.Data.DataRow dr in table.Rows)
            {
                XMLObject t = new XMLObject();
                System.Reflection.PropertyInfo[] propertys = t.GetType().GetProperties();// 获得此模型的公共属性
                foreach (System.Reflection.PropertyInfo pi in propertys)
                {
                    tempName = pi.Name;
                    if (table.Columns.Contains(tempName))
                    {
                        if (!pi.CanWrite) continue;
                        object value = dr[tempName];
                        if (value != DBNull.Value)
                            pi.SetValue(t, value, null);
                    }
                }
                ts.Add(t);
            }
            return ts;

        } 
    }
}
