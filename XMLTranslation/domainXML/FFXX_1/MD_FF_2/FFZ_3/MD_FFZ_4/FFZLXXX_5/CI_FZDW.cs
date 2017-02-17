using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.FFXX_1.MD_FF_2.FFZ_3.MD_FFZ_4.FFZLXXX_5.CI_FZDW_6;

namespace XMLTranslation.domainXML.FFXX_1.MD_FF_2.FFZ_3.MD_FFZ_4.FFZLXXX_5
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
        public String ZZ1
        {
            set;
            get;
        }
        /// <summary>
        /// 职责
        /// </summary>
        [XmlElement(ElementName = "职责")]
        public String ZZ2
        {
            set;
            get;
        }
        /// <summary>
        /// 职责
        /// </summary>
        [XmlElement(ElementName = "职责")]
        public String ZZ3
        {
            set;
            get;
        }
        /// <联系信息>
        /// 负责单位名称
        /// </summary>
        [XmlElement(ElementName = "联系信息")]
        public LXXX LXXX
        {
            set;
            get;
        }
    }
}
