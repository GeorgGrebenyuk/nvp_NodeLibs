using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Placement3D 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Placement3D_Constructor : INode 
	{
		public Renga.IPlacement3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPlacement3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Placement3D_ConstructorCast : INode 
	{
		public Renga.IPlacement3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPlacement3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Origin);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AxisX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisX);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AxisY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisY);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AxisZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisZ);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsOrthogonal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsOrthogonal);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsNormal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsNormal);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsLeft);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetTransformFrom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTransformFrom);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetTransformInto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTransformInto);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Placement3D", typeof(object))]
	[NodeInput("vector_", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Move : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Move(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Placement3D", typeof(object))]
	[NodeInput("axis_", typeof(System.Object))]
	[NodeInput("angle_", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Rotate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotate(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Placement3D", typeof(object))]
	[NodeInput("pTransform", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Transform : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Transform(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Placement3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetCopy : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCopy);

		}
	}
}
