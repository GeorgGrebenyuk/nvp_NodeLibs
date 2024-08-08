using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a group of dimension settings that determines the appearance of a dimension
///</summary>
namespace OdaX.AcadDimStyle 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimStyle_Constructor : INode 
	{
		public OdaX.IAcadDimStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDimStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimStyle_ConstructorCast : INode 
	{
		public OdaX.IAcadDimStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDimStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of a dimension style.", 
		ViewType = "Data")]
	[NodeInput("AcadDimStyle", typeof(object))]

	///<summary>
	///Specifies or returns the name of a dimension style.
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
		Text = "Specifies or returns the name of a dimension style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimStyle", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of a dimension style.
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Copies dimension style data to an existing dimension style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimStyle", typeof(object))]
	[NodeInput("StyleSource", typeof(System.Object))]

	///<summary>
	///Copies dimension style data to an existing dimension style.
	///</summary>
	public class CopyFrom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CopyFrom(inputs[1].Value);
			return null;
		}
	}
}
