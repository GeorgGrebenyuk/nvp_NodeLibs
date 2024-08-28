using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Cutted surface index mark
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymDimNumber 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimNumber_Constructor : INode 
	{
		public McCOM2.ISymDimNumber _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimNumber;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimNumber_ConstructorCast : INode 
	{
		public McCOM2.ISymDimNumber _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimNumber;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000001d9", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000001d9
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
		Text = "0x000001d9", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("pvResult", typeof(System.Object))]

	///<summary>
	///0x000001d9
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


	[NVP_Manifest(
		Text = "0x000001d6", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000001d6
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
		Text = "0x000001d6", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000001d6
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
		Text = "0x000001cf", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000001cf
	///</summary>
	public class Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Index);

		}
	}


	[NVP_Manifest(
		Text = "0x000001cf", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("pResult", typeof(System.Object))]

	///<summary>
	///0x000001cf
	///</summary>
	public class Set_Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Index = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000001c8", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000001c8
	///</summary>
	public class Autonum : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Autonum);

		}
	}


	[NVP_Manifest(
		Text = "0x000001c8", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x000001c8
	///</summary>
	public class Set_Autonum : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Autonum = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000001d8", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000001d8
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
		Text = "0x000001d8", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x000001d8
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
		Text = "0x000001cd", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000001cd
	///</summary>
	public class DisplayText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayText);

		}
	}


	[NVP_Manifest(
		Text = "0x000001c0", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("vBounds", typeof(System.Object))]

	///<summary>
	///0x000001c0
	///</summary>
	public class Align : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Align(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000001c7", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000001c7
	///</summary>
	public class Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrow);

		}
	}


	[NVP_Manifest(
		Text = "0x000001c7", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x000001c7
	///</summary>
	public class Set_Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrow = ((McCOM2.ArrowType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005b7", 
		ViewType = "Data")]
	[NodeInput("SymDimNumber", typeof(object))]

	///<summary>
	///0x000005b7
	///</summary>
	public class Owner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Owner);

		}
	}


	[NVP_Manifest(
		Text = "0x000005b7", 
		ViewType = "Modifier")]
	[NodeInput("SymDimNumber", typeof(object))]
	[NodeInput("ppValue", typeof(System.Object))]

	///<summary>
	///0x000005b7
	///</summary>
	public class Set_Owner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Owner = inputs[1].Value;
			return null;
		}
	}
}
