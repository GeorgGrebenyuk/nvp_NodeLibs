using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcExtendOption 
{


	[NVP_Manifest(
		Id = "1594894D-6E8F-49D3-A057-9F0D73D51961", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcExtendOption.enum_acExtendNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcExtendOption", 
		NodeName = "enum_acExtendNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acExtendNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcExtendOption.acExtendNone);

		}
	}


	[NVP_Manifest(
		Id = "22FB4A96-E036-4733-8C83-525D8E7D6C47", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcExtendOption.enum_acExtendThisEntity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcExtendOption", 
		NodeName = "enum_acExtendThisEntity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acExtendThisEntity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcExtendOption.acExtendThisEntity);

		}
	}


	[NVP_Manifest(
		Id = "328BE25A-1E31-4BE5-97DE-CE7DB95AE9CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcExtendOption.enum_acExtendOtherEntity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcExtendOption", 
		NodeName = "enum_acExtendOtherEntity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acExtendOtherEntity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcExtendOption.acExtendOtherEntity);

		}
	}


	[NVP_Manifest(
		Id = "A64CBD44-3431-44BE-888E-60670526FDB4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcExtendOption.enum_acExtendBoth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcExtendOption", 
		NodeName = "enum_acExtendBoth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acExtendBoth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcExtendOption.acExtendBoth);

		}
	}
}
