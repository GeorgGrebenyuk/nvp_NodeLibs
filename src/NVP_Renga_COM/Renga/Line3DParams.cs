using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Line3DParams 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Line3DParams_Constructor : INode 
	{
		public Renga.ILine3DParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILine3DParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Line3DParams_ConstructorCast : INode 
	{
		public Renga.ILine3DParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILine3DParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Line3DParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBaseline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBaseline);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Line3DParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class VerticalOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalOffset);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Line3DParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Color);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Line3DParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Style : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Style);

		}
	}
}
