using System;
using System.Windows.Forms;

namespace Graph
{
    public class MultiplicationTableController
    {
        private readonly MultiplicationTableView _view;
        private readonly MultiplicationTableModel _model;

        public MultiplicationTableController()
        {
            _view = new MultiplicationTableView(this);
            _model = new MultiplicationTableModel();
        }

        /// <summary>
        /// Get age categories calculator page form
        /// </summary>
        /// <returns>Page form</returns>
        public Form getViewForm() => _view;

        #region ButtonCallbacks

        public void OnCalculateButtonClick(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Calculate, ButtonThemeType.Pressed);
            
            _view.printResult(_model.CalculateTableByNumberString(_view.InputNum.Text));
        }

        public void OnCalculateButtonEnter(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Calculate, ButtonThemeType.Active);            
        }

        public void OnCalculateButtonExit(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Calculate, ButtonThemeType.Inactive);
        }

        #endregion
    }
}