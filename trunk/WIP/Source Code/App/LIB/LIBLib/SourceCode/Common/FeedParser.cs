﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LIB
{
    /// <summary>
    /// A simple RSS, RDF and ATOM feed parser.
    /// </summary>
    public class FeedParser
    {
        /// <summary>
        /// Parses the given <see cref="FeedType"/> and returns a <see cref="IList&lt;FeedDTO&gt;"/>.
        /// </summary>
        /// <returns></returns>
        public IList<FeedDTO> Parse(string url, FeedType feedType)
        {
            switch (feedType)
            {
                case FeedType.RSS:
                    return ParseRss(url);
                case FeedType.RDF:
                    return ParseRdf(url);
                case FeedType.Atom:
                    return ParseAtom(url);
                default:
                    throw new NotSupportedException(string.Format("{0} is not supported", feedType.ToString()));
            }
        }

        /// <summary>
        /// Parses an Atom feed and returns a <see cref="IList&lt;FeedDTO&gt;"/>.
        /// </summary>
        public virtual IList<FeedDTO> ParseAtom(string url)
        {
            try
            {
                XDocument doc = XDocument.Load(url);

                // Feed/Entry
                var entries = from item in doc.Root.Elements().Where(i => i.Name.LocalName == "entry")
                              select new FeedDTO
                                         {
                                             FeedType = FeedType.Atom,
                                             Content = item.Elements().First(i => i.Name.LocalName == "content").Value,
                                             Link = item.Elements().First(i => i.Name.LocalName == "link").Attribute("href").Value,
                                             PublishDate = ParseDate(item.Elements().First(i => i.Name.LocalName == "published").Value),
                                             Title = item.Elements().First(i => i.Name.LocalName == "title").Value
                                         };

                return entries.ToList();
            }
            catch
            {
                return new List<FeedDTO>();
            }
        }

        /// <summary>
        /// Parses an RSS feed and returns a <see cref="IList&lt;FeedDTO&gt;"/>.
        /// </summary>
        public virtual IList<FeedDTO> ParseRss(string url)
        {
            try
            {
                XDocument doc = XDocument.Load(url);

                // RSS/Channel/item
                var entries = from item in doc.Root.Descendants().First(i => i.Name.LocalName == "channel").Elements().Where(i => i.Name.LocalName == "item")
                              select new FeedDTO
                                         {
                                             FeedType = FeedType.RSS,
                                             Content = item.Elements().First(i => i.Name.LocalName == "description").Value,
                                             Link = item.Elements().First(i => i.Name.LocalName == "link").Value,
                                             PublishDate = ParseDate(item.Elements().First(i => i.Name.LocalName == "pubDate").Value),
                                             Title = item.Elements().First(i => i.Name.LocalName == "title").Value
                                         };

                return entries.ToList();
            }
            catch
            {
                return new List<FeedDTO>();
            }
        }

        /// <summary>
        /// Parses an RDF feed and returns a <see cref="IList&lt;FeedDTO&gt;"/>.
        /// </summary>
        public virtual IList<FeedDTO> ParseRdf(string url)
        {
            try
            {
                XDocument doc = XDocument.Load(url);

                // <item> is under the root
                var entries = from item in doc.Root.Descendants().Where(i => i.Name.LocalName == "item")
                              select new FeedDTO
                                         {
                                             FeedType = FeedType.RDF,
                                             Content = item.Elements().First(i => i.Name.LocalName == "description").Value,
                                             Link = item.Elements().First(i => i.Name.LocalName == "link").Value,
                                             PublishDate = ParseDate(item.Elements().First(i => i.Name.LocalName == "date").Value),
                                             Title = item.Elements().First(i => i.Name.LocalName == "title").Value
                                         };

                return entries.ToList();
            }
            catch
            {
                return new List<FeedDTO>();
            }
        }

        private DateTime ParseDate(string date)
        {
            DateTime result;
            if (DateTime.TryParse(date, out result))
                return result;
            else
                return DateTime.MinValue;
        }
    }
}