using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IForm interface
///</summary>
namespace McCOM2.Form 
{

	[NVP_Manifest(
		Id = "5085C40A-6042-419D-861F-9049AF4BA1CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Form.Form_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Form", 
		NodeName = "_Form_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Form_Constructor : INode 
	{
		public McCOM2.IForm _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IForm;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B5BD460C-5F43-47C9-93A2-0037E0787477", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Form.Form_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Form", 
		NodeName = "_Form_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Form_ConstructorCast : INode 
	{
		public McCOM2.IForm _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IForm;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "4D253CFE-2112-4F15-9AB8-F82CB0A25E3A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Form.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Form", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005e9", 
		ViewType = "Data")]
	[NodeInput("Form", typeof(object))]
	[NodeInput("vIndex", typeof(System.Object))]

	///<summary>
	///0x000005e9
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
		Id = "0EED816C-FDA7-4454-BAE5-D9DB50F58EEF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Form.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Form", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ea", 
		ViewType = "Data")]
	[NodeInput("Form", typeof(object))]

	///<summary>
	///0x000005ea
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
		Id = "9920D121-7121-48E8-BDB6-213B425A4452", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Form.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Form", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005f0", 
		ViewType = "Data")]
	[NodeInput("Form", typeof(object))]

	///<summary>
	///0x000005f0
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
		Id = "5EB5D4DC-BCF5-4262-A791-91B27DC7D6F1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Form.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Form", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005f1", 
		ViewType = "Data")]
	[NodeInput("Form", typeof(object))]

	///<summary>
	///0x000005f1
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
		Id = "03DB84C7-7555-4B20-9ED4-8968971386FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Form.Show", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Form", 
		NodeName = "Show", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005eb", 
		ViewType = "Data")]
	[NodeInput("Form", typeof(object))]

	///<summary>
	///0x000005eb
	///</summary>
	public class Show : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Show);

		}
	}


	[NVP_Manifest(
		Id = "D478D43E-603A-4746-9EC0-D62D9EFC7F75", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Form.Load", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Form", 
		NodeName = "Load", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ec", 
		ViewType = "Modifier")]
	[NodeInput("Form", typeof(object))]
	[NodeInput("vSource", typeof(System.Object))]

	///<summary>
	///0x000005ec
	///</summary>
	public class Load : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Load(inputs[1].Value);
			return null;
		}
	}
}
