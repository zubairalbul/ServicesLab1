using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLab1.Services
{
    public class BankServices 
    {
        public void Transfer(int ac1, int ac2,decimal amount)
        { }
    }
    public void Deposit(int accountId, decimal amount)
    {
        var account = _bankAccountRepository.GetAccountById(accountId);
        if (account != null)
        {
            account.Balance += amount;
            _bankAccountRepository.UpdateAccount(account);
        }
        else
        {
            throw new Exception("Account not found.");
        }
    }

    public void Withdraw(int accountId, decimal amount)
    {
        var account = _bankAccountRepository.GetAccountById(accountId);
        if (account != null)
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
                _bankAccountRepository.UpdateAccount(account);
            }
            else
            {
                throw new Exception("Insufficient funds.");
            }
        }
        else
        {
            throw new Exception("Account not found.");
        }
    }

    public string Withdraw2(int accountId, decimal amount)
    {
        var account = _bankAccountRepository.GetAccountById(accountId);
        if (account != null)
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
                _bankAccountRepository.UpdateAccount(account);
                return "Success";
            }
            else
            {

                return "Insufficient funds";
            }
        }
        else
        {
            return "Account not found.";
        }
    }
}
