using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LIB
{
    public class SearchBookResultDTO
    {
        private string _image;

        public int No { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string PublisherName { get; set; }
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }
        public string ShortDescription { get; set; }
        public String Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = Options.ImageFolder + (value.ToString().Equals("") ? Options.NotAvaiable : value);

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
                }
                catch (Exception e)
                {
                    Log.Error("Error at SearchBookResultDTO - Set Img", e);
                }
                // --
            }
        }
        public Image Img { get; set; }

    }
}
