using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Fragment mark
///</summary>
namespace McCOM2.SymSpdsFragment 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsFragment_Constructor : INode 
	{
		public McCOM2.ISymSpdsFragment _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsFragment;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsFragment_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsFragment _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsFragment;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000376", 
		ViewType = "Data")]
	[NodeInput("SymSpdsFragment", typeof(object))]

	///<summary>
	///0x00000376
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
		Text = "0x00000376", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsFragment", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000376
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
		Text = "0x00000367", 
		ViewType = "Data")]
	[NodeInput("SymSpdsFragment", typeof(object))]

	///<summary>
	///0x00000367
	///</summary>
	public class Begin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Begin);

		}
	}


	[NVP_Manifest(
		Text = "0x00000367", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsFragment", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000367
	///</summary>
	public class Set_Begin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Begin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000036c", 
		ViewType = "Data")]
	[NodeInput("SymSpdsFragment", typeof(object))]

	///<summary>
	///0x0000036c
	///</summary>
	public class End : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.End);

		}
	}


	[NVP_Manifest(
		Text = "0x0000036c", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsFragment", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x0000036c
	///</summary>
	public class Set_End : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.End = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000374", 
		ViewType = "Data")]
	[NodeInput("SymSpdsFragment", typeof(object))]

	///<summary>
	///0x00000374
	///</summary>
	public class Peak : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Peak);

		}
	}


	[NVP_Manifest(
		Text = "0x00000374", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsFragment", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000374
	///</summary>
	public class Set_Peak : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Peak = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000377", 
		ViewType = "Data")]
	[NodeInput("SymSpdsFragment", typeof(object))]

	///<summary>
	///0x00000377
	///</summary>
	public class TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextPosition);

		}
	}


	[NVP_Manifest(
		Text = "0x00000377", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsFragment", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000377
	///</summary>
	public class Set_TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextPosition = inputs[1].Value;
			return null;
		}
	}
}
