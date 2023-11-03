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

        public Form getViewForm() => _view;

        #region ButtonCallbacks

        public void OnCalculateButtonClicked(object sender, EventArgs args)
        {
            
        }

        public void OnCalculateButtonMouseEnter(object sender, EventArgs args)
        {
            
        }

        public void OnCalculateButtonMouseExit(object sender, EventArgs args)
        {
            
        }

        #endregion
    }
}