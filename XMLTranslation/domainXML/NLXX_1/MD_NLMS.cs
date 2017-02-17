using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLTranslation.domainXML.NLXX_1
{
    [XmlRoot("标识信息")]
    [Serializable]
    class MD_NLMS
    {
        /// <summary>
        /// 图层名称
        /// </summary>
        [XmlElement(ElementName = "图层名称")]
        public String TCMC
        {
            set;
            get;
        }
        /// <summary>
        /// 要素（实体）类型名称
        /// </summary>
        [XmlElement(ElementName = "要素（实体）类型名称")]
        public String YSSTLXMC
        {
            set;
            get;
        }
        /// <summary>
        /// 属性列表
        /// </summary>
        [XmlElement(ElementName = "属性列表")]
        public String SXLB
        {
            set;
            get;
        }
    }
}
