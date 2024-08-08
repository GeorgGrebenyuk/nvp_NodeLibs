using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Section or cut designation mark
///</summary>
namespace McCOM2.SymSection 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSection_Constructor : INode 
	{
		public McCOM2.ISymSection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSection_ConstructorCast : INode 
	{
		public McCOM2.ISymSection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000302", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x00000302
	///</summary>
	public class Edges : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Edges);

		}
	}


	[NVP_Manifest(
		Text = "0x00000302", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pvPointArray", typeof(System.Object))]

	///<summary>
	///0x00000302
	///</summary>
	public class Set_Edges : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Edges = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000301", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x00000301
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	[NVP_Manifest(
		Text = "0x00000301", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pvVector", typeof(System.Object))]

	///<summary>
	///0x00000301
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000002ff", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x000002ff
	///</summary>
	public class Cut : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Cut);

		}
	}


	[NVP_Manifest(
		Text = "0x000002ff", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pvbResult", typeof(System.Object))]

	///<summary>
	///0x000002ff
	///</summary>
	public class Set_Cut : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Cut = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000030b", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x0000030b
	///</summary>
	public class Prefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Prefix);

		}
	}


	[NVP_Manifest(
		Text = "0x0000030b", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x0000030b
	///</summary>
	public class Set_Prefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Prefix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000030e", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x0000030e
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
		Text = "0x0000030e", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x0000030e
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
		Text = "0x00000304", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x00000304
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
		Text = "0x00000304", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000304
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
		Text = "0x00000311", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x00000311
	///</summary>
	public class Zone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Zone);

		}
	}


	[NVP_Manifest(
		Text = "0x00000311", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000311
	///</summary>
	public class Set_Zone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Zone = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x0000030d", 
		ViewType = "Data")]
	[NodeInput("SymSection", typeof(object))]

	///<summary>
	///0x0000030d
	///</summary>
	public class Sheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Sheet);

		}
	}


	[NVP_Manifest(
		Text = "0x0000030d", 
		ViewType = "Modifier")]
	[NodeInput("SymSection", typeof(object))]
	[NodeInput("pnResult", typeof(System.Object))]

	///<summary>
	///0x0000030d
	///</summary>
	public class Set_Sheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Sheet = inputs[1].Value;
			return null;
		}
	}
}
