using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserCredentials
/// </summary>
public class UserCredentials
{
    string name = null;
    string password = null;
    string sessionID = null;
    string sessionExpiration = null;
    public UserCredentials(string name, string password, string sessionID, string sessionExpiration)
    {
        this.name = name;
        this.password = password;
        this.sessionID = sessionID;
        this.sessionExpiration = sessionExpiration;
        //
        // TODO: Add constructor logic here
        //
    }

    private string GetName()
    {
        return this.name;
    }

    private string GetPassword()
    {
        return this.password;
    }

    private string GetSessionID()
    {
        return this.sessionID;
    }

    private string GetSessionExpiration()
    {
        return this.sessionExpiration;
    }
}