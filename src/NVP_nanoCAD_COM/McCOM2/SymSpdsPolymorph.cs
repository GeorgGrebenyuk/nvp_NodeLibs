using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Polymorph mark
///</summary>
namespace McCOM2.SymSpdsPolymorph 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsPolymorph_Constructor : INode 
	{
		public McCOM2.ISymSpdsPolymorph _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsPolymorph;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsPolymorph_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsPolymorph _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsPolymorph;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x0000048d", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPolymorph", typeof(object))]

	///<summary>
	///0x0000048d
	///</summary>
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text);

		}
	}


	[NVP_Manifest(
		Text = "0x0000048d", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPolymorph", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x0000048d
	///</summary>
	public class Set_Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Text = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000048a", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPolymorph", typeof(object))]

	///<summary>
	///0x0000048a
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Text = "0x0000048a", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPolymorph", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x0000048a
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000048c", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPolymorph", typeof(object))]

	///<summary>
	///0x0000048c
	///</summary>
	public class Shape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Shape);

		}
	}


	[NVP_Manifest(
		Text = "0x0000048c", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPolymorph", typeof(object))]
	[NodeInput("McCOM2.PolymorphShape", typeof(System.Object))]

	///<summary>
	///0x0000048c
	///</summary>
	public class Set_Shape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Shape = ((McCOM2.PolymorphShape)inputs[1].Value);
			return null;
		}
	}
}
