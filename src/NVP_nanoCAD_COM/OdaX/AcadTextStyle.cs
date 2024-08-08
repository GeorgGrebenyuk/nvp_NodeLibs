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
		Id = "77AB60E5-6700-493E-895D-36BB2CEC52AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.AcadTextStyle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "_AcadTextStyle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "432741F7-C48B-4D29-A9E9-3237F28EC1F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.AcadTextStyle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "_AcadTextStyle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "83D63F4F-F6BF-4DBE-B7C2-86E7B58A35DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.BigFontFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "BigFontFile", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "138F40E8-3025-4FF2-AFCB-2CFC110F3C5E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.Set_BigFontFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "Set_BigFontFile", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "485A35CD-AAA2-4629-A864-3517F5D73DBF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.fontFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "fontFile", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "DE870B91-4739-4234-8B44-8ADFAA3DFFED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.Set_fontFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "Set_fontFile", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "86A26FC7-BEAA-4637-B96E-508C5026BB14", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "7DDA150D-BE6B-4AA4-B873-3A1FF0EFEF59", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "17D98E8E-89ED-4A39-B8F3-3D75E087B9FD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.LastHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "LastHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "50E08CF6-E0B5-45B9-BD84-E153F8BBF03C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.Set_LastHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "Set_LastHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "54B45B3B-2881-4800-B74D-6582D83BA960", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "B684541D-70E8-47E0-9517-F66CFF150DEC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.ObliqueAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "ObliqueAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "94776D21-6390-4558-BC4E-4397BA620033", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.Set_ObliqueAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "Set_ObliqueAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "C2D2AEDA-86BA-4CDC-A6B1-320EAEBFEC16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.TextGenerationFlag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "TextGenerationFlag", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "FA05E205-D4D3-4F60-8A46-FB3285A886C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.Set_TextGenerationFlag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "Set_TextGenerationFlag", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "B2937CD8-D509-4213-A4FC-54B02221A797", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "5AEBF048-3956-4065-81FA-F6349A2EB01A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "5CC43E71-2CB4-45DA-A269-EE0161D61CA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.GetFont", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "GetFont", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "0C9B6FC3-2B53-4AD3-B0F0-8BE97D48DDF1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTextStyle.SetFont", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTextStyle", 
		NodeName = "SetFont", 
		NodeType = "Loaded", 
		CADType = "None", 
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
