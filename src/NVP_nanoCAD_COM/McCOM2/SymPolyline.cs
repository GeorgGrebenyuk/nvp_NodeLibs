using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Polyline based symbol
///</summary>
namespace McCOM2.SymPolyline 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymPolyline_Constructor : INode 
	{
		public McCOM2.ISymPolyline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymPolyline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymPolyline_ConstructorCast : INode 
	{
		public McCOM2.ISymPolyline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymPolyline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x0000057c", 
		ViewType = "Data")]
	[NodeInput("SymPolyline", typeof(object))]

	///<summary>
	///0x0000057c
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Text = "0x0000057c", 
		ViewType = "Modifier")]
	[NodeInput("SymPolyline", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x0000057c
	///</summary>
	public class Set_Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Count = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000057d", 
		ViewType = "Data")]
	[NodeInput("SymPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000057d
	///</summary>
	public class Points : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Points(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x0000057d", 
		ViewType = "Modifier")]
	[NodeInput("SymPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x0000057d
	///</summary>
	public class Set_Points : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Points[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000057e", 
		ViewType = "Data")]
	[NodeInput("SymPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000057e
	///</summary>
	public class Bulges : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bulges(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x0000057e", 
		ViewType = "Modifier")]
	[NodeInput("SymPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x0000057e
	///</summary>
	public class Set_Bulges : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bulges[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000057f", 
		ViewType = "Data")]
	[NodeInput("SymPolyline", typeof(object))]

	///<summary>
	///0x0000057f
	///</summary>
	public class Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Closed);

		}
	}


	[NVP_Manifest(
		Text = "0x0000057f", 
		ViewType = "Modifier")]
	[NodeInput("SymPolyline", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x0000057f
	///</summary>
	public class Set_Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Closed = inputs[1].Value;
			return null;
		}
	}
}
