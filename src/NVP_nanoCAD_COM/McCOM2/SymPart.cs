using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Standard detail
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymPart 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymPart_Constructor : INode 
	{
		public McCOM2.ISymPart _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymPart;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymPart_ConstructorCast : INode 
	{
		public McCOM2.ISymPart _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymPart;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000002a2", 
		ViewType = "Modifier")]
	[NodeInput("SymPart", typeof(object))]
	[NodeInput("vPartId", typeof(System.Object))]

	///<summary>
	///0x000002a2
	///</summary>
	public class Init : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Init(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000002b4", 
		ViewType = "Data")]
	[NodeInput("SymPart", typeof(object))]

	///<summary>
	///0x000002b4
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
		Text = "0x000002b4", 
		ViewType = "Modifier")]
	[NodeInput("SymPart", typeof(object))]
	[NodeInput("pPoint", typeof(System.Object))]

	///<summary>
	///0x000002b4
	///</summary>
	public class Set_Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Origin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000002ac", 
		ViewType = "Data")]
	[NodeInput("SymPart", typeof(object))]

	///<summary>
	///0x000002ac
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
		Text = "0x000002ac", 
		ViewType = "Modifier")]
	[NodeInput("SymPart", typeof(object))]
	[NodeInput("pVector", typeof(System.Object))]

	///<summary>
	///0x000002ac
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
		Text = "0x0000029d", 
		ViewType = "Modifier")]
	[NodeInput("SymPart", typeof(object))]
	[NodeInput("vObjects", typeof(System.Object))]

	///<summary>
	///0x0000029d
	///</summary>
	public class Connect : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Connect(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000002a5", 
		ViewType = "Data")]
	[NodeInput("SymPart", typeof(object))]

	///<summary>
	///0x000002a5
	///</summary>
	public class AffectsTo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AffectsTo);

		}
	}


	[NVP_Manifest(
		Text = "0x000002aa", 
		ViewType = "Data")]
	[NodeInput("SymPart", typeof(object))]

	///<summary>
	///0x000002aa
	///</summary>
	public class DependsOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DependsOn);

		}
	}


	[NVP_Manifest(
		Text = "0x000002a7", 
		ViewType = "Data")]
	[NodeInput("SymPart", typeof(object))]

	///<summary>
	///0x000002a7
	///</summary>
	public class Class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Class);

		}
	}


	[NVP_Manifest(
		Text = "0x000002b7", 
		ViewType = "Data")]
	[NodeInput("SymPart", typeof(object))]

	///<summary>
	///0x000002b7
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Text = "0x000002b6", 
		ViewType = "Data")]
	[NodeInput("SymPart", typeof(object))]

	///<summary>
	///0x000002b6
	///</summary>
	public class SubType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SubType);

		}
	}
}
