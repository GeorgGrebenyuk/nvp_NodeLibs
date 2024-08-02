using NVP.API.Nodes;

namespace OdaX.AcadDimAngular 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadDimAngular_Constructor : INode 
		{
		public OdaX.IAcadDimAngular _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadDimAngular;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadDimAngular_ConstructorCast : INode 
		{
		public OdaX.IAcadDimAngular _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadDimAngular;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the start point of the first extension line.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		public class ExtLine1StartPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExtLine1StartPoint);

			}
		}


		///<summary>
		///Specifies or returns the start point of the first extension line.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		[NodeInput("xLine1Point", typeof(System.Object))]
		public class Set_ExtLine1StartPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExtLine1StartPoint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the end point of the first extension line.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		public class ExtLine1EndPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExtLine1EndPoint);

			}
		}


		///<summary>
		///Specifies or returns the end point of the first extension line.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		[NodeInput("xLine1Point", typeof(System.Object))]
		public class Set_ExtLine1EndPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExtLine1EndPoint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the start point of the second extension line.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		public class ExtLine2StartPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExtLine2StartPoint);

			}
		}


		///<summary>
		///Specifies or returns the start point of the second extension line.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		[NodeInput("xLine2Point", typeof(System.Object))]
		public class Set_ExtLine2StartPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExtLine2StartPoint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the end point of the second extension line.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		public class ExtLine2EndPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExtLine2EndPoint);

			}
		}


		///<summary>
		///Specifies or returns the end point of the second extension line.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		[NodeInput("xLine2Point", typeof(System.Object))]
		public class Set_ExtLine2EndPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExtLine2EndPoint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the unit of measurement for angular dimensions.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		public class AngleFormat : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AngleFormat);

			}
		}


		///<summary>
		///Specifies or returns the unit of measurement for angular dimensions.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		[NodeInput("format", typeof(System.Object))]
		public class Set_AngleFormat : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AngleFormat = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the color of dimension lines.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		///Specifies or returns the color of extension lines.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		///Specifies or returns how far extension lines extend beyond dimension lines.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		public class ExtensionLineExtend : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExtensionLineExtend);

			}
		}


		///<summary>
		///Specifies or returns how far extension lines extend beyond dimension lines.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		[NodeInput("extend", typeof(System.Double))]
		public class Set_ExtensionLineExtend : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExtensionLineExtend = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		///Specifies or returns the horizontal position of dimension text.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		public class HorizontalTextPosition : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HorizontalTextPosition);

			}
		}


		///<summary>
		///Specifies or returns the horizontal position of dimension text.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_HorizontalTextPosition : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.HorizontalTextPosition = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the lineweight of extension lines.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		///Specifies or returns whether the first dimension line displays.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		///Specifies or returns whether the first extension line displays.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		public class ExtLine1Suppress : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExtLine1Suppress);

			}
		}


		///<summary>
		///Specifies or returns whether the first extension line displays.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		[NodeInput("bSuppress", typeof(System.Object))]
		public class Set_ExtLine1Suppress : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExtLine1Suppress = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether the second extension line displays.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		public class ExtLine2Suppress : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExtLine2Suppress);

			}
		}


		///<summary>
		///Specifies or returns whether the second extension line displays.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		[NodeInput("bSuppress", typeof(System.Object))]
		public class Set_ExtLine2Suppress : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExtLine2Suppress = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether dimension lines are drawn outside of extension lines.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		public class DimLineInside : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DimLineInside);

			}
		}


		///<summary>
		///Specifies or returns whether dimension lines are drawn outside of extension lines.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		[NodeInput("bInside", typeof(System.Object))]
		public class Set_DimLineInside : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DimLineInside = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether dimension text displays between extension lines.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		///Specifies or returns the number of decimal places for angular dimension text.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		public class TextPrecision : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextPrecision);

			}
		}


		///<summary>
		///Specifies or returns the number of decimal places for angular dimension text.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		[NodeInput("precision", typeof(System.Object))]
		public class Set_TextPrecision : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextPrecision = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the distance between extension lines and the object being dimensioned.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		///Specifies or returns the lineweight of dimension lines.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		///Specifies or returns the linetype of the first extension line.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		public class ExtLine1Linetype : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExtLine1Linetype);

			}
		}


		///<summary>
		///Specifies or returns the linetype of the first extension line.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		[NodeInput("Linetype", typeof(System.String))]
		public class Set_ExtLine1Linetype : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExtLine1Linetype = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the linetype of the second extension line.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		public class ExtLine2Linetype : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ExtLine2Linetype);

			}
		}


		///<summary>
		///Specifies or returns the linetype of the second extension line.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
		[NodeInput("Linetype", typeof(System.String))]
		public class Set_ExtLine2Linetype : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ExtLine2Linetype = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether fixed-length extension lines display.
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		///Specifies the constraint type - Dynamic or Annotational
		///</summary>
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
		[NodeInput("AcadDimAngular", typeof(object))]
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
