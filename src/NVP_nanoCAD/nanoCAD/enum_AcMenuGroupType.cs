using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace nanoCAD.enum_AcMenuGroupType 
{


	[NVP_Manifest(
		Id = "DD751D57-AFB2-483A-85A0-8E4F423FAE50", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcMenuGroupType.enum_acBaseMenuGroup", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcMenuGroupType", 
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
			return new NodeResult(nanoCAD.AcMenuGroupType.acBaseMenuGroup);

		}
	}


	[NVP_Manifest(
		Id = "EB2C9296-13A6-4B6A-BF73-E3EBD61A2B5B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.enum_AcMenuGroupType.enum_acPartialMenuGroup", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.enum_AcMenuGroupType", 
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
			return new NodeResult(nanoCAD.AcMenuGroupType.acPartialMenuGroup);

		}
	}
}
