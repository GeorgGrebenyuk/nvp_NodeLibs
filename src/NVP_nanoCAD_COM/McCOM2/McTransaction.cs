using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///s)
///</summary>
namespace McCOM2.McTransaction 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McTransaction_Constructor : INode 
	{
		public McCOM2.IMcTransaction _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IMcTransaction;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McTransaction_ConstructorCast : INode 
	{
		public McCOM2.IMcTransaction _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IMcTransaction;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x0000057a", 
		ViewType = "Modifier")]
	[NodeInput("McTransaction", typeof(object))]
	[NodeInput("pObjectToWatch", typeof(System.Object))]

	///<summary>
	///0x0000057a
	///</summary>
	public class Start : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Start(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000578", 
		ViewType = "Modifier")]
	[NodeInput("McTransaction", typeof(object))]

	///<summary>
	///0x00000578
	///</summary>
	public class Commit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Commit();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000579", 
		ViewType = "Modifier")]
	[NodeInput("McTransaction", typeof(object))]

	///<summary>
	///0x00000579
	///</summary>
	public class Rollback : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rollback();
			return null;
		}
	}
}
