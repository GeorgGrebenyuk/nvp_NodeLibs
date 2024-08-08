using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymWeld interface
///</summary>
namespace McCOM2.SymWeld 
{

	[NVP_Manifest(
		Id = "E72E1069-A201-4678-8C80-A377D174CB07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymWeld.SymWeld_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymWeld", 
		NodeName = "_SymWeld_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymWeld_Constructor : INode 
	{
		public McCOM2.ISymWeld _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymWeld;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8FC192A3-C5BD-40BC-BB68-EEBAAF1680C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymWeld.SymWeld_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymWeld", 
		NodeName = "_SymWeld_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymWeld_ConstructorCast : INode 
	{
		public McCOM2.ISymWeld _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymWeld;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "1FD3CDF7-73FC-44BA-9A67-C1038A4BB5E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymWeld.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymWeld", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000565", 
		ViewType = "Data")]
	[NodeInput("SymWeld", typeof(object))]

	///<summary>
	///0x00000565
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
		Id = "A71E02F9-7D61-4C17-AE5A-F617BCCEFD90", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymWeld.Set_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymWeld", 
		NodeName = "Set_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000565", 
		ViewType = "Modifier")]
	[NodeInput("SymWeld", typeof(object))]
	[NodeInput("McCOM2.SymWeldType", typeof(System.Object))]

	///<summary>
	///0x00000565
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((McCOM2.SymWeldType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7F83853B-D437-4FDB-AA31-F4B6DCCB07B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymWeld.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymWeld", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000055b", 
		ViewType = "Data")]
	[NodeInput("SymWeld", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000055b
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "28E08CF9-68E1-4BDB-B482-2D893827997C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymWeld.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymWeld", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000055b", 
		ViewType = "Modifier")]
	[NodeInput("SymWeld", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x0000055b
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction[inputs[1]] = inputs[2];
			return null;
		}
	}
}
