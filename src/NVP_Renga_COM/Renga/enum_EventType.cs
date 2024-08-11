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
		ViewType = "Default")]
	public class enum_EventType_EventTypeNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.EventType.EventType_EventTypeNone);

		}
	}


	[NVP_Manifest(
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
