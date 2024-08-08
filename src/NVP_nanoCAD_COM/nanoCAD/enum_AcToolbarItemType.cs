using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcToolbarItemType 
{


	[NVP_Manifest(
		Id = "A76618AD-8060-4849-9E11-9AE99781017D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcToolbarItemType.enum_acToolbarButton", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcToolbarItemType", 
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
			return new NodeResult(nanoCAD.AcToolbarItemType.acToolbarButton);

		}
	}


	[NVP_Manifest(
		Id = "ED7A287C-870E-4696-B8D6-DEE7B91B5C80", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcToolbarItemType.enum_acToolbarSeparator", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcToolbarItemType", 
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
			return new NodeResult(nanoCAD.AcToolbarItemType.acToolbarSeparator);

		}
	}


	[NVP_Manifest(
		Id = "7D86BB92-F092-4575-BB1A-EB37BC68CACF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcToolbarItemType.enum_acToolbarControl", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcToolbarItemType", 
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
			return new NodeResult(nanoCAD.AcToolbarItemType.acToolbarControl);

		}
	}


	[NVP_Manifest(
		Id = "E3DD3DFD-A6C4-46E9-A34C-1B0D4301604E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcToolbarItemType.enum_acToolbarFlyout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcToolbarItemType", 
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
			return new NodeResult(nanoCAD.AcToolbarItemType.acToolbarFlyout);

		}
	}
}
