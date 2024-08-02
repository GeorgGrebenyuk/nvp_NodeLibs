using NVP.API.Nodes;

namespace OdaX.AcadTextStyle 
{
	[NodeInput("dynamic", typeof(object))]
	public class AcadTextStyle_Constructor : INode 
	{
		public OdaX.IAcadTextStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadTextStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class AcadTextStyle_ConstructorCast : INode 
	{
		public OdaX.IAcadTextStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadTextStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Specifies the name of the big font file associated with the text or attribute
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
	public class BigFontFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BigFontFile);

		}
	}


	///<summary>
	///Specifies the name of the big font file associated with the text or attribute
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
	[NodeInput("fontFile", typeof(System.String))]
	public class Set_BigFontFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BigFontFile = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the primary font file path and name
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
	public class fontFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.fontFile);

		}
	}


	///<summary>
	///Specifies the primary font file path and name
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
	[NodeInput("fontFile", typeof(System.String))]
	public class Set_fontFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.fontFile = inputs[1];
			return null;
		}
	}


	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
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
	///Specifies the last text height used
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
	public class LastHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LastHeight);

		}
	}


	///<summary>
	///Specifies the last text height used
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]
	public class Set_LastHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LastHeight = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the name of the object
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	///<summary>
	///Specifies the oblique angle of the object
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
	public class ObliqueAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObliqueAngle);

		}
	}


	///<summary>
	///Specifies the oblique angle of the object
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
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
	///Specifies the attribute text generation flag
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
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
	[NodeInput("AcadTextStyle", typeof(object))]
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
	///Specifies or returns the spacing of characters.
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	///<summary>
	///Specifies or returns the spacing of characters.
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1];
			return null;
		}
	}


	///<summary>
	///Gets the definition data of the font for the TextStyle
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
	[NodeInput("TypeFace", typeof(System.String))]
	[NodeInput("Bold", typeof(System.Object))]
	[NodeInput("Italic", typeof(System.Object))]
	[NodeInput("Charset", typeof(System.Object))]
	[NodeInput("PitchAndFamily", typeof(System.Object))]
	public class GetFont : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetFont(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]);
			return null;
		}
	}


	///<summary>
	///Sets the definition data of the font for the TextStyle
	///</summary>
	[NodeInput("AcadTextStyle", typeof(object))]
	[NodeInput("TypeFace", typeof(System.String))]
	[NodeInput("Bold", typeof(System.Object))]
	[NodeInput("Italic", typeof(System.Object))]
	[NodeInput("Charset", typeof(System.Object))]
	[NodeInput("PitchAndFamily", typeof(System.Object))]
	public class SetFont : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFont(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]);
			return null;
		}
	}
}
