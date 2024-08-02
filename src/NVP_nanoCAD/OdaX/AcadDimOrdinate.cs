using NVP.API.Nodes;

namespace OdaX.AcadDimOrdinate 
{
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


		///<summary>
		///Specifies or returns whether alternate units are used for dimensions.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		///Specifies or returns the color of extension lines.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		public class ExtensionLineColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExtensionLineColor);

			}
		}


		///<summary>
		///Specifies or returns the color of extension lines.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_ExtensionLineColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExtensionLineColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the number of decimal places for the primary units of dimensions.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		///Specifies or returns the scale factor for linear dimensions.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		///Specifies or returns the lineweight of extension lines.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		public class ExtensionLineWeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExtensionLineWeight);

			}
		}


		///<summary>
		///Specifies or returns the lineweight of extension lines.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		[NodeInput("lweight", typeof(System.Object))]
		public class Set_ExtensionLineWeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExtensionLineWeight = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns how measurements are rounded for all dimensions except angular dimensions.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		///Specifies or returns the distance between extension lines and the object being dimensioned.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		public class ExtensionLineOffset : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExtensionLineOffset);

			}
		}


		///<summary>
		///Specifies or returns the distance between extension lines and the object being dimensioned.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		[NodeInput("Offset", typeof(System.Double))]
		public class Set_ExtensionLineOffset : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExtensionLineOffset = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether leading zeros display for alternate unit dimensions.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		///Specifies or returns the size of dimension arrowheads.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		[NodeInput("AcadDimOrdinate", typeof(object))]
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
		///Returns the length measurement of linear dimensions or the angle measurement for angular dimensions.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		public class Measurement : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Measurement);

			}
		}


		///<summary>
		///Specifies or returns whether fixed-length extension lines display.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		public class ExtLineFixedLenSuppress : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExtLineFixedLenSuppress);

			}
		}


		///<summary>
		///Specifies or returns whether fixed-length extension lines display.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		[NodeInput("bFixedLen", typeof(System.Object))]
		public class Set_ExtLineFixedLenSuppress : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExtLineFixedLenSuppress = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether extension lines are a fixed length.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		public class ExtLineFixedLen : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExtLineFixedLen);

			}
		}


		///<summary>
		///Specifies or returns whether extension lines are a fixed length.
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		[NodeInput("FixedLen", typeof(System.Double))]
		public class Set_ExtLineFixedLen : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExtLineFixedLen = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the text suffix for all applicable linear dimension when change to sub-units
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		public class SubUnitsSuffix : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SubUnitsSuffix);

			}
		}


		///<summary>
		///Specifies the text suffix for all applicable linear dimension when change to sub-units
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		[NodeInput("suffix", typeof(System.String))]
		public class Set_SubUnitsSuffix : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SubUnitsSuffix = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the sub-units scale factor for all applicable linear dimension
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		public class SubUnitsFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SubUnitsFactor);

			}
		}


		///<summary>
		///Specifies the sub-units scale factor for all applicable linear dimension
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		[NodeInput("factor", typeof(System.Double))]
		public class Set_SubUnitsFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SubUnitsFactor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the text suffix for the alternate dimension when change to alternate sub-units
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		public class AltSubUnitsSuffix : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AltSubUnitsSuffix);

			}
		}


		///<summary>
		///Specifies the text suffix for the alternate dimension when change to alternate sub-units
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		[NodeInput("suffix", typeof(System.String))]
		public class Set_AltSubUnitsSuffix : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AltSubUnitsSuffix = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the alternate sub-units scale factor for all applicable linear dimension
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		public class AltSubUnitsFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AltSubUnitsFactor);

			}
		}


		///<summary>
		///Specifies the alternate sub-units scale factor for all applicable linear dimension
		///</summary>
		[NodeInput("AcadDimOrdinate", typeof(object))]
		[NodeInput("factor", typeof(System.Double))]
		public class Set_AltSubUnitsFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AltSubUnitsFactor = inputs[1];
				return null;
			}
		}
}
