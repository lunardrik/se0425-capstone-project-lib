using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIB
{
    public class PublisherBUS
    {
        public int InsertPublisher(PublisherDTO publisher)
        {
            PublisherDAO dao = new PublisherDAO();
            return dao.InsertPublisher(publisher);
        }

        public int DeletePublisher(PublisherDTO publisher)
        {
            PublisherDAO dao = new PublisherDAO();
            return dao.DeletePublisher(publisher);
        }

        public int UpdatePublisher(PublisherDTO publisher)
        {
            PublisherDAO dao = new PublisherDAO();
            return dao.UpdatePublisher(publisher);
        }

        public PublisherDTO GetPublisherById(int publisherId)
        {
            PublisherDAO dao = new PublisherDAO();
            return dao.GetPublisherById(publisherId);
        }

        public List<PublisherDTO> GetAllPublisher()
        {
            PublisherDAO dao = new PublisherDAO();
            return dao.GetAllPublisher();
        }

        public List<PublisherDTO> SearchPublisher(string info)
        {
            PublisherDAO publisherDao=new PublisherDAO();
            return publisherDao.SearchPublisher(info);
        }
    }
}
