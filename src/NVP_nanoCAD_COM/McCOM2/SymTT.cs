using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Technical requirements
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymTT 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTT_Constructor : INode 
	{
		public McCOM2.ISymTT _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymTT;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTT_ConstructorCast : INode 
	{
		public McCOM2.ISymTT _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymTT;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x0000052f", 
		ViewType = "Data")]
	[NodeInput("SymTT", typeof(object))]

	///<summary>
	///0x0000052f
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
		Text = "0x0000052f", 
		ViewType = "Modifier")]
	[NodeInput("SymTT", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x0000052f
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
		Text = "0x00000526", 
		ViewType = "Data")]
	[NodeInput("SymTT", typeof(object))]

	///<summary>
	///0x00000526
	///</summary>
	public class IsDescription : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsDescription);

		}
	}


	[NVP_Manifest(
		Text = "0x00000524", 
		ViewType = "Data")]
	[NodeInput("SymTT", typeof(object))]

	///<summary>
	///0x00000524
	///</summary>
	public class Frame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Frame);

		}
	}


	[NVP_Manifest(
		Text = "0x00000524", 
		ViewType = "Modifier")]
	[NodeInput("SymTT", typeof(object))]
	[NodeInput("ppFrame", typeof(System.Object))]

	///<summary>
	///0x00000524
	///</summary>
	public class Set_Frame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Frame = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000530", 
		ViewType = "Data")]
	[NodeInput("SymTT", typeof(object))]

	///<summary>
	///0x00000530
	///</summary>
	public class TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextHeight);

		}
	}


	[NVP_Manifest(
		Text = "0x00000530", 
		ViewType = "Modifier")]
	[NodeInput("SymTT", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x00000530
	///</summary>
	public class Set_TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000052e", 
		ViewType = "Data")]
	[NodeInput("SymTT", typeof(object))]

	///<summary>
	///0x0000052e
	///</summary>
	public class Slope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Slope);

		}
	}


	[NVP_Manifest(
		Text = "0x0000052e", 
		ViewType = "Modifier")]
	[NodeInput("SymTT", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x0000052e
	///</summary>
	public class Set_Slope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Slope = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000533", 
		ViewType = "Data")]
	[NodeInput("SymTT", typeof(object))]

	///<summary>
	///0x00000533
	///</summary>
	public class WordWrap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WordWrap);

		}
	}


	[NVP_Manifest(
		Text = "0x00000533", 
		ViewType = "Modifier")]
	[NodeInput("SymTT", typeof(object))]
	[NodeInput("pvbWrap", typeof(System.Object))]

	///<summary>
	///0x00000533
	///</summary>
	public class Set_WordWrap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WordWrap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000051d", 
		ViewType = "Modifier")]
	[NodeInput("SymTT", typeof(object))]
	[NodeInput("vTopLeftPoint", typeof(System.Object))]
	[NodeInput("vBottomRightPoint", typeof(System.Object))]

	///<summary>
	///0x0000051d
	///</summary>
	public class Move : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Move(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
