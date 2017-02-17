using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLTranslation.domainXML.BSXX_1.MD_BS_2.JTLLTXX_3
{
    [XmlRoot("MD_浏览图")]
    [Serializable]
    class MD_LLT
    {
        /// <summary>
        /// CI_负责单位
        /// </summary>
        [XmlElement(ElementName = "文件名称")]
        public String WJMC
        {
            set;
            get;
        }
    }
}
