using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcDrawingAreaSCMEdit 
{


	[NVP_Manifest(
		Id = "71219442-CDF7-4F67-A545-2FFAB8A808EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcDrawingAreaSCMEdit.enum_acEdRepeatLastCommand", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcDrawingAreaSCMEdit", 
		NodeName = "enum_acEdRepeatLastCommand", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acEdRepeatLastCommand : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcDrawingAreaSCMEdit.acEdRepeatLastCommand);

		}
	}


	[NVP_Manifest(
		Id = "3E36634B-5892-4CA4-B529-CB4DEF0A9621", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcDrawingAreaSCMEdit.enum_acEdSCM", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcDrawingAreaSCMEdit", 
		NodeName = "enum_acEdSCM", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acEdSCM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcDrawingAreaSCMEdit.acEdSCM);

		}
	}
}
