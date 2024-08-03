using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///Strings container
///</summary>
namespace nanoCAD.Arguments 
{

	[NVP_Manifest(
		Id = "BF3C4F38-6B11-44C1-92AB-D74B4EFFE030", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Arguments.Arguments_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Arguments", 
		NodeName = "_Arguments_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Arguments_Constructor : INode 
	{
		public nanoCAD.IArguments _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.IArguments;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "36694F71-4216-4622-86A3-736875B08864", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Arguments.Arguments_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Arguments", 
		NodeName = "_Arguments_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Arguments_ConstructorCast : INode 
	{
		public nanoCAD.IArguments _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.IArguments;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "B5CD7BBF-A0E7-4E76-BAEA-90C56C3250C9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Arguments.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Arguments", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves the string from container", 
		ViewType = "Data")]
	[NodeInput("Arguments", typeof(object))]
	[NodeInput("idx", typeof(System.Object))]

	///<summary>
	///Retrieves the string from container
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "EC89883B-BA80-46C0-B06B-8CBBC586D773", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Arguments.Set_Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Arguments", 
		NodeName = "Set_Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Retrieves the string from container", 
		ViewType = "Modifier")]
	[NodeInput("Arguments", typeof(object))]
	[NodeInput("idx", typeof(System.Object))]
	[NodeInput("str", typeof(System.String))]

	///<summary>
	///Retrieves the string from container
	///</summary>
	public class Set_Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Item[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "64EF8DE1-1759-4A4E-AB7E-094A8450463D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Arguments.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Arguments", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the number of commands in assembly", 
		ViewType = "Data")]
	[NodeInput("Arguments", typeof(object))]

	///<summary>
	///Gets the number of commands in assembly
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Id = "4B06C729-47AA-4503-81DF-4A4A69A6D6E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.Arguments.Append", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.Arguments", 
		NodeName = "Append", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Arguments", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Append : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Append();
			return null;
		}
	}
}
