using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcMenuGroupType 
{


	[NVP_Manifest(
		Id = "B092F047-DE31-4383-98DF-422D584EDFC4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMenuGroupType.enum_acBaseMenuGroup", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMenuGroupType", 
		NodeName = "enum_acBaseMenuGroup", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acBaseMenuGroup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMenuGroupType.acBaseMenuGroup);

		}
	}


	[NVP_Manifest(
		Id = "2CB7C9CE-26E3-4573-83D8-1487638676A5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcMenuGroupType.enum_acPartialMenuGroup", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcMenuGroupType", 
		NodeName = "enum_acPartialMenuGroup", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPartialMenuGroup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMenuGroupType.acPartialMenuGroup);

		}
	}
}
