using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)

        string message = "Do you want to close this window?";
        string title = "Close Window";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        DialogResult result = MessageBox.Show(message, title, buttons);
        if (result == DialogResult.Yes)
        {
            this.Close();
        }
        else
        {
            // Do something  

            {
                Console.WriteLine("Guess the Secret Number");
            }
        }