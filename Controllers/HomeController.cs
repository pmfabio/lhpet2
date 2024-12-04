using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet2.Models;

namespace LHPet2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(1, "Arthur A. Ferreira","000.000.000-00","arthur.antunes@ip.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(2, "Fulano Bezerra","000.000.000-01","fulano.antunes@ip.senai.br", "Fulano");
        Cliente cliente3 = new Cliente(3, "Cicrano da Silva","000.000.000-02","cicrano.antunes@ip.senai.br", "Cicrano");
        Cliente cliente4 = new Cliente(4, "Beltrano de Souza","000.000.000-03","beltrano.antunes@ip.senai.br", "Beltrano");
        Cliente cliente5 = new Cliente(5, "José da Costa","000.000.000-04","jose.antunes@ip.senai.br", "José");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.Clientes = listaClientes;    

        Fornecedor fornecedor1 = new Fornecedor(1, "Fornecedor Arthur A. Ferreira","000.000.000-00","arthur.antunes@ip.senai.br");
        Fornecedor fornecedor2 = new Fornecedor(2, "Fornecedor Fulano Bezerra","000.000.000-01","fulano.antunes@ip.senai.br");
        Fornecedor fornecedor3 = new Fornecedor(3, "Fornecedor Cicrano da Silva","000.000.000-02","cicrano.antunes@ip.senai.br");
        Fornecedor fornecedor4 = new Fornecedor(4, "Fornecedor Beltrano de Souza","000.000.000-03","beltrano.antunes@ip.senai.br");
        Fornecedor fornecedor5 = new Fornecedor(5, "Fornecedor José da Costa","000.000.000-04","jose.antunes@ip.senai.br");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.Fornecedores = listaFornecedores;     

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
