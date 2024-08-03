using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an object containing text that links to a block
///</summary>
namespace OdaX.AcadAttributeReference 
{

	[NVP_Manifest(
		Id = "6C36EE6E-AA5E-421B-A26B-C4D5D944772A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.AcadAttributeReference_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "_AcadAttributeReference_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadAttributeReference_Constructor : INode 
	{
		public OdaX.IAcadAttributeReference _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadAttributeReference;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B4BE4825-15CE-4AB0-8A51-B4587A13071A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.AcadAttributeReference_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "_AcadAttributeReference_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadAttributeReference_ConstructorCast : INode 
	{
		public OdaX.IAcadAttributeReference _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadAttributeReference;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3E9C6140-8F18-46BF-86E8-CFD257C453CB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the height of an attribute reference.
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
		Id = "5457400F-6C66-4CAD-A5DF-CB9F43F9259B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the height of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of an attribute reference.
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
		Id = "B1CC103A-CCB3-4EF4-8C4B-F5320F11C960", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.HorizontalAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "HorizontalAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the horizontal alignment of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the horizontal alignment of an attribute reference.
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
		Id = "5438BCE6-0BDB-4868-A555-91C67C4A70B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_HorizontalAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_HorizontalAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the horizontal alignment of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("OdaX.AcHorizontalAlignment", typeof(System.Object))]

	///<summary>
	///Specifies or returns the horizontal alignment of an attribute reference.
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
		Id = "E991BC00-432C-4DA8-97FE-799C0FE7A303", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.InsertionPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "InsertionPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the insertion point of attribute reference text.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the insertion point of attribute reference text.
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
		Id = "E533DD88-3E09-411B-93CA-95B1E44ADBB7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_InsertionPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_InsertionPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the insertion point of attribute reference text.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("insPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the insertion point of attribute reference text.
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
		Id = "7030785B-A3BC-4E85-BD0E-9BB80BB23D41", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

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
		Id = "C109B69A-F0D5-4E10-BF35-E21B65E6885C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
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
		Id = "8E21FA5B-89B5-4BCA-9000-E61E6ECBB9DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.ObliqueAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "ObliqueAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the oblique angle of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the oblique angle of an attribute reference.
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
		Id = "176352EA-8E76-40FF-81BB-1A4D046AEB63", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_ObliqueAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_ObliqueAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the oblique angle of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("obliAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the oblique angle of an attribute reference.
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
		Id = "5BEC5297-1DEB-4AB9-86C6-6C5F217A41AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of an attribute reference.
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
		Id = "DD18D7B2-3E0F-4DF0-95F8-2D9786997C06", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_Rotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_Rotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation angle of an attribute reference.
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
		Id = "4D174A72-BF7C-4F56-8334-EFC7D6766723", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor of an attribute reference.
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
		Id = "4DD51D1A-92C9-4DCF-BC10-C45FB3AA2CA9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale factor of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("scalFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the scale factor of an attribute reference.
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
		Id = "9D7E2810-FDC8-41E6-B170-BB8CBDCE4A30", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the style name of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the style name of an attribute reference.
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
		Id = "2E207DBA-2721-4F7A-9E1C-CEE60471D516", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the style name of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the style name of an attribute reference.
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
		Id = "AA050E7E-C57F-4FEA-96FB-B264BCE87AD3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.TagString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "TagString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the tag of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the tag of an attribute reference.
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
		Id = "CE2229F4-23BD-4724-BD63-A3AAA91841F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_TagString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_TagString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the tag of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("bstrTag", typeof(System.String))]

	///<summary>
	///Specifies or returns the tag of an attribute reference.
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
		Id = "48620483-C92A-4385-A353-AB05453BEBFD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.TextAlignmentPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "TextAlignmentPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z alignment point of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z alignment point of an attribute reference.
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
		Id = "7FEB23E4-0264-4AFD-BDB4-F60C95CB9E82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_TextAlignmentPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_TextAlignmentPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the x, y, z alignment point of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("alignPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z alignment point of an attribute reference.
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
		Id = "0405B9CA-BD7E-41C5-AAFC-19CBD03F2D0A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.TextGenerationFlag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "TextGenerationFlag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text generation flag of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the text generation flag of an attribute reference.
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
		Id = "2E4A7410-1F4B-4352-9D19-18F8B17D2B25", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_TextGenerationFlag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_TextGenerationFlag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text generation flag of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("textGenFlag", typeof(System.Object))]

	///<summary>
	///Specifies or returns the text generation flag of an attribute reference.
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
		Id = "F9C1137A-8C84-47FD-97B0-38A9EB83B31E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.TextString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "TextString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the text of an attribute reference.
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
		Id = "1A21871F-E83E-4D0F-8518-310E350DDDFF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_TextString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_TextString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies or returns the text of an attribute reference.
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
		Id = "E9544067-B214-4564-8657-863E81D3FD4C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z-direction value) of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///z-direction value) of an attribute reference.
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
		Id = "ADE9B2DB-D06C-4090-B4A3-AE4B7D9D1C68", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z-direction value) of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of an attribute reference.
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
		Id = "41CF4629-36D4-4704-93CD-50F05EF9CB65", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.VerticalAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "VerticalAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertical alignment of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the vertical alignment of an attribute reference.
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
		Id = "16A733AB-6D3E-48FE-A811-5AF21607DDE4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_VerticalAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_VerticalAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertical alignment of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("OdaX.AcVerticalAlignment", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertical alignment of an attribute reference.
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
		Id = "1520C02A-A78A-41ED-BF5D-E6889D9AC7BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.FieldLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "FieldLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the field length of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the field length of an attribute reference.
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
		Id = "B7D56D15-2605-4E42-851B-64AD1D5EEBD5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_FieldLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_FieldLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the field length of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("fieldLen", typeof(System.Object))]

	///<summary>
	///Specifies or returns the field length of an attribute reference.
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
		Id = "0525E93F-54B7-44A0-93CE-7E05F7820455", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Alignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Alignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the horizontal and vertical alignment of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the horizontal and vertical alignment of an attribute reference.
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
		Id = "42DAAEDE-706B-489F-B15F-89245B4CFEC8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_Alignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_Alignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the horizontal and vertical alignment of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("OdaX.AcAlignment", typeof(System.Object))]

	///<summary>
	///Specifies or returns the horizontal and vertical alignment of an attribute reference.
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
		Id = "174EFD10-1125-41D3-B9D9-A4028933FD71", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.UpsideDown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "UpsideDown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the text of an attribute reference is upside down.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns whether the text of an attribute reference is upside down.
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
		Id = "81D80BB3-3466-4E37-AF2A-B91B59955978", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_UpsideDown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_UpsideDown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the text of an attribute reference is upside down.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("bUpsideDown", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the text of an attribute reference is upside down.
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
		Id = "B1049CDE-3776-4010-A97D-374692C89630", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Backward", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Backward", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the text of an attribute reference is backward.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns whether the text of an attribute reference is backward.
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
		Id = "4B95929C-73A5-4D38-BE1D-9CF4ABCDE5D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_Backward", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_Backward", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the text of an attribute reference is backward.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("bBackward", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the text of an attribute reference is backward.
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
		Id = "00A5B248-3C2F-4E7A-AD8F-4A158B8BF5AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Invisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Invisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the invisible mode of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies or returns the invisible mode of an attribute reference.
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
		Id = "84126886-A080-4D6F-9F2B-AEA2F995601B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_Invisible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_Invisible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the invisible mode of an attribute reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("bInvisible", typeof(System.Object))]

	///<summary>
	///Specifies or returns the invisible mode of an attribute reference.
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
		Id = "C632510F-8B9C-4289-B9A3-2BA97D16C7C9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Constant", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Constant", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the constant mode of an attribute reference.", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Returns the constant mode of an attribute reference.
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
		Id = "8DDB8394-369F-482B-90C9-14E5CC532497", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.LockPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "LockPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether the attribute may be moved relative to the geometry in the block", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Specifies whether the attribute may be moved relative to the geometry in the block
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
		Id = "A056A42C-C968-439A-B882-7AA5B7309C40", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.MTextAttribute", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "MTextAttribute", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines whether if the attribute reference is multiline", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Determines whether if the attribute reference is multiline
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
		Id = "44B49921-7D32-4ADE-B4F8-495F00D9E087", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_MTextAttribute", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_MTextAttribute", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Determines whether if the attribute reference is multiline", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("bMTextAttribute", typeof(System.Object))]

	///<summary>
	///Determines whether if the attribute reference is multiline
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
		Id = "35ADC6BD-2E51-47C4-BB17-7158F537236C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.MTextAttributeContent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "MTextAttributeContent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the multiline attribute reference content", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Gets the multiline attribute reference content
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
		Id = "CE998FD7-7F54-4341-9DDE-B097C25202AC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_MTextAttributeContent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_MTextAttributeContent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the multiline attribute reference content", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
	[NodeInput("content", typeof(System.String))]

	///<summary>
	///Gets the multiline attribute reference content
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
		Id = "788982AB-F062-4527-BFC1-C824A706FC85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.UpdateMTextAttribute", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "UpdateMTextAttribute", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Updates attribute reference from the multiline mtext and vice versa", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]

	///<summary>
	///Updates attribute reference from the multiline mtext and vice versa
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
		Id = "CCA2BE2A-EC2C-4819-AE99-7F797B29AD85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.MTextBoundaryWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "MTextBoundaryWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the width of text boundary of the Mtext", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

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
		Id = "0327BA5B-E878-4627-8C13-A6FE827A761F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_MTextBoundaryWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_MTextBoundaryWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the width of text boundary of the Mtext", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]

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
		Id = "F814B8E5-1E34-42C9-975C-EF2C1ECD4802", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.MTextDrawingDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "MTextDrawingDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the drawing direction of the Mtext", 
		ViewType = "Data")]
	[NodeInput("AcadAttributeReference", typeof(object))]

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
		Id = "BC1F7E62-4BB5-4F4D-9E19-98F2AC7C158B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadAttributeReference.Set_MTextDrawingDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadAttributeReference", 
		NodeName = "Set_MTextDrawingDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the drawing direction of the Mtext", 
		ViewType = "Modifier")]
	[NodeInput("AcadAttributeReference", typeof(object))]
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
