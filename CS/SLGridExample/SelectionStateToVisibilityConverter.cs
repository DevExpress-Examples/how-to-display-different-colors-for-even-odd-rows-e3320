using System;
using System.Windows.Data;
using DevExpress.Xpf.Grid;
using System.Windows;

namespace SLGridExample {
    public class SelectionStateToVisibilityConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return (SelectionState)value == SelectionState.None ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
