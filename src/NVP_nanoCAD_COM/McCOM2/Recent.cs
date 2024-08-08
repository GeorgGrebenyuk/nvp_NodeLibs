using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Recent values container interface
///</summary>
namespace McCOM2.Recent 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Recent_Constructor : INode 
	{
		public McCOM2.IRecent _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IRecent;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Recent_ConstructorCast : INode 
	{
		public McCOM2.IRecent _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IRecent;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000000bd", 
		ViewType = "Data")]
	[NodeInput("Recent", typeof(object))]

	///<summary>
	///0x000000bd
	///</summary>
	public class Key : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Key);

		}
	}


	[NVP_Manifest(
		Text = "0x000000bd", 
		ViewType = "Modifier")]
	[NodeInput("Recent", typeof(object))]
	[NodeInput("pbstrKey", typeof(System.String))]

	///<summary>
	///0x000000bd
	///</summary>
	public class Set_Key : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Key = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000000bf", 
		ViewType = "Data")]
	[NodeInput("Recent", typeof(object))]
	[NodeInput("bstrSubkey", typeof(System.String))]

	///<summary>
	///0x000000bf
	///</summary>
	public class Values : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Values(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000000be", 
		ViewType = "Data")]
	[NodeInput("Recent", typeof(object))]
	[NodeInput("bstrSubkey", typeof(System.String))]

	///<summary>
	///0x000000be
	///</summary>
	public class NamedValues : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NamedValues(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "0x000000bb", 
		ViewType = "Modifier")]
	[NodeInput("Recent", typeof(object))]
	[NodeInput("bstrValue", typeof(System.String))]
	[NodeInput("bstrSubkey", typeof(System.String))]

	///<summary>
	///0x000000bb
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Add(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000000bc", 
		ViewType = "Modifier")]
	[NodeInput("Recent", typeof(object))]
	[NodeInput("bstrValue", typeof(System.String))]
	[NodeInput("bstrSubkey", typeof(System.String))]

	///<summary>
	///0x000000bc
	///</summary>
	public class Remove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Remove(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
