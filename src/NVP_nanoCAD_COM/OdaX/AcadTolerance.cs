using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a geometric tolerance contained in a feature control frame
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadTolerance 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadTolerance_Constructor : INode 
	{
		public OdaX.IAcadTolerance _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadTolerance;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadTolerance_ConstructorCast : INode 
	{
		public OdaX.IAcadTolerance _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadTolerance;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies the direction for the ray, tolerance, or xline through a vector", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the direction for the ray, tolerance, or xline through a vector
	///</summary>
	public class DirectionVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DirectionVector);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the direction for the ray, tolerance, or xline through a vector", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("dirVector", typeof(System.Object))]

	///<summary>
	///Specifies the direction for the ray, tolerance, or xline through a vector
	///</summary>
	public class Set_DirectionVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DirectionVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specify the X, Y, Z coordinate for insertion point of the tolerance", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specify the X, Y, Z coordinate for insertion point of the tolerance
	///</summary>
	public class InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsertionPoint);

		}
	}


	[NVP_Manifest(
		Text = "Specify the X, Y, Z coordinate for insertion point of the tolerance", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("insPoint", typeof(System.Object))]

	///<summary>
	///Specify the X, Y, Z coordinate for insertion point of the tolerance
	///</summary>
	public class Set_InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertionPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the three-dimensional normal unit vector for the entity", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the three-dimensional normal unit vector for the entity
	///</summary>
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the three-dimensional normal unit vector for the entity", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies the three-dimensional normal unit vector for the entity
	///</summary>
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the style name of the tolerance", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the style name of the tolerance
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
		Text = "Specifies the style name of the tolerance", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the style name of the tolerance
	///</summary>
	public class Set_StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the color of the dimension text", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the color of the dimension text
	///</summary>
	public class TextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the color of the dimension text", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies the color of the dimension text
	///</summary>
	public class Set_TextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the text string of the tolerance", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the text string of the tolerance
	///</summary>
	public class TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextString);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the text string of the tolerance", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies the text string of the tolerance
	///</summary>
	public class Set_TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the text style of the tolerance", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the text style of the tolerance
	///</summary>
	public class TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the text style of the tolerance", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("style", typeof(System.String))]

	///<summary>
	///Specifies the text style of the tolerance
	///</summary>
	public class Set_TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the text height of the tolerance", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the text height of the tolerance
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
		Text = "Specifies the text height of the tolerance", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies the text height of the tolerance
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
		Text = "Specifies the overall scale factor applied to properties that specify sizes, distances, or offsets", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the overall scale factor applied to properties that specify sizes, distances, or offsets
	///</summary>
	public class ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the overall scale factor applied to properties that specify sizes, distances, or offsets", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("factor", typeof(System.Object))]

	///<summary>
	///Specifies the overall scale factor applied to properties that specify sizes, distances, or offsets
	///</summary>
	public class Set_ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the color of the dimension lines", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the color of the dimension lines
	///</summary>
	public class DimensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLineColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the color of the dimension lines", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

	///<summary>
	///Specifies the color of the dimension lines
	///</summary>
	public class Set_DimensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLineColor = inputs[1].Value;
			return null;
		}
	}
}
