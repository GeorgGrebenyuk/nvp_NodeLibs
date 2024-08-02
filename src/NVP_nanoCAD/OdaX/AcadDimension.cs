using NVP.API.Nodes;

namespace OdaX.AcadDimension 
{
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


	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the rotation angle of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rotation);

		}
	}


	///<summary>
	///Specifies or returns the rotation angle of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]
	public class Set_Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotation = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the x, y, z coordinates for the text position of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextPosition);

		}
	}


	///<summary>
	///Specifies or returns the x, y, z coordinates for the text position of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("textPos", typeof(System.Object))]
	public class Set_TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextPosition = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the rotation angle of dimension text.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class TextRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextRotation);

		}
	}


	///<summary>
	///Specifies or returns the rotation angle of dimension text.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]
	public class Set_TextRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextRotation = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns a dimension text string that displays in addition to or instead of the dimension measurement.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class TextOverride : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextOverride);

		}
	}


	///<summary>
	///Specifies or returns a dimension text string that displays in addition to or instead of the dimension measurement.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]
	public class Set_TextOverride : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextOverride = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the name of the dimension style assigned to a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleName);

		}
	}


	///<summary>
	///Specifies or returns the name of the dimension style assigned to a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]
	public class Set_StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StyleName = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the text color of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class TextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextColor);

		}
	}


	///<summary>
	///Specifies or returns the text color of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("color", typeof(System.Object))]
	public class Set_TextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextColor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the decimal separator of a dimension formatted for decimals.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class DecimalSeparator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DecimalSeparator);

		}
	}


	///<summary>
	///Specifies or returns the decimal separator of a dimension formatted for decimals.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("character", typeof(System.String))]
	public class Set_DecimalSeparator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DecimalSeparator = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the amount of blank space surrounding dimension text when the text causes a dimension line to break.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class TextGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextGap);

		}
	}


	///<summary>
	///Specifies or returns the amount of blank space surrounding dimension text when the text causes a dimension line to break.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("Offset", typeof(System.Double))]
	public class Set_TextGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextGap = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the prefix for text of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class TextPrefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextPrefix);

		}
	}


	///<summary>
	///Specifies or returns the prefix for text of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("prefix", typeof(System.String))]
	public class Set_TextPrefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextPrefix = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the suffix for text of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class TextSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextSuffix);

		}
	}


	///<summary>
	///Specifies or returns the suffix for text of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("suffix", typeof(System.String))]
	public class Set_TextSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextSuffix = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the scale factor of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFactor);

		}
	}


	///<summary>
	///Specifies or returns the scale factor of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("factor", typeof(System.Object))]
	public class Set_ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleFactor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the vertical position of text for a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class VerticalTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalTextPosition);

		}
	}


	///<summary>
	///Specifies or returns the vertical position of text for a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]
	public class Set_VerticalTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VerticalTextPosition = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the number of decimal places for tolerance values of dimensions.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class TolerancePrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TolerancePrecision);

		}
	}


	///<summary>
	///Specifies or returns the number of decimal places for tolerance values of dimensions.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("precision", typeof(System.Object))]
	public class Set_TolerancePrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TolerancePrecision = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the scale factor of tolerance text height in relation to dimension text height.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class ToleranceHeightScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceHeightScale);

		}
	}


	///<summary>
	///Specifies or returns the scale factor of tolerance text height in relation to dimension text height.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("scale", typeof(System.Object))]
	public class Set_ToleranceHeightScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceHeightScale = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the lower tolerance limit for dimensions.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class ToleranceLowerLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceLowerLimit);

		}
	}


	///<summary>
	///Specifies or returns the lower tolerance limit for dimensions.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("lower", typeof(System.Double))]
	public class Set_ToleranceLowerLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceLowerLimit = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns how dimension lines move when the corresponding dimension text moves.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class TextMovement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextMovement);

		}
	}


	///<summary>
	///Specifies or returns how dimension lines move when the corresponding dimension text moves.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("Move", typeof(System.Object))]
	public class Set_TextMovement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextMovement = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether dimension tolerance values display with dimension text.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class ToleranceDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceDisplay);

		}
	}


	///<summary>
	///Specifies or returns whether dimension tolerance values display with dimension text.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("method", typeof(System.Object))]
	public class Set_ToleranceDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceDisplay = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the vertical placement of tolerance values for dimension text.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class ToleranceJustification : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceJustification);

		}
	}


	///<summary>
	///Specifies or returns the vertical placement of tolerance values for dimension text.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("method", typeof(System.Object))]
	public class Set_ToleranceJustification : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceJustification = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the upper tolerance limit for dimensions.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class ToleranceUpperLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceUpperLimit);

		}
	}


	///<summary>
	///Specifies or returns the upper tolerance limit for dimensions.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("upper", typeof(System.Double))]
	public class Set_ToleranceUpperLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceUpperLimit = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the text style of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyle);

		}
	}


	///<summary>
	///Specifies or returns the text style of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("style", typeof(System.String))]
	public class Set_TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the text height of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextHeight);

		}
	}


	///<summary>
	///Specifies or returns the text height of a dimension.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]
	public class Set_TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextHeight = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether leading zeros display for dimensions.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class SuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressLeadingZeros);

		}
	}


	///<summary>
	///Specifies or returns whether leading zeros display for dimensions.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_SuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SuppressLeadingZeros = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether trailing zeros display for dimensions.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class SuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressTrailingZeros);

		}
	}


	///<summary>
	///Specifies or returns whether trailing zeros display for dimensions.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_SuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SuppressTrailingZeros = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether leading zeros display for tolerance values of dimensions.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class ToleranceSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceSuppressLeadingZeros);

		}
	}


	///<summary>
	///Specifies or returns whether leading zeros display for tolerance values of dimensions.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_ToleranceSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceSuppressLeadingZeros = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether trailing zeros display for tolerance values of dimensions.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class ToleranceSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceSuppressTrailingZeros);

		}
	}


	///<summary>
	///Specifies or returns whether trailing zeros display for tolerance values of dimensions.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_ToleranceSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceSuppressTrailingZeros = inputs[1];
			return null;
		}
	}


	///<summary>
	///Not implemented. Specifies or returns the background fill of dimension text.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class TextFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextFill);

		}
	}


	///<summary>
	///Not implemented. Specifies or returns the background fill of dimension text.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_TextFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextFill = inputs[1];
			return null;
		}
	}


	///<summary>
	///Not implemented. Specifies or returns the fill color for dimension text.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	public class TextFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextFillColor);

		}
	}


	///<summary>
	///Not implemented. Specifies or returns the fill color for dimension text.
	///</summary>
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("color", typeof(System.Object))]
	public class Set_TextFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextFillColor = inputs[1];
			return null;
		}
	}
}
