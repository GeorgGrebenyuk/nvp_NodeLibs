using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcDrawingAreaSCMDefault 
{


	[NVP_Manifest(
		Id = "2F8291AA-E86C-4A8F-BD5B-12FCF5B60EAA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcDrawingAreaSCMDefault.enum_acRepeatLastCommand", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcDrawingAreaSCMDefault", 
		NodeName = "enum_acRepeatLastCommand", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acRepeatLastCommand : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcDrawingAreaSCMDefault.acRepeatLastCommand);

		}
	}


	[NVP_Manifest(
		Id = "1556B9D4-C8AC-41AF-86C0-3155DF555DCC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcDrawingAreaSCMDefault.enum_acSCM", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcDrawingAreaSCMDefault", 
		NodeName = "enum_acSCM", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSCM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcDrawingAreaSCMDefault.acSCM);

		}
	}
}
