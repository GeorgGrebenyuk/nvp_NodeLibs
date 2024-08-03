using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_EventType 
{


	[NVP_Manifest(
		Id = "9A9A26CC-78C2-4998-B1F9-1AB62129EBD1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_EventType.enum_EventType_EventTypeNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_EventType", 
		NodeName = "enum_EventType_EventTypeNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_EventType_EventTypeNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.EventType.EventType_EventTypeNone);

		}
	}


	[NVP_Manifest(
		Id = "035ED835-007F-43E9-8C5A-E543C67FD79F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_EventType.enum_EventType_ProjectClose", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_EventType", 
		NodeName = "enum_EventType_ProjectClose", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_EventType_ProjectClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.EventType.EventType_ProjectClose);

		}
	}


	[NVP_Manifest(
		Id = "E5537BE3-5BF2-4902-A3E2-E7943726E543", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_EventType.enum_EventType_ApplicationClose", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_EventType", 
		NodeName = "enum_EventType_ApplicationClose", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_EventType_ApplicationClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.EventType.EventType_ApplicationClose);

		}
	}
}
