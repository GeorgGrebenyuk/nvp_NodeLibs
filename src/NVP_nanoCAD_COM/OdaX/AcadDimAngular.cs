using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a dimension measuring the angular distance between two lines or between the angle of a circular arc
///</summary>
namespace OdaX.AcadDimAngular 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Specifies or returns the start point of the first extension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

	///<summary>
	///Specifies or returns the start point of the first extension line.
	///</summary>
	public class ExtLine1StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLine1StartPoint);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the start point of the first extension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAngular", typeof(object))]
	[NodeInput("xLine1Point", typeof(System.Object))]

	///<summary>
	///Specifies or returns the start point of the first extension line.
	///</summary>
	public class Set_ExtLine1StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLine1StartPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the end point of the first extension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

	///<summary>
	///Specifies or returns the end point of the first extension line.
	///</summary>
	public class ExtLine1EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLine1EndPoint);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the end point of the first extension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAngular", typeof(object))]
	[NodeInput("xLine1Point", typeof(System.Object))]

	///<summary>
	///Specifies or returns the end point of the first extension line.
	///</summary>
	public class Set_ExtLine1EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLine1EndPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the start point of the second extension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

	///<summary>
	///Specifies or returns the start point of the second extension line.
	///</summary>
	public class ExtLine2StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLine2StartPoint);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the start point of the second extension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAngular", typeof(object))]
	[NodeInput("xLine2Point", typeof(System.Object))]

	///<summary>
	///Specifies or returns the start point of the second extension line.
	///</summary>
	public class Set_ExtLine2StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLine2StartPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the end point of the second extension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

	///<summary>
	///Specifies or returns the end point of the second extension line.
	///</summary>
	public class ExtLine2EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLine2EndPoint);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the end point of the second extension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAngular", typeof(object))]
	[NodeInput("xLine2Point", typeof(System.Object))]

	///<summary>
	///Specifies or returns the end point of the second extension line.
	///</summary>
	public class Set_ExtLine2EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLine2EndPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the unit of measurement for angular dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

	///<summary>
	///Specifies or returns the unit of measurement for angular dimensions.
	///</summary>
	public class AngleFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleFormat);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the unit of measurement for angular dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAngular", typeof(object))]
	[NodeInput("OdaX.AcAngleUnits", typeof(System.Object))]

	///<summary>
	///Specifies or returns the unit of measurement for angular dimensions.
	///</summary>
	public class Set_AngleFormat : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AngleFormat = ((OdaX.AcAngleUnits)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of dimension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
		Text = "Specifies or returns the color of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
		Text = "Specifies or returns how far extension lines extend beyond dimension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

	///<summary>
	///Specifies or returns how far extension lines extend beyond dimension lines.
	///</summary>
	public class ExtensionLineExtend : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtensionLineExtend);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how far extension lines extend beyond dimension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAngular", typeof(object))]
	[NodeInput("extend", typeof(System.Double))]

	///<summary>
	///Specifies or returns how far extension lines extend beyond dimension lines.
	///</summary>
	public class Set_ExtensionLineExtend : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtensionLineExtend = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how text and arrowheads are positioned when they do not fit in the space between extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
		Text = "Specifies or returns the horizontal position of dimension text.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

	///<summary>
	///Specifies or returns the horizontal position of dimension text.
	///</summary>
	public class HorizontalTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HorizontalTextPosition);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the horizontal position of dimension text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAngular", typeof(object))]
	[NodeInput("OdaX.AcDimHorizontalJustification", typeof(System.Object))]

	///<summary>
	///Specifies or returns the horizontal position of dimension text.
	///</summary>
	public class Set_HorizontalTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HorizontalTextPosition = ((OdaX.AcDimHorizontalJustification)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
		Text = "Specifies or returns whether the first dimension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
		Text = "Specifies or returns whether the first extension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

	///<summary>
	///Specifies or returns whether the first extension line displays.
	///</summary>
	public class ExtLine1Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLine1Suppress);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the first extension line displays.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAngular", typeof(object))]
	[NodeInput("bSuppress", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the first extension line displays.
	///</summary>
	public class Set_ExtLine1Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLine1Suppress = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the second extension line displays.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

	///<summary>
	///Specifies or returns whether the second extension line displays.
	///</summary>
	public class ExtLine2Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLine2Suppress);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the second extension line displays.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAngular", typeof(object))]
	[NodeInput("bSuppress", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the second extension line displays.
	///</summary>
	public class Set_ExtLine2Suppress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLine2Suppress = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dimension lines are drawn outside of extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

	///<summary>
	///Specifies or returns whether dimension lines are drawn outside of extension lines.
	///</summary>
	public class DimLineInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimLineInside);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dimension lines are drawn outside of extension lines.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAngular", typeof(object))]
	[NodeInput("bInside", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether dimension lines are drawn outside of extension lines.
	///</summary>
	public class Set_DimLineInside : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimLineInside = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dimension text displays between extension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
		Text = "Specifies or returns the number of decimal places for angular dimension text.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

	///<summary>
	///Specifies or returns the number of decimal places for angular dimension text.
	///</summary>
	public class TextPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextPrecision);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of decimal places for angular dimension text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAngular", typeof(object))]
	[NodeInput("OdaX.AcDimPrecision", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of decimal places for angular dimension text.
	///</summary>
	public class Set_TextPrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextPrecision = ((OdaX.AcDimPrecision)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the distance between extension lines and the object being dimensioned.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
		Text = "Specifies or returns the lineweight of dimension lines.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
		Text = "Specifies or returns the linetype of the first extension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of the first extension line.
	///</summary>
	public class ExtLine1Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLine1Linetype);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of the first extension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAngular", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of the first extension line.
	///</summary>
	public class Set_ExtLine1Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLine1Linetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of the second extension line.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of the second extension line.
	///</summary>
	public class ExtLine2Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExtLine2Linetype);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of the second extension line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimAngular", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of the second extension line.
	///</summary>
	public class Set_ExtLine2Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExtLine2Linetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether fixed-length extension lines display.", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
		Text = "Specifies the constraint type - Dynamic or Annotational", 
		ViewType = "Data")]
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
	[NodeInput("AcadDimAngular", typeof(object))]

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
	[NodeInput("AcadDimAngular", typeof(object))]
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
