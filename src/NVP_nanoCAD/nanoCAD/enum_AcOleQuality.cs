using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcOleQuality 
{


	[NVP_Manifest(
		Id = "6BCC0957-B4C4-41FE-9F60-A207EE9656A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcOleQuality.enum_acOQLineArt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcOleQuality", 
		NodeName = "enum_acOQLineArt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acOQLineArt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcOleQuality.acOQLineArt);

		}
	}


	[NVP_Manifest(
		Id = "5203A76F-BC22-492B-B9D2-16AD74D64D7F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcOleQuality.enum_acOQText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcOleQuality", 
		NodeName = "enum_acOQText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acOQText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcOleQuality.acOQText);

		}
	}


	[NVP_Manifest(
		Id = "D3BF6847-5BAE-4F39-93CB-484A07AFEDF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcOleQuality.enum_acOQGraphics", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcOleQuality", 
		NodeName = "enum_acOQGraphics", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acOQGraphics : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcOleQuality.acOQGraphics);

		}
	}


	[NVP_Manifest(
		Id = "2802B5C5-37C5-4801-A5F1-BCAC127A6873", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcOleQuality.enum_acOQPhoto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcOleQuality", 
		NodeName = "enum_acOQPhoto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acOQPhoto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcOleQuality.acOQPhoto);

		}
	}


	[NVP_Manifest(
		Id = "97A007B7-9827-4B7C-8860-097BB08AFEE4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcOleQuality.enum_acOQHighPhoto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcOleQuality", 
		NodeName = "enum_acOQHighPhoto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acOQHighPhoto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcOleQuality.acOQHighPhoto);

		}
	}
}
