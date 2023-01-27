using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using DataAccess.Models;

namespace WebApplication1.Controllers
{
    public class MappingController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string query = @"
                    select MappingId,UsermId,DeviceId,MappingTimestamp,MappingEnergyConsumption
                    from
                    dbo.Mapping
                    ";
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["SDtema1"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }

            return Request.CreateResponse(HttpStatusCode.OK, table);


        }

        public string Post(Mapping mapping)
        {
            try
            {
                string query = @"
                    insert into dbo.Mapping values
                    (
                    '" + mapping.UsermId + @"'
                    ,'" + mapping.DeviceId + @"'
                    ,'" + mapping.MappingTimestamp + @"'
                    ,'" + mapping.MappingEnergyConsumption + @"'
                    )
                    ";

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["SDtema1"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Added Successfully!!";
            }
            catch (Exception)
            {

                return "Failed to Add!!";
            }
        }


        public string Put(Mapping mapping)
        {
            try
            {
                string query = @"
                    update dbo.Mapping set 
                    UsermId='" + mapping.UsermId + @"'
                    ,DeviceId='" + mapping.DeviceId + @"'
                    ,MappingTimestamp='" + mapping.MappingTimestamp + @"'
                    ,MappingEnergyConsumption='" + mapping.MappingEnergyConsumption + @"'
                    where MappingId=" + mapping.MappingId + @"
                    ";

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["SDtema1"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Updated Successfully!!";
            }
            catch (Exception)
            {

                return "Failed to Update!!";
            }
        }


        public string Delete(int id)
        {
            try
            {
                string query = @"
                    delete from dbo.Mapping
                    where MappingId=" + id + @"
                    ";

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["SDtema1"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }

                return "Deleted Successfully!!";
            }
            catch (Exception)
            {

                return "Failed to Delete!!";
            }
        }
    }
}