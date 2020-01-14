using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace EuroDiffusion
{
    public class ErrorProcessor
    {
        public void Show(String msg,MsgTypes msgType)
        {
            switch(msgType)
            {
                case MsgTypes.Error:
                    MessageBox.Show(msg, Captions.ErrorCaption, MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
                case MsgTypes.Informational:
                    MessageBox.Show(msg, Captions.InfoCaption, MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
            }
            
        }
    }
}
