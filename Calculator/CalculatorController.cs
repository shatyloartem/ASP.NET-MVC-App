using System;
using System.Windows.Forms;

namespace Graph
{
    public class CalculatorController
    {
        private readonly CalculatorView _view;
        private readonly CalculatorModel _model;
        
        public CalculatorController()
        {
            _view = new CalculatorView(this);
            _model = new CalculatorModel();
        }

        public Form getViewForm() => _view;

        #region ButtonsCallbacks

        #region PlusButton

        public void OnPlusButtonClick(object sender, EventArgs args)
        {
            _view.changeButtonTheme(CalculatorView.ButtonType.Plus, CalculatorView.ThemeType.Pressed);
            
            _view.printResult(_model.plusNumbersByString(_view.Input1.Text, _view.Input2.Text));
        }

        public void OnPlusButtonMouseEnter(object sender, EventArgs args)
        {
            _view.changeButtonTheme(CalculatorView.ButtonType.Plus, CalculatorView.ThemeType.Active);
        }
        
        public void OnPlusButtonMouseExit(object sender, EventArgs args)
        {
            _view.changeButtonTheme(CalculatorView.ButtonType.Plus, CalculatorView.ThemeType.Inactive);
        }
        
        #endregion
        
        #region DivisionButton

        public void OnDivisionButtonClick(object sender, EventArgs args)
        {
            _view.changeButtonTheme(CalculatorView.ButtonType.Division, CalculatorView.ThemeType.Pressed);
            
            _view.printResult(_model.divisionNumbersByString(_view.Input1.Text, _view.Input2.Text));
        }

        public void OnDivisionButtonMouseEnter(object sender, EventArgs args)
        {
            _view.changeButtonTheme(CalculatorView.ButtonType.Division, CalculatorView.ThemeType.Active);
        }
        
        public void OnDivisionButtonMouseExit(object sender, EventArgs args)
        {
            _view.changeButtonTheme(CalculatorView.ButtonType.Division, CalculatorView.ThemeType.Inactive);
        }
        
        #endregion
        
        #region MultiplyButton

        public void OnMultiplyButtonClick(object sender, EventArgs args)
        {
            _view.changeButtonTheme(CalculatorView.ButtonType.Multiply, CalculatorView.ThemeType.Pressed);
            
            _view.printResult(_model.multiplyNumbersByString(_view.Input1.Text, _view.Input2.Text));
        }

        public void OnMultiplyButtonMouseEnter(object sender, EventArgs args)
        {
            _view.changeButtonTheme(CalculatorView.ButtonType.Multiply, CalculatorView.ThemeType.Active);
        }
        
        public void OnMultiplyButtonMouseExit(object sender, EventArgs args)
        {
            _view.changeButtonTheme(CalculatorView.ButtonType.Multiply, CalculatorView.ThemeType.Inactive);
        }
        
        #endregion
        
        #region SubtractButton

        public void OnSubtractionButtonClick(object sender, EventArgs args)
        {
            _view.changeButtonTheme(CalculatorView.ButtonType.Minus, CalculatorView.ThemeType.Pressed);
            
            _view.printResult(_model.subtractNumbersByString(_view.Input1.Text, _view.Input2.Text));
        }

        public void OnSubtractionButtonMouseEnter(object sender, EventArgs args)
        {
            _view.changeButtonTheme(CalculatorView.ButtonType.Minus, CalculatorView.ThemeType.Active);
        }
        
        public void OnSubtractionButtonMouseExit(object sender, EventArgs args)
        {
            _view.changeButtonTheme(CalculatorView.ButtonType.Minus, CalculatorView.ThemeType.Inactive);
        }
        
        #endregion

        #endregion
    }
}