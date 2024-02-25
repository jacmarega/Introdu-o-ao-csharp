using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    public class StatusChangedEventArgs :EventArgs//trata os argumentos para os eventos status changeg
    {
        //estamos interessados na mensagem descrevendo o evento
        private string EventMsg;
        //Propriedade para retornar e definir uma mensagem do evento
        public string EventMessage
        {
            get {  return EventMsg; }
            set { EventMsg = value; }
        }
        //construtor para definigir a mensagem do evento
        public StatusChangedEventArgs(string strEventMsg)
        {
            EventMsg = strEventMsg;
        }
    }
}
