using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLTranslation.domainXML.KJCZXTXX_1.RS_CZXX_2.SC_DDZBCZXX_3
{
    [XmlRoot("SC_大地坐标系统")]
    [Serializable]
    class SC_DDZBXX
    {
        /// <summary>
        /// 坐标系统类型
        /// </summary>
        [XmlElement(ElementName = "坐标系统类型")]
        public String ZBXTLX
        {
            set;
            get;
        }
        /// <summary>
        /// 坐标系统名称
        /// </summary>
        [XmlElement(ElementName = "坐标系统名称")]
        public String ZBXTMC
        {
            set;
            get;
        }
        /// <summary>
        /// 投影坐标系统参数
        /// </summary>
        [XmlElement(ElementName = "投影坐标系统参数")]
        public String TYZBXTCS
        {
            set;
            get;
        }
    }
}
