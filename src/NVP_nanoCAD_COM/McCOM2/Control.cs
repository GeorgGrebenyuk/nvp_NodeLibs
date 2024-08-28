using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IControl interface
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.Control 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Control_Constructor : INode 
	{
		public McCOM2.IControl _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IControl;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Control_ConstructorCast : INode 
	{
		public McCOM2.IControl _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IControl;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000005d9", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005d9
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value);

		}
	}


	[NVP_Manifest(
		Text = "0x000005d9", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pvValue", typeof(System.Object))]

	///<summary>
	///0x000005d9
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005da", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005da
	///</summary>
	public class ClassName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClassName);

		}
	}


	[NVP_Manifest(
		Text = "0x000005db", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005db
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Text = "0x000005dc", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005dc
	///</summary>
	public class Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Visible);

		}
	}


	[NVP_Manifest(
		Text = "0x000005dc", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005dc
	///</summary>
	public class Set_Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Visible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Enabled);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Enabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005ef", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005ef
	///</summary>
	public class Form : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Form);

		}
	}


	[NVP_Manifest(
		Text = "0x000005df", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005df
	///</summary>
	public class Left : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Left);

		}
	}


	[NVP_Manifest(
		Text = "0x000005df", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005df
	///</summary>
	public class Set_Left : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Left = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005e0", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005e0
	///</summary>
	public class Top : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Top);

		}
	}


	[NVP_Manifest(
		Text = "0x000005e0", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005e0
	///</summary>
	public class Set_Top : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Top = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005e1", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005e1
	///</summary>
	public class Right : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Right);

		}
	}


	[NVP_Manifest(
		Text = "0x000005e1", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005e1
	///</summary>
	public class Set_Right : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Right = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005e2", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005e2
	///</summary>
	public class Bottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bottom);

		}
	}


	[NVP_Manifest(
		Text = "0x000005e2", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005e2
	///</summary>
	public class Set_Bottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bottom = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005e3", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005e3
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Text = "0x000005e3", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005e3
	///</summary>
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005e4", 
		ViewType = "Data")]
	[NodeInput("Control", typeof(object))]

	///<summary>
	///0x000005e4
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Text = "0x000005e4", 
		ViewType = "Modifier")]
	[NodeInput("Control", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x000005e4
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}
}
