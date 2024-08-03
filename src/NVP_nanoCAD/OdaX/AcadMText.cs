using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a paragraph of alphanumeric characters that fits within a nonprinting text boundary
///</summary>
namespace OdaX.AcadMText 
{

	[NVP_Manifest(
		Id = "C9EC0341-9CD8-499F-9297-6723052B3632", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.AcadMText_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "_AcadMText_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMText_Constructor : INode 
	{
		public OdaX.IAcadMText _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadMText;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "E658578A-ABB3-4993-ADCA-213DE88233EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.AcadMText_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "_AcadMText_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMText_ConstructorCast : INode 
	{
		public OdaX.IAcadMText _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadMText;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "F04F0341-C7B1-4E60-90AE-84F9A08679E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.TextString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "TextString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the characters of multline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the characters of multline text.
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
		Id = "B5F48A7B-8C03-4078-B107-90060EE2AEF1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Set_TextString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Set_TextString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the characters of multline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies or returns the characters of multline text.
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
		Id = "88B4C91D-05FE-4610-82E0-01E1D2374A30", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the style name of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the style name of multiline text.
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
		Id = "CBAF0467-E568-4652-9D47-F6CE848A7C42", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Set_StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Set_StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the style name of multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the style name of multiline text.
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
		Id = "9FEC5953-3B12-4470-9735-2ACF16137985", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.AttachmentPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "AttachmentPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the position of multline text in relation to the insertion point.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the position of multline text in relation to the insertion point.
	///</summary>
	public class AttachmentPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AttachmentPoint);

		}
	}


	[NVP_Manifest(
		Id = "B16A33F5-4B78-43EE-A42F-198932E110DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Set_AttachmentPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Set_AttachmentPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the position of multline text in relation to the insertion point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("OdaX.AcAttachmentPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the position of multline text in relation to the insertion point.
	///</summary>
	public class Set_AttachmentPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AttachmentPoint = ((OdaX.AcAttachmentPoint)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AC3D1B36-3578-4FA3-AA10-3224D57FF148", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.DrawingDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "DrawingDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the direction in which the characters of multiline text display.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the direction in which the characters of multiline text display.
	///</summary>
	public class DrawingDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawingDirection);

		}
	}


	[NVP_Manifest(
		Id = "E831CD88-8910-43A7-B5A3-90F1A30CDD8B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Set_DrawingDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Set_DrawingDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the direction in which the characters of multiline text display.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("OdaX.AcDrawingDirection", typeof(System.Object))]

	///<summary>
	///Specifies or returns the direction in which the characters of multiline text display.
	///</summary>
	public class Set_DrawingDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawingDirection = ((OdaX.AcDrawingDirection)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "572637E9-DF00-4DC7-8693-A7880B6B9A72", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the width of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the width of multiline text.
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
		Id = "5680A4CC-2607-4781-B5C9-BB8904338087", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the width of multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies or returns the width of multiline text.
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
		Id = "6D5FA538-71CB-4D91-8286-5FD1CDE4D41F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the height of multiline text.
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
		Id = "3BB23779-ED7C-401F-BCE5-2459219B6102", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of multiline text.
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
		Id = "F6775507-0A65-45ED-9E92-A469E2628B0F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of multiline text.
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
		Id = "848AB5BA-AC43-4A0A-B83F-C948BC6177AC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Set_Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Set_Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation angle of multiline text.
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
		Id = "98EED08D-C935-4935-9BC0-AE34BADB107E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.InsertionPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "InsertionPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the attribute text insertion point.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

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
		Id = "349DCA4E-6636-4386-9ED0-4E0A5D212616", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Set_InsertionPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Set_InsertionPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the attribute text insertion point.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
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
		Id = "03D33199-68E7-4210-B3FE-3942DCA0C878", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

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
		Id = "A57ACA13-0E5E-48FF-921F-96C8FB10C7AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Set_Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Set_Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
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
		Id = "E69BB742-6A59-40DD-AAED-B80D1741B6BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.LineSpacingFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "LineSpacingFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the line spacing factor of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the line spacing factor of multiline text.
	///</summary>
	public class LineSpacingFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineSpacingFactor);

		}
	}


	[NVP_Manifest(
		Id = "4C2BF8A8-6B5B-42FA-9A16-ACA1A1DBDF27", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Set_LineSpacingFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Set_LineSpacingFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the line spacing factor of multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("factor", typeof(System.Double))]

	///<summary>
	///Specifies or returns the line spacing factor of multiline text.
	///</summary>
	public class Set_LineSpacingFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineSpacingFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3CE5EF97-1963-4682-9EEE-7A3DD19F918A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.LineSpacingStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "LineSpacingStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the line spacing style of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the line spacing style of multiline text.
	///</summary>
	public class LineSpacingStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineSpacingStyle);

		}
	}


	[NVP_Manifest(
		Id = "6F6F6E1B-BD50-4816-A0B5-CE741137A2C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Set_LineSpacingStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Set_LineSpacingStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the line spacing style of multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("OdaX.AcLineSpacingStyle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the line spacing style of multiline text.
	///</summary>
	public class Set_LineSpacingStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineSpacingStyle = ((OdaX.AcLineSpacingStyle)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FE32F9D9-A244-4921-A211-33E85195E0D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.LineSpacingDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "LineSpacingDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the distance between lines of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns the distance between lines of multiline text.
	///</summary>
	public class LineSpacingDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineSpacingDistance);

		}
	}


	[NVP_Manifest(
		Id = "D1DE9894-5E07-4BF2-9B5E-3648262B8AF4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Set_LineSpacingDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Set_LineSpacingDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the distance between lines of multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("Value", typeof(System.Double))]

	///<summary>
	///Specifies or returns the distance between lines of multiline text.
	///</summary>
	public class Set_LineSpacingDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineSpacingDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2137E5C3-5804-4004-A747-875A2177A615", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.BackgroundFill", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "BackgroundFill", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the multiline text is filled with a background.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Specifies or returns whether the multiline text is filled with a background.
	///</summary>
	public class BackgroundFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundFill);

		}
	}


	[NVP_Manifest(
		Id = "29AB3787-A188-46B9-AA99-EA7338297C06", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.Set_BackgroundFill", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "Set_BackgroundFill", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the multiline text is filled with a background.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMText", typeof(object))]
	[NodeInput("bUseBackgroundFill", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the multiline text is filled with a background.
	///</summary>
	public class Set_BackgroundFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundFill = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5E8BFF4B-7468-4E0B-951B-E41AC30B19B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMText.FieldCode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMText", 
		NodeName = "FieldCode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the characters and field codes of multiline text.", 
		ViewType = "Data")]
	[NodeInput("AcadMText", typeof(object))]

	///<summary>
	///Returns the characters and field codes of multiline text.
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
