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
    public class DeviceController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string query = @"
                    select DeviceId,UsermId,DeviceDescription,DeviceAddress,DeviceMaxHEnergyConsumption
                    from
                    dbo.Device
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

        public string Post(Device device)
        {
            try
            {
                string query = @"
                    insert into dbo.Device values
                    (
                    '" + device.UsermId + @"'
                    ,'" + device.DeviceDescription + @"'
                    ,'" + device.DeviceAddress + @"'
                    ,'" + device.DeviceMaxHEnergyConsumption + @"'
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


        public string Put(Device device)
        {
            try
            {
                string query = @"
                    update dbo.Device set 
                    UsermId='" + device.UsermId + @"'
                    ,DeviceDescription='" + device.DeviceDescription + @"'
                    ,DeviceAddress='" + device.DeviceAddress + @"'
                    ,DeviceMaxHEnergyConsumption='" + device.DeviceMaxHEnergyConsumption + @"'
                    where DeviceId=" + device.DeviceId + @"
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
                    delete from dbo.Device
                    where DeviceId=" + id + @"
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