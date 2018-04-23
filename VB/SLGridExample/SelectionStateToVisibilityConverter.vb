Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Data
Imports DevExpress.Xpf.Grid
Imports System.Windows

Namespace SLGridExample
	Public Class SelectionStateToVisibilityConverter
		Implements IValueConverter

		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Return If(CType(value, SelectionState) = SelectionState.None, Visibility.Visible, Visibility.Collapsed)
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class
End Namespace
