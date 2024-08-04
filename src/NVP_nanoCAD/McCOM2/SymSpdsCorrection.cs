using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Correction mark
///</summary>
namespace McCOM2.SymSpdsCorrection 
{

	[NVP_Manifest(
		Id = "5E6A5B3C-8A0A-4298-ABAC-2320F9157D48", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsCorrection.SymSpdsCorrection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsCorrection", 
		NodeName = "_SymSpdsCorrection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsCorrection_Constructor : INode 
	{
		public McCOM2.ISymSpdsCorrection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsCorrection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "32187AC0-05CA-4866-A894-F856D6EB6F16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsCorrection.SymSpdsCorrection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsCorrection", 
		NodeName = "_SymSpdsCorrection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsCorrection_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsCorrection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsCorrection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "8CBDB398-ED72-48A4-8359-E6ECBE55C00F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsCorrection.Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsCorrection", 
		NodeName = "Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000035d", 
		ViewType = "Data")]
	[NodeInput("SymSpdsCorrection", typeof(object))]

	///<summary>
	///0x0000035d
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
		Id = "D727AA92-858D-41EF-8747-CB3F02A3956B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsCorrection.Set_Text", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsCorrection", 
		NodeName = "Set_Text", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000035d", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsCorrection", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x0000035d
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
		Id = "F8C6235C-6F29-45E3-928A-5DD828E3A3CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsCorrection.Footer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsCorrection", 
		NodeName = "Footer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000353", 
		ViewType = "Data")]
	[NodeInput("SymSpdsCorrection", typeof(object))]

	///<summary>
	///0x00000353
	///</summary>
	public class Footer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Footer);

		}
	}


	[NVP_Manifest(
		Id = "98B413A2-BC83-498F-A138-3B39AE6C2F16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsCorrection.Set_Footer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsCorrection", 
		NodeName = "Set_Footer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000353", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsCorrection", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000353
	///</summary>
	public class Set_Footer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Footer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D3F91ED5-B37C-4E83-804C-D7E67179F939", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymSpdsCorrection.Leaders", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymSpdsCorrection", 
		NodeName = "Leaders", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000356", 
		ViewType = "Data")]
	[NodeInput("SymSpdsCorrection", typeof(object))]

	///<summary>
	///0x00000356
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
