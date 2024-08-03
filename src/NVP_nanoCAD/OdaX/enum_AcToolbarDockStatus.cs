using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcToolbarDockStatus 
{


	[NVP_Manifest(
		Id = "63E4E0DA-915B-4603-980C-71DCA48F5888", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcToolbarDockStatus.enum_acToolbarDockTop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcToolbarDockStatus", 
		NodeName = "enum_acToolbarDockTop", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acToolbarDockTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcToolbarDockStatus.acToolbarDockTop);

		}
	}


	[NVP_Manifest(
		Id = "2C580A8C-C525-426F-815D-B321483CE38E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcToolbarDockStatus.enum_acToolbarDockBottom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcToolbarDockStatus", 
		NodeName = "enum_acToolbarDockBottom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acToolbarDockBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcToolbarDockStatus.acToolbarDockBottom);

		}
	}


	[NVP_Manifest(
		Id = "0AF6A5FD-1997-482F-A907-4E14ADC31542", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcToolbarDockStatus.enum_acToolbarDockLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcToolbarDockStatus", 
		NodeName = "enum_acToolbarDockLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acToolbarDockLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcToolbarDockStatus.acToolbarDockLeft);

		}
	}


	[NVP_Manifest(
		Id = "16960B6F-FFEF-4A13-9141-E7BFAC7C941D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcToolbarDockStatus.enum_acToolbarDockRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcToolbarDockStatus", 
		NodeName = "enum_acToolbarDockRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acToolbarDockRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcToolbarDockStatus.acToolbarDockRight);

		}
	}


	[NVP_Manifest(
		Id = "BA298B75-3F1D-4A67-89D7-E2A9F0B6D39F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcToolbarDockStatus.enum_acToolbarFloating", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcToolbarDockStatus", 
		NodeName = "enum_acToolbarFloating", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acToolbarFloating : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcToolbarDockStatus.acToolbarFloating);

		}
	}
}
