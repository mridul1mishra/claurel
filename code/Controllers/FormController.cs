using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.ModelBinding;
using code.Models;
using MySql.Data.MySqlClient;

namespace code.Controllers
{
    public class FormController : ApiController
    {
        public IHttpActionResult PostNewForm(FeedbackFormModel feedback)
        {
            MySqlConnection conn = new MySqlConnection("datasource=148.72.232.170;protocol=TCP;port=3306;database=customerlaurel;username=claurel;password=123456789");
            
            string insertQuery="INSERT INTO feedback(NAME, EMAIL, SUBJECT, MESSAGE) VALUES('"+feedback.name+"','"+feedback.email+"','"+feedback.subject+"','"+feedback.message+"')";
            
            MySqlCommand command = new MySqlCommand(insertQuery, conn);
            MySqlDataReader dataReader;
            conn.Open();
            dataReader = command.ExecuteReader();
            conn.Close();
            return Ok();
        }
    }
}