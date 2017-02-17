using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.BSXX_1.MD_BS_2.SJJXZ_3;

namespace XMLTranslation.domainXML.BSXX_1.MD_BS_2
{
    [XmlRoot("数据集限制")]
    [Serializable]
    class SJJXZ
    {
        /// <summary>
        /// MD_数据集限制
        /// </summary>
        [XmlElement(ElementName = "MD_数据集限制")]
        public MD_SJJXZ MD_SJJXZ
        {
            set;
            get;
        }
    }
}
