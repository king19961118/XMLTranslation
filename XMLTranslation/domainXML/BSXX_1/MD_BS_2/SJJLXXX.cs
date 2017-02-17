using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.BSXX_1.MD_BS_2.SJJLXXX_3;

namespace XMLTranslation.domainXML.BSXX_1.MD_BS_2
{
    [XmlRoot("数据集联系信息")]
    [Serializable]
    class SJJLXXX
    {
        /// <summary>
        /// CI_负责单位
        /// </summary>
        [XmlElement(ElementName = "CI_负责单位")]
        public CI_FZDW CI_FZDW
        {
            set;
            get;
        }
    }
}
