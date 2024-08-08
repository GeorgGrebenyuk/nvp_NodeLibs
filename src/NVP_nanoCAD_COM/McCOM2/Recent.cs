using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Recent values container interface
///</summary>
namespace McCOM2.Recent 
{

	[NVP_Manifest(
		Id = "F093FEE1-D75C-42B9-BFFF-F93714F2039C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Recent.Recent_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Recent", 
		NodeName = "_Recent_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Recent_Constructor : INode 
	{
		public McCOM2.IRecent _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IRecent;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B42C0936-258F-4FEA-9104-B295AFEF80EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Recent.Recent_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Recent", 
		NodeName = "_Recent_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Recent_ConstructorCast : INode 
	{
		public McCOM2.IRecent _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IRecent;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "1D94C273-F5F3-40EE-8E8A-2589AD18F36D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Recent.Key", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Recent", 
		NodeName = "Key", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000bd", 
		ViewType = "Data")]
	[NodeInput("Recent", typeof(object))]

	///<summary>
	///0x000000bd
	///</summary>
	public class Key : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Key);

		}
	}


	[NVP_Manifest(
		Id = "0DCC8D39-9622-4BA3-A18D-F2D3B3A00DAA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Recent.Set_Key", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Recent", 
		NodeName = "Set_Key", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000bd", 
		ViewType = "Modifier")]
	[NodeInput("Recent", typeof(object))]
	[NodeInput("pbstrKey", typeof(System.String))]

	///<summary>
	///0x000000bd
	///</summary>
	public class Set_Key : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Key = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5C613AB0-9D28-4D4C-B157-1CEA84103392", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Recent.Values", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Recent", 
		NodeName = "Values", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000bf", 
		ViewType = "Data")]
	[NodeInput("Recent", typeof(object))]
	[NodeInput("bstrSubkey", typeof(System.String))]

	///<summary>
	///0x000000bf
	///</summary>
	public class Values : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Values(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "85C531BE-4128-4C60-9F5E-5D15A2821DCF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Recent.NamedValues", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Recent", 
		NodeName = "NamedValues", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000be", 
		ViewType = "Data")]
	[NodeInput("Recent", typeof(object))]
	[NodeInput("bstrSubkey", typeof(System.String))]

	///<summary>
	///0x000000be
	///</summary>
	public class NamedValues : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NamedValues(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "28E3BA7C-C310-4B66-8F5C-8B278DC7065D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Recent.Add", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Recent", 
		NodeName = "Add", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000bb", 
		ViewType = "Modifier")]
	[NodeInput("Recent", typeof(object))]
	[NodeInput("bstrValue", typeof(System.String))]
	[NodeInput("bstrSubkey", typeof(System.String))]

	///<summary>
	///0x000000bb
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Add(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F3E5AB92-DFC1-4CFC-A1FC-0D74877701B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Recent.Remove", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Recent", 
		NodeName = "Remove", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000bc", 
		ViewType = "Modifier")]
	[NodeInput("Recent", typeof(object))]
	[NodeInput("bstrValue", typeof(System.String))]
	[NodeInput("bstrSubkey", typeof(System.String))]

	///<summary>
	///0x000000bc
	///</summary>
	public class Remove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Remove(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
