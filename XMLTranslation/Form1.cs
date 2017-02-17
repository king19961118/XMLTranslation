using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace XMLTranslation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //excel路径选择事件
        private void excelPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Microsoft Excel files(*.xls)|*.xls;*.xlsx";
            if (OFD.ShowDialog() != DialogResult.OK)
                return;
            this.excelPath.Text = OFD.FileName;
            string str = System.IO.Path.GetExtension(this.excelPath.Text);
        }
        //xml路径选择事件
        private void XMLPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "选择XML导入的文件夹";
            if (FBD.ShowDialog() != DialogResult.OK)
                return;
            this.XMLPath.Text = FBD.SelectedPath;
        }
        //print路径选择事件
        private void printPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "选择输出文件夹";
            if (FBD.ShowDialog() != DialogResult.OK)
                return;
            this.printPath.Text = FBD.SelectedPath;
        }
        //excel转换成xml事件
        private void btnExcelToXML_Click(object sender, EventArgs e)
        {
            String excelDataPath = this.excelPath.Text;//excel文件的路径
            String printPath = this.printPath.Text;//生成文件的路径
            if (!Directory.Exists(printPath))//生产xml的路径不存在 直接结束
            {
                printPath = excelDataPath.Substring(0, excelDataPath.LastIndexOf("\\"));
            }
            XMLOperate xmlOperate = new XMLOperate();
            ExcelOperate excelOperate = new ExcelOperate();
            List<XMLObject> xmlObjectList=excelOperate.ExcelToXMLObject(excelDataPath);
            foreach (XMLObject xmlObject in xmlObjectList)
            {
                xmlOperate.ObjectToXMLFile(printPath,xmlObject);
            }
            MessageBox.Show("excel已经转成xml文件", "确定");
        }
        //xml转换成excel事件
        private void btnXMLToExcel_Click(object sender, EventArgs e)
        {
            String xmlFilePath = this.XMLPath.Text;//xml文件夹路径
            String printPath = this.printPath.Text;//生成文件的路径    这里为excel文件的路径
            if (!Directory.Exists(xmlFilePath))//xml的路径不存在 直接结束
            {
                DialogResult dr = MessageBox.Show("文件夹内未有xml文件");
                return;
            }
            if (!Directory.Exists(printPath))//不存在，使用xml的路径
            {
                printPath = xmlFilePath;
            }
            String guid = System.Guid.NewGuid().ToString();//生成的guid
            DirectoryInfo folder = new DirectoryInfo(xmlFilePath);

            XMLOperate xmlOperate = new XMLOperate();
            ExcelOperate excelOperate = new ExcelOperate();

            List<XMLObject> xmlObjectList=new List<XMLObject>();
            foreach (FileInfo file in folder.GetFiles("*.xml"))
            {
                xmlObjectList.Add(xmlOperate.XMLFiletoObject(xmlFilePath, file.Name));//一个xml文件内的数据转成object     
            }
            excelOperate.XMLObjectAddToExcel(xmlObjectList, xmlFilePath);
            MessageBox.Show("xml文件已经转成excel文件", "确定");
        }
    }
}
