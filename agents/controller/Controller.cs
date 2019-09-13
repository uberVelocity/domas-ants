using agents.model;
using agents.view;

namespace agents.controller
{
    public sealed class Controller
    {
        private Model _model;
        private View _view;

        public Controller(Model _model, View _view)
        {
            this._model = _model;
            this._view = _view;
        }

        public Model Model
        {
            get
            {
                return this._model;
            }
        }

        public View View
        {
            get
            {
                return this._view;
            }
        }

    }
}