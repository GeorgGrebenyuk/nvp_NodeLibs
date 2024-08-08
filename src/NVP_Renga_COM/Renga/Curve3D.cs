using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Curve3D 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Curve3D_Constructor : INode 
	{
		public Renga.ICurve3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ICurve3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Curve3D_ConstructorCast : INode 
	{
		public Renga.ICurve3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ICurve3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Curve3DType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Curve3DType);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

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


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBeginPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBeginPoint);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetEndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEndPoint);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]
	[NodeInput("param", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class GetPointOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPointOn(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MinParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinParameter);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MaxParameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaxParameter);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLength);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetGabarit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGabarit);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsClosed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsClosed);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]
	[NodeInput("startT", typeof(System.Double))]
	[NodeInput("distance", typeof(System.Double))]
	[NodeInput("direction", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetParameterAtDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetParameterAtDistance(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]
	[NodeInput("t1", typeof(System.Double))]
	[NodeInput("t2", typeof(System.Double))]
	[NodeInput("sense", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetTrimmed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTrimmed(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Curve3D", typeof(object))]
	[NodeInput("point", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class PointProjection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PointProjection(inputs[1].Value));

		}
	}
}
