using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///The common interface for TeighaX dimensions
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadDimension 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimension_Constructor : INode 
	{
		public OdaX.IAcadDimension _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDimension;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimension_ConstructorCast : INode 
	{
		public OdaX.IAcadDimension _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDimension;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
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
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
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
		Text = "Specifies or returns the rotation angle of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of a dimension.
	///</summary>
	public class Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rotation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation angle of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation angle of a dimension.
	///</summary>
	public class Set_Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinates for the text position of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates for the text position of a dimension.
	///</summary>
	public class TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextPosition);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinates for the text position of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("textPos", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates for the text position of a dimension.
	///</summary>
	public class Set_TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation angle of dimension text.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of dimension text.
	///</summary>
	public class TextRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextRotation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation angle of dimension text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation angle of dimension text.
	///</summary>
	public class Set_TextRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextRotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns a dimension text string that displays in addition to or instead of the dimension measurement.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns a dimension text string that displays in addition to or instead of the dimension measurement.
	///</summary>
	public class TextOverride : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextOverride);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns a dimension text string that displays in addition to or instead of the dimension measurement.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies or returns a dimension text string that displays in addition to or instead of the dimension measurement.
	///</summary>
	public class Set_TextOverride : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextOverride = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of the dimension style assigned to a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the name of the dimension style assigned to a dimension.
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
		Text = "Specifies or returns the name of the dimension style assigned to a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of the dimension style assigned to a dimension.
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
		Text = "Specifies or returns the text color of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the text color of a dimension.
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
		Text = "Specifies or returns the text color of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies or returns the text color of a dimension.
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
		Text = "Specifies or returns the decimal separator of a dimension formatted for decimals.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the decimal separator of a dimension formatted for decimals.
	///</summary>
	public class DecimalSeparator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DecimalSeparator);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the decimal separator of a dimension formatted for decimals.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("character", typeof(System.String))]

	///<summary>
	///Specifies or returns the decimal separator of a dimension formatted for decimals.
	///</summary>
	public class Set_DecimalSeparator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DecimalSeparator = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the amount of blank space surrounding dimension text when the text causes a dimension line to break.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the amount of blank space surrounding dimension text when the text causes a dimension line to break.
	///</summary>
	public class TextGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextGap);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the amount of blank space surrounding dimension text when the text causes a dimension line to break.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("Offset", typeof(System.Double))]

	///<summary>
	///Specifies or returns the amount of blank space surrounding dimension text when the text causes a dimension line to break.
	///</summary>
	public class Set_TextGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextGap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the prefix for text of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the prefix for text of a dimension.
	///</summary>
	public class TextPrefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextPrefix);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the prefix for text of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("prefix", typeof(System.String))]

	///<summary>
	///Specifies or returns the prefix for text of a dimension.
	///</summary>
	public class Set_TextPrefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextPrefix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the suffix for text of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the suffix for text of a dimension.
	///</summary>
	public class TextSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextSuffix);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the suffix for text of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("suffix", typeof(System.String))]

	///<summary>
	///Specifies or returns the suffix for text of a dimension.
	///</summary>
	public class Set_TextSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextSuffix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale factor of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor of a dimension.
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
		Text = "Specifies or returns the scale factor of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("factor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale factor of a dimension.
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
		Text = "Specifies or returns the vertical position of text for a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the vertical position of text for a dimension.
	///</summary>
	public class VerticalTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalTextPosition);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertical position of text for a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("OdaX.AcDimVerticalJustification", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertical position of text for a dimension.
	///</summary>
	public class Set_VerticalTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VerticalTextPosition = ((OdaX.AcDimVerticalJustification)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of decimal places for tolerance values of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the number of decimal places for tolerance values of dimensions.
	///</summary>
	public class TolerancePrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TolerancePrecision);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of decimal places for tolerance values of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("OdaX.AcDimPrecision", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of decimal places for tolerance values of dimensions.
	///</summary>
	public class Set_TolerancePrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TolerancePrecision = ((OdaX.AcDimPrecision)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale factor of tolerance text height in relation to dimension text height.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor of tolerance text height in relation to dimension text height.
	///</summary>
	public class ToleranceHeightScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceHeightScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale factor of tolerance text height in relation to dimension text height.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("scale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale factor of tolerance text height in relation to dimension text height.
	///</summary>
	public class Set_ToleranceHeightScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceHeightScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lower tolerance limit for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the lower tolerance limit for dimensions.
	///</summary>
	public class ToleranceLowerLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceLowerLimit);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lower tolerance limit for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("lower", typeof(System.Double))]

	///<summary>
	///Specifies or returns the lower tolerance limit for dimensions.
	///</summary>
	public class Set_ToleranceLowerLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceLowerLimit = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how dimension lines move when the corresponding dimension text moves.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns how dimension lines move when the corresponding dimension text moves.
	///</summary>
	public class TextMovement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextMovement);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how dimension lines move when the corresponding dimension text moves.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("OdaX.AcDimTextMovement", typeof(System.Object))]

	///<summary>
	///Specifies or returns how dimension lines move when the corresponding dimension text moves.
	///</summary>
	public class Set_TextMovement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextMovement = ((OdaX.AcDimTextMovement)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dimension tolerance values display with dimension text.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns whether dimension tolerance values display with dimension text.
	///</summary>
	public class ToleranceDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceDisplay);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dimension tolerance values display with dimension text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("OdaX.AcDimToleranceMethod", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether dimension tolerance values display with dimension text.
	///</summary>
	public class Set_ToleranceDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceDisplay = ((OdaX.AcDimToleranceMethod)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertical placement of tolerance values for dimension text.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the vertical placement of tolerance values for dimension text.
	///</summary>
	public class ToleranceJustification : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceJustification);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the vertical placement of tolerance values for dimension text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("OdaX.AcDimToleranceJustify", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertical placement of tolerance values for dimension text.
	///</summary>
	public class Set_ToleranceJustification : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceJustification = ((OdaX.AcDimToleranceJustify)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the upper tolerance limit for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the upper tolerance limit for dimensions.
	///</summary>
	public class ToleranceUpperLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceUpperLimit);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the upper tolerance limit for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("upper", typeof(System.Double))]

	///<summary>
	///Specifies or returns the upper tolerance limit for dimensions.
	///</summary>
	public class Set_ToleranceUpperLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceUpperLimit = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the text style of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the text style of a dimension.
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
		Text = "Specifies or returns the text style of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("style", typeof(System.String))]

	///<summary>
	///Specifies or returns the text style of a dimension.
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
		Text = "Specifies or returns the text height of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the text height of a dimension.
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
		Text = "Specifies or returns the text height of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the text height of a dimension.
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
		Text = "Specifies or returns whether leading zeros display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns whether leading zeros display for dimensions.
	///</summary>
	public class SuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressLeadingZeros);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether leading zeros display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether leading zeros display for dimensions.
	///</summary>
	public class Set_SuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SuppressLeadingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether trailing zeros display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns whether trailing zeros display for dimensions.
	///</summary>
	public class SuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressTrailingZeros);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether trailing zeros display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether trailing zeros display for dimensions.
	///</summary>
	public class Set_SuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SuppressTrailingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether leading zeros display for tolerance values of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns whether leading zeros display for tolerance values of dimensions.
	///</summary>
	public class ToleranceSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceSuppressLeadingZeros);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether leading zeros display for tolerance values of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether leading zeros display for tolerance values of dimensions.
	///</summary>
	public class Set_ToleranceSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceSuppressLeadingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether trailing zeros display for tolerance values of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns whether trailing zeros display for tolerance values of dimensions.
	///</summary>
	public class ToleranceSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceSuppressTrailingZeros);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether trailing zeros display for tolerance values of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether trailing zeros display for tolerance values of dimensions.
	///</summary>
	public class Set_ToleranceSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceSuppressTrailingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the background fill of dimension text.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the background fill of dimension text.
	///</summary>
	public class TextFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextFill);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the background fill of dimension text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns the background fill of dimension text.
	///</summary>
	public class Set_TextFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextFill = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the fill color for dimension text.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the fill color for dimension text.
	///</summary>
	public class TextFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextFillColor);

		}
	}


	[NVP_Manifest(
		Text = "Not implemented. Specifies or returns the fill color for dimension text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns the fill color for dimension text.
	///</summary>
	public class Set_TextFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextFillColor = inputs[1].Value;
			return null;
		}
	}
}
