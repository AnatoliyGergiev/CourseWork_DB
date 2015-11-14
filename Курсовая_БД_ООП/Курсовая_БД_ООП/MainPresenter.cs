using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_БД_ООП
{
    class MainPresenter
    {
        private readonly Model _model = new Model(new FileDownloader());
        private readonly IMainForm _view;
        public MainPresenter(IMainForm view)
        {
            _view = view;
            // Презентер подписывается на уведомления о событиях Представления
            _view.Download_file += new EventHandler<EventArgs>(OnDFile);
            _view.Update += new EventHandler<EventArgs>(UpdateView);
            //UpdateView();
        }

        private void OnDFile(object sender, EventArgs e)
        {
            // В ответ на изменения в Представлении необходимо изменить Модель
            _model.Download();
            _view.List_Start = _model.List_Start;
        }

        private void UpdateView(object sender, EventArgs e)
        {
             _model.List_Encoded = _view.List_Encoded;
        }
    }
}
