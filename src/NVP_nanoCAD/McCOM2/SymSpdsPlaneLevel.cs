using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Plane level mark
///</summary>
namespace McCOM2.SymSpdsPlaneLevel 
{

	[NVP_Manifest(
		Id = "B254572E-ADC7-4525-8F7D-2F5DCC10FDB8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPlaneLevel.SymSpdsPlaneLevel_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPlaneLevel", 
		NodeName = "_SymSpdsPlaneLevel_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsPlaneLevel_Constructor : INode 
	{
		public McCOM2.ISymSpdsPlaneLevel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsPlaneLevel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "CFD1E512-0920-43A5-A64D-84EB4CE734AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPlaneLevel.SymSpdsPlaneLevel_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPlaneLevel", 
		NodeName = "_SymSpdsPlaneLevel_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsPlaneLevel_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsPlaneLevel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsPlaneLevel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "4BD11F91-9F9D-48F7-BB78-69707E6E1F78", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPlaneLevel.Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPlaneLevel", 
		NodeName = "Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000475", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPlaneLevel", typeof(object))]

	///<summary>
	///0x00000475
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value);

		}
	}


	[NVP_Manifest(
		Id = "85697C94-DD01-4928-8F23-31BD8F23C8F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPlaneLevel.Set_Value", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPlaneLevel", 
		NodeName = "Set_Value", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000475", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPlaneLevel", typeof(object))]
	[NodeInput("pvValue", typeof(System.Object))]

	///<summary>
	///0x00000475
	///</summary>
	public class Set_Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Value = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "00BD21C2-C9BD-4C2B-913D-371012DD5821", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPlaneLevel.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPlaneLevel", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000472", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPlaneLevel", typeof(object))]

	///<summary>
	///0x00000472
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
		Id = "EA8C40A4-BADD-40D3-9418-36F0E0A3EF5C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPlaneLevel.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPlaneLevel", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000472", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPlaneLevel", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000472
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
		Id = "828CE1FB-2DCD-4EA6-8533-CCFC7B1387BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPlaneLevel.Shape", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPlaneLevel", 
		NodeName = "Shape", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000474", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPlaneLevel", typeof(object))]

	///<summary>
	///0x00000474
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
		Id = "F9834941-4519-47D7-BB21-903D008356DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPlaneLevel.Set_Shape", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPlaneLevel", 
		NodeName = "Set_Shape", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000474", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPlaneLevel", typeof(object))]
	[NodeInput("McCOM2.PlaneLevelShape", typeof(System.Object))]

	///<summary>
	///0x00000474
	///</summary>
	public class Set_Shape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Shape = ((McCOM2.PlaneLevelShape)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "19D7D2E0-720A-4316-989B-2A40C98E56E2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsPlaneLevel.Leaders", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsPlaneLevel", 
		NodeName = "Leaders", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000046c", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPlaneLevel", typeof(object))]

	///<summary>
	///0x0000046c
	///</summary>
	public class Leaders : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Leaders);

		}
	}
}
