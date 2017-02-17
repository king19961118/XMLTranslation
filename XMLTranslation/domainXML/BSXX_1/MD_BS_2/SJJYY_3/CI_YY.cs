using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLTranslation.domainXML.BSXX_1.MD_BS_2.SJJYY_3
{
    [XmlRoot("CI_引用")]
    [Serializable]
    class CI_YY
    {
        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement(ElementName = "名称")]
        public String MC
        {
            set;
            get;
        }
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
        /// 版本
        /// </summary>
        [XmlElement(ElementName = "版本")]
        public String BB
        {
            set;
            get;
        }
    }
}
