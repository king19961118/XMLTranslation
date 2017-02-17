using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLTranslation.domainXML.BSXX_1.MD_BS_2;

namespace XMLTranslation.domainXML.BSXX_1
{
    [XmlRoot("MD_标识")]
    [Serializable]
    class MD_BS
    {
        /// <summary>
        /// 数据集引用
        /// </summary>
        [XmlElement(ElementName = "数据集引用")]
        public SJJYY SJJYY
        {
            set;
            get;
        }
        /// <summary>
        /// 语种
        /// </summary>
        [XmlElement(ElementName = "语种")]
        public String YZ
        {
            set;
            get;
        }
        /// <summary>
        /// 摘要
        /// </summary>
        [XmlElement(ElementName = "摘要")]
        public String ZY
        {
            set;
            get;
        }
        /// <summary>
        /// 现状
        /// </summary>
        [XmlElement(ElementName = "现状")]
        public String XZ
        {
            set;
            get;
        }
        /// <summary>
        /// 土地利用分类系统
        /// </summary>
        [XmlElement(ElementName = "土地利用分类系统")]
        public String TDLYFLXT
        {
            set;
            get;
        }
        /// <summary>
        /// 地理范围
        /// </summary>
        [XmlElement(ElementName = "地理范围")]
        public DLFW DLFW
        {
            set;
            get;
        }
        /// <summary>
        /// 地理描述
        /// </summary>
        [XmlElement(ElementName = "地理描述")]
        public DLMS DLMS
        {
            set;
            get;
        }
        /// <summary>
        /// 时间范围
        /// </summary>
        [XmlElement(ElementName = "时间范围")]
        public SJFW SJFW
        {
            set;
            get;
        }
        /// <summary>
        /// 表示方式
        /// </summary>
        [XmlElement(ElementName = "表示方式")]
        public String BSFS
        {
            set;
            get;
        }
        /// <summary>
        /// 空间分辨率
        /// </summary>
        [XmlElement(ElementName = "空间分辨率")]
        public String KJFBL
        {
            set;
            get;
        }
        /// <summary>
        /// 类别
        /// </summary>
        [XmlElement(ElementName = "类别")]
        public String LB
        {
            set;
            get;
        }
        /// <summary>
        /// 数据集联系信息
        /// </summary>
        [XmlElement(ElementName = "数据集联系信息")]
        public SJJLXXX SJJLXXX
        {
            set;
            get;
        }
        /// <summary>
        /// 静态浏览图信息
        /// </summary>
        [XmlElement(ElementName = "静态浏览图信息")]
        public JTLLTXX JTLLTXX
        {
            set;
            get;
        }
        /// <summary>
        /// 数据集限制
        /// </summary>
        [XmlElement(ElementName = "数据集限制")]
        public SJJXZ SJJXZ
        {
            set;
            get;
        }
        /// <summary>
        /// 数据集格式
        /// </summary>
        [XmlElement(ElementName = "数据集格式")]
        public SJJGS SJJGS
        {
            set;
            get;
        }
    }
}
