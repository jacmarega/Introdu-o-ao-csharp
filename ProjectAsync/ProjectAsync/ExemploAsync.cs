using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAsync
{
    internal class ExemploAsync
    {
        //metodo Task com retorno Task<TResult>
        async Task<bool> Task_TResult_Async()
        {
            return await Task.FromResult<bool>(DateTime.IsLeapYear(DateTime.Now.Year));
        }
        //metodo com retorno void (task)
        async Task Task_Void_Async()
        {
            await Task.Delay(2000);
            Form1.lstRes.Items.Add("Tarefa longa executada");
        }
        public async Task Task_LongaDuracao2()
        {
            bool isAnoBi = await Task_TResult_Async();
            Form1.lstRes.Items.Add($"{DateTime.Now.Year} {(isAnoBi ? "é" : "não é")} um ano bissexto");
            await Task_Void_Async();
        }
    }
}
