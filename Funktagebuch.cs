using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Funktagebuch
{
    class Funktagebuch
    {
        private SortedDictionary<int, FunktagebuchEntry> entries;
        private DateTime beginn;
        private DateTime ende;
        public DateTime Beginn
        {
            get { return beginn; }
            set { beginn = value; }
        }
        public DateTime Ende
        {
            get { return ende; }
            set { ende = value; }
        }
        private string funker = "unbekannt";
        public string Funker
        {
            get { return funker; }
            set { funker = value; }
        }
        private string einsatzgebiet = "unbekannt";
        public string Einsatzgebiet
        {
            get { return einsatzgebiet; }
            set { einsatzgebiet = value; }
        }
        private int funkkanal;
        public int Funkkanal
        {
            get { return funkkanal; }
            set { funkkanal = value; }
        }
        public bool EinsatzBegonnen
        {
            get { return beginn != DateTime.MinValue; }
        }
        public bool EinsatzBeendet
        {
            get { return ende != DateTime.MinValue; }
        }

        public Funktagebuch()
        {
            entries = new SortedDictionary<int, FunktagebuchEntry>();
        }

        public void AddEntry(string from, string to, string content, string funker)
        {
            from = prependKennungen(from);
            to = prependKennungen(to);
            if (entries.Count > 0)
            {
                entries.Add(entries.Keys.Max() + 1, new FunktagebuchEntry(
                    DateTime.Now, from, to, content, funker
                ));
            }
            else
            {
                entries.Add(1, new FunktagebuchEntry(
                    DateTime.Now, from, to, content, funker
                ));
            }
        }

        private string prependKennungen(string input)
        {
            Regex regex = new Regex(@"^(\d{1,3}[-\/]?)+$");
            if (input.Length < Properties.Settings.Default.OrgaKennung.Length ||
                input.Substring(0, Properties.Settings.Default.OrgaKennung.Length) 
                != Properties.Settings.Default.OrgaKennung) // Es steht keine Orga-Kennung vor dem Rufnamen
            {
                if ((input.Length < Properties.Settings.Default.Gliederung.Length ||
                    input.Substring(0, Properties.Settings.Default.Gliederung.Length)
                    != Properties.Settings.Default.Gliederung)
                    && regex.IsMatch(input)) // Es steht kein Gliederungskennung vor dem Rufnamen
                {
                    input = Properties.Settings.Default.Gliederung + " " + input;
                }
                input = Properties.Settings.Default.OrgaKennung + " " + input;
            }
            return input;
        }

        public SortedDictionary<int, FunktagebuchEntry> Entries
        {
            get
            {
                return new SortedDictionary<int, FunktagebuchEntry>(entries);
            }
        }

        public void Save()
        {

        }

        public static Funktagebuch Open(string path)
        {
            throw new NotImplementedException();
        }

        public void Save(string path)
        {
            throw new NotImplementedException();
        }
    }
}
