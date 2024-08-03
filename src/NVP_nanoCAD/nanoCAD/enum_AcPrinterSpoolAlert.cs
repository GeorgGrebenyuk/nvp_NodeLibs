using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcPrinterSpoolAlert 
{


	[NVP_Manifest(
		Id = "8E3B3FAF-E6A9-48EF-AF53-2C05427CC185", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcPrinterSpoolAlert.enum_acPrinterAlwaysAlert", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcPrinterSpoolAlert", 
		NodeName = "enum_acPrinterAlwaysAlert", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPrinterAlwaysAlert : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcPrinterSpoolAlert.acPrinterAlwaysAlert);

		}
	}


	[NVP_Manifest(
		Id = "E1EE5977-9104-4F9A-BE08-D9FB0F33B995", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcPrinterSpoolAlert.enum_acPrinterAlertOnce", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcPrinterSpoolAlert", 
		NodeName = "enum_acPrinterAlertOnce", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPrinterAlertOnce : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcPrinterSpoolAlert.acPrinterAlertOnce);

		}
	}


	[NVP_Manifest(
		Id = "1B9C3BE6-DB64-405F-9967-30E471573F2B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcPrinterSpoolAlert.enum_acPrinterNeverAlertLogOnce", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcPrinterSpoolAlert", 
		NodeName = "enum_acPrinterNeverAlertLogOnce", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPrinterNeverAlertLogOnce : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcPrinterSpoolAlert.acPrinterNeverAlertLogOnce);

		}
	}


	[NVP_Manifest(
		Id = "4E24A662-840D-41EF-A014-C5B695730D25", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcPrinterSpoolAlert.enum_acPrinterNeverAlert", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcPrinterSpoolAlert", 
		NodeName = "enum_acPrinterNeverAlert", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPrinterNeverAlert : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcPrinterSpoolAlert.acPrinterNeverAlert);

		}
	}
}
