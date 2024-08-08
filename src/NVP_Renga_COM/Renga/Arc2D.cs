using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Arc2D 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Arc2D_Constructor : INode 
	{
		public Renga.IArc2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IArc2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Arc2D_ConstructorCast : INode 
	{
		public Renga.IArc2D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IArc2D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

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
	[NodeInput("Arc2D", typeof(object))]

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
	[NodeInput("Arc2D", typeof(object))]

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
	[NodeInput("Arc2D", typeof(object))]

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
	[NodeInput("Arc2D", typeof(object))]

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
	[NodeInput("Arc2D", typeof(object))]

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
	[NodeInput("Arc2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBeginGlobalAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBeginGlobalAngle);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetEndGlobalAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEndGlobalAngle);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

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


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsClockwise : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsClockwise);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Arc2D", typeof(object))]

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
}
