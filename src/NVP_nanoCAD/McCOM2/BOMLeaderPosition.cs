using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Single position of ISymBOMLeader mark
///</summary>
namespace McCOM2.BOMLeaderPosition 
{

	[NVP_Manifest(
		Id = "8C276408-9F6C-4555-B7F1-6142DC3348BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOMLeaderPosition.BOMLeaderPosition_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOMLeaderPosition", 
		NodeName = "_BOMLeaderPosition_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BOMLeaderPosition_Constructor : INode 
	{
		public McCOM2.IBOMLeaderPosition _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IBOMLeaderPosition;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "39B2DA0A-7603-4F58-A1C6-4D08E6585E5B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOMLeaderPosition.BOMLeaderPosition_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOMLeaderPosition", 
		NodeName = "_BOMLeaderPosition_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BOMLeaderPosition_ConstructorCast : INode 
	{
		public McCOM2.IBOMLeaderPosition _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IBOMLeaderPosition;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "E1C76494-A828-488A-9BFD-B5A0032055C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOMLeaderPosition.Owner", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOMLeaderPosition", 
		NodeName = "Owner", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005d2", 
		ViewType = "Data")]
	[NodeInput("BOMLeaderPosition", typeof(object))]

	///<summary>
	///0x000005d2
	///</summary>
	public class Owner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Owner);

		}
	}


	[NVP_Manifest(
		Id = "6A81D139-63B0-4A20-853D-45891848F983", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOMLeaderPosition.Record", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOMLeaderPosition", 
		NodeName = "Record", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005d3", 
		ViewType = "Data")]
	[NodeInput("BOMLeaderPosition", typeof(object))]

	///<summary>
	///0x000005d3
	///</summary>
	public class Record : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Record);

		}
	}


	[NVP_Manifest(
		Id = "3D312C8E-D2FE-40B8-9494-597EB81DA5F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOMLeaderPosition.Set_Record", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOMLeaderPosition", 
		NodeName = "Set_Record", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005d3", 
		ViewType = "Modifier")]
	[NodeInput("BOMLeaderPosition", typeof(object))]
	[NodeInput("ppValue", typeof(System.Object))]

	///<summary>
	///0x000005d3
	///</summary>
	public class Set_Record : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Record = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A04228C1-E406-43F3-BF13-D4CAA4AF483B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOMLeaderPosition.Object", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOMLeaderPosition", 
		NodeName = "Object", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005d4", 
		ViewType = "Data")]
	[NodeInput("BOMLeaderPosition", typeof(object))]

	///<summary>
	///0x000005d4
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object);

		}
	}


	[NVP_Manifest(
		Id = "4551ED07-D6F6-483B-AB36-9705B59AE262", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOMLeaderPosition.Set_Object", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOMLeaderPosition", 
		NodeName = "Set_Object", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005d4", 
		ViewType = "Modifier")]
	[NodeInput("BOMLeaderPosition", typeof(object))]
	[NodeInput("ppValue", typeof(System.Object))]

	///<summary>
	///0x000005d4
	///</summary>
	public class Set_Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Object = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DC4A3DFB-6AB9-4404-BFDC-BACDA517962F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.BOMLeaderPosition.BOM", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.BOMLeaderPosition", 
		NodeName = "BOM", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005d5", 
		ViewType = "Data")]
	[NodeInput("BOMLeaderPosition", typeof(object))]

	///<summary>
	///0x000005d5
	///</summary>
	public class BOM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BOM);

		}
	}
}
