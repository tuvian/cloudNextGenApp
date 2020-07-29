using System;
using System.Data;
using DataLayer;
using Entity;

namespace BusinessLayer
{
    public class BL
    {
        
        public string InsertComment(CommentsEntity objComment)
        {
            DA objDA = new DA();
            string sqlQuery = "";
            string returnValue = string.Empty;
            //try
            //{
            //ID, Name, Description
            sqlQuery = "INSERT INTO tb_cloud (name,comments)VALUES('" + objComment.name + "','" + objComment.comment + "')";

            objDA.ExecuteNonQuery(sqlQuery);
            return "success";
            //}
            //catch()
            //{
            //return "error";
            //}
        }

        public DataTable searchComments()
        {            
            DataTable resultTable = new DataTable();
            DA objDA = new DA();
            string sqlQuery = "";
            string returnValue = string.Empty;
            sqlQuery = "SELECT name, comments FROM tb_cloud";

            resultTable = objDA.ExecuteDataTable(sqlQuery);
            
            return resultTable;
        }
    }
}

