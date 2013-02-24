using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funktagebuch
{
    class FunktagebuchEntry
    {
        private DateTime timestamp;
        public DateTime Timestamp
        {
            get { return timestamp; }
        }

        private string from;
        public string From
        {
            get { return from; }
        }

        private string to;
        public string To
        {
            get { return to; }
        }

        private string content;
        public string Content
        {
            get { return content; }
        }

        private string funker;
        public string Funker
        {
            get { return funker; }
        }

        public FunktagebuchEntry(DateTime timestamp, string from, string to, string content, string funker)
        {
            this.timestamp = timestamp;
            this.from = from;
            this.to = to;
            this.content = content;
            this.funker = funker;
        }

        public FunktagebuchEntry(FunktagebuchEntry other)
            : this(other.Timestamp, other.From, other.To, other.Content, other.Funker)
        { }
    }
}
