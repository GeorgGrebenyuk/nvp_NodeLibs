using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymView interface
///</summary>
namespace McCOM2.SymView 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymView_Constructor : INode 
	{
		public McCOM2.ISymView _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymView;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymView_ConstructorCast : INode 
	{
		public McCOM2.ISymView _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymView;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x00000547", 
		ViewType = "Data")]
	[NodeInput("SymView", typeof(object))]

	///<summary>
	///0x00000547
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
		Text = "0x00000547", 
		ViewType = "Modifier")]
	[NodeInput("SymView", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000547
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
		Text = "0x00000548", 
		ViewType = "Data")]
	[NodeInput("SymView", typeof(object))]

	///<summary>
	///0x00000548
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
		Text = "0x00000548", 
		ViewType = "Modifier")]
	[NodeInput("SymView", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000548
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
		Text = "0x00000540", 
		ViewType = "Data")]
	[NodeInput("SymView", typeof(object))]

	///<summary>
	///0x00000540
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
		Text = "0x00000540", 
		ViewType = "Modifier")]
	[NodeInput("SymView", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000540
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
		Text = "0x0000054d", 
		ViewType = "Data")]
	[NodeInput("SymView", typeof(object))]

	///<summary>
	///0x0000054d
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
		Text = "0x0000054d", 
		ViewType = "Modifier")]
	[NodeInput("SymView", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x0000054d
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
		Text = "0x0000054a", 
		ViewType = "Data")]
	[NodeInput("SymView", typeof(object))]

	///<summary>
	///0x0000054a
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
		Text = "0x0000054a", 
		ViewType = "Modifier")]
	[NodeInput("SymView", typeof(object))]
	[NodeInput("pnResult", typeof(System.Object))]

	///<summary>
	///0x0000054a
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
