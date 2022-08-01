using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace Lommeregner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

         
          
        private void Addition_ButtonClicked(object sender, RoutedEventArgs e)
        {
            /*      
                   
            De enkelte dele af den oprindelige kode, som kommenteres ud, fordeles forskellige steder i den nye metode med operator (private void CalculateWithOperator(string operatorInt). 
            Så istedet for at have 4 næsten identistiske metoder (+,-,*,/), så samler vi dem i en ny metode.

            Det er den oprindelige + metode:

            int firstInput = int.Parse(firstInput_Textbox.Text);
            int secondInput = int.Parse(SecondInput_Textbox.Text);
            int result = firstInput + secondInput;

            */

            CalculateWithOperator("+");               // 0 er valget i switchen. int 0 i switchen ændres til string "+", så det er mere sigende for bruger.
        }

        private void Subtraction_ButtonClicked(object sender, RoutedEventArgs e)
        {
            /*
              
            Det er den oprindelige - metode:

            int firstInput = int.Parse(firstInput_Textbox.Text);
            int secondInput = int.Parse(SecondInput_Textbox.Text);
            int result = firstInput - secondInput;
            
            result_Textbox.Text = result + "";     ( Kommentar til denne kodeline: result er en int værdi. Textbox indeholder string værdier. Ved at bruge et lille "trick" (result + "") omdannes det til en string)

            */

            CalculateWithOperator("-");             // 1 er valget i switchen. int 1 i switchen ændres til string "-", så det er mere sigende for bruger.

        }

            private void Multiplication_ButtonClicked(object sender, RoutedEventArgs e)
        {
            /*
              
            Det er den oprindelige  * metode:

            int firstInput = int.Parse(firstInput_Textbox.Text);
            int secondInput = int.Parse(SecondInput_Textbox.Text);
            int result = firstInput * secondInput;
            
            */

            CalculateWithOperator("*");               // 2 er valget i switchen. int 2 i switchen ændres til string "*", så det er mere sigende for bruger.   

        }

        private void Division_ButtonClicked(object sender, RoutedEventArgs e)
        {
            /*
              
            Det er den oprindelige  / metode:

            int firstInput = int.Parse(firstInput_Textbox.Text);
            int secondInput = int.Parse(SecondInput_Textbox.Text);
            int result = firstInput / secondInput;
            result_Textbox.Text = result + "";

            */

            CalculateWithOperator("/");                 // 3 er valget i switchen. int 3 i switchen ændres til string "/", så det er mere sigende for bruger.

        }

        

        private void CalculateWithOperator(string operatorString)
        {
            int firstInput = int.Parse(firstInput_Textbox.Text);
            int secondInput = int.Parse(SecondInput_Textbox.Text);

            // 0 = +        (operatorInt)
            // 1 = -        (operatorInt)
            // 2 = *        (operatorInt)        
            // 3 = /        (operatorInt)

            int result = 0;

            switch (operatorString)
            {
                case "+":
                    {
                        result = firstInput + secondInput;
                    }
                        break;
                case "-":
                    {
                        result = firstInput - secondInput;
                    }
                        break;
                case "*":
                    {
                        result = firstInput * secondInput;
                    }
                        break;
                case "/":
                    {
                        result = firstInput / secondInput;
                    }
                        break;
            }
            result_Textbox.Text = result + "";
        }
    }
}
