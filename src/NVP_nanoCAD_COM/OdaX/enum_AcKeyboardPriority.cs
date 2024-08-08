using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcKeyboardPriority 
{


	[NVP_Manifest(
		Id = "BB5153F7-1FB3-4F2B-808F-C74B373633CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcKeyboardPriority.enum_acKeyboardRunningObjSnap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcKeyboardPriority", 
		NodeName = "enum_acKeyboardRunningObjSnap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acKeyboardRunningObjSnap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcKeyboardPriority.acKeyboardRunningObjSnap);

		}
	}


	[NVP_Manifest(
		Id = "47A8CA9C-B9C3-4FFC-8D8B-CB8B407912A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcKeyboardPriority.enum_acKeyboardEntry", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcKeyboardPriority", 
		NodeName = "enum_acKeyboardEntry", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acKeyboardEntry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcKeyboardPriority.acKeyboardEntry);

		}
	}


	[NVP_Manifest(
		Id = "CE28205D-FD4F-4A05-B7AA-CE53B605A771", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcKeyboardPriority.enum_acKeyboardEntryExceptScripts", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcKeyboardPriority", 
		NodeName = "enum_acKeyboardEntryExceptScripts", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acKeyboardEntryExceptScripts : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcKeyboardPriority.acKeyboardEntryExceptScripts);

		}
	}
}
