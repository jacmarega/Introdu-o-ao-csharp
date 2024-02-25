using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAsync
{
    internal class Exemplo
    {
        //METODO COM RETORNO
        bool Task_TResult()
        {
            return DateTime.IsLeapYear(DateTime.Now.Year);
        }

        //METODO COM RETORNO VOID
        void Task_Void()
        {
            Task.Delay(2000);
            Form1.lstRes.Items.Add("Tarefa longa executada");
        }

        public void Task_LongDuracao()
        {
            bool isAnoBi = Task_TResult();
            Form1.lstRes.Items.Add($"{DateTime.Now.Year} {(isAnoBi ? "é" : "não é")} um ano bi");
            Task_Void();
        }
    }
}
