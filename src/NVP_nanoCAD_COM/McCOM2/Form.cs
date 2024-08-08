using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IForm interface
///</summary>
namespace McCOM2.Form 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Form_Constructor : INode 
	{
		public McCOM2.IForm _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IForm;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Form_ConstructorCast : INode 
	{
		public McCOM2.IForm _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IForm;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000005e9", 
		ViewType = "Data")]
	[NodeInput("Form", typeof(object))]
	[NodeInput("vIndex", typeof(System.Object))]

	///<summary>
	///0x000005e9
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000005ea", 
		ViewType = "Data")]
	[NodeInput("Form", typeof(object))]

	///<summary>
	///0x000005ea
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
		Text = "0x000005f0", 
		ViewType = "Data")]
	[NodeInput("Form", typeof(object))]

	///<summary>
	///0x000005f0
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
		Text = "0x000005f1", 
		ViewType = "Data")]
	[NodeInput("Form", typeof(object))]

	///<summary>
	///0x000005f1
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
		Text = "0x000005eb", 
		ViewType = "Data")]
	[NodeInput("Form", typeof(object))]

	///<summary>
	///0x000005eb
	///</summary>
	public class Show : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Show);

		}
	}


	[NVP_Manifest(
		Text = "0x000005ec", 
		ViewType = "Modifier")]
	[NodeInput("Form", typeof(object))]
	[NodeInput("vSource", typeof(System.Object))]

	///<summary>
	///0x000005ec
	///</summary>
	public class Load : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Load(inputs[1].Value);
			return null;
		}
	}
}
