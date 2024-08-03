using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///The common interface for TeighaX dimensions
///</summary>
namespace OdaX.AcadDimension 
{

	[NVP_Manifest(
		Id = "CCF3E2A8-2202-4CE3-8A79-02B261214BE1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.AcadDimension_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "_AcadDimension_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimension_Constructor : INode 
	{
		public OdaX.IAcadDimension _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDimension;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "911A2BBD-C27A-40F6-BCB1-F192F9CAEF09", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.AcadDimension_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "_AcadDimension_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDimension_ConstructorCast : INode 
	{
		public OdaX.IAcadDimension _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDimension;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "DFE8ACBF-CB39-4367-A641-03C1F01A093B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
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
		Id = "924FC5FE-D870-4FF9-AEB8-ACE1BE0A9B50", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
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
		Id = "94D50C77-9406-4542-A307-7C1CBA78F0AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of a dimension.
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
		Id = "573C1237-C609-4D56-BD7B-8D616537B1AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation angle of a dimension.
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
		Id = "23A09426-BFA4-4BB2-900E-6D61CFBF54F0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z coordinates for the text position of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates for the text position of a dimension.
	///</summary>
	public class TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextPosition);

		}
	}


	[NVP_Manifest(
		Id = "DB9F4890-223B-4920-8294-4580906BF3CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z coordinates for the text position of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("textPos", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates for the text position of a dimension.
	///</summary>
	public class Set_TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2F2F0D57-34D1-42D8-B460-7EEBE61DD57D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.TextRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "TextRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of dimension text.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of dimension text.
	///</summary>
	public class TextRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextRotation);

		}
	}


	[NVP_Manifest(
		Id = "1CB11E4F-8EA2-4EF5-BB7C-A2A1F98AF71D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_TextRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_TextRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of dimension text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation angle of dimension text.
	///</summary>
	public class Set_TextRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextRotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A94E51D0-173E-4EF9-9BF4-2BF49A480B7C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.TextOverride", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "TextOverride", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a dimension text string that displays in addition to or instead of the dimension measurement.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns a dimension text string that displays in addition to or instead of the dimension measurement.
	///</summary>
	public class TextOverride : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextOverride);

		}
	}


	[NVP_Manifest(
		Id = "47C98AA7-FB0A-46C6-A576-C4A6D96F937B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_TextOverride", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_TextOverride", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns a dimension text string that displays in addition to or instead of the dimension measurement.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies or returns a dimension text string that displays in addition to or instead of the dimension measurement.
	///</summary>
	public class Set_TextOverride : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextOverride = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "682D10ED-98C6-4805-9AA3-ABDF0693D181", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the dimension style assigned to a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the name of the dimension style assigned to a dimension.
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
		Id = "9EF4B468-BB2A-4079-A5F7-2D35553782D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the dimension style assigned to a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of the dimension style assigned to a dimension.
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
		Id = "925CC682-729E-4999-934B-6C6820499C8E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.TextColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "TextColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text color of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the text color of a dimension.
	///</summary>
	public class TextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextColor);

		}
	}


	[NVP_Manifest(
		Id = "AD8345C9-E5FB-49FD-A5AD-3C7AEBFB3CDE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_TextColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_TextColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text color of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies or returns the text color of a dimension.
	///</summary>
	public class Set_TextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "787E379A-8726-42FA-A986-B2DC29DE69D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.DecimalSeparator", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "DecimalSeparator", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the decimal separator of a dimension formatted for decimals.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the decimal separator of a dimension formatted for decimals.
	///</summary>
	public class DecimalSeparator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DecimalSeparator);

		}
	}


	[NVP_Manifest(
		Id = "CB435944-983D-44D1-8F33-409297A3DC36", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_DecimalSeparator", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_DecimalSeparator", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the decimal separator of a dimension formatted for decimals.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("character", typeof(System.String))]

	///<summary>
	///Specifies or returns the decimal separator of a dimension formatted for decimals.
	///</summary>
	public class Set_DecimalSeparator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DecimalSeparator = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A7154D45-3757-4E74-8F84-47F188D683AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.TextGap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "TextGap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the amount of blank space surrounding dimension text when the text causes a dimension line to break.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the amount of blank space surrounding dimension text when the text causes a dimension line to break.
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
		Id = "A7DD11A7-85D2-42DE-ADDD-27FF43F394C3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_TextGap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_TextGap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the amount of blank space surrounding dimension text when the text causes a dimension line to break.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("Offset", typeof(System.Double))]

	///<summary>
	///Specifies or returns the amount of blank space surrounding dimension text when the text causes a dimension line to break.
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
		Id = "EA1ACBFC-7914-4AD4-A779-B74DC8EB7155", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.TextPrefix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "TextPrefix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the prefix for text of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the prefix for text of a dimension.
	///</summary>
	public class TextPrefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextPrefix);

		}
	}


	[NVP_Manifest(
		Id = "64F92461-B289-4A6A-B57C-802958889559", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_TextPrefix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_TextPrefix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the prefix for text of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("prefix", typeof(System.String))]

	///<summary>
	///Specifies or returns the prefix for text of a dimension.
	///</summary>
	public class Set_TextPrefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextPrefix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B52E7BF9-07C6-4CD6-BE86-50ABCEF99CCC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.TextSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "TextSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the suffix for text of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the suffix for text of a dimension.
	///</summary>
	public class TextSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextSuffix);

		}
	}


	[NVP_Manifest(
		Id = "37C01D26-310F-47F1-9354-0D453C5CB3DA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_TextSuffix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_TextSuffix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the suffix for text of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("suffix", typeof(System.String))]

	///<summary>
	///Specifies or returns the suffix for text of a dimension.
	///</summary>
	public class Set_TextSuffix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextSuffix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2C736B46-FB5D-464C-9246-F6D53519328D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor of a dimension.
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
		Id = "418EEBE9-73C7-4638-861F-D6BAC15F116A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("factor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale factor of a dimension.
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
		Id = "C9AD9AC9-15E9-4414-AAF8-98846AA52FD5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.VerticalTextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "VerticalTextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertical position of text for a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the vertical position of text for a dimension.
	///</summary>
	public class VerticalTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VerticalTextPosition);

		}
	}


	[NVP_Manifest(
		Id = "212D98CC-8882-454F-B847-CB589156435D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_VerticalTextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_VerticalTextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertical position of text for a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("OdaX.AcDimVerticalJustification", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertical position of text for a dimension.
	///</summary>
	public class Set_VerticalTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VerticalTextPosition = ((OdaX.AcDimVerticalJustification)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "812C6E22-12D4-463C-A180-1EADD0C1D940", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.TolerancePrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "TolerancePrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for tolerance values of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the number of decimal places for tolerance values of dimensions.
	///</summary>
	public class TolerancePrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TolerancePrecision);

		}
	}


	[NVP_Manifest(
		Id = "EAC77057-8F9E-4730-A410-2A0AEABCADF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_TolerancePrecision", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_TolerancePrecision", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of decimal places for tolerance values of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("OdaX.AcDimPrecision", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of decimal places for tolerance values of dimensions.
	///</summary>
	public class Set_TolerancePrecision : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TolerancePrecision = ((OdaX.AcDimPrecision)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "96664CB0-EEE2-4856-8D2D-90A7527DAD54", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.ToleranceHeightScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "ToleranceHeightScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor of tolerance text height in relation to dimension text height.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor of tolerance text height in relation to dimension text height.
	///</summary>
	public class ToleranceHeightScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceHeightScale);

		}
	}


	[NVP_Manifest(
		Id = "C9316F47-CD45-49E5-A739-ADEF672AB52D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_ToleranceHeightScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_ToleranceHeightScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor of tolerance text height in relation to dimension text height.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("scale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale factor of tolerance text height in relation to dimension text height.
	///</summary>
	public class Set_ToleranceHeightScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceHeightScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "96F8B731-60BB-4F96-B8A2-E89A1EA71268", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.ToleranceLowerLimit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "ToleranceLowerLimit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lower tolerance limit for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the lower tolerance limit for dimensions.
	///</summary>
	public class ToleranceLowerLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceLowerLimit);

		}
	}


	[NVP_Manifest(
		Id = "B77018BC-C027-44CE-8596-BBC6CF45DD06", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_ToleranceLowerLimit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_ToleranceLowerLimit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lower tolerance limit for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("lower", typeof(System.Double))]

	///<summary>
	///Specifies or returns the lower tolerance limit for dimensions.
	///</summary>
	public class Set_ToleranceLowerLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceLowerLimit = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B09B18E1-8044-4F5E-A4D7-7712DD59CB69", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.TextMovement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "TextMovement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how dimension lines move when the corresponding dimension text moves.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns how dimension lines move when the corresponding dimension text moves.
	///</summary>
	public class TextMovement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextMovement);

		}
	}


	[NVP_Manifest(
		Id = "CB9777F0-C9DC-4037-BC05-D0DEA6D183E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_TextMovement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_TextMovement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how dimension lines move when the corresponding dimension text moves.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("OdaX.AcDimTextMovement", typeof(System.Object))]

	///<summary>
	///Specifies or returns how dimension lines move when the corresponding dimension text moves.
	///</summary>
	public class Set_TextMovement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextMovement = ((OdaX.AcDimTextMovement)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C692E82D-6A5F-4763-92C8-28DC97FB59C3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.ToleranceDisplay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "ToleranceDisplay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension tolerance values display with dimension text.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns whether dimension tolerance values display with dimension text.
	///</summary>
	public class ToleranceDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceDisplay);

		}
	}


	[NVP_Manifest(
		Id = "AEB94799-01F3-4178-9EF9-A578607BB886", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_ToleranceDisplay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_ToleranceDisplay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dimension tolerance values display with dimension text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("OdaX.AcDimToleranceMethod", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether dimension tolerance values display with dimension text.
	///</summary>
	public class Set_ToleranceDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceDisplay = ((OdaX.AcDimToleranceMethod)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6B11A21B-4367-4800-AEFA-3CD384C6645C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.ToleranceJustification", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "ToleranceJustification", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertical placement of tolerance values for dimension text.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the vertical placement of tolerance values for dimension text.
	///</summary>
	public class ToleranceJustification : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceJustification);

		}
	}


	[NVP_Manifest(
		Id = "807BFF61-F0ED-46A1-8613-BA4C19E8948F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_ToleranceJustification", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_ToleranceJustification", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertical placement of tolerance values for dimension text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("OdaX.AcDimToleranceJustify", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertical placement of tolerance values for dimension text.
	///</summary>
	public class Set_ToleranceJustification : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceJustification = ((OdaX.AcDimToleranceJustify)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D903F26B-9A77-4A51-96E8-DE4899A0BD43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.ToleranceUpperLimit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "ToleranceUpperLimit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the upper tolerance limit for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the upper tolerance limit for dimensions.
	///</summary>
	public class ToleranceUpperLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceUpperLimit);

		}
	}


	[NVP_Manifest(
		Id = "01913BDA-A05A-4C4E-9297-9093DD116D5E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_ToleranceUpperLimit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_ToleranceUpperLimit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the upper tolerance limit for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("upper", typeof(System.Double))]

	///<summary>
	///Specifies or returns the upper tolerance limit for dimensions.
	///</summary>
	public class Set_ToleranceUpperLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceUpperLimit = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E1F968D6-6E34-43FA-B38B-957B564656B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.TextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "TextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text style of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the text style of a dimension.
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
		Id = "3BF31805-3C66-43A9-9123-8E99F47A71D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_TextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_TextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text style of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("style", typeof(System.String))]

	///<summary>
	///Specifies or returns the text style of a dimension.
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
		Id = "A1B03EB9-7F98-4841-8D5E-63354605C4B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text height of a dimension.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns the text height of a dimension.
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
		Id = "EB1B7E6B-4DC0-4063-AF90-8BF04C43E26E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text height of a dimension.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the text height of a dimension.
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
		Id = "884C6F9C-7A4B-4084-ABFE-064167CEBFDD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.SuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "SuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns whether leading zeros display for dimensions.
	///</summary>
	public class SuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressLeadingZeros);

		}
	}


	[NVP_Manifest(
		Id = "4AD113D1-9993-4F60-A565-20498321BDF4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_SuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_SuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether leading zeros display for dimensions.
	///</summary>
	public class Set_SuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SuppressLeadingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EE0162FB-F7D5-4423-9998-C6B1BA5116C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.SuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "SuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether trailing zeros display for dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns whether trailing zeros display for dimensions.
	///</summary>
	public class SuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressTrailingZeros);

		}
	}


	[NVP_Manifest(
		Id = "EFF187B8-7340-4538-A73D-2C680A97FD49", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_SuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_SuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether trailing zeros display for dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether trailing zeros display for dimensions.
	///</summary>
	public class Set_SuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SuppressTrailingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BEC29997-6936-4D5C-A12D-B219E36DE4F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.ToleranceSuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "ToleranceSuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for tolerance values of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns whether leading zeros display for tolerance values of dimensions.
	///</summary>
	public class ToleranceSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceSuppressLeadingZeros);

		}
	}


	[NVP_Manifest(
		Id = "D6095D49-78BA-4550-8912-ABB595A110E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_ToleranceSuppressLeadingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_ToleranceSuppressLeadingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether leading zeros display for tolerance values of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether leading zeros display for tolerance values of dimensions.
	///</summary>
	public class Set_ToleranceSuppressLeadingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceSuppressLeadingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8306AC0C-EA82-4AD5-9ABF-85BDAE0FE961", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.ToleranceSuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "ToleranceSuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether trailing zeros display for tolerance values of dimensions.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Specifies or returns whether trailing zeros display for tolerance values of dimensions.
	///</summary>
	public class ToleranceSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToleranceSuppressTrailingZeros);

		}
	}


	[NVP_Manifest(
		Id = "4C7298A4-BBB7-4BF2-B409-40EBFF148D11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_ToleranceSuppressTrailingZeros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_ToleranceSuppressTrailingZeros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether trailing zeros display for tolerance values of dimensions.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether trailing zeros display for tolerance values of dimensions.
	///</summary>
	public class Set_ToleranceSuppressTrailingZeros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToleranceSuppressTrailingZeros = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "46B28FB0-66F1-4150-BA5C-DB3D7867DCAB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.TextFill", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "TextFill", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the background fill of dimension text.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the background fill of dimension text.
	///</summary>
	public class TextFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextFill);

		}
	}


	[NVP_Manifest(
		Id = "8AF1B009-1050-48BF-B868-D98F38B20F0D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_TextFill", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_TextFill", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the background fill of dimension text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("bVal", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns the background fill of dimension text.
	///</summary>
	public class Set_TextFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextFill = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3BBEC497-A9A7-4691-B936-C5D5B9863A95", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.TextFillColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "TextFillColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the fill color for dimension text.", 
		ViewType = "Data")]
	[NodeInput("AcadDimension", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns the fill color for dimension text.
	///</summary>
	public class TextFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextFillColor);

		}
	}


	[NVP_Manifest(
		Id = "163D99C1-AB43-4D98-B884-AC0046D9A217", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadDimension.Set_TextFillColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadDimension", 
		NodeName = "Set_TextFillColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns the fill color for dimension text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDimension", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns the fill color for dimension text.
	///</summary>
	public class Set_TextFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextFillColor = inputs[1].Value;
			return null;
		}
	}
}
