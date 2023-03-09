using Microsoft.AspNetCore.Mvc;
using WebApplicationBankClients.Model;
using WebApplicationBankClients.Repository;

namespace WebApplicationBankClients.Controllers;

[ApiController]
[Route("[controller]/")]
public class BankClientsController : ControllerBase
{
    private BankClientsRepository _bankClientsRepository = BankClientsRepository.Instance;

    [HttpGet("{id}")]
    public BankClient GetClientById(int id)
    {
        return _bankClientsRepository.GetById(id);
    }

    [HttpGet]
    public List<BankClient> GetAllClients()
    {
        return _bankClientsRepository.GetAll();
    }

    [HttpPost]
    public void AddNewClient(BankClient bankClient)
    {
        _bankClientsRepository.AddNew(bankClient);
    }

    [HttpDelete("{id}")]
    public void DeleteClientById(int id)
    {
        _bankClientsRepository.DeleteById(id);
    }

    [HttpPut("{id}")]
    public void UpdateClientById(int id, BankClient bankClient)
    {
        _bankClientsRepository.UpdateClientById(id, bankClient);
    }
}