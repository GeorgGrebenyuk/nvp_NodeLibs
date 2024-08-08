using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IElements Interface
///</summary>
namespace mdsLINEComLib.Elements 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Elements_Constructor : INode 
	{
		public mdsLINEComLib.IElements _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IElements;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Elements_ConstructorCast : INode 
	{
		public mdsLINEComLib.IElements _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IElements;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "method Item", 
		ViewType = "Data")]
	[NodeInput("Elements", typeof(object))]

	///<summary>
	///method Item
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
		Text = "property Count", 
		ViewType = "Data")]
	[NodeInput("Elements", typeof(object))]

	///<summary>
	///property Count
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
		Text = "method Add", 
		ViewType = "Modifier")]
	[NodeInput("Elements", typeof(object))]
	[NodeInput("Item", typeof(System.Object))]

	///<summary>
	///method Add
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Add(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method Remove", 
		ViewType = "Modifier")]
	[NodeInput("Elements", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///method Remove
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
}
