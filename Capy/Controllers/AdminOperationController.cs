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

    //  Generate SessionID for the user based on 
    private String CreateSessionId()
    {
        String date = DateTime.Now.ToString();
        String dateId = "";

        for (int i = 0; i < date.Length; i++)
        {
            if (date[i] == '/' || date[i] == ' ' || date[i] == ':')
            {
                continue;
            }
            else
            {
                dateId += date[i];
            }
        }

        return dateId;
    }
}
