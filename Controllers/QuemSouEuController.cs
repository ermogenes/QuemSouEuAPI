using Microsoft.AspNetCore.Mvc;
using QuemSouEuAPI.Models;

namespace QuemSouEuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuemSouEuController : ControllerBase
    {
        [HttpGet]
        public PessoaModel Get()
        {
            PessoaModel eu = new PessoaModel();

            eu.Nome = "Ermogenes";
            eu.Sobrenome = "Palacio";
            eu.UsuarioGitHub = "ermogenes";

            return eu;
        }
    }
}