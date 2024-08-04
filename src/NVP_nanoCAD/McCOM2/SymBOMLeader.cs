using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///BOM posiiton mark
///</summary>
namespace McCOM2.SymBOMLeader 
{

	[NVP_Manifest(
		Id = "D6F6E48E-6C1B-4787-89AA-0E68D787E44A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBOMLeader.SymBOMLeader_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBOMLeader", 
		NodeName = "_SymBOMLeader_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymBOMLeader_Constructor : INode 
	{
		public McCOM2.ISymBOMLeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymBOMLeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "9BA6B666-72FF-4325-A189-E0D981A141BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBOMLeader.SymBOMLeader_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBOMLeader", 
		NodeName = "_SymBOMLeader_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymBOMLeader_ConstructorCast : INode 
	{
		public McCOM2.ISymBOMLeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymBOMLeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "05667CF2-022E-4E0A-A9BB-1CF817069BE6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBOMLeader.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBOMLeader", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ca", 
		ViewType = "Data")]
	[NodeInput("SymBOMLeader", typeof(object))]

	///<summary>
	///0x000005ca
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
		Id = "9FB67367-5E8A-4290-B699-6C11DF1E9E8E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBOMLeader.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBOMLeader", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ca", 
		ViewType = "Modifier")]
	[NodeInput("SymBOMLeader", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000005ca
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
		Id = "0C687A83-33D1-4EAB-A477-0ED7D76C1FA0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBOMLeader.TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBOMLeader", 
		NodeName = "TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005cb", 
		ViewType = "Data")]
	[NodeInput("SymBOMLeader", typeof(object))]

	///<summary>
	///0x000005cb
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
		Id = "7DE74DB2-CE63-45A6-B638-E649B7CD82C0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBOMLeader.Set_TextPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBOMLeader", 
		NodeName = "Set_TextPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005cb", 
		ViewType = "Modifier")]
	[NodeInput("SymBOMLeader", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000005cb
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


	[NVP_Manifest(
		Id = "E6DF9A14-9036-4153-B755-CA2A1FB517A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBOMLeader.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBOMLeader", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005cc", 
		ViewType = "Data")]
	[NodeInput("SymBOMLeader", typeof(object))]

	///<summary>
	///0x000005cc
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
		Id = "3157D240-24CA-48B4-919E-F127CAD59FA3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBOMLeader.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBOMLeader", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005cd", 
		ViewType = "Data")]
	[NodeInput("SymBOMLeader", typeof(object))]
	[NodeInput("nIndex", typeof(System.Object))]

	///<summary>
	///0x000005cd
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
		Id = "91CC808B-34BB-41C0-8016-161099A71A73", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBOMLeader.CreateItem", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBOMLeader", 
		NodeName = "CreateItem", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005ce", 
		ViewType = "Modifier")]
	[NodeInput("SymBOMLeader", typeof(object))]
	[NodeInput("pRecord", typeof(System.Object))]
	[NodeInput("pObject", typeof(System.Object))]
	[NodeInput("ppCreated", typeof(System.Object))]

	///<summary>
	///0x000005ce
	///</summary>
	public class CreateItem : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CreateItem(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "098FF9B4-1B00-4F44-BB1B-BCE1CADC6BC3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBOMLeader.DeleteItem", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBOMLeader", 
		NodeName = "DeleteItem", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005cf", 
		ViewType = "Modifier")]
	[NodeInput("SymBOMLeader", typeof(object))]
	[NodeInput("nItemIndex", typeof(System.Object))]

	///<summary>
	///0x000005cf
	///</summary>
	public class DeleteItem : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteItem(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "447A811A-A13F-439D-BEE0-2C90C6F608F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymBOMLeader.BOM", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymBOMLeader", 
		NodeName = "BOM", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005d0", 
		ViewType = "Data")]
	[NodeInput("SymBOMLeader", typeof(object))]

	///<summary>
	///0x000005d0
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
