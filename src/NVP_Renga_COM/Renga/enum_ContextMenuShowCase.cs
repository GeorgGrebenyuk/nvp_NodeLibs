using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_ContextMenuShowCase 
{


	[NVP_Manifest(
		Id = "85962A97-F6E9-43F1-A05C-104654DF7DEC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ContextMenuShowCase.enum_ContextMenuShowCase_Scene", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ContextMenuShowCase", 
		NodeName = "enum_ContextMenuShowCase_Scene", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ContextMenuShowCase_Scene : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ContextMenuShowCase.ContextMenuShowCase_Scene);

		}
	}


	[NVP_Manifest(
		Id = "B858E7EF-EE78-458B-8F22-046C184E45C2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ContextMenuShowCase.enum_ContextMenuShowCase_Selection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ContextMenuShowCase", 
		NodeName = "enum_ContextMenuShowCase_Selection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ContextMenuShowCase_Selection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ContextMenuShowCase.ContextMenuShowCase_Selection);

		}
	}
}
