using ServicesLab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLab1.Services
{
    public class TransactionService
    {
        private readonly IRepository<Transaction> _transactionRepository;

        public TransactionService(IRepository<Transaction> transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public void CreateTransaction(Transaction transaction)
        {
            _transactionRepository.Add(transaction);
        }

        public Transaction GetTransaction(int id)
        {
            return _transactionRepository.Get(id);
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            return _transactionRepository.GetAll();
        }

        public void UpdateTransaction(Transaction transaction)
        {
            _transactionRepository.Update(transaction);
        }

        public void DeleteTransaction(int id)
        {
            _transactionRepository.Delete(id);
        }
    }
}
