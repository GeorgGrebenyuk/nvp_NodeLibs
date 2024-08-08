using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.BuildingInfo 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BuildingInfo_Constructor : INode 
	{
		public Renga.IBuildingInfo _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IBuildingInfo;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BuildingInfo_ConstructorCast : INode 
	{
		public Renga.IBuildingInfo _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IBuildingInfo;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("BuildingInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Number);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("BuildingInfo", typeof(object))]
	[NodeInput("pNumber", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Number = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("BuildingInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("BuildingInfo", typeof(object))]
	[NodeInput("pName", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("BuildingInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Description);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("BuildingInfo", typeof(object))]
	[NodeInput("pDescription", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Description = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("BuildingInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetAddress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAddress);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("BuildingInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetProperties : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetProperties);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("BuildingInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class UniqueId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UniqueId);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("BuildingInfo", typeof(object))]

	///<summary>
	///
	///</summary>
	public class UniqueIdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UniqueIdS);

		}
	}
}
