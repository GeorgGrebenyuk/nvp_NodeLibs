using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a named, saved collection of settings that determines the appearance of text characters
///</summary>
namespace OdaX.AcadTextStyle 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Specifies the name of the big font file associated with the text or attribute", 
		ViewType = "Data")]
	[NodeInput("AcadTextStyle", typeof(object))]

	///<summary>
	///Specifies the name of the big font file associated with the text or attribute
	///</summary>
	public class BigFontFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BigFontFile);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the name of the big font file associated with the text or attribute", 
		ViewType = "Modifier")]
	[NodeInput("AcadTextStyle", typeof(object))]
	[NodeInput("fontFile", typeof(System.String))]

	///<summary>
	///Specifies the name of the big font file associated with the text or attribute
	///</summary>
	public class Set_BigFontFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BigFontFile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the primary font file path and name", 
		ViewType = "Data")]
	[NodeInput("AcadTextStyle", typeof(object))]

	///<summary>
	///Specifies the primary font file path and name
	///</summary>
	public class fontFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.fontFile);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the primary font file path and name", 
		ViewType = "Modifier")]
	[NodeInput("AcadTextStyle", typeof(object))]
	[NodeInput("fontFile", typeof(System.String))]

	///<summary>
	///Specifies the primary font file path and name
	///</summary>
	public class Set_fontFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.fontFile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Data")]
	[NodeInput("AcadTextStyle", typeof(object))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
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
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Modifier")]
	[NodeInput("AcadTextStyle", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
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
		Text = "Specifies the last text height used", 
		ViewType = "Data")]
	[NodeInput("AcadTextStyle", typeof(object))]

	///<summary>
	///Specifies the last text height used
	///</summary>
	public class LastHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LastHeight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the last text height used", 
		ViewType = "Modifier")]
	[NodeInput("AcadTextStyle", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies the last text height used
	///</summary>
	public class Set_LastHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LastHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("AcadTextStyle", typeof(object))]

	///<summary>
	///Specifies the name of the object
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the oblique angle of the object", 
		ViewType = "Data")]
	[NodeInput("AcadTextStyle", typeof(object))]

	///<summary>
	///Specifies the oblique angle of the object
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
		Text = "Specifies the oblique angle of the object", 
		ViewType = "Modifier")]
	[NodeInput("AcadTextStyle", typeof(object))]
	[NodeInput("obliAngle", typeof(System.Object))]

	///<summary>
	///Specifies the oblique angle of the object
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
		Text = "Specifies the attribute text generation flag", 
		ViewType = "Data")]
	[NodeInput("AcadTextStyle", typeof(object))]

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
	[NodeInput("AcadTextStyle", typeof(object))]
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
		Text = "Specifies or returns the spacing of characters.", 
		ViewType = "Data")]
	[NodeInput("AcadTextStyle", typeof(object))]

	///<summary>
	///Specifies or returns the spacing of characters.
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the spacing of characters.", 
		ViewType = "Modifier")]
	[NodeInput("AcadTextStyle", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies or returns the spacing of characters.
	///</summary>
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the definition data of the font for the TextStyle", 
		ViewType = "Modifier")]
	[NodeInput("AcadTextStyle", typeof(object))]
	[NodeInput("TypeFace", typeof(System.String))]
	[NodeInput("Bold", typeof(System.Object))]
	[NodeInput("Italic", typeof(System.Object))]
	[NodeInput("Charset", typeof(System.Object))]
	[NodeInput("PitchAndFamily", typeof(System.Object))]

	///<summary>
	///Gets the definition data of the font for the TextStyle
	///</summary>
	public class GetFont : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetFont(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Sets the definition data of the font for the TextStyle", 
		ViewType = "Modifier")]
	[NodeInput("AcadTextStyle", typeof(object))]
	[NodeInput("TypeFace", typeof(System.String))]
	[NodeInput("Bold", typeof(System.Object))]
	[NodeInput("Italic", typeof(System.Object))]
	[NodeInput("Charset", typeof(System.Object))]
	[NodeInput("PitchAndFamily", typeof(System.Object))]

	///<summary>
	///Sets the definition data of the font for the TextStyle
	///</summary>
	public class SetFont : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetFont(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value);
			return null;
		}
	}
}
