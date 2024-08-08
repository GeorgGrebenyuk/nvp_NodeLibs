using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Params wrapper
///</summary>
namespace nanoCAD.Params 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Params_Constructor : INode 
	{
		public nanoCAD.IParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.IParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Params_ConstructorCast : INode 
	{
		public nanoCAD.IParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.IParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Sets new section", 
		ViewType = "Modifier")]
	[NodeInput("Params", typeof(object))]
	[NodeInput("Path", typeof(System.String))]
	[NodeInput("create", typeof(System.Object))]
	[NodeInput("Section", typeof(System.Object))]

	///<summary>
	///Sets new section
	///</summary>
	public class Set_Section : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Section[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Sets new section", 
		ViewType = "Data")]
	[NodeInput("Params", typeof(object))]
	[NodeInput("Path", typeof(System.String))]
	[NodeInput("create", typeof(System.Object))]

	///<summary>
	///Sets new section
	///</summary>
	public class Section : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Section(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the subsections names enumerator", 
		ViewType = "Data")]
	[NodeInput("Params", typeof(object))]

	///<summary>
	///Returns the subsections names enumerator
	///</summary>
	public class Sections : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Sections);

		}
	}


	[NVP_Manifest(
		Text = "Returns the value of named value", 
		ViewType = "Data")]
	[NodeInput("Params", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("nanoCAD.ValueType", typeof(System.Object))]

	///<summary>
	///Returns the value of named value
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value(inputs[1].Value,((nanoCAD.ValueType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Text = "Returns the value of named value", 
		ViewType = "Modifier")]
	[NodeInput("Params", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("nanoCAD.ValueType", typeof(System.Object))]
	[NodeInput("pValue", typeof(System.Object))]

	///<summary>
	///Returns the value of named value
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the values names enumerator", 
		ViewType = "Data")]
	[NodeInput("Params", typeof(object))]

	///<summary>
	///Returns the values names enumerator
	///</summary>
	public class Values : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Values);

		}
	}


	[NVP_Manifest(
		Text = "Retrieves text", 
		ViewType = "Data")]
	[NodeInput("Params", typeof(object))]
	[NodeInput("nanoCAD.SerializationFormat", typeof(System.Object))]

	///<summary>
	///Retrieves text
	///</summary>
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text(((nanoCAD.SerializationFormat)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Text = "Retrieves text", 
		ViewType = "Modifier")]
	[NodeInput("Params", typeof(object))]
	[NodeInput("nanoCAD.SerializationFormat", typeof(System.Object))]
	[NodeInput("Text", typeof(System.String))]

	///<summary>
	///Retrieves text
	///</summary>
	public class Set_Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Text[inputs[1]] = inputs[2];
			return null;
		}
	}
}
