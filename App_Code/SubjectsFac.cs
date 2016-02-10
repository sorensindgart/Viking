using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SubjectsFac
/// </summary>
public class SubjectsFac
{
    public int _id { get; set; }                     //fldSubID
    public string _title { get; set; }               //fldTitle
    public string _text { get; set; }                //fldText
    public string _img { get; set; }                 //fldImage

    DataAccess DA = new DataAccess();

    public DataTable GetLatestSubject()
    {
        string SQL = @"SELECT TOP 1 *
                       FROM tblSubject
                       ORDER BY NEWID() DESC";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }             // Getting subjects from dbViking
    public DataTable GetAllSubjects()
    {
        string SQL = @"SELECT *
                       FROM tblSubject";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }             // Getting subjects from dbViking
    public DataTable GetSubjectFromID()
    {
        string SQL = @"SELECT * 
                       FROM tblSubject 
                       WHERE fldSubID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        return DA.GetData(CMD);
    }       // Getting subjectID's from dbVikings
    public int AddSubject()
    {
        string SQL = @"INSERT INTO tblSubject (fldTitle, fldText, fldImage)
                       VALUES (@title, @text, @img)";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@title", _title);
        CMD.Parameters.AddWithValue("@text", _text);
        CMD.Parameters.AddWithValue("@img", _img);
        return DA.ModifyData(CMD);
    }                       // Add new subject
    public int DelSubject()
    {
        string SQL = @"DELETE FROM tblSubject WHERE fldSubID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        return DA.ModifyData(CMD);
    }                       // Delete subject
    public int EditSubject()
    {
        string SQL = @"UPDATE tblSubject 
                       SET fldTitle = @title, fldText = @text, fldImage = @img
                       WHERE fldSubID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        CMD.Parameters.AddWithValue("@title", _title);
        CMD.Parameters.AddWithValue("@text", _text);
        CMD.Parameters.AddWithValue("@img", _img);
        return DA.ModifyData(CMD);
    }                      // Edit subject
}