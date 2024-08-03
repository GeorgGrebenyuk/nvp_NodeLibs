using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_LayeredMaterialGroup 
{


	[NVP_Manifest(
		Id = "475AF738-CEE4-469B-BC05-21ABB782893F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_LayeredMaterialGroup.enum_LayeredMaterialGroup_Undefined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_LayeredMaterialGroup", 
		NodeName = "enum_LayeredMaterialGroup_Undefined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_LayeredMaterialGroup_Undefined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.LayeredMaterialGroup.LayeredMaterialGroup_Undefined);

		}
	}


	[NVP_Manifest(
		Id = "103845F7-82CE-459D-AE37-C4A7C568098A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_LayeredMaterialGroup.enum_LayeredMaterialGroup_Wall", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_LayeredMaterialGroup", 
		NodeName = "enum_LayeredMaterialGroup_Wall", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_LayeredMaterialGroup_Wall : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.LayeredMaterialGroup.LayeredMaterialGroup_Wall);

		}
	}


	[NVP_Manifest(
		Id = "91CBF3B6-26ED-4863-A520-122A8AA4BFAD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_LayeredMaterialGroup.enum_LayeredMaterialGroup_Floor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_LayeredMaterialGroup", 
		NodeName = "enum_LayeredMaterialGroup_Floor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_LayeredMaterialGroup_Floor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.LayeredMaterialGroup.LayeredMaterialGroup_Floor);

		}
	}


	[NVP_Manifest(
		Id = "DD051A89-0DF4-4B79-A134-8F81BEE4B912", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_LayeredMaterialGroup.enum_LayeredMaterialGroup_Roof", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_LayeredMaterialGroup", 
		NodeName = "enum_LayeredMaterialGroup_Roof", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_LayeredMaterialGroup_Roof : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.LayeredMaterialGroup.LayeredMaterialGroup_Roof);

		}
	}
}
