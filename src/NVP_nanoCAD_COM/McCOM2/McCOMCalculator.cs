using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMcCOMCalculator Interface
///</summary>
namespace McCOM2.McCOMCalculator 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McCOMCalculator_Constructor : INode 
	{
		public McCOM2.IMcCOMCalculator _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IMcCOMCalculator;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McCOMCalculator_ConstructorCast : INode 
	{
		public McCOM2.IMcCOMCalculator _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IMcCOMCalculator;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "method OnCreate", 
		ViewType = "Modifier")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("HWND", typeof(System.Object))]

	///<summary>
	///method OnCreate
	///</summary>
	public class OnCreate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnCreate(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method OnEdit", 
		ViewType = "Modifier")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("HWND", typeof(System.Object))]

	///<summary>
	///method OnEdit
	///</summary>
	public class OnEdit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnEdit(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method Value", 
		ViewType = "Data")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///method Value
	///</summary>
	public class GetValueByName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetValueByName(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "method Value", 
		ViewType = "Modifier")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("newVal", typeof(System.Object))]

	///<summary>
	///method Value
	///</summary>
	public class PutValueByName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PutValueByName(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method OnRead", 
		ViewType = "Modifier")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("vArray", typeof(System.Object))]

	///<summary>
	///method OnRead
	///</summary>
	public class OnRead : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnRead(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method OnWrite", 
		ViewType = "Data")]
	[NodeInput("McCOMCalculator", typeof(object))]

	///<summary>
	///method OnWrite
	///</summary>
	public class OnWrite : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OnWrite);

		}
	}


	[NVP_Manifest(
		Text = "method ValueByIndex", 
		ViewType = "Data")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///method ValueByIndex
	///</summary>
	public class GetValueByIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetValueByIndex(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "method ValueByIndex", 
		ViewType = "Modifier")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("newVal", typeof(System.Object))]

	///<summary>
	///method ValueByIndex
	///</summary>
	public class PutValueByIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PutValueByIndex(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method Keywords for report", 
		ViewType = "Modifier")]
	[NodeInput("McCOMCalculator", typeof(object))]
	[NodeInput("pManager", typeof(System.Object))]

	///<summary>
	///method Keywords for report
	///</summary>
	public class GetKeywords : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetKeywords(inputs[1].Value);
			return null;
		}
	}
}
