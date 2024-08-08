using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a dimension measuring the diameter of a circle or arc
///</summary>
namespace OdaX.AcadDimDiametric 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Specifies the length of the leader used with the diametral dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("rhs", typeof(System.Double))]

	///<summary>
	///Specifies the length of the leader used with the diametral dimension.
	///</summary>
	public class Set_LeaderLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether alternate units are used for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether alternate units are used for dimensions.
	///</summary>
	public class AltUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltUnits);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether alternate units are used for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bAlternate", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether alternate units are used for dimensions.
	///</summary>
	public class Set_AltUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltUnits = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of decimal places for alternate unit dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the number of decimal places for alternate unit dimension.
	///</summary>
	public class AltUnitsPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltUnitsPrecision);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of decimal places for alternate unit dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("OdaX.AcDimPrecision", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of decimal places for alternate unit dimension.
	///</summary>
	public class Set_AltUnitsPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltUnitsPrecision = ((OdaX.AcDimPrecision)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale factor for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor for alternate unit dimensions.
	///</summary>
	public class AltUnitsScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltUnitsScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale factor for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("scale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale factor for alternate unit dimensions.
	///</summary>
	public class Set_AltUnitsScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltUnitsScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rounding value for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the rounding value for alternate unit dimensions.
	///</summary>
	public class AltRoundDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltRoundDistance);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rounding value for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Specifies or returns the rounding value for alternate unit dimensions.
	///</summary>
	public class Set_AltRoundDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltRoundDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of decimal places for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the number of decimal places for tolerance values of alternate unit dimensions.
	///</summary>
	public class AltTolerancePrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltTolerancePrecision);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of decimal places for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("OdaX.AcDimPrecision", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of decimal places for tolerance values of alternate unit dimensions.
	///</summary>
	public class Set_AltTolerancePrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltTolerancePrecision = ((OdaX.AcDimPrecision)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "not including angular dimensions).", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///not including angular dimensions).
	///</summary>
	public class AltUnitsFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltUnitsFormat);

		}
	}


	[NVP_Manifest(
		Text = "not including angular dimensions).", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("OdaX.AcDimUnits", typeof(System.Object))]

	///<summary>
	///not including angular dimensions).
	///</summary>
	public class Set_AltUnitsFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltUnitsFormat = ((OdaX.AcDimUnits)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "not including angular dimensions).", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///not including angular dimensions).
	///</summary>
	public class AltTextPrefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltTextPrefix);

		}
	}


	[NVP_Manifest(
		Text = "not including angular dimensions).", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("prefix", typeof(System.String))]

	///<summary>
	///not including angular dimensions).
	///</summary>
	public class Set_AltTextPrefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltTextPrefix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "not including angular dimensions).", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///not including angular dimensions).
	///</summary>
	public class AltTextSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltTextSuffix);

		}
	}


	[NVP_Manifest(
		Text = "not including angular dimensions).", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("prefix", typeof(System.String))]

	///<summary>
	///not including angular dimensions).
	///</summary>
	public class Set_AltTextSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltTextSuffix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of dimension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the color of dimension lines.
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
		Text = "Specifies or returns the color of dimension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of dimension lines.
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


	[NVP_Manifest(
		Text = "Specifies or returns the number of decimal places for the primary units of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the number of decimal places for the primary units of dimensions.
	///</summary>
	public class PrimaryUnitsPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrimaryUnitsPrecision);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of decimal places for the primary units of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("OdaX.AcDimPrecision", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of decimal places for the primary units of dimensions.
	///</summary>
	public class Set_PrimaryUnitsPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PrimaryUnitsPrecision = ((OdaX.AcDimPrecision)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how fractions display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns how fractions display for dimensions.
	///</summary>
	public class FractionFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FractionFormat);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how fractions display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("OdaX.AcDimFractionType", typeof(System.Object))]

	///<summary>
	///Specifies or returns how fractions display for dimensions.
	///</summary>
	public class Set_FractionFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FractionFormat = ((OdaX.AcDimFractionType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.
	///</summary>
	public class Fit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Fit);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("OdaX.AcDimFit", typeof(System.Object))]

	///<summary>
	///Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.
	///</summary>
	public class Set_Fit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Fit = ((OdaX.AcDimFit)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale factor for linear dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor for linear dimensions.
	///</summary>
	public class LinearScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinearScaleFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale factor for linear dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale factor for linear dimensions.
	///</summary>
	public class Set_LinearScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinearScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the unit of measurement for linear dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the unit of measurement for linear dimensions.
	///</summary>
	public class UnitsFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitsFormat);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the unit of measurement for linear dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("OdaX.AcDimLUnits", typeof(System.Object))]

	///<summary>
	///Specifies or returns the unit of measurement for linear dimensions.
	///</summary>
	public class Set_UnitsFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnitsFormat = ((OdaX.AcDimLUnits)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how measurements are rounded for all dimensions except angular dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns how measurements are rounded for all dimensions except angular dimensions.
	///</summary>
	public class RoundDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RoundDistance);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how measurements are rounded for all dimensions except angular dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Specifies or returns how measurements are rounded for all dimensions except angular dimensions.
	///</summary>
	public class Set_RoundDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RoundDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the first dimension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether the first dimension line displays.
	///</summary>
	public class DimLine1Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimLine1Suppress);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the first dimension line displays.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bSuppress", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the first dimension line displays.
	///</summary>
	public class Set_DimLine1Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimLine1Suppress = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the second dimension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether the second dimension line displays.
	///</summary>
	public class DimLine2Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimLine2Suppress);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the second dimension line displays.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bSuppress", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the second dimension line displays.
	///</summary>
	public class Set_DimLine2Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimLine2Suppress = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dimension text displays between extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether dimension text displays between extension lines.
	///</summary>
	public class TextInsideAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextInsideAlign);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dimension text displays between extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bInside", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether dimension text displays between extension lines.
	///</summary>
	public class Set_TextInsideAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextInsideAlign = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dimension text between extension lines is aligned horizontally or with the dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether dimension text between extension lines is aligned horizontally or with the dimension line.
	///</summary>
	public class TextInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextInside);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dimension text between extension lines is aligned horizontally or with the dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bInside", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether dimension text between extension lines is aligned horizontally or with the dimension line.
	///</summary>
	public class Set_TextInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextInside = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dimension lines display between extension lines when text is positioned outside of the extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether dimension lines display between extension lines when text is positioned outside of the extension lines.
	///</summary>
	public class ForceLineInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForceLineInside);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dimension lines display between extension lines when text is positioned outside of the extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bInside", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether dimension lines display between extension lines when text is positioned outside of the extension lines.
	///</summary>
	public class Set_ForceLineInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForceLineInside = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dimension text displays outside of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether dimension text displays outside of extension lines.
	///</summary>
	public class TextOutsideAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextOutsideAlign);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dimension text displays outside of extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bInside", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether dimension text displays outside of extension lines.
	///</summary>
	public class Set_TextOutsideAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextOutsideAlign = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the type of center mark used for diametral dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the type of center mark used for diametral dimensions.
	///</summary>
	public class CenterType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CenterType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the type of center mark used for diametral dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("OdaX.AcDimCenterType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of center mark used for diametral dimensions.
	///</summary>
	public class Set_CenterType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CenterType = ((OdaX.AcDimCenterType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the size of the center mark used for diametral dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the size of the center mark used for diametral dimensions.
	///</summary>
	public class CenterMarkSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CenterMarkSize);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the size of the center mark used for diametral dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Type", typeof(System.Double))]

	///<summary>
	///Specifies or returns the size of the center mark used for diametral dimensions.
	///</summary>
	public class Set_CenterMarkSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CenterMarkSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether leading zeros display for alternate unit dimensions.
	///</summary>
	public class AltSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSuppressLeadingZeros);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether leading zeros display for alternate unit dimensions.
	///</summary>
	public class Set_AltSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSuppressLeadingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether leading zeros display for alternate unit dimensions.
	///</summary>
	public class AltSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSuppressTrailingZeros);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether leading zeros display for alternate unit dimensions.
	///</summary>
	public class Set_AltSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSuppressTrailingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero feet measurements display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for alternate unit dimensions.
	///</summary>
	public class AltSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSuppressZeroFeet);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero feet measurements display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for alternate unit dimensions.
	///</summary>
	public class Set_AltSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSuppressZeroFeet = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero inch measurements display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for alternate unit dimensions.
	///</summary>
	public class AltSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSuppressZeroInches);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero inch measurements display for alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for alternate unit dimensions.
	///</summary>
	public class Set_AltSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSuppressZeroInches = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether leading zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether leading zeros display for tolerance values of alternate unit dimensions.
	///</summary>
	public class AltToleranceSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltToleranceSuppressLeadingZeros);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether leading zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether leading zeros display for tolerance values of alternate unit dimensions.
	///</summary>
	public class Set_AltToleranceSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltToleranceSuppressLeadingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether trailing zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether trailing zeros display for tolerance values of alternate unit dimensions.
	///</summary>
	public class AltToleranceSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltToleranceSuppressTrailingZeros);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether trailing zeros display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether trailing zeros display for tolerance values of alternate unit dimensions.
	///</summary>
	public class Set_AltToleranceSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltToleranceSuppressTrailingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for tolerance values of alternate unit dimensions.
	///</summary>
	public class AltToleranceSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltToleranceSuppressZeroFeet);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for tolerance values of alternate unit dimensions.
	///</summary>
	public class Set_AltToleranceSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltToleranceSuppressZeroFeet = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for tolerance values of alternate unit dimensions.
	///</summary>
	public class AltToleranceSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltToleranceSuppressZeroInches);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of alternate unit dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for tolerance values of alternate unit dimensions.
	///</summary>
	public class Set_AltToleranceSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltToleranceSuppressZeroInches = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero feet measurements display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for dimensions.
	///</summary>
	public class SuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressZeroFeet);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero feet measurements display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for dimensions.
	///</summary>
	public class Set_SuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SuppressZeroFeet = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero inch measurements display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for dimensions.
	///</summary>
	public class SuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressZeroInches);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero inch measurements display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for dimensions.
	///</summary>
	public class Set_SuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SuppressZeroInches = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for tolerance values of dimensions.
	///</summary>
	public class ToleranceSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceSuppressZeroFeet);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero feet measurements display for tolerance values of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero feet measurements display for tolerance values of dimensions.
	///</summary>
	public class Set_ToleranceSuppressZeroFeet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceSuppressZeroFeet = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for tolerance values of dimensions.
	///</summary>
	public class ToleranceSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceSuppressZeroInches);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether zero inch measurements display for tolerance values of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether zero inch measurements display for tolerance values of dimensions.
	///</summary>
	public class Set_ToleranceSuppressZeroInches : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceSuppressZeroInches = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of dimension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of dimension lines.
	///</summary>
	public class DimensionLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLineWeight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of dimension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("weight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of dimension lines.
	///</summary>
	public class Set_DimensionLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLineWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the size of dimension arrowheads.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the size of dimension arrowheads.
	///</summary>
	public class ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadSize);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the size of dimension arrowheads.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("size", typeof(System.Double))]

	///<summary>
	///Specifies or returns the size of dimension arrowheads.
	///</summary>
	public class Set_ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrowhead of the first dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the arrowhead of the first dimension line.
	///</summary>
	public class Arrowhead1Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrowhead1Type);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrowhead of the first dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("OdaX.AcDimArrowheadType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the arrowhead of the first dimension line.
	///</summary>
	public class Set_Arrowhead1Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrowhead1Type = ((OdaX.AcDimArrowheadType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrowhead of the second dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns the arrowhead of the second dimension line.
	///</summary>
	public class Arrowhead2Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrowhead2Type);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrowhead of the second dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("OdaX.AcDimArrowheadType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the arrowhead of the second dimension line.
	///</summary>
	public class Set_Arrowhead2Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrowhead2Type = ((OdaX.AcDimArrowheadType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the length measurement of linear dimensions or the angle measurement for angular dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Returns the length measurement of linear dimensions or the angle measurement for angular dimensions.
	///</summary>
	public class Measurement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Measurement);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns a custom block to replace the arrowhead of the first dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns a custom block to replace the arrowhead of the first dimension line.
	///</summary>
	public class Arrowhead1Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrowhead1Block);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns a custom block to replace the arrowhead of the first dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]

	///<summary>
	///Specifies or returns a custom block to replace the arrowhead of the first dimension line.
	///</summary>
	public class Set_Arrowhead1Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrowhead1Block = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns a custom block to replace the arrowhead of the second dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies or returns a custom block to replace the arrowhead of the second dimension line.
	///</summary>
	public class Arrowhead2Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrowhead2Block);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns a custom block to replace the arrowhead of the second dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]

	///<summary>
	///Specifies or returns a custom block to replace the arrowhead of the second dimension line.
	///</summary>
	public class Set_Arrowhead2Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrowhead2Block = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the linetype of a dimension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies the linetype of a dimension line.
	///</summary>
	public class DimensionLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLinetype);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the linetype of a dimension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies the linetype of a dimension line.
	///</summary>
	public class Set_DimensionLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the constraint type - Dynamic or Annotational", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies the constraint type - Dynamic or Annotational
	///</summary>
	public class DimConstrForm : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrForm);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the constraint type - Dynamic or Annotational", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bIsDynamic", typeof(System.Object))]

	///<summary>
	///Specifies the constraint type - Dynamic or Annotational
	///</summary>
	public class Set_DimConstrForm : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrForm = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies whether the parameter is a reference constraint. Reference dimensions can be used in expressions but don't drive geometry - similar to an associative dimension", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies whether the parameter is a reference constraint. Reference dimensions can be used in expressions but don't drive geometry - similar to an associative dimension
	///</summary>
	public class DimConstrReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrReference);

		}
	}


	[NVP_Manifest(
		Text = "Specifies whether the parameter is a reference constraint. Reference dimensions can be used in expressions but don't drive geometry - similar to an associative dimension", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bIsReference", typeof(System.Object))]

	///<summary>
	///Specifies whether the parameter is a reference constraint. Reference dimensions can be used in expressions but don't drive geometry - similar to an associative dimension
	///</summary>
	public class Set_DimConstrReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrReference = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the name of the dimensional constraint. Names cannot have spaces", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies the name of the dimensional constraint. Names cannot have spaces
	///</summary>
	public class DimConstrName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the name of the dimensional constraint. Names cannot have spaces", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the name of the dimensional constraint. Names cannot have spaces
	///</summary>
	public class Set_DimConstrName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the expression or the value of the constraint", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies the expression or the value of the constraint
	///</summary>
	public class DimConstrExpression : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrExpression);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the expression or the value of the constraint", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bstrExpression", typeof(System.String))]

	///<summary>
	///Specifies the expression or the value of the constraint
	///</summary>
	public class Set_DimConstrExpression : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrExpression = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the value of the constraint", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies the value of the constraint
	///</summary>
	public class DimConstrValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrValue);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the value of the constraint", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///Specifies the value of the constraint
	///</summary>
	public class Set_DimConstrValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrValue = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies description for constraint", 
		ViewType = "Data")]
	[NodeInput("AcadDimDiametric", typeof(object))]

	///<summary>
	///Specifies description for constraint
	///</summary>
	public class DimConstrDesc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimConstrDesc);

		}
	}


	[NVP_Manifest(
		Text = "Specifies description for constraint", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimDiametric", typeof(object))]
	[NodeInput("bstrDescription", typeof(System.String))]

	///<summary>
	///Specifies description for constraint
	///</summary>
	public class Set_DimConstrDesc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimConstrDesc = inputs[1].Value;
			return null;
		}
	}
}
