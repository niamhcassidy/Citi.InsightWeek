using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace VerySimpleContactsCRUDApp
{
    public static class MarketDataDAO
    {
        private static string strConn = @"user id = root;" + 
                                       "password=c0nygre;server=localhost:3306;" + 
                                       "Trusted_Connection=yes;" + 
                                       "database=test; " + 
                                       "connection timeout=30";
        public static List<MarketData> AllMarketData()
        {
            List<MarketData> MarketDatas = new List<MarketData>();
            using(SqlConnection cn = new SqlConnection(strConn))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM MarketData",cn);
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                            MarketDatas.Add(new MarketData(dr.GetString(dr.GetOrdinal("ticker")), 
                            dr.GetString(dr.GetOrdinal("Date")),
                            dr.GetDouble(dr.GetOrdinal("Open")),
                            dr.GetDouble(dr.GetOrdinal("High")),
                            dr.GetDouble(dr.GetOrdinal("Low")),
                            dr.GetDouble(dr.GetOrdinal("Close")),
                            dr.GetInt32(dr.GetOrdinal("Volume"))));
                    }
                }
            }
            return MarketDatas;
        }
        public static void AddContact(Contact c)
        {
            using (SqlConnection cn = new SqlConnection(strConn))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Contact(name,email,phone)" +
                    " VALUES(@name,@email,@phone)", cn);
                cmd.Parameters.AddWithValue("@name", c.Name);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@phone", c.Phone);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateContact(Contact c)
        {
            using (SqlConnection cn = new SqlConnection(strConn))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Contact SET name = " +
                    "@name, email = @email, Phone = @phone WHERE id = @id", cn);
                cmd.Parameters.AddWithValue("@name", c.Name);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@phone", c.Phone);
                cmd.Parameters.AddWithValue("@id", c.Id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteContact(Contact c)
        {
            using (SqlConnection cn = new SqlConnection(strConn))
            {
                SqlCommand cmd = new SqlCommand("DELETE Contact WHERE id = @id", cn);
                cmd.Parameters.AddWithValue("@id", c.Id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}