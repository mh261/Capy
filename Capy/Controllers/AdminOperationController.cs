using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Capy.Constants;

namespace Capy.Controllers;
[Authorize(Roles = nameof(Roles.Admin))]

public class AdminOperationController
{

}
