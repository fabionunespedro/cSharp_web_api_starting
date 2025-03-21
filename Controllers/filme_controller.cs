
using filmesApi.models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 0;

    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)
    {
        filme.Id  = id++;
        filmes.Add(filme);
        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Duracao);
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperaFilmes()
    {
        return filmes;
    }

    [HttpGet("{id}")]
    public Filme? RecuperaFilmePorId(int id){

        return filmes.FirstOrDefault(filme => filme.Id == id);
    }
}