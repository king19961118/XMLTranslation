using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLTranslation.domainXML
{
    [XmlRoot("福建省厦门市集美区基本农田永久划定成果元数据")]
    [Serializable]
    class Parent
    {
        /// <summary>
        /// 标识信息
        /// </summary>
        [XmlElement(ElementName = "标识信息")]
        public BSXX BSXX
        {
            set;
            get;
        }

        /// <summary>
        /// 数据质量信息
        /// </summary>
        [XmlElement(ElementName = "数据质量信息")]
        public SJZLXX SJZLXX
        {
            set;
            get;
        }

        /// <summary>
        /// 空间参照系统信息
        /// </summary>
        [XmlElement(ElementName = "空间参照系统信息")]
        public KJCZXTXX KJCZXTXX
        {
            set;
            get;
        }

        /// <summary>
        /// 内容信息
        /// </summary>
        [XmlElement(ElementName = "内容信息")]
        public NLXX NLXX
        {
            set;
            get;
        }

        /// <summary>
        /// 分发信息
        /// </summary>
        [XmlElement(ElementName = "分发信息")]
        public FFXX FFXX
        {
            set;
            get;
        }

        /// <summary>
        /// MD_元数据
        /// </summary>
        [XmlElement(ElementName = "MD_元数据")]
        public MD_YSJ MD_YSJ
        {
            set;
            get;
        }
    }
}
