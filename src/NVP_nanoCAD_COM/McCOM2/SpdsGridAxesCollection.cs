using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Collection of SpdsGridAxesSet objects
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SpdsGridAxesCollection 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SpdsGridAxesCollection_Constructor : INode 
	{
		public McCOM2.ISpdsGridAxesCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISpdsGridAxesCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SpdsGridAxesCollection_ConstructorCast : INode 
	{
		public McCOM2.ISpdsGridAxesCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISpdsGridAxesCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000005f9", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]

	///<summary>
	///0x000005f9
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item);

		}
	}


	[NVP_Manifest(
		Text = "0x000005fa", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]

	///<summary>
	///0x000005fa
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
		Text = "0x000005fb", 
		ViewType = "Modifier")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]
	[NodeInput("rDistance", typeof(System.Double))]
	[NodeInput("nCount", typeof(System.Object))]
	[NodeInput("bstrIndex", typeof(System.String))]

	///<summary>
	///0x000005fb
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Add(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005fc", 
		ViewType = "Modifier")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]
	[NodeInput("nIndex", typeof(System.Object))]

	///<summary>
	///0x000005fc
	///</summary>
	public class Remove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Remove(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005fd", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]

	///<summary>
	///0x000005fd
	///</summary>
	public class DimTotal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimTotal);

		}
	}


	[NVP_Manifest(
		Text = "0x000005fd", 
		ViewType = "Modifier")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005fd
	///</summary>
	public class Set_DimTotal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimTotal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000005fe", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]

	///<summary>
	///0x000005fe
	///</summary>
	public class DimChain : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimChain);

		}
	}


	[NVP_Manifest(
		Text = "0x000005fe", 
		ViewType = "Modifier")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005fe
	///</summary>
	public class Set_DimChain : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimChain = inputs[1].Value;
			return null;
		}
	}
}
