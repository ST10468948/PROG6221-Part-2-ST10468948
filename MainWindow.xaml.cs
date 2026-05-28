using System;
using System.IO;
using System.Media;
using System.Windows;
using System.Windows.Input;

namespace ChatBotGui
{
    public partial class MainWindow : Window
    {
        

     
   

        private void ExecuteCommunicationCycle()
        {
            string rawPrompt = txtUserInput.Text.Trim();
            if (string.IsNullOrEmpty(rawPrompt)) return;

            // Render User Output Dialogue Track[cite: 5]
            tbChatDisplay.Text += $"You: {rawPrompt}\n";
            txtUserInput.Clear();

          

   
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            ExecuteCommunicationCycle();
        }

        private void TxtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ExecuteCommunicationCycle();
            }
        }
    }
}


