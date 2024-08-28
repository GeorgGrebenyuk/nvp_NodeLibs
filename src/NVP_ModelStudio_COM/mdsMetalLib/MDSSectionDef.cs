using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSSectionDef Interface
///</summary>
namespace NVP_ModelStudio_COM._mdsMetalLib.MDSSectionDef 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSSectionDef_Constructor : INode 
	{
		public mdsMetalLib.IMDSSectionDef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsMetalLib.IMDSSectionDef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSSectionDef_ConstructorCast : INode 
	{
		public mdsMetalLib.IMDSSectionDef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsMetalLib.IMDSSectionDef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property Name", 
		ViewType = "Data")]
	[NodeInput("MDSSectionDef", typeof(object))]

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
		Text = "property Name", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionDef", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Name
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
		Text = "property TextStyleName", 
		ViewType = "Data")]
	[NodeInput("MDSSectionDef", typeof(object))]

	///<summary>
	///property TextStyleName
	///</summary>
	public class TextStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyleName);

		}
	}


	[NVP_Manifest(
		Text = "property TextStyleName", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionDef", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property TextStyleName
	///</summary>
	public class Set_TextStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property TextHeight", 
		ViewType = "Data")]
	[NodeInput("MDSSectionDef", typeof(object))]

	///<summary>
	///property TextHeight
	///</summary>
	public class TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextHeight);

		}
	}


	[NVP_Manifest(
		Text = "property TextHeight", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property TextHeight
	///</summary>
	public class Set_TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property StrokeLng", 
		ViewType = "Data")]
	[NodeInput("MDSSectionDef", typeof(object))]

	///<summary>
	///property StrokeLng
	///</summary>
	public class StrokeLng : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StrokeLng);

		}
	}


	[NVP_Manifest(
		Text = "property StrokeLng", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property StrokeLng
	///</summary>
	public class Set_StrokeLng : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StrokeLng = inputs[1].Value;
			return null;
		}
	}
}
