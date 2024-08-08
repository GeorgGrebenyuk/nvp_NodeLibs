using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Polymorph mark
///</summary>
namespace McCOM2.SymSpdsPolymorph 
{

	[NVP_Manifest(
		Id = "82CF46C3-7E2A-4F56-B43C-18011BE6E044", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPolymorph.SymSpdsPolymorph_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPolymorph", 
		NodeName = "_SymSpdsPolymorph_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsPolymorph_Constructor : INode 
	{
		public McCOM2.ISymSpdsPolymorph _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsPolymorph;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "17CA3B84-8FC5-48F6-8D4D-50A07C3302C4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPolymorph.SymSpdsPolymorph_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPolymorph", 
		NodeName = "_SymSpdsPolymorph_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsPolymorph_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsPolymorph _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsPolymorph;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "074F972A-9866-41ED-B5CD-60C705D51F04", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPolymorph.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPolymorph", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000048d", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPolymorph", typeof(object))]

	///<summary>
	///0x0000048d
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
		Id = "553D2119-6C72-43BA-B7A1-50E5EE79188D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPolymorph.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPolymorph", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000048d", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPolymorph", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x0000048d
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
		Id = "29E6157A-8964-4BA0-B9B4-F75B87AB25ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPolymorph.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPolymorph", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000048a", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPolymorph", typeof(object))]

	///<summary>
	///0x0000048a
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Id = "B9EEBED5-BEE2-4C05-8D3D-A59778D72414", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPolymorph.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPolymorph", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000048a", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPolymorph", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x0000048a
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "76227A0B-8A20-42B9-B01F-7DAA93747AB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPolymorph.Shape", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPolymorph", 
		NodeName = "Shape", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000048c", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPolymorph", typeof(object))]

	///<summary>
	///0x0000048c
	///</summary>
	public class Shape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Shape);

		}
	}


	[NVP_Manifest(
		Id = "FE1B5B61-821C-4EC4-B05A-C9AF17CD008B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPolymorph.Set_Shape", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPolymorph", 
		NodeName = "Set_Shape", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000048c", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPolymorph", typeof(object))]
	[NodeInput("McCOM2.PolymorphShape", typeof(System.Object))]

	///<summary>
	///0x0000048c
	///</summary>
	public class Set_Shape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Shape = ((McCOM2.PolymorphShape)inputs[1].Value);
			return null;
		}
	}
}
