using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSLevelMark Interface
///</summary>
namespace NVP_ModelStudio_COM._mdsURSLib.MDSLevelMark 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLevelMark_Constructor : INode 
	{
		public mdsURSLib.IMDSLevelMark _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsURSLib.IMDSLevelMark;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLevelMark_ConstructorCast : INode 
	{
		public mdsURSLib.IMDSLevelMark _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsURSLib.IMDSLevelMark;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property Location", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property Location
	///</summary>
	public class Location : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Location);

		}
	}


	[NVP_Manifest(
		Text = "property Location", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Location
	///</summary>
	public class Set_Location : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Location = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Value", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property Value
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value);

		}
	}


	[NVP_Manifest(
		Text = "property Value", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Value
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property IsCustom", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property IsCustom
	///</summary>
	public class IsCustom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsCustom);

		}
	}


	[NVP_Manifest(
		Text = "property IsCustom", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property IsCustom
	///</summary>
	public class Set_IsCustom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IsCustom = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Scale", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property Scale
	///</summary>
	public class Scale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Scale);

		}
	}


	[NVP_Manifest(
		Text = "property Scale", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Scale
	///</summary>
	public class Set_Scale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Scale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Base", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property Base
	///</summary>
	public class Base : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Base);

		}
	}


	[NVP_Manifest(
		Text = "property Base", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Base
	///</summary>
	public class Set_Base : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Base = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property CoordinateId", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property CoordinateId
	///</summary>
	public class CoordinateId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CoordinateId);

		}
	}


	[NVP_Manifest(
		Text = "property CoordinateId", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property CoordinateId
	///</summary>
	public class Set_CoordinateId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CoordinateId = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Precision", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property Precision
	///</summary>
	public class Precision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Precision);

		}
	}


	[NVP_Manifest(
		Text = "property Precision", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Precision
	///</summary>
	public class Set_Precision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Precision = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property SignedPositive", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property SignedPositive
	///</summary>
	public class SignedPositive : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SignedPositive);

		}
	}


	[NVP_Manifest(
		Text = "property SignedPositive", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property SignedPositive
	///</summary>
	public class Set_SignedPositive : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SignedPositive = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property TextStyle", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property TextStyle
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
		Text = "property TextStyle", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property TextStyle
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
		Text = "property TextHeight", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property TextHeight
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
		Text = "property TextHeight", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property TextHeight
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
		Text = "property ArrowHeight", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property ArrowHeight
	///</summary>
	public class ArrowHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowHeight);

		}
	}


	[NVP_Manifest(
		Text = "property ArrowHeight", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ArrowHeight
	///</summary>
	public class Set_ArrowHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ShelfWidth", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property ShelfWidth
	///</summary>
	public class ShelfWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShelfWidth);

		}
	}


	[NVP_Manifest(
		Text = "property ShelfWidth", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ShelfWidth
	///</summary>
	public class Set_ShelfWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShelfWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ArrowSize", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property ArrowSize
	///</summary>
	public class ArrowSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowSize);

		}
	}


	[NVP_Manifest(
		Text = "property ArrowSize", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ArrowSize
	///</summary>
	public class Set_ArrowSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ArrowLineWidth", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property ArrowLineWidth
	///</summary>
	public class ArrowLineWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowLineWidth);

		}
	}


	[NVP_Manifest(
		Text = "property ArrowLineWidth", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ArrowLineWidth
	///</summary>
	public class Set_ArrowLineWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowLineWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ShelfOffset", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property ShelfOffset
	///</summary>
	public class ShelfOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShelfOffset);

		}
	}


	[NVP_Manifest(
		Text = "property ShelfOffset", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ShelfOffset
	///</summary>
	public class Set_ShelfOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShelfOffset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property OffsetX", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property OffsetX
	///</summary>
	public class OffsetX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetX);

		}
	}


	[NVP_Manifest(
		Text = "property OffsetX", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property OffsetX
	///</summary>
	public class Set_OffsetX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Bottom String", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property Bottom String
	///</summary>
	public class BottomStrValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BottomStrValue);

		}
	}


	[NVP_Manifest(
		Text = "property Bottom String", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bottom String
	///</summary>
	public class Set_BottomStrValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BottomStrValue = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property textGap", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property textGap
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
		Text = "property textGap", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property textGap
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
		Text = "property freemarklocation", 
		ViewType = "Data")]
	[NodeInput("MDSLevelMark", typeof(object))]

	///<summary>
	///property freemarklocation
	///</summary>
	public class FreeMarkLocation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FreeMarkLocation);

		}
	}


	[NVP_Manifest(
		Text = "property freemarklocation", 
		ViewType = "Modifier")]
	[NodeInput("MDSLevelMark", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property freemarklocation
	///</summary>
	public class Set_FreeMarkLocation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FreeMarkLocation = inputs[1].Value;
			return null;
		}
	}
}
