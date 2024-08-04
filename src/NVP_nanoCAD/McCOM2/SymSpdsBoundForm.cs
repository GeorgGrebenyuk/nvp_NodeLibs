using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsBoundForm interface
///</summary>
namespace McCOM2.SymSpdsBoundForm 
{

	[NVP_Manifest(
		Id = "55AD472C-62D3-4AF9-895A-D175D7539CA0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsBoundForm.SymSpdsBoundForm_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsBoundForm", 
		NodeName = "_SymSpdsBoundForm_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsBoundForm_Constructor : INode 
	{
		public McCOM2.ISymSpdsBoundForm _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsBoundForm;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "E28D2511-A20C-4381-A80D-DD0ABC1BAD37", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsBoundForm.SymSpdsBoundForm_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsBoundForm", 
		NodeName = "_SymSpdsBoundForm_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsBoundForm_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsBoundForm _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsBoundForm;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "37024516-9354-48F0-9D34-A8CD7B0078D3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsBoundForm.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsBoundForm", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000345", 
		ViewType = "Data")]
	[NodeInput("SymSpdsBoundForm", typeof(object))]

	///<summary>
	///0x00000345
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Id = "7556FBCB-44F4-44E6-8381-77C48FD8C189", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsBoundForm.Set_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsBoundForm", 
		NodeName = "Set_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000345", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsBoundForm", typeof(object))]
	[NodeInput("McCOM2.SymBoundFormType", typeof(System.Object))]

	///<summary>
	///0x00000345
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((McCOM2.SymBoundFormType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B6921B88-BA4C-4CC2-ADE2-3A982EB1D8F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsBoundForm.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsBoundForm", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000033b", 
		ViewType = "Data")]
	[NodeInput("SymSpdsBoundForm", typeof(object))]

	///<summary>
	///0x0000033b
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	[NVP_Manifest(
		Id = "2E98D4E9-EADB-40ED-BE7E-B66577733EEB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsBoundForm.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsBoundForm", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000033b", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsBoundForm", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x0000033b
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1].Value;
			return null;
		}
	}
}
