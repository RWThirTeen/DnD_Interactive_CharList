using DnD_Interactive_CharList.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DnD_Interactive_CharList.ViewModels
{
    internal class MainWindowVM : ViewModel
    {
        #region Текущая вкладка

        private FrameworkElement _currentView;
        public FrameworkElement CurrentView
        {
            get => _currentView;
            set => Set(ref _currentView, value);
        }

        #endregion

        #region Логика переключения вкладок



        #endregion

        #region Репозиторий персонажей



        #endregion

        #region Логика работы окна



        #endregion

        public MainWindowVM()
        {
            
        }
    }
}
