using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyMarks.Dal;

namespace MyMarks.Contracts;

public class DiBasePageModel : PageModel
{
    protected MyMarksDbContext Context { get; }
    protected IAuthorizationService AuthorizationService { get; }
    protected UserManager<IdentityUser> UserManager { get; }

    public DiBasePageModel(
        MyMarksDbContext context,
        IAuthorizationService authorizationService,
        UserManager<IdentityUser> userManager)
    {
        Context = context;
        UserManager = userManager;
        AuthorizationService = authorizationService;
    } 
}