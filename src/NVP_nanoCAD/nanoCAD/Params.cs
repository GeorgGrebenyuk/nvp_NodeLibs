using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///Params wrapper
///</summary>
namespace nanoCAD.Params 
{

	[NVP_Manifest(
		Id = "F4DDE7CC-6AF3-4287-B1D7-3A797626C8E4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Params.Params_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Params", 
		NodeName = "_Params_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Params_Constructor : INode 
	{
		public nanoCAD.IParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.IParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D1B48DD5-FDEF-47C6-ADA2-054581826B1B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Params.Params_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Params", 
		NodeName = "_Params_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Params_ConstructorCast : INode 
	{
		public nanoCAD.IParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.IParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "31407C79-6E65-4D62-9785-E238BCC0428F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Params.Set_Section", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Params", 
		NodeName = "Set_Section", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets new section", 
		ViewType = "Modifier")]
	[NodeInput("Params", typeof(object))]
	[NodeInput("Path", typeof(System.String))]
	[NodeInput("create", typeof(System.Object))]
	[NodeInput("Section", typeof(System.Object))]

	///<summary>
	///Sets new section
	///</summary>
	public class Set_Section : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Section[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "495BC888-F0E2-4CFF-A85C-B946AEBBB421", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Params.Section", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Params", 
		NodeName = "Section", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets new section", 
		ViewType = "Data")]
	[NodeInput("Params", typeof(object))]
	[NodeInput("Path", typeof(System.String))]
	[NodeInput("create", typeof(System.Object))]

	///<summary>
	///Sets new section
	///</summary>
	public class Section : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Section(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "F9E68C95-4359-436C-923F-73AA6F09F49C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Params.Sections", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Params", 
		NodeName = "Sections", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the subsections names enumerator", 
		ViewType = "Data")]
	[NodeInput("Params", typeof(object))]

	///<summary>
	///Returns the subsections names enumerator
	///</summary>
	public class Sections : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Sections);

		}
	}


	[NVP_Manifest(
		Id = "DCB2AD9D-7F6B-4C77-BA76-2D647F2677AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Params.Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Params", 
		NodeName = "Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the value of named value", 
		ViewType = "Data")]
	[NodeInput("Params", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("nanoCAD.ValueType", typeof(System.Object))]

	///<summary>
	///Returns the value of named value
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value(inputs[1].Value,((nanoCAD.ValueType)inputs[2].Value)));

		}
	}


	[NVP_Manifest(
		Id = "90C8AB2F-91C1-4244-BB1E-446073A76AF8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Params.Set_Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Params", 
		NodeName = "Set_Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the value of named value", 
		ViewType = "Modifier")]
	[NodeInput("Params", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("nanoCAD.ValueType", typeof(System.Object))]
	[NodeInput("pValue", typeof(System.Object))]

	///<summary>
	///Returns the value of named value
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EB1E5864-6B10-4FC9-8F25-87F6FB1D7662", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Params.Values", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Params", 
		NodeName = "Values", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the values names enumerator", 
		ViewType = "Data")]
	[NodeInput("Params", typeof(object))]

	///<summary>
	///Returns the values names enumerator
	///</summary>
	public class Values : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Values);

		}
	}


	[NVP_Manifest(
		Id = "BF7C99D5-EEA1-4A0D-B635-54C4C9AE57B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Params.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Params", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves text", 
		ViewType = "Data")]
	[NodeInput("Params", typeof(object))]
	[NodeInput("nanoCAD.SerializationFormat", typeof(System.Object))]

	///<summary>
	///Retrieves text
	///</summary>
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text(((nanoCAD.SerializationFormat)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		Id = "CE684AFF-8AEC-42D5-A3C2-A5211C054FBF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Params.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Params", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves text", 
		ViewType = "Modifier")]
	[NodeInput("Params", typeof(object))]
	[NodeInput("nanoCAD.SerializationFormat", typeof(System.Object))]
	[NodeInput("Text", typeof(System.String))]

	///<summary>
	///Retrieves text
	///</summary>
	public class Set_Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Text[inputs[1]] = inputs[2];
			return null;
		}
	}
}
