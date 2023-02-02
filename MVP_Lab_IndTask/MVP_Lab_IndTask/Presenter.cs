using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Lab_IndTask
{
    internal class Presenter
    {
        private SquareMatrixModel _model = new SquareMatrixModel();
        private IView _view;
        //в конструктор передается конкретный экземпляр представления и происходит подписка на все нужные события
        public Presenter(IView view)
        {
            _view = view;
            _view.SetSize += new EventHandler<EventArgs>(OnSetSize);
    
            RefreshView();
        }
        //обработка события, установка нового значения
        public void OnSetSize(object sender, EventArgs e)
        {
            _model.Size= _view.InputSize;
            RefreshView();
        }
        

        //обновляет представление новыми значениями модели. По сути Binding(привязка) значений модели к Представлению
        public void RefreshView()
        {
            
            _view.PrintMatrix=_model.PrintMatrix();
           
        }
    }
}
