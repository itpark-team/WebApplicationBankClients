using WebApplicationBankClients.Model;

namespace WebApplicationBankClients.Repository;

public class BankClientsRepository
{
    private static BankClientsRepository _instance = null;

    public static BankClientsRepository Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new BankClientsRepository();
            }

            return _instance;
        }
    }

    private BankClientsRepository()
    {
        _bankClients = new List<BankClient>()
        {
            new BankClient()
            {
                Id = 1,
                CardNumber = "23423-4564567-67-565",
                Money = 100000
            }
        };
    }

    private List<BankClient> _bankClients;

    public List<BankClient> GetAll()
    {
        return _bankClients;
    }

    public BankClient GetById(int id)
    {
        return _bankClients.Find(client => client.Id == id);
    }

    public void AddNew(BankClient bankClient)
    {
        _bankClients.Add(bankClient);
    }

    public void DeleteById(int id)
    {
        BankClient foundBankClient = _bankClients.Find(client => client.Id == id);

        if (foundBankClient != null)
        {
            _bankClients.Remove(foundBankClient);
        }
    }

    public void UpdateClientById(int id, BankClient bankClient)
    {
        BankClient foundBankClient = _bankClients.Find(client => client.Id == id);

        if (foundBankClient != null)
        {
            foundBankClient.Money = bankClient.Money;
            foundBankClient.CardNumber = bankClient.CardNumber;
        }
    }
}