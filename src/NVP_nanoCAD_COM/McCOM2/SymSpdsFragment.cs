using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Fragment mark
///</summary>
namespace McCOM2.SymSpdsFragment 
{

	[NVP_Manifest(
		Id = "C40620E6-D650-4523-9896-9FFD14A72F7E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsFragment.SymSpdsFragment_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsFragment", 
		NodeName = "_SymSpdsFragment_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsFragment_Constructor : INode 
	{
		public McCOM2.ISymSpdsFragment _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsFragment;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "692E92DB-C7A0-4FE1-8EE1-0804A78ECCB3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsFragment.SymSpdsFragment_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsFragment", 
		NodeName = "_SymSpdsFragment_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsFragment_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsFragment _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsFragment;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "7F1FC27F-4A01-4EE1-A8C5-5939DDF6DE3E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsFragment.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsFragment", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000376", 
		ViewType = "Data")]
	[NodeInput("SymSpdsFragment", typeof(object))]

	///<summary>
	///0x00000376
	///</summary>
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text);

		}
	}


	[NVP_Manifest(
		Id = "30DD8D8A-53E4-4768-952B-6FC0297B1509", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsFragment.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsFragment", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000376", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsFragment", typeof(object))]
	[NodeInput("pbstrValue", typeof(System.String))]

	///<summary>
	///0x00000376
	///</summary>
	public class Set_Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Text = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A9662F27-E42B-49A5-A5AA-57EA7294C697", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsFragment.Begin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsFragment", 
		NodeName = "Begin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000367", 
		ViewType = "Data")]
	[NodeInput("SymSpdsFragment", typeof(object))]

	///<summary>
	///0x00000367
	///</summary>
	public class Begin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Begin);

		}
	}


	[NVP_Manifest(
		Id = "EC42A931-9533-45E3-9FA7-D74CC6FFE24C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsFragment.Set_Begin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsFragment", 
		NodeName = "Set_Begin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000367", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsFragment", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000367
	///</summary>
	public class Set_Begin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Begin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A7E3AC41-92B7-4780-8D4A-6BE35F5D9211", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsFragment.End", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsFragment", 
		NodeName = "End", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000036c", 
		ViewType = "Data")]
	[NodeInput("SymSpdsFragment", typeof(object))]

	///<summary>
	///0x0000036c
	///</summary>
	public class End : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.End);

		}
	}


	[NVP_Manifest(
		Id = "F8AC6115-B040-4CCD-953F-3FF78E9603AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsFragment.Set_End", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsFragment", 
		NodeName = "Set_End", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000036c", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsFragment", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x0000036c
	///</summary>
	public class Set_End : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.End = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6E2024A4-D80A-4C9F-845D-67D00DE27969", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsFragment.Peak", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsFragment", 
		NodeName = "Peak", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000374", 
		ViewType = "Data")]
	[NodeInput("SymSpdsFragment", typeof(object))]

	///<summary>
	///0x00000374
	///</summary>
	public class Peak : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Peak);

		}
	}


	[NVP_Manifest(
		Id = "1A585A0A-181B-47BA-AC9B-A947C1BFE1A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsFragment.Set_Peak", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsFragment", 
		NodeName = "Set_Peak", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000374", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsFragment", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000374
	///</summary>
	public class Set_Peak : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Peak = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8319848F-66B2-45D3-AC95-29AE3C2209B0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsFragment.TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsFragment", 
		NodeName = "TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000377", 
		ViewType = "Data")]
	[NodeInput("SymSpdsFragment", typeof(object))]

	///<summary>
	///0x00000377
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
		Id = "031A3A6F-FABB-4F93-BE9A-E62F28B4A604", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsFragment.Set_TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsFragment", 
		NodeName = "Set_TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000377", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsFragment", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000377
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
}
