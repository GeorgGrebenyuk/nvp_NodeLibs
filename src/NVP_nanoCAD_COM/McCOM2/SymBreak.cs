using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Break designation
///</summary>
namespace McCOM2.SymBreak 
{

	[NVP_Manifest(
		Id = "49B187F5-9796-4146-8747-A5CE5DAA0D0C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBreak.SymBreak_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBreak", 
		NodeName = "_SymBreak_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymBreak_Constructor : INode 
	{
		public McCOM2.ISymBreak _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymBreak;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F5A53772-1FE4-455B-8C5C-C7CE475DE3D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBreak.SymBreak_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBreak", 
		NodeName = "_SymBreak_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymBreak_ConstructorCast : INode 
	{
		public McCOM2.ISymBreak _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymBreak;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "0AB44699-9EA9-475B-BE54-CC690B7F4E57", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBreak.PositionTop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBreak", 
		NodeName = "PositionTop", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000e6", 
		ViewType = "Data")]
	[NodeInput("SymBreak", typeof(object))]

	///<summary>
	///0x000000e6
	///</summary>
	public class PositionTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PositionTop);

		}
	}


	[NVP_Manifest(
		Id = "41CBD005-C495-4AFA-84D3-1FC8CB1F7F75", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBreak.Set_PositionTop", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBreak", 
		NodeName = "Set_PositionTop", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000e6", 
		ViewType = "Modifier")]
	[NodeInput("SymBreak", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000000e6
	///</summary>
	public class Set_PositionTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PositionTop = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A460A099-5831-4246-ADBB-467741DE0F9A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBreak.PositionBottom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBreak", 
		NodeName = "PositionBottom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000e4", 
		ViewType = "Data")]
	[NodeInput("SymBreak", typeof(object))]

	///<summary>
	///0x000000e4
	///</summary>
	public class PositionBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PositionBottom);

		}
	}


	[NVP_Manifest(
		Id = "F6C94C58-B9E6-48B1-B8E1-B7D7FE3C91F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBreak.Set_PositionBottom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBreak", 
		NodeName = "Set_PositionBottom", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000e4", 
		ViewType = "Modifier")]
	[NodeInput("SymBreak", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000000e4
	///</summary>
	public class Set_PositionBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PositionBottom = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0A584543-446B-4345-A9EF-A17EB80E7D04", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBreak.PositionRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBreak", 
		NodeName = "PositionRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000e5", 
		ViewType = "Data")]
	[NodeInput("SymBreak", typeof(object))]

	///<summary>
	///0x000000e5
	///</summary>
	public class PositionRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PositionRight);

		}
	}


	[NVP_Manifest(
		Id = "7D31CCD9-AA2E-470D-A40B-9E70A3330473", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBreak.Set_PositionRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBreak", 
		NodeName = "Set_PositionRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000e5", 
		ViewType = "Modifier")]
	[NodeInput("SymBreak", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000000e5
	///</summary>
	public class Set_PositionRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PositionRight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9859A8C1-9F0E-47C3-A407-27DC99A48F75", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBreak.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBreak", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000e8", 
		ViewType = "Data")]
	[NodeInput("SymBreak", typeof(object))]

	///<summary>
	///0x000000e8
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
		Id = "1113CC43-DCB0-446B-ACC5-9ACAE1E1DB89", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBreak.Set_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBreak", 
		NodeName = "Set_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000e8", 
		ViewType = "Modifier")]
	[NodeInput("SymBreak", typeof(object))]
	[NodeInput("McCOM2.SymBreakType", typeof(System.Object))]

	///<summary>
	///0x000000e8
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((McCOM2.SymBreakType)inputs[1].Value);
			return null;
		}
	}
}
