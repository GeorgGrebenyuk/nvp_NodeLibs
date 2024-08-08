using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Technical requirements
///</summary>
namespace McCOM2.SymTT 
{

	[NVP_Manifest(
		Id = "A9E21CFC-106A-43BA-A4A8-2464DF0DBADA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTT.SymTT_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTT", 
		NodeName = "_SymTT_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTT_Constructor : INode 
	{
		public McCOM2.ISymTT _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymTT;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "232D28AB-1369-4B1A-AF49-62DBCAFC4E11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTT.SymTT_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTT", 
		NodeName = "_SymTT_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymTT_ConstructorCast : INode 
	{
		public McCOM2.ISymTT _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymTT;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "FEE9B6D9-17F7-48D4-91D4-600BBCF9A5E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTT.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTT", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000052f", 
		ViewType = "Data")]
	[NodeInput("SymTT", typeof(object))]

	///<summary>
	///0x0000052f
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
		Id = "2AAC3DBB-8F26-44C5-8896-8C19F107C0CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTT.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTT", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000052f", 
		ViewType = "Modifier")]
	[NodeInput("SymTT", typeof(object))]
	[NodeInput("pbstrText", typeof(System.String))]

	///<summary>
	///0x0000052f
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
		Id = "3263DDAA-7F08-4843-AE06-179EF7670349", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTT.IsDescription", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTT", 
		NodeName = "IsDescription", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000526", 
		ViewType = "Data")]
	[NodeInput("SymTT", typeof(object))]

	///<summary>
	///0x00000526
	///</summary>
	public class IsDescription : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsDescription);

		}
	}


	[NVP_Manifest(
		Id = "7EA349D8-EE89-4DBA-B7A1-9018513AC713", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTT.Frame", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTT", 
		NodeName = "Frame", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000524", 
		ViewType = "Data")]
	[NodeInput("SymTT", typeof(object))]

	///<summary>
	///0x00000524
	///</summary>
	public class Frame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Frame);

		}
	}


	[NVP_Manifest(
		Id = "E7D7BBBD-934D-438D-8B47-99B63F44FDB0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTT.Set_Frame", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTT", 
		NodeName = "Set_Frame", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000524", 
		ViewType = "Modifier")]
	[NodeInput("SymTT", typeof(object))]
	[NodeInput("ppFrame", typeof(System.Object))]

	///<summary>
	///0x00000524
	///</summary>
	public class Set_Frame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Frame = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "235A8783-CA64-4398-9E78-D538A974764D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTT.TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTT", 
		NodeName = "TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000530", 
		ViewType = "Data")]
	[NodeInput("SymTT", typeof(object))]

	///<summary>
	///0x00000530
	///</summary>
	public class TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextHeight);

		}
	}


	[NVP_Manifest(
		Id = "69D3E41B-AC1F-4CB0-BC7C-E6E5455B405A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTT.Set_TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTT", 
		NodeName = "Set_TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000530", 
		ViewType = "Modifier")]
	[NodeInput("SymTT", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x00000530
	///</summary>
	public class Set_TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1E6E197C-6F8C-4451-AB36-40CCAB46B910", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTT.Slope", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTT", 
		NodeName = "Slope", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000052e", 
		ViewType = "Data")]
	[NodeInput("SymTT", typeof(object))]

	///<summary>
	///0x0000052e
	///</summary>
	public class Slope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Slope);

		}
	}


	[NVP_Manifest(
		Id = "81A71F1F-8B2C-4839-BF11-95CE4DC018D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTT.Set_Slope", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTT", 
		NodeName = "Set_Slope", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000052e", 
		ViewType = "Modifier")]
	[NodeInput("SymTT", typeof(object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x0000052e
	///</summary>
	public class Set_Slope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Slope = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E40FAFA9-BCB9-4642-AB13-FC491ED173BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTT.WordWrap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTT", 
		NodeName = "WordWrap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000533", 
		ViewType = "Data")]
	[NodeInput("SymTT", typeof(object))]

	///<summary>
	///0x00000533
	///</summary>
	public class WordWrap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WordWrap);

		}
	}


	[NVP_Manifest(
		Id = "D9C9E807-3564-4436-9AE4-E4FE3C63CC3C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTT.Set_WordWrap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTT", 
		NodeName = "Set_WordWrap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000533", 
		ViewType = "Modifier")]
	[NodeInput("SymTT", typeof(object))]
	[NodeInput("pvbWrap", typeof(System.Object))]

	///<summary>
	///0x00000533
	///</summary>
	public class Set_WordWrap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WordWrap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B5973DC6-7E32-4FD5-9482-A2A7574D611C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymTT.Move", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymTT", 
		NodeName = "Move", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000051d", 
		ViewType = "Modifier")]
	[NodeInput("SymTT", typeof(object))]
	[NodeInput("vTopLeftPoint", typeof(System.Object))]
	[NodeInput("vBottomRightPoint", typeof(System.Object))]

	///<summary>
	///0x0000051d
	///</summary>
	public class Move : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Move(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
