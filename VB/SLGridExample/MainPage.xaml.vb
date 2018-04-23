' Developer Express Code Central Example:
' How to display different colors for even/odd rows
' 
' This sample shows how to change the background color for even and odd rows
' separately. It is necessary to create custom data row template and bind its
' background to the EvenRow property via converter.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3320


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Namespace SLGridExample
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
