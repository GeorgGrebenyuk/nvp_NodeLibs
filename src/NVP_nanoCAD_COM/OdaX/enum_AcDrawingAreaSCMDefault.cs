using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDrawingAreaSCMDefault 
{


	[NVP_Manifest(
		Id = "79178D57-AFE0-4589-BE5C-519325C0C164", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDrawingAreaSCMDefault.enum_acRepeatLastCommand", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDrawingAreaSCMDefault", 
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
			return new NodeResult(OdaX.AcDrawingAreaSCMDefault.acRepeatLastCommand);

		}
	}


	[NVP_Manifest(
		Id = "4A1DCEB2-415E-4CC4-8FF9-FEC1A8930971", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDrawingAreaSCMDefault.enum_acSCM", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDrawingAreaSCMDefault", 
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
			return new NodeResult(OdaX.AcDrawingAreaSCMDefault.acSCM);

		}
	}
}
