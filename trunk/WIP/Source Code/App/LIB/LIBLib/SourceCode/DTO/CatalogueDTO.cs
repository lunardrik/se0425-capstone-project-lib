using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LIB
{
    public class CatalogueDTO
    {
        private string _image;
        private List<AuthorOfBookDTO> _authorList;

        /*Properties of Catalogue*/
        public String ISBN { get; set; }
        public String Title { get; set; }
        public PublisherDTO Publisher { get; set; }
        public String ShortDescription { get; set; }
        public CategoryDTO Category { get; set; }
        public List<AuthorOfBookDTO> AuthorList
        {
            get { return _authorList; }
            set
            {
                _authorList = value;
                string authors = _authorList.Aggregate("", (str, au) => str + au.Author.AuthorName + "; ");
                Authors = authors.Substring(0, authors.Length <= 2 ? authors.Length : (authors.Length - 2));
            }
        }
        public string Authors { get; set; }
        public String Language { get; set; }
        public int Year { get; set; }
        public int ExpandLimit { get; set; }
        public int ExpandDateLimit { get; set; }
        public int NumberOfCopies { get; set; }
        public int AvailableCopies { get; set; }
        public String Image 
        { 
            get
            {
                return _image;
            } 
            set 
            { 
                _image = value;

                // ++ DiepTN: 11/03/2012 - Add
                try
                {
                    if (!Options.IsWeb)
                    {
                        if (!value.Equals(""))
                        {
                            Img = System.Drawing.Image.FromFile(Options.ImageFolder + value);
                        }
                        else
                        {
                            Img = System.Drawing.Image.FromFile(Options.ImageFolder + Options.NotAvaiable);
                        }
                    }
                } catch(Exception e)
                {
                    Log.Error("Error at CatalogueDTO - Set Img", e);                    
                }
                // --
            } 
        }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public float Price { get; set; }
        public Image Img { get; set; }
        public int HitTime { get; set; }
        public int RentalTime { get; set; }
    }
}
