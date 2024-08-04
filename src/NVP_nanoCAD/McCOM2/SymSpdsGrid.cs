using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Construction axis interface
///</summary>
namespace McCOM2.SymSpdsGrid 
{

	[NVP_Manifest(
		Id = "0DC42541-9D49-48E6-91CF-10113621C055", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsGrid.SymSpdsGrid_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsGrid", 
		NodeName = "_SymSpdsGrid_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsGrid_Constructor : INode 
	{
		public McCOM2.ISymSpdsGrid _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsGrid;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "031533EE-366C-4380-AAED-C911354BF506", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsGrid.SymSpdsGrid_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsGrid", 
		NodeName = "_SymSpdsGrid_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsGrid_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsGrid _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsGrid;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "D2088D6F-D20A-4BBB-98E7-67B09F5BB3A2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsGrid.AxesX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsGrid", 
		NodeName = "AxesX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000600", 
		ViewType = "Data")]
	[NodeInput("SymSpdsGrid", typeof(object))]

	///<summary>
	///0x00000600
	///</summary>
	public class AxesX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxesX);

		}
	}


	[NVP_Manifest(
		Id = "6F5C574E-199E-473E-8DFB-6DFB53017739", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsGrid.AxesY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsGrid", 
		NodeName = "AxesY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000601", 
		ViewType = "Data")]
	[NodeInput("SymSpdsGrid", typeof(object))]

	///<summary>
	///0x00000601
	///</summary>
	public class AxesY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxesY);

		}
	}


	[NVP_Manifest(
		Id = "ADCA17E0-8209-488A-9986-692697E8D253", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsGrid.Polar", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsGrid", 
		NodeName = "Polar", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000602", 
		ViewType = "Data")]
	[NodeInput("SymSpdsGrid", typeof(object))]

	///<summary>
	///0x00000602
	///</summary>
	public class Polar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Polar);

		}
	}


	[NVP_Manifest(
		Id = "B79B446C-A418-4C22-A6EA-59226B594525", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsGrid.Set_Polar", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsGrid", 
		NodeName = "Set_Polar", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000602", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsGrid", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x00000602
	///</summary>
	public class Set_Polar : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Polar = inputs[1].Value;
			return null;
		}
	}
}
