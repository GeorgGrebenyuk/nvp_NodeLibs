using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcKeyboardPriority 
{


	[NVP_Manifest(
		Id = "CE0535EE-DFEF-4195-8BAF-E98C1DDEC805", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcKeyboardPriority.enum_acKeyboardRunningObjSnap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcKeyboardPriority", 
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
			return new NodeResult(nanoCAD.AcKeyboardPriority.acKeyboardRunningObjSnap);

		}
	}


	[NVP_Manifest(
		Id = "091642CC-F643-48A2-9684-8D9694C3C0B9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcKeyboardPriority.enum_acKeyboardEntry", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcKeyboardPriority", 
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
			return new NodeResult(nanoCAD.AcKeyboardPriority.acKeyboardEntry);

		}
	}


	[NVP_Manifest(
		Id = "2D2BAF9E-ED67-47EA-8BA5-A43645400832", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcKeyboardPriority.enum_acKeyboardEntryExceptScripts", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcKeyboardPriority", 
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
			return new NodeResult(nanoCAD.AcKeyboardPriority.acKeyboardEntryExceptScripts);

		}
	}
}
