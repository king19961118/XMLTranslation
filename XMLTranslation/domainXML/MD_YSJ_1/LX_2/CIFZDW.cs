using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLTranslation.domainXML.MD_YSJ_1.LX_2
{
    [XmlRoot("CI负责单位")]
    [Serializable]
    class CIFZDW
    {
        /// <summary>
        /// 负责单位名称
        /// </summary>
        [XmlElement(ElementName = "负责单位名称")]
        public String FZDWMC
        {
            set;
            get;
        }

        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement(ElementName = "联系人")]
        public String LXR
        {
            set;
            get;
        }

        /// <summary>
        /// 职责
        /// </summary>
        [XmlElement(ElementName = "职责")]
        public String ZZ
        {
            set;
            get;
        }
    }
}
