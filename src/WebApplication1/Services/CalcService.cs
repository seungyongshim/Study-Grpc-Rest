using System;
using System.Threading.Tasks;
using LanguageExt;
using static LanguageExt.Prelude;
using LanguageExt.Common;
using WebApplication1.Models;

namespace WebApplication1
{
    public class CalcService
    {
        public Task<AddResult> Add(AddQuery addCommand) => 
            Task.FromResult(addCommand.A + addCommand.B)
                .Select(x => new AddResult(x));

        public Task<int> Sub((int, int) input)
        {
            var (a, b) = input;
            return Task.FromResult(a - b);
        }

        public async Task<int> Except(int y) 
        {
            if (y is 0)
            {
                throw new NotImplementedException();
            }
            return 1;
        }
        
    }
}
