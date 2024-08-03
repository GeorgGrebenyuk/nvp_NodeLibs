using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcCellAlignment 
{


	[NVP_Manifest(
		Id = "57874D4C-BA03-4495-A2D0-2CB8B042EBFC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellAlignment.enum_acTopLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellAlignment", 
		NodeName = "enum_acTopLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTopLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellAlignment.acTopLeft);

		}
	}


	[NVP_Manifest(
		Id = "DD2EE349-14D8-491E-9086-8510BF39B308", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellAlignment.enum_acTopCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellAlignment", 
		NodeName = "enum_acTopCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTopCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellAlignment.acTopCenter);

		}
	}


	[NVP_Manifest(
		Id = "265548B9-9C92-406C-9629-85B7E71E23D5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellAlignment.enum_acTopRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellAlignment", 
		NodeName = "enum_acTopRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTopRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellAlignment.acTopRight);

		}
	}


	[NVP_Manifest(
		Id = "D08E2BCA-6004-4DF8-9C20-B0F36822AA65", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellAlignment.enum_acMiddleLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellAlignment", 
		NodeName = "enum_acMiddleLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMiddleLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellAlignment.acMiddleLeft);

		}
	}


	[NVP_Manifest(
		Id = "44D8E7AD-1CE5-4838-BD45-741FD9F3E626", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellAlignment.enum_acMiddleCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellAlignment", 
		NodeName = "enum_acMiddleCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMiddleCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellAlignment.acMiddleCenter);

		}
	}


	[NVP_Manifest(
		Id = "AB3444A5-196F-4192-8FF7-F5AC42F2C6F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellAlignment.enum_acMiddleRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellAlignment", 
		NodeName = "enum_acMiddleRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMiddleRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellAlignment.acMiddleRight);

		}
	}


	[NVP_Manifest(
		Id = "23F89710-40DC-4DC1-AF75-28D1A3589EB8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellAlignment.enum_acBottomLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellAlignment", 
		NodeName = "enum_acBottomLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acBottomLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellAlignment.acBottomLeft);

		}
	}


	[NVP_Manifest(
		Id = "7FAA0C67-1346-454C-8504-1FFFADA8D0FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellAlignment.enum_acBottomCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellAlignment", 
		NodeName = "enum_acBottomCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acBottomCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellAlignment.acBottomCenter);

		}
	}


	[NVP_Manifest(
		Id = "5563149E-CC6B-44AF-9B95-AA92C69B94DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcCellAlignment.enum_acBottomRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcCellAlignment", 
		NodeName = "enum_acBottomRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acBottomRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcCellAlignment.acBottomRight);

		}
	}
}
