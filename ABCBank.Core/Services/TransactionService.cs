using ABCBank.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBank.Core
{
    public class TransactionService : ITransactionService
    {
       
        private readonly DataContext _db;

        public TransactionService(            
             DataContext db
            )
        {            
            _db = db;
        }

        public async Task<Response<List<Transaction>>> FetchAllTransactions()
        {
            try
            {
                List<Transaction> list = await _db.Transactions.Where(x => x.IsDeleted == false).OrderBy(x=> x.Id).ToListAsync();

                if (list.Count() != 0)
                    return await Task.FromResult(new Response<List<Transaction>>
                    {
                        Success = true,
                        Data = list,
                        Message = "Successfull"
                    });


                return await Task.FromResult(new Response<List<Transaction>>
                {
                    Message = "No Transaction Found"
                });
            }
            catch (Exception ex)
            {

                // LOG EXCEPTION

                return await Task.FromResult(new Response<List<Transaction>>
                {
                    Message = "An Error Occured"
                });
            }
        }


    }
}
