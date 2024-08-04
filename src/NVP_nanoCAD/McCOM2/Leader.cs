using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Leader points interface
///</summary>
namespace McCOM2.Leader 
{

	[NVP_Manifest(
		Id = "A2F3756D-4EDC-48F5-B954-09DE533C50B5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Leader.Leader_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Leader", 
		NodeName = "_Leader_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Leader_Constructor : INode 
	{
		public McCOM2.ILeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ILeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B120DBDE-9351-4801-A094-952C2D7AFD1F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Leader.Leader_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Leader", 
		NodeName = "_Leader_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Leader_ConstructorCast : INode 
	{
		public McCOM2.ILeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ILeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "FFEF48A2-1BB5-47DF-9BF8-A8C56CA60D40", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Leader.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Leader", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000081", 
		ViewType = "Data")]
	[NodeInput("Leader", typeof(object))]

	///<summary>
	///0x00000081
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
		Id = "D56D6C88-FFBA-4304-AD1D-1F7EA5C3E65A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Leader.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Leader", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000081", 
		ViewType = "Modifier")]
	[NodeInput("Leader", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000081
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
		Id = "849FF871-673F-41A7-9F7D-9CCA4F5D16AC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Leader.Arrow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Leader", 
		NodeName = "Arrow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000007e", 
		ViewType = "Data")]
	[NodeInput("Leader", typeof(object))]

	///<summary>
	///0x0000007e
	///</summary>
	public class Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrow);

		}
	}


	[NVP_Manifest(
		Id = "E368130A-43CD-4672-B499-CBE715BB9F87", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Leader.Set_Arrow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Leader", 
		NodeName = "Set_Arrow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000007e", 
		ViewType = "Modifier")]
	[NodeInput("Leader", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x0000007e
	///</summary>
	public class Set_Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrow = ((McCOM2.ArrowType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F7D5E4AA-03BE-4FD1-B8DD-746CEF620152", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Leader.ArrowSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Leader", 
		NodeName = "ArrowSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000007f", 
		ViewType = "Data")]
	[NodeInput("Leader", typeof(object))]

	///<summary>
	///0x0000007f
	///</summary>
	public class ArrowSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowSize);

		}
	}


	[NVP_Manifest(
		Id = "3815CD7A-E2A2-4185-932E-F488E3EDE27B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Leader.Set_ArrowSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Leader", 
		NodeName = "Set_ArrowSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000007f", 
		ViewType = "Modifier")]
	[NodeInput("Leader", typeof(object))]
	[NodeInput("pnSize", typeof(System.Double))]

	///<summary>
	///0x0000007f
	///</summary>
	public class Set_ArrowSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C27B75CD-4422-4948-9458-549244A33445", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Leader.Object", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Leader", 
		NodeName = "Object", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000080", 
		ViewType = "Data")]
	[NodeInput("Leader", typeof(object))]

	///<summary>
	///0x00000080
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object);

		}
	}
}
