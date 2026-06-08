using Microsoft.AspNetCore.Mvc;
using Atividade_Criar_uma_p_gina_com_ASP_NET_MVC___CHECKPOINT_IV.Models;

namespace Atividade_Criar_uma_p_gina_com_ASP_NET_MVC___CHECKPOINT_IV.Controllers;

public class AlunosController : Controller
{
    public IActionResult Index()
    {
        // Criando uma lista de alunos direto no código para testar
        var listaDeAlunos = new List<Aluno>
        {
            new Aluno { Id = 1, Nome = "Ana Silva", RA = "123456", Email = "ana@uni.br" },
            new Aluno { Id = 2, Nome = "Bruno Souza", RA = "654321", Email = "bruno@uni.br" },
            new Aluno { Id = 3, Nome = "Carlos Mendes", RA = "789012", Email = "carlos@uni.br" }
        };

        // Manda essa lista lá para a tela (View)
        return View(listaDeAlunos);
    }
}