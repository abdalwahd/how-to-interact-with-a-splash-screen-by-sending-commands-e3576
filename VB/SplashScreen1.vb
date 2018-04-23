Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen

Namespace SplashScreen_ProcessCommand
	Partial Public Class SplashScreen1
		Inherits SplashScreen
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "Overrides"

		Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
			MyBase.ProcessCommand(cmd, arg)
			Dim command As SplashScreenCommand = CType(cmd, SplashScreenCommand)
			If command = SplashScreenCommand.SetProgress Then
				Dim pos As Integer = CInt(Fix(arg))
				progressBarControl1.Position = pos
			End If
		End Sub

		#End Region

		Public Enum SplashScreenCommand
			SetProgress
			Command2
			Command3
		End Enum
	End Class
End Namespace