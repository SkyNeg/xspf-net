using System.Xml.Serialization;

namespace SkyNeg.Xspf
{
    public class Link
    {
        /// <summary>
        /// URI of a resource type.
        /// </summary>
        [XmlAttribute(AttributeName = "rel")]
        public string Rel { get; set; }

        /// <summary>
        /// URI of a resource.
        /// </summary>
        [XmlText]
        public string Uri { get; set; }
    }
}
