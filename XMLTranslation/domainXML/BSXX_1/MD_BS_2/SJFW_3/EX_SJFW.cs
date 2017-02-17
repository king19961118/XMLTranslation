using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.BSXX_1.MD_BS_2.SJFW_3.EX_SJFW_4;

namespace XMLTranslation.domainXML.BSXX_1.MD_BS_2.SJFW_3
{
    [XmlRoot("EX_时间范围")]
    [Serializable]
    class EX_SJFW
    {
        /// <summary>
        /// 范围
        /// </summary>
        [XmlElement(ElementName = "范围")]
        public FW FW
        {
            set;
            get;
        }
    }
}
