using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymView interface
///</summary>
namespace McCOM2.SymView 
{

	[NVP_Manifest(
		Id = "3E8C742C-2D44-4250-AED2-118E1C59E6A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymView.SymView_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymView", 
		NodeName = "_SymView_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymView_Constructor : INode 
	{
		public McCOM2.ISymView _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymView;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C5C05223-7044-4386-BBF9-F14101D9B431", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymView.SymView_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymView", 
		NodeName = "_SymView_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymView_ConstructorCast : INode 
	{
		public McCOM2.ISymView _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymView;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "51C4C93B-3B00-464F-AFAD-81CC7EB7B9C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymView.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymView", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000547", 
		ViewType = "Data")]
	[NodeInput("SymView", typeof(object))]

	///<summary>
	///0x00000547
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
		Id = "8E298FF3-C974-4261-8BE9-F5FFF3BDF0BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymView.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymView", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000547", 
		ViewType = "Modifier")]
	[NodeInput("SymView", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x00000547
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
		Id = "3CEC9463-32EB-4D75-A2FE-DB249E2204DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymView.Prefix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymView", 
		NodeName = "Prefix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000548", 
		ViewType = "Data")]
	[NodeInput("SymView", typeof(object))]

	///<summary>
	///0x00000548
	///</summary>
	public class Prefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Prefix);

		}
	}


	[NVP_Manifest(
		Id = "A33C6CD8-410F-48D9-A242-0B10E98324A9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymView.Set_Prefix", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymView", 
		NodeName = "Set_Prefix", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000548", 
		ViewType = "Modifier")]
	[NodeInput("SymView", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000548
	///</summary>
	public class Set_Prefix : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Prefix = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2A02EB19-8717-413C-8F8D-50A92A413C4E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymView.Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymView", 
		NodeName = "Index", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000540", 
		ViewType = "Data")]
	[NodeInput("SymView", typeof(object))]

	///<summary>
	///0x00000540
	///</summary>
	public class Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Index);

		}
	}


	[NVP_Manifest(
		Id = "F32ACB02-9CA0-4A5B-BA86-4C6CB1EC2920", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymView.Set_Index", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymView", 
		NodeName = "Set_Index", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000540", 
		ViewType = "Modifier")]
	[NodeInput("SymView", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x00000540
	///</summary>
	public class Set_Index : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Index = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F8A259A5-F8F5-41C5-91F5-A8467EE36DEE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymView.Zone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymView", 
		NodeName = "Zone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000054d", 
		ViewType = "Data")]
	[NodeInput("SymView", typeof(object))]

	///<summary>
	///0x0000054d
	///</summary>
	public class Zone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Zone);

		}
	}


	[NVP_Manifest(
		Id = "FF198AC8-DBBD-4B61-A796-120F5CB9C3B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymView.Set_Zone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymView", 
		NodeName = "Set_Zone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000054d", 
		ViewType = "Modifier")]
	[NodeInput("SymView", typeof(object))]
	[NodeInput("pbstrResult", typeof(System.String))]

	///<summary>
	///0x0000054d
	///</summary>
	public class Set_Zone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Zone = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4C37354F-92FF-45DF-B95E-C5E9BC4E7B0B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymView.Sheet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymView", 
		NodeName = "Sheet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000054a", 
		ViewType = "Data")]
	[NodeInput("SymView", typeof(object))]

	///<summary>
	///0x0000054a
	///</summary>
	public class Sheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Sheet);

		}
	}


	[NVP_Manifest(
		Id = "BE216A83-EEE1-4F61-B778-A7A93AAD3363", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymView.Set_Sheet", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymView", 
		NodeName = "Set_Sheet", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000054a", 
		ViewType = "Modifier")]
	[NodeInput("SymView", typeof(object))]
	[NodeInput("pnResult", typeof(System.Object))]

	///<summary>
	///0x0000054a
	///</summary>
	public class Set_Sheet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Sheet = inputs[1].Value;
			return null;
		}
	}
}
