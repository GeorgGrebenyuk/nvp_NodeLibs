using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDrawingAreaSCMEdit 
{


	[NVP_Manifest(
		Id = "18A0B863-7FE6-4E2A-8A1B-F0EEE148086A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDrawingAreaSCMEdit.enum_acEdRepeatLastCommand", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDrawingAreaSCMEdit", 
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
			return new NodeResult(OdaX.AcDrawingAreaSCMEdit.acEdRepeatLastCommand);

		}
	}


	[NVP_Manifest(
		Id = "19EE497B-8D6D-4FAD-BEF7-5E0A98DF0760", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDrawingAreaSCMEdit.enum_acEdSCM", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDrawingAreaSCMEdit", 
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
			return new NodeResult(OdaX.AcDrawingAreaSCMEdit.acEdSCM);

		}
	}
}
