using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Capy.Constants;

namespace Capy.Controllers;
[Authorize(Roles = nameof(Roles.Admin))]

public class AdminOperationController
{
    public AuthService NewSession()
    {
        String sessionId = CreateSessionId();

        //  Checks for the valid sessionId to ensure only one id is available
        var instance = AuthService.Instance(sessionId);

        return instance;
    }

    //  Generate SessionID for the user based on date/time and admin ID
    //  with the following format: ID_YYYYMMDDHHMMSS
    private String CreateSessionId()
    {
        // get admin ID from the session
        // change testID to the actual admin ID fetched from DB
        String adminId = "testID";

        String date = DateTime.Now.ToString();
        String sessionId = adminId + "_";
        

        //  join date and time into a continuous string with no space/symbols to create a unique sessionId
        for (int i = 0; i < date.Length; i++)
        {
            if (date[i] == '/' || date[i] == ' ' || date[i] == ':')
            {
                continue;
            }
            else
            {
                sessionId += date[i];
            }
        }

        return sessionId;
    }
}
