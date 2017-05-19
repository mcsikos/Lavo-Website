using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Net;
using System.Data;

/// <summary>
/// Summary description for clsDataLayer
/// </summary>
/// 

public class clsDataLayer
{   
    OleDbConnection dbConnection;

    // Constructor 
    public clsDataLayer()
    {
        // Constructor with database path, data source?
        dbConnection = new OleDbConnection("Provider=MySQLProv;Data Source=helios.secondmoonsoftware.com;User Id=lavo;Password=9hL2My0d6edR;");
    }

    /*Constructor with the database path as a parameter
    public clsDataLayer(string path)
    {
        dbConnection = new OleDbConnection("Provider=MySQLProv;Data Source=lavo;User Id=lavo;Password=9hL2My0d6edR;");
    }*/

    // Method to fill a dataset with all requests
    public dsLavo GetAllRequests()
    {
        //Building SQL select statement
        OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter("select * from requests;", dbConnection);

        //Method to fill the dataset
        dsLavo myDataSet = new dsLavo();
        sqlDataAdapter.Fill(myDataSet.requests);

        //Return the dataset
        return myDataSet;
    }

    // Method to fill a dataset with all washers
    public dsLavo GetAllWashers()
    {
        //Building SQL select statement
        OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter("select username, name, phone, email from washers;", dbConnection);

        //Method to fill the dataset
        dsLavo myDataSet = new dsLavo();
        sqlDataAdapter.Fill(myDataSet.washers);

        //Return the dataset
        return myDataSet;
    }
}
