using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an object appearing as a text string that describes the characteristics of an attribute reference
///</summary>
namespace OdaX.AcadAttribute 
{

	[NVP_Manifest(
		Id = "63ED8559-86A8-4E90-B811-761E80F5C3AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.AcadAttribute_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "_AcadAttribute_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadAttribute_Constructor : INode 
	{
		public OdaX.IAcadAttribute _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadAttribute;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "11338F4F-4837-4B1D-83C7-5E097984A2F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.AcadAttribute_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "_AcadAttribute_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadAttribute_ConstructorCast : INode 
	{
		public OdaX.IAcadAttribute _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadAttribute;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "FB24FEE4-710D-4A42-BFE3-266E81E1B5F5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.FieldLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "FieldLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the field length of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the field length of an attribute.
	///</summary>
	public class FieldLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FieldLength);

		}
	}


	[NVP_Manifest(
		Id = "373FDDE8-4740-4CCF-8241-BF986729341E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_FieldLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_FieldLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the field length of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("fieldLen", typeof(System.Object))]

	///<summary>
	///Specifies or returns the field length of an attribute.
	///</summary>
	public class Set_FieldLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FieldLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4171A424-21AA-4B3C-9254-17C3FC81DFDA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.TagString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "TagString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the tag of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the tag of an attribute.
	///</summary>
	public class TagString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TagString);

		}
	}


	[NVP_Manifest(
		Id = "BBC7D3D0-13C3-4CB5-BA0B-54254850ECF4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_TagString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_TagString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the tag of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("Tag", typeof(System.String))]

	///<summary>
	///Specifies or returns the tag of an attribute.
	///</summary>
	public class Set_TagString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TagString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5375E00D-AD55-40EE-825E-D934D3801B63", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.PromptString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "PromptString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the prompt string of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the prompt string of an attribute.
	///</summary>
	public class PromptString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PromptString);

		}
	}


	[NVP_Manifest(
		Id = "38C72108-A9BF-4DF3-9BD4-C34258720897", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_PromptString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_PromptString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the prompt string of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bstrPrompt", typeof(System.String))]

	///<summary>
	///Specifies or returns the prompt string of an attribute.
	///</summary>
	public class Set_PromptString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PromptString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B550030E-DFDA-4502-9FA1-5935570ED15A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.TextString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "TextString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text that displays for an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the text that displays for an attribute.
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
		Id = "1A257FC2-E16C-40B1-B8EA-E22E2929573F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_TextString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_TextString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text that displays for an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies or returns the text that displays for an attribute.
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
		Id = "15651802-8953-4401-8534-9076F9A87E97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text style of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the text style of an attribute.
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
		Id = "A1B738AD-3082-46A4-AAEC-87EA46E87D68", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text style of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the text style of an attribute.
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
		Id = "2AA80AB3-7F85-4ACF-B21C-F2E561697702", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Alignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Alignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the horizontal and vertical alignment of the attribute text.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the horizontal and vertical alignment of the attribute text.
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
		Id = "D630E82E-ADA3-43EA-A30D-A5BC4E6E2052", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_Alignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_Alignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the horizontal and vertical alignment of the attribute text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("OdaX.AcAlignment", typeof(System.Object))]

	///<summary>
	///Specifies or returns the horizontal and vertical alignment of the attribute text.
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
		Id = "1D9780ED-F18C-4B5A-891E-7C6EF202499D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.HorizontalAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "HorizontalAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the horizontal alignment of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the horizontal alignment of an attribute.
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
		Id = "4F737B62-DDFF-4C50-9C5B-64D97022C89B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_HorizontalAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_HorizontalAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the horizontal alignment of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("OdaX.AcHorizontalAlignment", typeof(System.Object))]

	///<summary>
	///Specifies or returns the horizontal alignment of an attribute.
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
		Id = "311EB1B5-972E-49F7-9D9C-AF36033F3F44", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.VerticalAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "VerticalAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertical alignment of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the vertical alignment of an attribute.
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
		Id = "08373692-9865-4BC6-ACF6-40505D178C8C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_VerticalAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_VerticalAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertical alignment of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("OdaX.AcVerticalAlignment", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertical alignment of an attribute.
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
		Id = "B7521EB2-8FAE-4677-9C6E-72ABD2CFC622", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the height of an attribute.
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
		Id = "6FC6458E-185A-4134-993E-9655715EC047", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of an attribute.
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
		Id = "38DC02DB-82FF-443A-BDB1-3A84842BD1A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of an attribute.
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
		Id = "4E883B1F-CBE8-45A2-ABF2-A238E9F1F025", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation angle of an attribute.
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
		Id = "6E966F1D-3B4D-40F6-B8C2-22E859F3C4E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor of an attribute.
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
		Id = "CFE10DDB-5D31-431F-91DE-C2746BF286F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("scalFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale factor of an attribute.
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
		Id = "D327CD10-47FB-43E9-8CE8-DD3B75495B73", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.ObliqueAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "ObliqueAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the oblique angle of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the oblique angle of an attribute.
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
		Id = "5D516F26-E08E-4F45-8544-AD91B19BDBDE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_ObliqueAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_ObliqueAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the oblique angle of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("obliAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the oblique angle of an attribute.
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
		Id = "F006325D-C650-4C1E-93B4-82C99FA5030F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.TextAlignmentPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "TextAlignmentPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z alignment point of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z alignment point of an attribute.
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
		Id = "EA103B74-4123-4EDF-98D7-0B446E395DF6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_TextAlignmentPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_TextAlignmentPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z alignment point of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("alignPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z alignment point of an attribute.
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
		Id = "2BBD9AD9-0693-4EBD-A6F0-EB052A739CB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.InsertionPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "InsertionPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the attribute text insertion point.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the attribute text insertion point.
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
		Id = "3F8CBD1B-E6E1-4DF4-A921-D4CBB95C3F24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_InsertionPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_InsertionPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the attribute text insertion point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("insPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the attribute text insertion point.
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
		Id = "CFC0C9E1-F7BB-496B-BED1-AB9D9C47944B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

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
		Id = "32D92DE9-AE7A-4810-B0C2-DE1099457691", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
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
		Id = "898693F1-D582-46CC-BFF9-22064BEADFFC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.TextGenerationFlag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "TextGenerationFlag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text generation flag of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the text generation flag of an attribute.
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
		Id = "3D71E54C-01E2-4297-8955-EF22F6666EF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_TextGenerationFlag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_TextGenerationFlag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text generation flag of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("textGenFlag", typeof(System.Object))]

	///<summary>
	///Specifies or returns the text generation flag of an attribute.
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
		Id = "E8983E8E-8C1B-4E0E-8CC4-5C73321DD402", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z-direction value) of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///z-direction value) of an attribute.
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
		Id = "BAE99B2F-D5DA-405F-BDA6-AEC3B7AB215C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z-direction value) of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of an attribute.
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
		Id = "E27E906B-BA44-441D-8553-D070B840FB33", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Mode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Mode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the mode of an attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the mode of an attribute.
	///</summary>
	public class Mode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Mode);

		}
	}


	[NVP_Manifest(
		Id = "6D1C2599-B057-45E2-A17F-D16B8422A400", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_Mode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_Mode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the mode of an attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("Mode", typeof(System.Object))]

	///<summary>
	///Specifies or returns the mode of an attribute.
	///</summary>
	public class Set_Mode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Mode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4A5D6250-0A41-41EF-BFF6-80D9E719B4C0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.UpsideDown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "UpsideDown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the text of an attribute is upside down.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns whether the text of an attribute is upside down.
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
		Id = "E1481461-29FD-44D3-A818-D6FA00CD84D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_UpsideDown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_UpsideDown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the text of an attribute is upside down.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bUpsideDown", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the text of an attribute is upside down.
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
		Id = "E4A11AEE-6499-47CA-97DD-26F40FA0DB8D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Backward", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Backward", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the attribute text is backward.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns whether the attribute text is backward.
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
		Id = "27ED2FBA-A8A1-40C3-A5B4-3DDAECCE58F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_Backward", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_Backward", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the attribute text is backward.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bBackward", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the attribute text is backward.
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
		Id = "13C8B93D-D33F-443A-BE04-1022511F36D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Invisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Invisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the invisible mode of the attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the invisible mode of the attribute.
	///</summary>
	public class Invisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Invisible);

		}
	}


	[NVP_Manifest(
		Id = "8706BD68-A302-46E7-A4C5-0C2BF8FF5837", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_Invisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_Invisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the invisible mode of the attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bInvisible", typeof(System.Object))]

	///<summary>
	///Specifies or returns the invisible mode of the attribute.
	///</summary>
	public class Set_Invisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Invisible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C17A117D-6EF9-4C3E-93D8-390A831C5BFF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Constant", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Constant", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the constant mode of the attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the constant mode of the attribute.
	///</summary>
	public class Constant : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Constant);

		}
	}


	[NVP_Manifest(
		Id = "5DD48870-78BB-4EB6-BA05-BB2576DE8D33", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_Constant", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_Constant", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the constant mode of the attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bConstant", typeof(System.Object))]

	///<summary>
	///Specifies or returns the constant mode of the attribute.
	///</summary>
	public class Set_Constant : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Constant = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "416EAFFA-389C-49B4-8189-709951E47AD9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Verify", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Verify", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the verify mode of the attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the verify mode of the attribute.
	///</summary>
	public class Verify : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Verify);

		}
	}


	[NVP_Manifest(
		Id = "A0437512-D05B-4A23-A67E-D257526D3848", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_Verify", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_Verify", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the verify mode of the attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bVerify", typeof(System.Object))]

	///<summary>
	///Specifies or returns the verify mode of the attribute.
	///</summary>
	public class Set_Verify : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Verify = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DA911F47-0E8A-4499-82C1-B5CA6788D63E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Preset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Preset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the preset mode of the attribute.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Specifies or returns the preset mode of the attribute.
	///</summary>
	public class Preset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Preset);

		}
	}


	[NVP_Manifest(
		Id = "CCC549AF-0D3C-4424-9894-4A878E9CA1DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_Preset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_Preset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the preset mode of the attribute.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bPreset", typeof(System.Object))]

	///<summary>
	///Specifies or returns the preset mode of the attribute.
	///</summary>
	public class Set_Preset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Preset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FF65A16B-8295-43E0-B4D5-0B00C701B1CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.LockPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "LockPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns whether an attribute is moved relative to its associated block.", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Not implemented. Specifies or returns whether an attribute is moved relative to its associated block.
	///</summary>
	public class LockPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LockPosition);

		}
	}


	[NVP_Manifest(
		Id = "BE77483A-A003-49B5-A466-CC7881896AB1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_LockPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_LockPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Specifies or returns whether an attribute is moved relative to its associated block.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bLockPosition", typeof(System.Object))]

	///<summary>
	///Not implemented. Specifies or returns whether an attribute is moved relative to its associated block.
	///</summary>
	public class Set_LockPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LockPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E5280A49-791F-41C4-8109-7E672ED65021", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.MTextAttribute", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "MTextAttribute", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines whether if the attribute is multiline", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Determines whether if the attribute is multiline
	///</summary>
	public class MTextAttribute : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MTextAttribute);

		}
	}


	[NVP_Manifest(
		Id = "11090A11-32D0-4E01-B933-A5BB3102CC0B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_MTextAttribute", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_MTextAttribute", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines whether if the attribute is multiline", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("bMTextAttribute", typeof(System.Object))]

	///<summary>
	///Determines whether if the attribute is multiline
	///</summary>
	public class Set_MTextAttribute : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MTextAttribute = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E49DE058-91A2-483C-A8CC-3A46A9A1D1DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.MTextAttributeContent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "MTextAttributeContent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the multiline attribute content", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Gets the multiline attribute content
	///</summary>
	public class MTextAttributeContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MTextAttributeContent);

		}
	}


	[NVP_Manifest(
		Id = "EAE4C60E-4745-4678-8CD4-4089DD9DB676", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_MTextAttributeContent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_MTextAttributeContent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the multiline attribute content", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("content", typeof(System.String))]

	///<summary>
	///Gets the multiline attribute content
	///</summary>
	public class Set_MTextAttributeContent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MTextAttributeContent = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C7975780-3400-4858-AD94-87625E7440EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.UpdateMTextAttribute", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "UpdateMTextAttribute", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Updates multiline MText", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Updates multiline MText
	///</summary>
	public class UpdateMTextAttribute : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UpdateMTextAttribute();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "752368AE-E754-4CF8-BFFB-0FD9359A52D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.MTextBoundaryWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "MTextBoundaryWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the width of text boundary of the Mtext", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Gets the width of text boundary of the Mtext
	///</summary>
	public class MTextBoundaryWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MTextBoundaryWidth);

		}
	}


	[NVP_Manifest(
		Id = "CAA98F11-8AA6-4BEE-A878-254D0A7BEAEA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_MTextBoundaryWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_MTextBoundaryWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the width of text boundary of the Mtext", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Gets the width of text boundary of the Mtext
	///</summary>
	public class Set_MTextBoundaryWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MTextBoundaryWidth[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4FE9470D-A720-49E3-9777-8CDEC7432653", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.MTextDrawingDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "MTextDrawingDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the drawing direction of the Mtext", 
		ViewType = "Data")]
	[NodeInput("AcadAttribute", typeof(object))]

	///<summary>
	///Gets the drawing direction of the Mtext
	///</summary>
	public class MTextDrawingDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MTextDrawingDirection);

		}
	}


	[NVP_Manifest(
		Id = "CB2E073C-1F9A-4336-84F4-141284E6259F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttribute.Set_MTextDrawingDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttribute", 
		NodeName = "Set_MTextDrawingDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the drawing direction of the Mtext", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttribute", typeof(object))]
	[NodeInput("OdaX.AcDrawingDirection", typeof(System.Object))]

	///<summary>
	///Gets the drawing direction of the Mtext
	///</summary>
	public class Set_MTextDrawingDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MTextDrawingDirection = ((OdaX.AcDrawingDirection)inputs[1].Value);
			return null;
		}
	}
}
