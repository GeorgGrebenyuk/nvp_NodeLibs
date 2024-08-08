using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcInsertUnitsAction 
{


	[NVP_Manifest(
		Id = "23EE209B-E19B-4C51-982F-14100E155D49", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnitsAction.enum_acInsertUnitsPrompt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnitsAction", 
		NodeName = "enum_acInsertUnitsPrompt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsPrompt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnitsAction.acInsertUnitsPrompt);

		}
	}


	[NVP_Manifest(
		Id = "F89F0C2E-77FC-4099-BB67-7FE19B1A2DBE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcInsertUnitsAction.enum_acInsertUnitsAutoAssign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcInsertUnitsAction", 
		NodeName = "enum_acInsertUnitsAutoAssign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acInsertUnitsAutoAssign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcInsertUnitsAction.acInsertUnitsAutoAssign);

		}
	}
}
