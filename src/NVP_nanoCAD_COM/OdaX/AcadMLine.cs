using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of multiple parallel lines
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadMLine 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMLine_Constructor : INode 
	{
		public OdaX.IAcadMLine _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadMLine;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMLine_ConstructorCast : INode 
	{
		public OdaX.IAcadMLine _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadMLine;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the style name of a multiline.", 
		ViewType = "Data")]
	[NodeInput("AcadMLine", typeof(object))]

	///<summary>
	///Returns the style name of a multiline.
	///</summary>
	public class StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertices of a multline.", 
		ViewType = "Data")]
	[NodeInput("AcadMLine", typeof(object))]

	///<summary>
	///Specifies or returns the vertices of a multline.
	///</summary>
	public class Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinates);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertices of a multline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLine", typeof(object))]
	[NodeInput("Vertices", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertices of a multline.
	///</summary>
	public class Set_Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinates = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the orientation of a multiline.", 
		ViewType = "Data")]
	[NodeInput("AcadMLine", typeof(object))]

	///<summary>
	///Specifies or returns the orientation of a multiline.
	///</summary>
	public class Justification : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Justification);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the orientation of a multiline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLine", typeof(object))]
	[NodeInput("OdaX.AcMLineJustification", typeof(System.Object))]

	///<summary>
	///Specifies or returns the orientation of a multiline.
	///</summary>
	public class Set_Justification : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Justification = ((OdaX.AcMLineJustification)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale of a multiline.", 
		ViewType = "Data")]
	[NodeInput("AcadMLine", typeof(object))]

	///<summary>
	///Specifies or returns the scale of a multiline.
	///</summary>
	public class MLineScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MLineScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale of a multiline.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLine", typeof(object))]
	[NodeInput("scale", typeof(System.Double))]

	///<summary>
	///Specifies or returns the scale of a multiline.
	///</summary>
	public class Set_MLineScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MLineScale = inputs[1].Value;
			return null;
		}
	}
}
