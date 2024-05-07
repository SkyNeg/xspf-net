using System.Xml;
using System.Xml.Serialization;

namespace SkyNeg.Xspf
{
    public class Extension
    {
        /// <summary>
        /// URI of a resource defining the structure and purpose of the nested XML.
        /// </summary>
        [XmlAttribute(AttributeName = "application")]
        public string Application { get; set; }

        /// <summary>
        /// nested XML
        /// </summary>
        [XmlText]
        public string Content { get; set; }
    }
}
