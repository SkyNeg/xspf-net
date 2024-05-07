using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SkyNeg.Xspf
{
    [XmlRoot("playlist", Namespace = "http://xspf.org/ns/0/")]
    public class Playlist
    {
        [XmlAttribute(AttributeName = "version")]
        internal int Version { get; set; }
        /// <summary>
        /// A human-readable title for the playlist. xspf:playlist elements MAY contain exactly one.
        /// </summary>
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Human-readable name of the entity (author, authors, group, company, etc) that authored the playlist. xspf:playlist elements MAY contain exactly one.
        /// </summary>
        [XmlElement(ElementName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// A human-readable comment on the playlist.
        /// This is character data, not HTML, and it may not contain markup. xspf:playlist elements MAY contain exactly one.
        /// </summary>
        [XmlElement(ElementName = "annotation")]
        public string Annotation { get; set; }

        /// <summary>
        /// URI of a web page to find out more about this playlist.
        /// Likely to be homepage of the author, and would be used to find out more about the author and to find more playlists by the author. xspf:playlist elements MAY contain exactly one.
        /// </summary>
        [XmlElement(ElementName = "info")]
        public string Info { get; set; }

        /// <summary>
        /// Source URI for this playlist. xspf:playlist elements MAY contain exactly one.
        /// </summary>
        [XmlElement(ElementName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Canonical ID for this playlist.
        /// Likely to be a hash or other location-independent name. MUST be a legal URI. xspf:playlist elements MAY contain exactly one.
        /// </summary>
        [XmlElement(ElementName = "identifier")]
        public string Indentifier { get; set; }

        /// <summary>
        /// URI of an image to display in the absence of a //playlist/trackList/image element. xspf:playlist elements MAY contain exactly one.
        /// </summary>
        [XmlElement(ElementName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// Creation date (not last-modified date) of the playlist, formatted as a XML schema dateTime. xspf:playlist elements MAY contain exactly one.
        /// </summary>
        [XmlElement(ElementName = "date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// URI of a resource that describes the license under which this playlist was released. xspf:playlist elements may contain zero or one license element.
        /// </summary>
        [XmlElement(ElementName = "license")]
        public string License { get; set; }

        /// <summary>
        /// An ordered list of URIs. The purpose is to satisfy licenses allowing modification but requiring attribution.
        /// If you modify such a playlist, move its //playlist/location or //playlist/identifier element to the top of the items in the //playlist/attribution element. xspf:playlist elements MAY contain exactly one xspf:attribution element.
        /// https://www.xspf.org/spec#411210-attribution
        /// </summary>
        public List<string> Attribution { get; set; }

        /// <summary>
        /// The link element allows XSPF to be extended without the use of XML namespaces. xspf:playlist elements MAY contain zero or more link elements.
        /// <link rel="http://foaf.example.org/namespace/version1">http://socialnetwork.example.org/foaf/mary.rdfs</link>
        /// </summary>
        public List<Link> Links { get; set; }

        /// <summary>
        /// The meta element allows metadata fields to be added to XSPF. xspf:playlist elements MAY contain zero or more meta elements.
        /// </summary>
        [XmlElement(ElementName = "meta")]
        public Metadata Meta { get; set; }

        /// <summary>
        /// The extension element allows non-XSPF XML to be included in XSPF documents. The purpose is to allow nested XML, which the meta and link elements do not. xspf:playlist elements MAY contain zero or more extension elements.
        /// </summary>
        [XmlElement(ElementName = "extension")]
        public Extension Extension { get; set; }

        /// <summary>
        /// Ordered list of xspf:track elements to be rendered.
        /// The sequence is a hint, not a requirement; renderers are advised to play tracks from top to bottom unless there is an indication otherwise.
        /// If an xspf:track element cannot be rendered, a user-agent MUST skip to the next xspf:track element and MUST NOT interrupt the sequence. xspf:playlist elements MUST contain one and only one trackList element.
        /// The trackList element my be empty.
        /// </summary>
        [XmlArray("trackList")]
        [XmlArrayItem("track")]
        public List<Track> Tracks { get; set; }
    }
}
