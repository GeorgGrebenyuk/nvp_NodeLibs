using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcRowType 
{


	[NVP_Manifest(
		Id = "787E95D0-C6F8-48BA-BE9A-0DEB61A287D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcRowType.enum_acUnknownRow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcRowType", 
		NodeName = "enum_acUnknownRow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acUnknownRow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcRowType.acUnknownRow);

		}
	}


	[NVP_Manifest(
		Id = "2F2726B2-E2D7-40EE-9956-0688CE5A9890", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcRowType.enum_acDataRow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcRowType", 
		NodeName = "enum_acDataRow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataRow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcRowType.acDataRow);

		}
	}


	[NVP_Manifest(
		Id = "BF70D2E5-435B-4CDE-B373-96E9E428FABC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcRowType.enum_acTitleRow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcRowType", 
		NodeName = "enum_acTitleRow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleRow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcRowType.acTitleRow);

		}
	}


	[NVP_Manifest(
		Id = "C0B12279-04AB-41E8-AC89-8F9B7578E04E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcRowType.enum_acHeaderRow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcRowType", 
		NodeName = "enum_acHeaderRow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderRow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcRowType.acHeaderRow);

		}
	}
}
