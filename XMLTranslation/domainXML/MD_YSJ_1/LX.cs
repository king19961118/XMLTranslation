using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.MD_YSJ_1.LX_2;

namespace XMLTranslation.domainXML.MD_YSJ_1
{
    [XmlRoot("联系")]
    [Serializable]
    class LX
    {
        /// <summary>
        /// CI负责单位
        /// </summary>
        [XmlElement(ElementName = "CI负责单位")]
        public CIFZDW CIFZDW
        {
            set;
            get;
        }

        /// <summary>
        /// CI_联系
        /// </summary>
        [XmlElement(ElementName = "CI_联系")]
        public CI_LX CI_LX
        {
            set;
            get;
        }
    }
}
