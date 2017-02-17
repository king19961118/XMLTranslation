using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.BSXX_1.MD_BS_2.JTLLTXX_3;

namespace XMLTranslation.domainXML.BSXX_1.MD_BS_2
{
    [XmlRoot("静态浏览图信息")]
    [Serializable]
    class JTLLTXX
    {
        /// <summary>
        /// MD_浏览图
        /// </summary>
        [XmlElement(ElementName = "MD_浏览图")]
        public MD_LLT MD_LLT
        {
            set;
            get;
        }
    }
}
