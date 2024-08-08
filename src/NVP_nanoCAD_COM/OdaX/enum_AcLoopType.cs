using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcLoopType 
{


	[NVP_Manifest(
		Id = "E98E3F3D-1363-419D-B404-CE910D7B6248", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLoopType.enum_acHatchLoopTypeDefault", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLoopType", 
		NodeName = "enum_acHatchLoopTypeDefault", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHatchLoopTypeDefault : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLoopType.acHatchLoopTypeDefault);

		}
	}


	[NVP_Manifest(
		Id = "0E046CB1-6123-4065-9857-F54AEAB6AF3D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLoopType.enum_acHatchLoopTypeExternal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLoopType", 
		NodeName = "enum_acHatchLoopTypeExternal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHatchLoopTypeExternal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLoopType.acHatchLoopTypeExternal);

		}
	}


	[NVP_Manifest(
		Id = "C57BCA20-4457-49FD-8FD6-2EC34E07542F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLoopType.enum_acHatchLoopTypePolyline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLoopType", 
		NodeName = "enum_acHatchLoopTypePolyline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHatchLoopTypePolyline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLoopType.acHatchLoopTypePolyline);

		}
	}


	[NVP_Manifest(
		Id = "3B081CF2-2FDC-42F1-8E96-A5EF59016943", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLoopType.enum_acHatchLoopTypeDerived", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLoopType", 
		NodeName = "enum_acHatchLoopTypeDerived", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHatchLoopTypeDerived : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLoopType.acHatchLoopTypeDerived);

		}
	}


	[NVP_Manifest(
		Id = "AAD5F69D-9248-45CA-B870-65ACC2C7710A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLoopType.enum_acHatchLoopTypeTextbox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLoopType", 
		NodeName = "enum_acHatchLoopTypeTextbox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHatchLoopTypeTextbox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLoopType.acHatchLoopTypeTextbox);

		}
	}
}
