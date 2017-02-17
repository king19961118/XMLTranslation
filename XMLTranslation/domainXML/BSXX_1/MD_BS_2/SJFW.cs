using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.BSXX_1.MD_BS_2.SJFW_3;

namespace XMLTranslation.domainXML.BSXX_1.MD_BS_2
{
    [XmlRoot("时间范围")]
    [Serializable]
    class SJFW
    {
        /// <summary>
        /// EX_时间范围
        /// </summary>
        [XmlElement(ElementName = "EX_时间范围")]
        public EX_SJFW EX_SJFW
        {
            set;
            get;
        }
    }
}
