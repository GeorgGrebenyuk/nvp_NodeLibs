using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a single line of alphanumeric characters
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadText 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadText_Constructor : INode 
	{
		public OdaX.IAcadText _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadText;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadText_ConstructorCast : INode 
	{
		public OdaX.IAcadText _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadText;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies the text string of the text", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Specifies the text string of the text
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
		Text = "Specifies the text string of the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies the text string of the text
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
		Text = "Specifies the style name of the text", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Specifies the style name of the text
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
		Text = "Specifies the style name of the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the style name of the text
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
		Text = "Specifies both text height and text orientation by designating the endpoints of the baseline", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Specifies both text height and text orientation by designating the endpoints of the baseline
	///</summary>
	public class Alignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Alignment);

		}
	}


	[NVP_Manifest(
		Text = "Specifies both text height and text orientation by designating the endpoints of the baseline", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("OdaX.AcAlignment", typeof(System.Object))]

	///<summary>
	///Specifies both text height and text orientation by designating the endpoints of the baseline
	///</summary>
	public class Set_Alignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Alignment = ((OdaX.AcAlignment)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the horizontal alignment of the text", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Specifies the horizontal alignment of the text
	///</summary>
	public class HorizontalAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HorizontalAlignment);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the horizontal alignment of the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("OdaX.AcHorizontalAlignment", typeof(System.Object))]

	///<summary>
	///Specifies the horizontal alignment of the text
	///</summary>
	public class Set_HorizontalAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HorizontalAlignment = ((OdaX.AcHorizontalAlignment)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the vertical alignment of the text", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Specifies the vertical alignment of the text
	///</summary>
	public class VerticalAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalAlignment);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the vertical alignment of the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("OdaX.AcVerticalAlignment", typeof(System.Object))]

	///<summary>
	///Specifies the vertical alignment of the text
	///</summary>
	public class Set_VerticalAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VerticalAlignment = ((OdaX.AcVerticalAlignment)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the height of the text", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Specifies the height of the text
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the height of the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies the height of the text
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the rotation angle of the text", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Specifies the rotation angle of the text
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
		Text = "Specifies the rotation angle of the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies the rotation angle of the text
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
		Text = "Specifies the width scale factor of the text", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Specifies the width scale factor of the text
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
		Text = "Specifies the width scale factor of the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("scalFactor", typeof(System.Object))]

	///<summary>
	///Specifies the width scale factor of the text
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
		Text = "Specifies the oblique angle of the text", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Specifies the oblique angle of the text
	///</summary>
	public class ObliqueAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObliqueAngle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the oblique angle of the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("obliAngle", typeof(System.Object))]

	///<summary>
	///Specifies the oblique angle of the text
	///</summary>
	public class Set_ObliqueAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObliqueAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specify the X, Y, Z coordinate of the alignment point of the text", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Specify the X, Y, Z coordinate of the alignment point of the text
	///</summary>
	public class TextAlignmentPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAlignmentPoint);

		}
	}


	[NVP_Manifest(
		Text = "Specify the X, Y, Z coordinate of the alignment point of the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("alignPoint", typeof(System.Object))]

	///<summary>
	///Specify the X, Y, Z coordinate of the alignment point of the text
	///</summary>
	public class Set_TextAlignmentPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAlignmentPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specify the X, Y, Z coordinate of the insertion point of the text", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Specify the X, Y, Z coordinate of the insertion point of the text
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
		Text = "Specify the X, Y, Z coordinate of the insertion point of the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("insPoint", typeof(System.Object))]

	///<summary>
	///Specify the X, Y, Z coordinate of the insertion point of the text
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
	[NodeInput("AcadText", typeof(object))]

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
	[NodeInput("AcadText", typeof(object))]
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
		Text = "Specifies the attribute text generation flag", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Specifies the attribute text generation flag
	///</summary>
	public class TextGenerationFlag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextGenerationFlag);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the attribute text generation flag", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("textGenFlag", typeof(System.Object))]

	///<summary>
	///Specifies the attribute text generation flag
	///</summary>
	public class Set_TextGenerationFlag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextGenerationFlag = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "z-direction value) of the text", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///z-direction value) of the text
	///</summary>
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	[NVP_Manifest(
		Text = "z-direction value) of the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of the text
	///</summary>
	public class Set_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Determines whether the text is upside down or not", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Determines whether the text is upside down or not
	///</summary>
	public class UpsideDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UpsideDown);

		}
	}


	[NVP_Manifest(
		Text = "Determines whether the text is upside down or not", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("UpsideDown", typeof(System.Object))]

	///<summary>
	///Determines whether the text is upside down or not
	///</summary>
	public class Set_UpsideDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UpsideDown = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Determines whether the text is backward or not", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Determines whether the text is backward or not
	///</summary>
	public class Backward : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Backward);

		}
	}


	[NVP_Manifest(
		Text = "Determines whether the text is backward or not", 
		ViewType = "Modifier")]
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("Backward", typeof(System.Object))]

	///<summary>
	///Determines whether the text is backward or not
	///</summary>
	public class Set_Backward : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Backward = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the text string with field codes of the text", 
		ViewType = "Data")]
	[NodeInput("AcadText", typeof(object))]

	///<summary>
	///Returns the text string with field codes of the text
	///</summary>
	public class FieldCode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FieldCode);

		}
	}
}
