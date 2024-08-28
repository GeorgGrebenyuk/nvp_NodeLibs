using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.Arc3D 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Arc3D_Constructor : INode 
	{
		public Renga.IArc3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IArc3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Arc3D_ConstructorCast : INode 
	{
		public Renga.IArc3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IArc3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetPlacement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPlacement);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRadius);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRadiusA : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRadiusA);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRadiusB : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRadiusB);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBeginAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBeginAngle);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetEndAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEndAngle);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCenter);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Arc3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsCircular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsCircular);

		}
	}
}
