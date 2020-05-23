using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Web;
using ExcelDataReader;
using MySql.Data.MySqlClient;

namespace code.Models
{
    public class PageMetaDetails
    {
        public string title { get; set; }
        public string metaDescription { get; set; }
        public string metaKeyword { get; set; }
        public PageMetaDetails(string pageUrl)
        {
            
            //string currentDir = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
            var filePath = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath + "book1.xlsx";
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    
                    // 1. Use the reader methods
                    var conf = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    };

                    // 2. Use the AsDataSet extension method
                    var dataSet = reader.AsDataSet(conf);

                    // Now you can get data from each sheet by its index or its "name"
                    var dataTable = dataSet.Tables[0];
                    for (var x= 0; x < dataTable.Rows.Count; x++)
                    {
                        if (pageUrl == dataTable.Rows[x][1].ToString())
                        {
                            metaDescription = dataTable.Rows[x][4].ToString();
                            metaKeyword = dataTable.Rows[x][3].ToString();
                            title = dataTable.Rows[x][2].ToString();
                            break;
                        }
                    }


                    // The result of each spreadsheet is in result.Tables
                }

            }

            
        }

    }
}