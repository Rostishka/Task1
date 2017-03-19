using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void PushPrintButton();//Оголошення делегата - 1 крок

    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            //Підписуємося на подію з вказанням конкретного метода
            button.Click += new PushPrintButton(button.OnButtonClick);

            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Please, press the w button: ");
                var enteredButton = Console.ReadKey().Key.ToString().ToLower();
                if (enteredButton == "w")
                {
                    flag = false;
                    button.Click -= new PushPrintButton(button.OnButtonClick);//Відписка від події
                    button.DoEvent();
                }
                else
                    button.DoEvent();
            }
        }
    }

    public class Button
    {
        public event PushPrintButton Click;//Оголошення події з типом делегата - 2 крок

        public void DoEvent()
        {
            if (Click != null)
                Click();//Виконати
        }

        public void OnButtonClick()
        {
            Console.WriteLine("\nВідбулося натиснення кнопки...\n\n");
        }
    }
}
