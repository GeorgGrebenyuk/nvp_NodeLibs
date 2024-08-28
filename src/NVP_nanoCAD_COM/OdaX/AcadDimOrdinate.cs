using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a dimension measuring the absolute X or Y position of a point from the origin
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadDimOrdinate 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimOrdinate_Constructor : INode 
	{
		public OdaX.IAcadDimOrdinate _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDimOrdinate;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimOrdinate_ConstructorCast : INode 
	{
		public OdaX.IAcadDimOrdinate _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDimOrdinate;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether alternate units are used for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
		Text = "Specifies or returns the color of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

	///<summary>
	///Specifies or returns the color of extension lines.
	///</summary>
	public class ExtensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtensionLineColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimOrdinate", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of extension lines.
	///</summary>
	public class Set_ExtensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtensionLineColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of decimal places for the primary units of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
		Text = "Specifies or returns the scale factor for linear dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
		Text = "Specifies or returns the lineweight of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of extension lines.
	///</summary>
	public class ExtensionLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtensionLineWeight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimOrdinate", typeof(object))]
	[NodeInput("lweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of extension lines.
	///</summary>
	public class Set_ExtensionLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtensionLineWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how measurements are rounded for all dimensions except angular dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
		Text = "Specifies or returns the distance between extension lines and the object being dimensioned.", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

	///<summary>
	///Specifies or returns the distance between extension lines and the object being dimensioned.
	///</summary>
	public class ExtensionLineOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtensionLineOffset);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the distance between extension lines and the object being dimensioned.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimOrdinate", typeof(object))]
	[NodeInput("Offset", typeof(System.Double))]

	///<summary>
	///Specifies or returns the distance between extension lines and the object being dimensioned.
	///</summary>
	public class Set_ExtensionLineOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtensionLineOffset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether leading zeros display for alternate unit dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
		Text = "Specifies or returns the size of dimension arrowheads.", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
	[NodeInput("AcadDimOrdinate", typeof(object))]
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
		Text = "Returns the length measurement of linear dimensions or the angle measurement for angular dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

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
		Text = "Specifies or returns whether fixed-length extension lines display.", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

	///<summary>
	///Specifies or returns whether fixed-length extension lines display.
	///</summary>
	public class ExtLineFixedLenSuppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLineFixedLenSuppress);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether fixed-length extension lines display.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimOrdinate", typeof(object))]
	[NodeInput("bFixedLen", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether fixed-length extension lines display.
	///</summary>
	public class Set_ExtLineFixedLenSuppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLineFixedLenSuppress = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether extension lines are a fixed length.", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

	///<summary>
	///Specifies or returns whether extension lines are a fixed length.
	///</summary>
	public class ExtLineFixedLen : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLineFixedLen);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether extension lines are a fixed length.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimOrdinate", typeof(object))]
	[NodeInput("FixedLen", typeof(System.Double))]

	///<summary>
	///Specifies or returns whether extension lines are a fixed length.
	///</summary>
	public class Set_ExtLineFixedLen : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLineFixedLen = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the text suffix for all applicable linear dimension when change to sub-units", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

	///<summary>
	///Specifies the text suffix for all applicable linear dimension when change to sub-units
	///</summary>
	public class SubUnitsSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SubUnitsSuffix);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the text suffix for all applicable linear dimension when change to sub-units", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimOrdinate", typeof(object))]
	[NodeInput("suffix", typeof(System.String))]

	///<summary>
	///Specifies the text suffix for all applicable linear dimension when change to sub-units
	///</summary>
	public class Set_SubUnitsSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SubUnitsSuffix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the sub-units scale factor for all applicable linear dimension", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

	///<summary>
	///Specifies the sub-units scale factor for all applicable linear dimension
	///</summary>
	public class SubUnitsFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SubUnitsFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the sub-units scale factor for all applicable linear dimension", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimOrdinate", typeof(object))]
	[NodeInput("factor", typeof(System.Double))]

	///<summary>
	///Specifies the sub-units scale factor for all applicable linear dimension
	///</summary>
	public class Set_SubUnitsFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SubUnitsFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the text suffix for the alternate dimension when change to alternate sub-units", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

	///<summary>
	///Specifies the text suffix for the alternate dimension when change to alternate sub-units
	///</summary>
	public class AltSubUnitsSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSubUnitsSuffix);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the text suffix for the alternate dimension when change to alternate sub-units", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimOrdinate", typeof(object))]
	[NodeInput("suffix", typeof(System.String))]

	///<summary>
	///Specifies the text suffix for the alternate dimension when change to alternate sub-units
	///</summary>
	public class Set_AltSubUnitsSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSubUnitsSuffix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the alternate sub-units scale factor for all applicable linear dimension", 
		ViewType = "Data")]
	[NodeInput("AcadDimOrdinate", typeof(object))]

	///<summary>
	///Specifies the alternate sub-units scale factor for all applicable linear dimension
	///</summary>
	public class AltSubUnitsFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltSubUnitsFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the alternate sub-units scale factor for all applicable linear dimension", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimOrdinate", typeof(object))]
	[NodeInput("factor", typeof(System.Double))]

	///<summary>
	///Specifies the alternate sub-units scale factor for all applicable linear dimension
	///</summary>
	public class Set_AltSubUnitsFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltSubUnitsFactor = inputs[1].Value;
			return null;
		}
	}
}
