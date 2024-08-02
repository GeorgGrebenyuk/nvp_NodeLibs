using NVP.API.Nodes;

namespace OdaX.AcadText 
{
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


	///<summary>
	///Specifies the text string of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextString);

		}
	}


	///<summary>
	///Specifies the text string of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]
	public class Set_TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextString = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the style name of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleName);

		}
	}


	///<summary>
	///Specifies the style name of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
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
	///Specifies both text height and text orientation by designating the endpoints of the baseline
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class Alignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Alignment);

		}
	}


	///<summary>
	///Specifies both text height and text orientation by designating the endpoints of the baseline
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("align", typeof(System.Object))]
	public class Set_Alignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Alignment = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the horizontal alignment of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class HorizontalAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HorizontalAlignment);

		}
	}


	///<summary>
	///Specifies the horizontal alignment of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("horizAlign", typeof(System.Object))]
	public class Set_HorizontalAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HorizontalAlignment = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the vertical alignment of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class VerticalAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalAlignment);

		}
	}


	///<summary>
	///Specifies the vertical alignment of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("vertiAlign", typeof(System.Object))]
	public class Set_VerticalAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VerticalAlignment = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the height of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	///<summary>
	///Specifies the height of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the rotation angle of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rotation);

		}
	}


	///<summary>
	///Specifies the rotation angle of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
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
	///Specifies the width scale factor of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFactor);

		}
	}


	///<summary>
	///Specifies the width scale factor of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("scalFactor", typeof(System.Object))]
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
	///Specifies the oblique angle of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class ObliqueAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObliqueAngle);

		}
	}


	///<summary>
	///Specifies the oblique angle of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("obliAngle", typeof(System.Object))]
	public class Set_ObliqueAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObliqueAngle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specify the X, Y, Z coordinate of the alignment point of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class TextAlignmentPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAlignmentPoint);

		}
	}


	///<summary>
	///Specify the X, Y, Z coordinate of the alignment point of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("alignPoint", typeof(System.Object))]
	public class Set_TextAlignmentPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAlignmentPoint = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specify the X, Y, Z coordinate of the insertion point of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsertionPoint);

		}
	}


	///<summary>
	///Specify the X, Y, Z coordinate of the insertion point of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("insPoint", typeof(System.Object))]
	public class Set_InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertionPoint = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the three-dimensional normal unit vector for the entity
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	///<summary>
	///Specifies the three-dimensional normal unit vector for the entity
	///</summary>
	[NodeInput("AcadText", typeof(object))]
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
	///Specifies the attribute text generation flag
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class TextGenerationFlag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextGenerationFlag);

		}
	}


	///<summary>
	///Specifies the attribute text generation flag
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("textGenFlag", typeof(System.Object))]
	public class Set_TextGenerationFlag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextGenerationFlag = inputs[1];
			return null;
		}
	}


	///<summary>
	///z-direction value) of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	///<summary>
	///z-direction value) of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]
	public class Set_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Thickness = inputs[1];
			return null;
		}
	}


	///<summary>
	///Determines whether the text is upside down or not
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class UpsideDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UpsideDown);

		}
	}


	///<summary>
	///Determines whether the text is upside down or not
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("UpsideDown", typeof(System.Object))]
	public class Set_UpsideDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UpsideDown = inputs[1];
			return null;
		}
	}


	///<summary>
	///Determines whether the text is backward or not
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class Backward : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Backward);

		}
	}


	///<summary>
	///Determines whether the text is backward or not
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	[NodeInput("Backward", typeof(System.Object))]
	public class Set_Backward : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Backward = inputs[1];
			return null;
		}
	}


	///<summary>
	///Returns the text string with field codes of the text
	///</summary>
	[NodeInput("AcadText", typeof(object))]
	public class FieldCode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FieldCode);

		}
	}
}
