using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_FlowDirectionType 
{


	[NVP_Manifest(
		Id = "40E75004-6513-4B5C-9A85-04B993F11F72", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_FlowDirectionType.enum_FlowDirectionType_Inlet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_FlowDirectionType", 
		NodeName = "enum_FlowDirectionType_Inlet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_FlowDirectionType_Inlet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.FlowDirectionType.FlowDirectionType_Inlet);

		}
	}


	[NVP_Manifest(
		Id = "838E043B-D93B-4F51-B2CE-C50A0FE00424", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_FlowDirectionType.enum_FlowDirectionType_Outlet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_FlowDirectionType", 
		NodeName = "enum_FlowDirectionType_Outlet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_FlowDirectionType_Outlet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.FlowDirectionType.FlowDirectionType_Outlet);

		}
	}


	[NVP_Manifest(
		Id = "86810291-5173-40AB-85A5-C185D98C73CA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_FlowDirectionType.enum_FlowDirectionType_InletAndOutlet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_FlowDirectionType", 
		NodeName = "enum_FlowDirectionType_InletAndOutlet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_FlowDirectionType_InletAndOutlet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.FlowDirectionType.FlowDirectionType_InletAndOutlet);

		}
	}


	[NVP_Manifest(
		Id = "9E460DD6-3433-4E76-BCF0-F04DD823B29E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_FlowDirectionType.enum_FlowDirectionType_Undefined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_FlowDirectionType", 
		NodeName = "enum_FlowDirectionType_Undefined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_FlowDirectionType_Undefined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.FlowDirectionType.FlowDirectionType_Undefined);

		}
	}
}
