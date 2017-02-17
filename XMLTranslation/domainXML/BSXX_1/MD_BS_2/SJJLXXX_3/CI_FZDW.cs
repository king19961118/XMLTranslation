using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.BSXX_1.MD_BS_2.SJJLXXX_3.CI_FZDW_4;

namespace XMLTranslation.domainXML.BSXX_1.MD_BS_2.SJJLXXX_3
{
    [XmlRoot("CI_负责单位")]
    [Serializable]
    class CI_FZDW
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
