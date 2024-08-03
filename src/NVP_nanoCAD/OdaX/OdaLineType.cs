using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///An additional TeighaX Interface to the line characteristics
///</summary>
namespace OdaX.OdaLineType 
{

	[NVP_Manifest(
		Id = "D5CB6075-88D5-4DEA-8D1C-D5AC453F1D8A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.OdaLineType_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "_OdaLineType_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaLineType_Constructor : INode 
	{
		public OdaX.IOdaLineType _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaLineType;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5916C565-F7AC-4CD2-88FC-32B1EC37B50E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.OdaLineType_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "_OdaLineType_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaLineType_ConstructorCast : INode 
	{
		public OdaX.IOdaLineType _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaLineType;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C87F9DDB-AE30-440E-BB00-D5B80A870914", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.NumDashes", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "NumDashes", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of dashes of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the number of dashes of a linetype.
	///</summary>
	public class NumDashes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumDashes);

		}
	}


	[NVP_Manifest(
		Id = "D9604AD7-A800-4482-8558-D64ACC160001", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.Set_NumDashes", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "Set_NumDashes", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the number of dashes of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("Count", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of dashes of a linetype.
	///</summary>
	public class Set_NumDashes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NumDashes = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4E2CD7B5-5A28-433B-8051-5E510FDE6AD3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.TextAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "TextAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text to be included as part of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Specifies or returns the text to be included as part of a linetype.
	///</summary>
	public class TextAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAt(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "437708C7-D060-4725-8411-5E93C36E0EEB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.Set_TextAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "Set_TextAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text to be included as part of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies or returns the text to be included as part of a linetype.
	///</summary>
	public class Set_TextAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAt[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "29FF656B-3C25-4EAE-ADEA-246CB2875C2C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.PatternLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "PatternLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the pattern length of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the pattern length of a linetype.
	///</summary>
	public class PatternLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternLength);

		}
	}


	[NVP_Manifest(
		Id = "CBDC5F37-A4CD-4E70-9C0B-448D8AD76B66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.Set_PatternLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "Set_PatternLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the pattern length of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns the pattern length of a linetype.
	///</summary>
	public class Set_PatternLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PatternLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "39ABE8A5-203F-4150-A24C-4CD6FD31EE3B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.DashLengthAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "DashLengthAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the dash length of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the dash length of a linetype.
	///</summary>
	public class DashLengthAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DashLengthAt);

		}
	}


	[NVP_Manifest(
		Id = "44F310BF-AA68-4796-A7F8-1442CAA71926", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.Set_DashLengthAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "Set_DashLengthAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the dash length of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns the dash length of a linetype.
	///</summary>
	public class Set_DashLengthAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DashLengthAt = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B6B4C893-A523-4712-B0F5-B0B461F6D98B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.ShapeScaleAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "ShapeScaleAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale of a shape that is included as part of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the scale of a shape that is included as part of a linetype.
	///</summary>
	public class ShapeScaleAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShapeScaleAt);

		}
	}


	[NVP_Manifest(
		Id = "F13AFD09-2BD9-4FC8-8F06-0DD07BEB4A04", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.Set_ShapeScaleAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "Set_ShapeScaleAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the scale of a shape that is included as part of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns the scale of a shape that is included as part of a linetype.
	///</summary>
	public class Set_ShapeScaleAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShapeScaleAt = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "23873075-E9A2-4FA6-BBF3-782D0C44246A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.ShapeNumberAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "ShapeNumberAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the shape to be included as part of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the shape to be included as part of a linetype.
	///</summary>
	public class ShapeNumberAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShapeNumberAt);

		}
	}


	[NVP_Manifest(
		Id = "44F0C095-C0C3-46ED-B469-5CCC2813CCF0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.Set_ShapeNumberAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "Set_ShapeNumberAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the shape to be included as part of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the shape to be included as part of a linetype.
	///</summary>
	public class Set_ShapeNumberAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShapeNumberAt = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DAF769BA-0C25-4777-88C0-B44C7B1B836E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.ShapeRotationAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "ShapeRotationAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of a shape or text that is included as part of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of a shape or text that is included as part of a linetype.
	///</summary>
	public class ShapeRotationAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShapeRotationAt);

		}
	}


	[NVP_Manifest(
		Id = "B47FF6C3-696C-4939-AB20-1EB6274FD7BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.Set_ShapeRotationAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "Set_ShapeRotationAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation angle of a shape or text that is included as part of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns the rotation angle of a shape or text that is included as part of a linetype.
	///</summary>
	public class Set_ShapeRotationAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShapeRotationAt = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "32783713-1860-4B04-BCFC-4457F1E5F9C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.ShapeOffsetAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "ShapeOffsetAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the offset of a shape that is included as part of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the offset of a shape that is included as part of a linetype.
	///</summary>
	public class ShapeOffsetAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShapeOffsetAt);

		}
	}


	[NVP_Manifest(
		Id = "F8BDBB14-ADE5-4477-B29D-F54645962555", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.Set_ShapeOffsetAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "Set_ShapeOffsetAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the offset of a shape that is included as part of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the offset of a shape that is included as part of a linetype.
	///</summary>
	public class Set_ShapeOffsetAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShapeOffsetAt = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "64D25AB0-06EC-4E9B-9CC1-4EEF900D7F2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.ShapeStyleAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "ShapeStyleAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the style of a shape or text that is included as part of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the style of a shape or text that is included as part of a linetype.
	///</summary>
	public class ShapeStyleAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShapeStyleAt);

		}
	}


	[NVP_Manifest(
		Id = "23548332-D845-4C00-9B74-390F17C8DA97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaLineType.Set_ShapeStyleAt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaLineType", 
		NodeName = "Set_ShapeStyleAt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the style of a shape or text that is included as part of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("pStyle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the style of a shape or text that is included as part of a linetype.
	///</summary>
	public class Set_ShapeStyleAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShapeStyleAt = inputs[1].Value;
			return null;
		}
	}
}
