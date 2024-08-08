using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcLoadPalette 
{


	[NVP_Manifest(
		Id = "8D5A6F5A-75A0-46FF-A945-61856D731781", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLoadPalette.enum_acPaletteByDrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLoadPalette", 
		NodeName = "enum_acPaletteByDrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPaletteByDrawing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLoadPalette.acPaletteByDrawing);

		}
	}


	[NVP_Manifest(
		Id = "EC3270F1-A662-4CCE-929A-58FBB2402B30", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcLoadPalette.enum_acPaletteBySession", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcLoadPalette", 
		NodeName = "enum_acPaletteBySession", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPaletteBySession : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcLoadPalette.acPaletteBySession);

		}
	}
}
