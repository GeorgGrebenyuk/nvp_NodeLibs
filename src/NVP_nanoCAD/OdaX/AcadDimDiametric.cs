using NVP.API.Nodes;

namespace OdaX.AcadDimDiametric 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimDiametric_Constructor : INode 
	{
		public OdaX.IAcadDimDiametric _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDimDiametric;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimDiametric_ConstructorCast : INode 
	{
		public OdaX.IAcadDimDiametric _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDimDiametric;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies the length of the leader used with the diametral dimension.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("rhs", typeof(System.Double))]
	public class Set_LeaderLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLength = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether alternate units are used for dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltUnits);

		}
	}


	///<summary>
	///Specifies or returns whether alternate units are used for dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bAlternate", typeof(System.Object))]
	public class Set_AltUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltUnits = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the number of decimal places for alternate unit dimension.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltUnitsPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltUnitsPrecision);

		}
	}


	///<summary>
	///Specifies or returns the number of decimal places for alternate unit dimension.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("precision", typeof(System.Object))]
	public class Set_AltUnitsPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltUnitsPrecision = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the scale factor for alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltUnitsScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltUnitsScale);

		}
	}


	///<summary>
	///Specifies or returns the scale factor for alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("scale", typeof(System.Object))]
	public class Set_AltUnitsScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltUnitsScale = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the rounding value for alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltRoundDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltRoundDistance);

		}
	}


	///<summary>
	///Specifies or returns the rounding value for alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]
	public class Set_AltRoundDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltRoundDistance = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the number of decimal places for tolerance values of alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltTolerancePrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltTolerancePrecision);

		}
	}


	///<summary>
	///Specifies or returns the number of decimal places for tolerance values of alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Distance", typeof(System.Object))]
	public class Set_AltTolerancePrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltTolerancePrecision = inputs[1];
			return null;
		}
	}


	///<summary>
	///not including angular dimensions).
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltUnitsFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltUnitsFormat);

		}
	}


	///<summary>
	///not including angular dimensions).
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Units", typeof(System.Object))]
	public class Set_AltUnitsFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltUnitsFormat = inputs[1];
			return null;
		}
	}


	///<summary>
	///not including angular dimensions).
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltTextPrefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltTextPrefix);

		}
	}


	///<summary>
	///not including angular dimensions).
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("prefix", typeof(System.String))]
	public class Set_AltTextPrefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltTextPrefix = inputs[1];
			return null;
		}
	}


	///<summary>
	///not including angular dimensions).
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltTextSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltTextSuffix);

		}
	}


	///<summary>
	///not including angular dimensions).
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("prefix", typeof(System.String))]
	public class Set_AltTextSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltTextSuffix = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the color of dimension lines.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class DimensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLineColor);

		}
	}


	///<summary>
	///Specifies or returns the color of dimension lines.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]
	public class Set_DimensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLineColor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the number of decimal places for the primary units of dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class PrimaryUnitsPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrimaryUnitsPrecision);

		}
	}


	///<summary>
	///Specifies or returns the number of decimal places for the primary units of dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Prec", typeof(System.Object))]
	public class Set_PrimaryUnitsPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PrimaryUnitsPrecision = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns how fractions display for dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class FractionFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FractionFormat);

		}
	}


	///<summary>
	///Specifies or returns how fractions display for dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]
	public class Set_FractionFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FractionFormat = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class Fit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Fit);

		}
	}


	///<summary>
	///Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("fittype", typeof(System.Object))]
	public class Set_Fit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Fit = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the scale factor for linear dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class LinearScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinearScaleFactor);

		}
	}


	///<summary>
	///Specifies or returns the scale factor for linear dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]
	public class Set_LinearScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinearScaleFactor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the unit of measurement for linear dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class UnitsFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitsFormat);

		}
	}


	///<summary>
	///Specifies or returns the unit of measurement for linear dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("format", typeof(System.Object))]
	public class Set_UnitsFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnitsFormat = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns how measurements are rounded for all dimensions except angular dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class RoundDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RoundDistance);

		}
	}


	///<summary>
	///Specifies or returns how measurements are rounded for all dimensions except angular dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]
	public class Set_RoundDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RoundDistance = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether the first dimension line displays.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class DimLine1Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimLine1Suppress);

		}
	}


	///<summary>
	///Specifies or returns whether the first dimension line displays.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bSuppress", typeof(System.Object))]
	public class Set_DimLine1Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimLine1Suppress = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether the second dimension line displays.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class DimLine2Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimLine2Suppress);

		}
	}


	///<summary>
	///Specifies or returns whether the second dimension line displays.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bSuppress", typeof(System.Object))]
	public class Set_DimLine2Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimLine2Suppress = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether dimension text displays between extension lines.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class TextInsideAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextInsideAlign);

		}
	}


	///<summary>
	///Specifies or returns whether dimension text displays between extension lines.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bInside", typeof(System.Object))]
	public class Set_TextInsideAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextInsideAlign = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether dimension text between extension lines is aligned horizontally or with the dimension line.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class TextInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextInside);

		}
	}


	///<summary>
	///Specifies or returns whether dimension text between extension lines is aligned horizontally or with the dimension line.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bInside", typeof(System.Object))]
	public class Set_TextInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextInside = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether dimension lines display between extension lines when text is positioned outside of the extension lines.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class ForceLineInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForceLineInside);

		}
	}


	///<summary>
	///Specifies or returns whether dimension lines display between extension lines when text is positioned outside of the extension lines.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bInside", typeof(System.Object))]
	public class Set_ForceLineInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForceLineInside = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether dimension text displays outside of extension lines.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class TextOutsideAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextOutsideAlign);

		}
	}


	///<summary>
	///Specifies or returns whether dimension text displays outside of extension lines.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bInside", typeof(System.Object))]
	public class Set_TextOutsideAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextOutsideAlign = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the type of center mark used for diametral dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class CenterType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CenterType);

		}
	}


	///<summary>
	///Specifies or returns the type of center mark used for diametral dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]
	public class Set_CenterType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CenterType = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the size of the center mark used for diametral dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class CenterMarkSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CenterMarkSize);

		}
	}


	///<summary>
	///Specifies or returns the size of the center mark used for diametral dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Type", typeof(System.Double))]
	public class Set_CenterMarkSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CenterMarkSize = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether leading zeros display for alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSuppressLeadingZeros);

		}
	}


	///<summary>
	///Specifies or returns whether leading zeros display for alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_AltSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSuppressLeadingZeros = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether leading zeros display for alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSuppressTrailingZeros);

		}
	}


	///<summary>
	///Specifies or returns whether leading zeros display for alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_AltSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSuppressTrailingZeros = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether zero feet measurements display for alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSuppressZeroFeet);

		}
	}


	///<summary>
	///Specifies or returns whether zero feet measurements display for alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_AltSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSuppressZeroFeet = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether zero inch measurements display for alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSuppressZeroInches);

		}
	}


	///<summary>
	///Specifies or returns whether zero inch measurements display for alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_AltSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSuppressZeroInches = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether leading zeros display for tolerance values of alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltToleranceSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltToleranceSuppressLeadingZeros);

		}
	}


	///<summary>
	///Specifies or returns whether leading zeros display for tolerance values of alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_AltToleranceSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltToleranceSuppressLeadingZeros = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether trailing zeros display for tolerance values of alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltToleranceSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltToleranceSuppressTrailingZeros);

		}
	}


	///<summary>
	///Specifies or returns whether trailing zeros display for tolerance values of alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_AltToleranceSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltToleranceSuppressTrailingZeros = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether zero feet measurements display for tolerance values of alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltToleranceSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltToleranceSuppressZeroFeet);

		}
	}


	///<summary>
	///Specifies or returns whether zero feet measurements display for tolerance values of alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_AltToleranceSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltToleranceSuppressZeroFeet = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether zero inch measurements display for tolerance values of alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class AltToleranceSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltToleranceSuppressZeroInches);

		}
	}


	///<summary>
	///Specifies or returns whether zero inch measurements display for tolerance values of alternate unit dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_AltToleranceSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltToleranceSuppressZeroInches = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether zero feet measurements display for dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class SuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressZeroFeet);

		}
	}


	///<summary>
	///Specifies or returns whether zero feet measurements display for dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_SuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SuppressZeroFeet = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether zero inch measurements display for dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class SuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressZeroInches);

		}
	}


	///<summary>
	///Specifies or returns whether zero inch measurements display for dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_SuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SuppressZeroInches = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether zero feet measurements display for tolerance values of dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class ToleranceSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceSuppressZeroFeet);

		}
	}


	///<summary>
	///Specifies or returns whether zero feet measurements display for tolerance values of dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_ToleranceSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceSuppressZeroFeet = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether zero inch measurements display for tolerance values of dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class ToleranceSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceSuppressZeroInches);

		}
	}


	///<summary>
	///Specifies or returns whether zero inch measurements display for tolerance values of dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]
	public class Set_ToleranceSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceSuppressZeroInches = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the lineweight of dimension lines.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class DimensionLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLineWeight);

		}
	}


	///<summary>
	///Specifies or returns the lineweight of dimension lines.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("weight", typeof(System.Object))]
	public class Set_DimensionLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLineWeight = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the size of dimension arrowheads.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadSize);

		}
	}


	///<summary>
	///Specifies or returns the size of dimension arrowheads.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("size", typeof(System.Double))]
	public class Set_ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadSize = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the arrowhead of the first dimension line.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class Arrowhead1Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrowhead1Type);

		}
	}


	///<summary>
	///Specifies or returns the arrowhead of the first dimension line.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]
	public class Set_Arrowhead1Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrowhead1Type = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the arrowhead of the second dimension line.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class Arrowhead2Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrowhead2Type);

		}
	}


	///<summary>
	///Specifies or returns the arrowhead of the second dimension line.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]
	public class Set_Arrowhead2Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrowhead2Type = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the length measurement of linear dimensions or the angle measurement for angular dimensions.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class Measurement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Measurement);

		}
	}


	///<summary>
	///Specifies or returns a custom block to replace the arrowhead of the first dimension line.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class Arrowhead1Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrowhead1Block);

		}
	}


	///<summary>
	///Specifies or returns a custom block to replace the arrowhead of the first dimension line.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]
	public class Set_Arrowhead1Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrowhead1Block = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns a custom block to replace the arrowhead of the second dimension line.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class Arrowhead2Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrowhead2Block);

		}
	}


	///<summary>
	///Specifies or returns a custom block to replace the arrowhead of the second dimension line.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]
	public class Set_Arrowhead2Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrowhead2Block = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the linetype of a dimension line.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class DimensionLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLinetype);

		}
	}


	///<summary>
	///Specifies the linetype of a dimension line.
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]
	public class Set_DimensionLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLinetype = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the constraint type - Dynamic or Annotational
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class DimConstrForm : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrForm);

		}
	}


	///<summary>
	///Specifies the constraint type - Dynamic or Annotational
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bIsDynamic", typeof(System.Object))]
	public class Set_DimConstrForm : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrForm = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies whether the parameter is a reference constraint. Reference dimensions can be used in expressions but don't drive geometry - similar to an associative dimension
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class DimConstrReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrReference);

		}
	}


	///<summary>
	///Specifies whether the parameter is a reference constraint. Reference dimensions can be used in expressions but don't drive geometry - similar to an associative dimension
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bIsReference", typeof(System.Object))]
	public class Set_DimConstrReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrReference = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the name of the dimensional constraint. Names cannot have spaces
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class DimConstrName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrName);

		}
	}


	///<summary>
	///Specifies the name of the dimensional constraint. Names cannot have spaces
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]
	public class Set_DimConstrName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrName = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the expression or the value of the constraint
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class DimConstrExpression : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrExpression);

		}
	}


	///<summary>
	///Specifies the expression or the value of the constraint
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bstrExpression", typeof(System.String))]
	public class Set_DimConstrExpression : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrExpression = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the value of the constraint
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class DimConstrValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrValue);

		}
	}


	///<summary>
	///Specifies the value of the constraint
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Value", typeof(System.String))]
	public class Set_DimConstrValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrValue = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies description for constraint
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	public class DimConstrDesc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrDesc);

		}
	}


	///<summary>
	///Specifies description for constraint
	///</summary>
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bstrDescription", typeof(System.String))]
	public class Set_DimConstrDesc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrDesc = inputs[1];
			return null;
		}
	}
}
