using Microsoft.AspNetCore.Mvc;
using WebApplicationBankClients.Model;
using WebApplicationBankClients.Repository;

namespace WebApplicationBankClients.Controllers;

[ApiController]
public class BankClientsController : ControllerBase
{
    private BankClientsRepository _bankClientsRepository = BankClientsRepository.Instance;

    [HttpGet("BankClients/{id}")]
    public BankClient GetClientById(int id)
    {
        return _bankClientsRepository.GetById(id);
    }

    [HttpGet("BankClients")]
    public List<BankClient> GetAllClients()
    {
        return _bankClientsRepository.GetAll();
    }

    [HttpPost("BankClients")]
    public void AddNewClient(BankClient bankClient)
    {
        _bankClientsRepository.AddNew(bankClient);
    }

    [HttpDelete("BankClients/{id}")]
    public void DeleteClientById(int id)
    {
        _bankClientsRepository.DeleteById(id);
    }

    [HttpPut("BankClients/{id}")]
    public void UpdateClientById(int id, BankClient bankClient)
    {
        _bankClientsRepository.UpdateClientById(id, bankClient);
    }
}