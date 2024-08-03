using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_ReinforcementUnitType 
{


	[NVP_Manifest(
		Id = "FD085CCB-781C-4EDF-B2D1-724B4BC7A0D6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ReinforcementUnitType.enum_ReinforcementUnitType_Undefined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ReinforcementUnitType", 
		NodeName = "enum_ReinforcementUnitType_Undefined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ReinforcementUnitType_Undefined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ReinforcementUnitType.ReinforcementUnitType_Undefined);

		}
	}


	[NVP_Manifest(
		Id = "5F121E8F-DA53-4832-A4D3-1A82899C31AA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ReinforcementUnitType.enum_ReinforcementUnitType_Mesh", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ReinforcementUnitType", 
		NodeName = "enum_ReinforcementUnitType_Mesh", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ReinforcementUnitType_Mesh : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ReinforcementUnitType.ReinforcementUnitType_Mesh);

		}
	}


	[NVP_Manifest(
		Id = "5EFA79BA-9CE5-4ED4-8C58-499761A761D2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_ReinforcementUnitType.enum_ReinforcementUnitType_Cage", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_ReinforcementUnitType", 
		NodeName = "enum_ReinforcementUnitType_Cage", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ReinforcementUnitType_Cage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.ReinforcementUnitType.ReinforcementUnitType_Cage);

		}
	}
}
