using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcToolbarDockStatus 
{


	[NVP_Manifest(
		Id = "BA0FC982-A09C-4042-97FE-9E1321139487", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcToolbarDockStatus.enum_acToolbarDockTop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcToolbarDockStatus", 
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
			return new NodeResult(nanoCAD.AcToolbarDockStatus.acToolbarDockTop);

		}
	}


	[NVP_Manifest(
		Id = "88E58DC3-C00B-46FF-BD71-139E3E54FB92", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcToolbarDockStatus.enum_acToolbarDockBottom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcToolbarDockStatus", 
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
			return new NodeResult(nanoCAD.AcToolbarDockStatus.acToolbarDockBottom);

		}
	}


	[NVP_Manifest(
		Id = "E2914202-7FEE-4D31-B5B3-9E28EF359255", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcToolbarDockStatus.enum_acToolbarDockLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcToolbarDockStatus", 
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
			return new NodeResult(nanoCAD.AcToolbarDockStatus.acToolbarDockLeft);

		}
	}


	[NVP_Manifest(
		Id = "E7E2C560-08AA-4387-91F9-8DA96010168C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcToolbarDockStatus.enum_acToolbarDockRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcToolbarDockStatus", 
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
			return new NodeResult(nanoCAD.AcToolbarDockStatus.acToolbarDockRight);

		}
	}


	[NVP_Manifest(
		Id = "F6ABF685-D409-4715-AF08-81C26F1C5434", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcToolbarDockStatus.enum_acToolbarFloating", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcToolbarDockStatus", 
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
			return new NodeResult(nanoCAD.AcToolbarDockStatus.acToolbarFloating);

		}
	}
}
