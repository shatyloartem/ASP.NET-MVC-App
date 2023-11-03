using System;
using System.Windows.Forms;

namespace Graph
{
    public class AgeCategoriesController
    {
        private readonly AgeCategoriesView _view;
        private readonly AgeCategoriesModel _model;
        
        public AgeCategoriesController()
        {
            _view = new AgeCategoriesView(this);
            _model = new AgeCategoriesModel();
        }

        /// <summary>
        /// Get age categories calculator page form
        /// </summary>
        /// <returns>Page form</returns>
        public Form getViewForm() => _view;

        #region ButtonCallbacks

        public void OnCalculateButtonClicked(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Calculate, ButtonThemeType.Pressed);
            
            _view.printResult(_model.CalculateByAgeString(_view.InputAge.Text));
        }

        public void OnCalculateButtonMouseEnter(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Calculate, ButtonThemeType.Active);
        }

        public void OnCalculateButtonMouseExit(object sender, EventArgs args)
        {
            _view.changeButtonTheme(ButtonType.Calculate, ButtonThemeType.Inactive);
        }

        #endregion
    }
}