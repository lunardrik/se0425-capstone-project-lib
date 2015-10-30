using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchingClassDiagram.DTO
{
    class SearchBookDTO
    {
        private string stInfo;

        public string StInfo
        {
            get { return stInfo; }
            set { stInfo = value; }
        }
        private string ndInfo;

        public string NdInfo
        {
            get { return ndInfo; }
            set { ndInfo = value; }
        }
        private string rdInfo;

        public string RdInfo
        {
            get { return rdInfo; }
            set { rdInfo = value; }
        }
        private string stFieldToSearch;

        public string StFieldToSearch
        {
            get { return stFieldToSearch; }
            set { stFieldToSearch = value; }
        }
        private string ndFieldToSearch;

        public string NdFieldToSearch
        {
            get { return ndFieldToSearch; }
            set { ndFieldToSearch = value; }
        }
        private string rdFieldToSearch;

        public string RdFieldToSearch
        {
            get { return rdFieldToSearch; }
            set { rdFieldToSearch = value; }
        }
        private int type1;

        public int Type1
        {
            get { return type1; }
            set { type1 = value; }
        }
        private int type2;

        public int Type2
        {
            get { return type2; }
            set { type2 = value; }
        }
        private int type3;

        public int Type3
        {
            get { return type3; }
            set { type3 = value; }
        }
        private int ano1;

        public int Ano1
        {
            get { return ano1; }
            set { ano1 = value; }
        }
        private int ano2;

        public int Ano2
        {
            get { return ano2; }
            set { ano2 = value; }
        }
    }
}
