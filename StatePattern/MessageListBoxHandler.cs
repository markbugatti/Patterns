using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace StatePattern
{
    class MessageListBoxHandler
    {
        static private ListBox messageListBox { get; set; }
        public static void Initialize(ListBox listBox)
        {
            if(messageListBox == null)
            {
                messageListBox = listBox;
            }
        }
        static public void OutMessage(string message)
        {
            if(messageListBox != null)
            {
                messageListBox.Items.Add(message);
            }
            else
            {
                throw new Exception("инициализируйте ListBox");
            }
        }
    }
}
