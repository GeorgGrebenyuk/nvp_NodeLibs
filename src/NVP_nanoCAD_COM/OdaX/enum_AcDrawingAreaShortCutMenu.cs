using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDrawingAreaShortCutMenu 
{


	[NVP_Manifest(
		Id = "22A8DF9E-B63D-4FE9-B1A8-566EF9FBDF90", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDrawingAreaShortCutMenu.enum_acNoDrawingAreaShortCutMenu", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDrawingAreaShortCutMenu", 
		NodeName = "enum_acNoDrawingAreaShortCutMenu", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acNoDrawingAreaShortCutMenu : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDrawingAreaShortCutMenu.acNoDrawingAreaShortCutMenu);

		}
	}


	[NVP_Manifest(
		Id = "B2B70A90-F5D9-484C-B3F2-919F20259C96", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDrawingAreaShortCutMenu.enum_acUseDefaultDrawingAreaShortCutMenu", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDrawingAreaShortCutMenu", 
		NodeName = "enum_acUseDefaultDrawingAreaShortCutMenu", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acUseDefaultDrawingAreaShortCutMenu : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDrawingAreaShortCutMenu.acUseDefaultDrawingAreaShortCutMenu);

		}
	}
}
