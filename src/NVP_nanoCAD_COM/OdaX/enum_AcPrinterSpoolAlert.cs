using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcPrinterSpoolAlert 
{


	[NVP_Manifest(
		Id = "D1C82D86-518E-4612-B201-CC88CDE98CAB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPrinterSpoolAlert.enum_acPrinterAlwaysAlert", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPrinterSpoolAlert", 
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
			return new NodeResult(OdaX.AcPrinterSpoolAlert.acPrinterAlwaysAlert);

		}
	}


	[NVP_Manifest(
		Id = "760F85BA-5A4B-4D20-9D7E-559CE06C082D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPrinterSpoolAlert.enum_acPrinterAlertOnce", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPrinterSpoolAlert", 
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
			return new NodeResult(OdaX.AcPrinterSpoolAlert.acPrinterAlertOnce);

		}
	}


	[NVP_Manifest(
		Id = "CD633548-0859-4020-8E81-F1D196074CBD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPrinterSpoolAlert.enum_acPrinterNeverAlertLogOnce", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPrinterSpoolAlert", 
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
			return new NodeResult(OdaX.AcPrinterSpoolAlert.acPrinterNeverAlertLogOnce);

		}
	}


	[NVP_Manifest(
		Id = "78A665C5-9385-4AFE-9F92-D048CF335516", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcPrinterSpoolAlert.enum_acPrinterNeverAlert", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcPrinterSpoolAlert", 
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
			return new NodeResult(OdaX.AcPrinterSpoolAlert.acPrinterNeverAlert);

		}
	}
}
