using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLTranslation.domainXML
{
    [XmlRoot("数据质量信息")]
    [Serializable]
    class SJZLXX
    {
        /// <summary>
        /// 概述
        /// </summary>
        [XmlElement(ElementName = "概述")]
        public String YZ
        {
            set;
            get;
        }
        /// <summary>
        /// 数据志
        /// </summary>
        [XmlElement(ElementName = "数据志")]
        public String ZY
        {
            set;
            get;
        }
    }
}
