using Microsoft.AspNetCore.Identity;
using QuelloCook.Data;
using QuelloCook.ViewModels;

namespace QuelloCook.Services;
public class UsuarioService : IUsuarioService
{
    private AppDbContext _context;
    private SignInManager<IdentityUser> _signInManager;
    private UserManager<IdentityUser> _userManager;
    private IHttpContextAccessor _httpContextAccessor;

    public UsuarioService(
        AppDbContext context,
         SignInManager<IdentityUser> signInManager,
         UserManager<IdentityUser> userManager,
         IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _signInManager = signInManager;
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
    }
    public Task<UsuarioVM> GetUsuarioLogado()
    {
        throw new NotImplementedException();
    }
}
