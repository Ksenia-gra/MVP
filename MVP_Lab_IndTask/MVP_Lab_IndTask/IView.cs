using System;


namespace MVP_Lab_IndTask
{
    internal interface IView
    {
        string PrintMatrix { get; set; }
        int InputSize { get; set; }

        
        //cобытия ввода значений
        event EventHandler<EventArgs> SetSize;

    }
}
