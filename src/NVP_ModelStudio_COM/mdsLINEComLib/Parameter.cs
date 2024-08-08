using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IParameter Interface
///</summary>
namespace mdsLINEComLib.Parameter 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Parameter_Constructor : INode 
	{
		public mdsLINEComLib.IParameter _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IParameter;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Parameter_ConstructorCast : INode 
	{
		public mdsLINEComLib.IParameter _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IParameter;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property Name", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///property Name
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
		Text = "property Value", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///property Value
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
		Text = "property Value", 
		ViewType = "Modifier")]
	[NodeInput("Parameter", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Value
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
		Text = "property Comment", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///property Comment
	///</summary>
	public class Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Comment);

		}
	}


	[NVP_Manifest(
		Text = "property Comment", 
		ViewType = "Modifier")]
	[NodeInput("Parameter", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Comment
	///</summary>
	public class Set_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Comment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ValueComment", 
		ViewType = "Data")]
	[NodeInput("Parameter", typeof(object))]

	///<summary>
	///property ValueComment
	///</summary>
	public class ValueComment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ValueComment);

		}
	}


	[NVP_Manifest(
		Text = "property ValueComment", 
		ViewType = "Modifier")]
	[NodeInput("Parameter", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property ValueComment
	///</summary>
	public class Set_ValueComment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ValueComment = inputs[1].Value;
			return null;
		}
	}
}
