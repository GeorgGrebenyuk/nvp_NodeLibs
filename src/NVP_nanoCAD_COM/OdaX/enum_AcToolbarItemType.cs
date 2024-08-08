using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcToolbarItemType 
{


	[NVP_Manifest(
		Id = "9A6CD9A4-3FB0-4C44-97D5-DE85E83E68DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcToolbarItemType.enum_acToolbarButton", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcToolbarItemType", 
		NodeName = "enum_acToolbarButton", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acToolbarButton : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcToolbarItemType.acToolbarButton);

		}
	}


	[NVP_Manifest(
		Id = "D979849A-F989-4EBD-8A32-D64EC320DC75", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcToolbarItemType.enum_acToolbarSeparator", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcToolbarItemType", 
		NodeName = "enum_acToolbarSeparator", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acToolbarSeparator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcToolbarItemType.acToolbarSeparator);

		}
	}


	[NVP_Manifest(
		Id = "9025114D-234E-4E9C-A3A6-E0813CACE5F0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcToolbarItemType.enum_acToolbarControl", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcToolbarItemType", 
		NodeName = "enum_acToolbarControl", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acToolbarControl : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcToolbarItemType.acToolbarControl);

		}
	}


	[NVP_Manifest(
		Id = "5966B8AF-86F2-421C-B40D-952F491CE8EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcToolbarItemType.enum_acToolbarFlyout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcToolbarItemType", 
		NodeName = "enum_acToolbarFlyout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acToolbarFlyout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcToolbarItemType.acToolbarFlyout);

		}
	}
}
