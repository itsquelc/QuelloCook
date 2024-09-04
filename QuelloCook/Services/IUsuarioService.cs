using QuelloCook.ViewModels;

namespace QuelloCook.Services;
    public interface IUsuarioService
    {
        Task<UsuarioVM> GetUsuarioLogado();
    }
