﻿' Developer Express Code Central Example:
' How to deploy a WPF Report Designer on the client
' 
' This example illustrates how you can deploy a WPF Report Designer on the client
' (without a reporting server).
' In addition, it shows how you can enable/disable
' the Report Wizard option for the Designer.
' 
' To deploy the WPF Report Designer
' locally, do the following.
' 1. Substitute the default client for the Report
' Designer with a custom one.  1.1. Create a custom client (in this sample, see
' LocalReportDesignerClient) that implements the IReportDesignerServiceClient
' interface. All methods of this interface are delegated from ReportService that
' is defined as a field or property in this client. 1.2. The client can refer to a
' ReportService type object, but it does not implement saving/loading of a report
' layout. For this reason, override the SaveReportLayout and LoadReportLayout
' methods (in this sample, see LocalReportService showing a simplified
' implementation of these methods).  1.3. In this sample, the Abort and CloseAsync
' methods in LocalReportDesignerClient are intentionally left empty, because they
' are not required. 1.4. Since the ReportDesignerViewModel exposes not the client,
' but its factory, you need to create this factory as well (in this sample,
' LocalReportDesignerClientFactory) and assign it to the Designer’s view model (in
' this sample, see MainWindow.xaml.cs).
' 2. For the ReportDesignerViewModel,
' specify a report's name and namespace, as well as a fake ServiceUri.
' 3.
' Optional (only when activating the Report Wizard option for your Designer):
' register your datasources to allow the Report Wizard access them (in this
' sample, see MainWindow.xaml.cs).
' 
' See also:
' http://www.devexpress.com/scid=E4018.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4017

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.261
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Namespace My


	<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")> _
	Friend NotInheritable Partial Class Settings
		Inherits System.Configuration.ApplicationSettingsBase

		Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

		Public Shared ReadOnly Property [Default]() As Settings
			Get
				Return defaultInstance
			End Get
		End Property

		<Global.System.Configuration.ApplicationScopedSettingAttribute(), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString), Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\nwind.mdb;Persist Se" & "curity Info=True")> _
		Public ReadOnly Property nwindConnectionString() As String
			Get
				Return (CStr(Me("nwindConnectionString")))
			End Get
		End Property
	End Class
End Namespace
