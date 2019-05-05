using System;
using System.Collections.Generic;
using System.Text;
using Wildlife.Navigation.NavigationModels;

namespace Wildlife.Navigation
{
    public interface INavigableView
    {
        void WithValues(NavigationModelBase model);
    }
}
