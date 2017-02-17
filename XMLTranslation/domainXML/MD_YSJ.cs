using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.MD_YSJ_1;

namespace XMLTranslation.domainXML
{
    [XmlRoot("MD_元数据")]
    [Serializable]
    class MD_YSJ
    {
        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement(ElementName = "日期")]
        public String RQ
        {
            set;
            get;
        }
        /// <summary>
        /// 联系
        /// </summary>
        [XmlElement(ElementName = "联系")]
        public LX LX
        {
            set;
            get;
        }
    }
}
