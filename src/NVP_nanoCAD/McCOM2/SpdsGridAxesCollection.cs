using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Collection of SpdsGridAxesSet objects
///</summary>
namespace McCOM2.SpdsGridAxesCollection 
{

	[NVP_Manifest(
		Id = "52A8B058-A884-4CDB-9CC8-8CBD5BF8D0F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesCollection.SpdsGridAxesCollection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesCollection", 
		NodeName = "_SpdsGridAxesCollection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SpdsGridAxesCollection_Constructor : INode 
	{
		public McCOM2.ISpdsGridAxesCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISpdsGridAxesCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "17834534-FB3A-47C8-AE54-4C4FBBEFA016", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesCollection.SpdsGridAxesCollection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesCollection", 
		NodeName = "_SpdsGridAxesCollection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SpdsGridAxesCollection_ConstructorCast : INode 
	{
		public McCOM2.ISpdsGridAxesCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISpdsGridAxesCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "2973961C-B778-40F7-AFDA-C386CD35C6A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesCollection.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesCollection", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005f9", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]

	///<summary>
	///0x000005f9
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item);

		}
	}


	[NVP_Manifest(
		Id = "B96D6117-47F0-4219-8D40-281A3FEBD167", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesCollection.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesCollection", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005fa", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]

	///<summary>
	///0x000005fa
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
		Id = "CEE8C00A-BF4A-4356-8E60-DC0FDAD89913", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesCollection.Add", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesCollection", 
		NodeName = "Add", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005fb", 
		ViewType = "Modifier")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]
	[NodeInput("rDistance", typeof(System.Double))]
	[NodeInput("nCount", typeof(System.Object))]
	[NodeInput("bstrIndex", typeof(System.String))]

	///<summary>
	///0x000005fb
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Add(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "79BEC632-1758-4AF9-AD11-C153B6E1C613", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesCollection.Remove", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesCollection", 
		NodeName = "Remove", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005fc", 
		ViewType = "Modifier")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]
	[NodeInput("nIndex", typeof(System.Object))]

	///<summary>
	///0x000005fc
	///</summary>
	public class Remove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Remove(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FF107F74-43B9-49D1-A99C-170792169FC8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesCollection.DimTotal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesCollection", 
		NodeName = "DimTotal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005fd", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]

	///<summary>
	///0x000005fd
	///</summary>
	public class DimTotal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimTotal);

		}
	}


	[NVP_Manifest(
		Id = "F805147C-EFD9-4F99-B2CE-67A324A7404E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesCollection.Set_DimTotal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesCollection", 
		NodeName = "Set_DimTotal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005fd", 
		ViewType = "Modifier")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005fd
	///</summary>
	public class Set_DimTotal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimTotal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0E5DD98A-06AC-40E3-A6CC-0A88D5561685", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesCollection.DimChain", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesCollection", 
		NodeName = "DimChain", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005fe", 
		ViewType = "Data")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]

	///<summary>
	///0x000005fe
	///</summary>
	public class DimChain : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimChain);

		}
	}


	[NVP_Manifest(
		Id = "EA32872C-CF56-477C-9FF2-9662B823C55C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SpdsGridAxesCollection.Set_DimChain", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SpdsGridAxesCollection", 
		NodeName = "Set_DimChain", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000005fe", 
		ViewType = "Modifier")]
	[NodeInput("SpdsGridAxesCollection", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x000005fe
	///</summary>
	public class Set_DimChain : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimChain = inputs[1].Value;
			return null;
		}
	}
}
