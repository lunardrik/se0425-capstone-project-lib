using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIB
{
    public class QuoteBUS
    {
        public string GetRandomQuote()
        {
            QuoteDAO dao = new QuoteDAO();
            return dao.GetRandomQuote();
        }
    }
}
