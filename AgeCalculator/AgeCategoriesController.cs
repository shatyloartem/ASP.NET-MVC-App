using System;
using System.Windows.Forms;

namespace Graph
{
    public class AgeCategoriesController
    {
        private AgeCategoriesView _view;
        private AgeCategoriesModel _model;
        
        public AgeCategoriesController()
        {
            _view = new AgeCategoriesView(this);
            _model = new AgeCategoriesModel();
        }

        public Form getViewForm()
        {
            return _view;
        }

        
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
    }
}