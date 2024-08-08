using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcDrawingAreaSCMCommand 
{


	[NVP_Manifest(
		Id = "A11A8FDA-8C4B-4B87-92B9-876592C1089A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcDrawingAreaSCMCommand.enum_acEnter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcDrawingAreaSCMCommand", 
		NodeName = "enum_acEnter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acEnter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcDrawingAreaSCMCommand.acEnter);

		}
	}


	[NVP_Manifest(
		Id = "2F215B46-3103-404A-BA2C-4FBFA5504A65", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcDrawingAreaSCMCommand.enum_acEnableSCMOptions", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcDrawingAreaSCMCommand", 
		NodeName = "enum_acEnableSCMOptions", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acEnableSCMOptions : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcDrawingAreaSCMCommand.acEnableSCMOptions);

		}
	}


	[NVP_Manifest(
		Id = "1347BA7F-C54F-49C3-A6A4-5DBC35855ED0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcDrawingAreaSCMCommand.enum_acEnableSCM", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcDrawingAreaSCMCommand", 
		NodeName = "enum_acEnableSCM", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acEnableSCM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(nanoCAD.AcDrawingAreaSCMCommand.acEnableSCM);

		}
	}
}
