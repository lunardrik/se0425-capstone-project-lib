using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using LIB;
using LIB.Common;

namespace LIB
{
    public class PublisherDAO
    {
        public int InsertPublisher(PublisherDTO publisher)
        {
            publisher.UpdatedDate = DateTime.Now;
            publisher.CreatedDate = DateTime.Now;
            try
            {
                ConnectionManager.GetCommand("SP0402",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param2", SqlDbType.NVarChar},
                                                     {"@Param3", SqlDbType.DateTime},
                                                     {"@Param4", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     publisher.PublisherName,
                                                     publisher.CreatedDate,
                                                     publisher.UpdatedDate
                                                 }).ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Log.Error("Error at PublisherDAO - InsertPublisher", e);
                return 0;
            }

            return 1;
        }

        public int DeletePublisher(PublisherDTO publisher)
        {
            try
            {
                ConnectionManager.GetCommand("SP0404",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.Int}
                                                 },
                                             new List<object>()
                                                 {
                                                     publisher.PublisherId
                                                 }).ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Log.Error("Error at PublisherDAO - DeletePublisher", e);
                return 0;
            }

            return 1;
        }

        public int UpdatePublisher(PublisherDTO publisher)
        {
            publisher.UpdatedDate = DateTime.Now;
            try
            {
                ConnectionManager.GetCommand("SP0403",
                                             new Dictionary<string, SqlDbType>()
                                                 {
                                                     {"@Param1", SqlDbType.Int},
                                                     {"@Param2", SqlDbType.NVarChar},
                                                     {"@Param3", SqlDbType.DateTime},
                                                     {"@Param4", SqlDbType.DateTime}
                                                 },
                                             new List<object>()
                                                 {
                                                     publisher.PublisherId,
                                                     publisher.PublisherName,
                                                     publisher.CreatedDate,
                                                     publisher.UpdatedDate
                                                 }).ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Log.Error("Error at PublisherDAO - UpdatePublisher", e);
                return 0;
            }

            return 1;
        }

        public PublisherDTO GetPublisherById(int publisherId)
        {
            PublisherDTO publisherDto = null;

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0401PI",
                                                                    new Dictionary<string, SqlDbType>() { { "@Param1", SqlDbType.Int } },
                                                                    new List<object>() { publisherId }).ExecuteReader();

                if (reader.Read())
                {
                    publisherDto = new PublisherDTO();
                    publisherDto.PublisherId = int.Parse(reader["PublisherID"].ToString());
                    publisherDto.PublisherName = reader["PublisherName"].ToString();
                    publisherDto.CreatedDate = (DateTime)reader["CreatedDate"];
                    publisherDto.UpdatedDate = (DateTime)reader["UpdatedDate"];
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at PublisherDAO - GetPublisherByID", e);
                return null;
            }

            return publisherDto;
        }

        public List<PublisherDTO> GetAllPublisher()
        {
            List<PublisherDTO> list = new List<PublisherDTO>();

            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("SP0401ALL",
                                                                    new Dictionary<string, SqlDbType>() { },
                                                                    new List<object>() { }).ExecuteReader();

                while (reader.Read())
                {
                    PublisherDTO publisherDto = new PublisherDTO();
                    publisherDto.PublisherId = int.Parse(reader["PublisherID"].ToString());
                    publisherDto.PublisherName = reader["PublisherName"].ToString();
                    publisherDto.CreatedDate = (DateTime)reader["CreatedDate"];
                    publisherDto.UpdatedDate = (DateTime)reader["UpdatedDate"];
                    list.Add(publisherDto);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Error("Error at AuthorDAO - GetAllPublisher", e);
                return null;
            }

            return list;
        }

        public List<PublisherDTO> SearchPublisher(string info)
        {
            List<PublisherDTO> list=new List<PublisherDTO>();
            PublisherDTO publisherDTO;
            try
            {
                SqlDataReader reader = ConnectionManager.GetCommand("sp0005publisher",
                                                                    new Dictionary<string, SqlDbType>() { { "@publisher", SqlDbType.NVarChar } },
                                                                    new List<object>() { info }).ExecuteReader();

                while (reader.Read())
                {
                    publisherDTO = new PublisherDTO();
                    publisherDTO.PublisherId = int.Parse(reader["publisherID"].ToString());
                    publisherDTO.PublisherName = reader["publisherName"].ToString();
                    publisherDTO.CreatedDate = (DateTime)reader["CreatedDate"];
                    publisherDTO.UpdatedDate = (DateTime)reader["UpdatedDate"];
                    list.Add(publisherDTO);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Log.Logger.Error("Error at AuthorDAO - GetAuthorByID", e);
                return null;
            }
            return list;
        }
    }
}
