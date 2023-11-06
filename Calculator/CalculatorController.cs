using System;
using System.Windows.Forms;

namespace Graph
{
    public class CalculatorController
    {
        private CalculatorView _view;
        private CalculatorModel _model;
        
        public CalculatorController()
        {
            _view = new CalculatorView(this);
            _model = new CalculatorModel();
        }

        public Form getViewForm()
        {
            return _view;
        } 


        
        public void OnPlusButtonClick(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Plus, ButtonThemeType.Pressed);
            
            _view.printResult(_model.plusNumbersByString(_view.Input1.Text, _view.Input2.Text));
        }

        public void OnPlusButtonMouseEnter(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Plus, ButtonThemeType.Active);
        }
        
        public void OnPlusButtonMouseExit(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Plus, ButtonThemeType.Inactive);
        }

        
        public void OnDivisionButtonClick(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Division, ButtonThemeType.Pressed);
            
            _view.printResult(_model.divisionNumbersByString(_view.Input1.Text, _view.Input2.Text));
        }

        public void OnDivisionButtonMouseEnter(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Division, ButtonThemeType.Active);
        }
        
        public void OnDivisionButtonMouseExit(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Division, ButtonThemeType.Inactive);
        }
        

        public void OnMultiplyButtonClick(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Multiply, ButtonThemeType.Pressed);
            
            _view.printResult(_model.multiplyNumbersByString(_view.Input1.Text, _view.Input2.Text));
        }

        public void OnMultiplyButtonMouseEnter(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Multiply, ButtonThemeType.Active);
        }
        
        public void OnMultiplyButtonMouseExit(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Multiply, ButtonThemeType.Inactive);
        }
        

        public void OnSubtractionButtonClick(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Minus, ButtonThemeType.Pressed);
            
            _view.printResult(_model.subtractNumbersByString(_view.Input1.Text, _view.Input2.Text));
        }

        public void OnSubtractionButtonMouseEnter(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Minus, ButtonThemeType.Active);
        }
        
        public void OnSubtractionButtonMouseExit(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Minus, ButtonThemeType.Inactive);
        }
    }
}
