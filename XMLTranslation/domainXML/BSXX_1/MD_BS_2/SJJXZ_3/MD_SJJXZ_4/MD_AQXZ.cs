using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLTranslation.domainXML.BSXX_1.MD_BS_2.SJJXZ_3.MD_SJJXZ_4
{
    [XmlRoot("MD_安全限制")]
    [Serializable]
    class MD_AQXZ
    {
        /// <summary>
        /// 安全等级代码
        /// </summary>
        [XmlElement(ElementName = "安全等级代码")]
        public String AQDJDM
        {
            set;
            get;
        }
    }
}
