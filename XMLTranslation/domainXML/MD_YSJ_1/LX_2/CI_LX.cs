using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.MD_YSJ_1.LX_2.CI_LX_3;

namespace XMLTranslation.domainXML.MD_YSJ_1.LX_2
{

    [XmlRoot("CI_联系")]
    [Serializable]
    class CI_LX
    {
        /// <summary>
        /// 联系信息
        /// </summary>
        [XmlElement(ElementName = "联系信息")]
        public LXXX LXXX
        {
            set;
            get;
        }
    }
}
