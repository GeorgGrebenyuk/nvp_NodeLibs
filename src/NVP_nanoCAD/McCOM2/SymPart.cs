using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Standard detail
///</summary>
namespace McCOM2.SymPart 
{

	[NVP_Manifest(
		Id = "89A54B63-487E-4A0B-9D8E-6A8D6074CBEE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPart.SymPart_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPart", 
		NodeName = "_SymPart_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymPart_Constructor : INode 
	{
		public McCOM2.ISymPart _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymPart;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "9D5ABD79-A58B-43A8-BDF2-81E2A816A1A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPart.SymPart_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPart", 
		NodeName = "_SymPart_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymPart_ConstructorCast : INode 
	{
		public McCOM2.ISymPart _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymPart;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "97B72B21-2B47-448A-A964-8D6FF9237B01", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPart.Init", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPart", 
		NodeName = "Init", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002a2", 
		ViewType = "Modifier")]
	[NodeInput("SymPart", typeof(object))]
	[NodeInput("vPartId", typeof(System.Object))]

	///<summary>
	///0x000002a2
	///</summary>
	public class Init : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Init(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3D2E9B96-139A-4F92-8EB9-0B3A8194CE86", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPart.Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPart", 
		NodeName = "Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002b4", 
		ViewType = "Data")]
	[NodeInput("SymPart", typeof(object))]

	///<summary>
	///0x000002b4
	///</summary>
	public class Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Origin);

		}
	}


	[NVP_Manifest(
		Id = "85D56692-C706-4F62-B73E-F08FD9BD5404", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPart.Set_Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPart", 
		NodeName = "Set_Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002b4", 
		ViewType = "Modifier")]
	[NodeInput("SymPart", typeof(object))]
	[NodeInput("pPoint", typeof(System.Object))]

	///<summary>
	///0x000002b4
	///</summary>
	public class Set_Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Origin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "185F3AD5-81C9-4BBD-8D2B-BB77CF985BC9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPart.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPart", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002ac", 
		ViewType = "Data")]
	[NodeInput("SymPart", typeof(object))]

	///<summary>
	///0x000002ac
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	[NVP_Manifest(
		Id = "53607CA8-6D14-4B4A-98DE-16D1C23D7F4B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPart.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPart", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002ac", 
		ViewType = "Modifier")]
	[NodeInput("SymPart", typeof(object))]
	[NodeInput("pVector", typeof(System.Object))]

	///<summary>
	///0x000002ac
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E96A706C-12FD-43F2-9853-244106F1E4BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPart.Connect", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPart", 
		NodeName = "Connect", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000029d", 
		ViewType = "Modifier")]
	[NodeInput("SymPart", typeof(object))]
	[NodeInput("vObjects", typeof(System.Object))]

	///<summary>
	///0x0000029d
	///</summary>
	public class Connect : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Connect(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E838E495-BD19-4D2D-8D26-5AFCD7DD049D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPart.AffectsTo", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPart", 
		NodeName = "AffectsTo", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002a5", 
		ViewType = "Data")]
	[NodeInput("SymPart", typeof(object))]

	///<summary>
	///0x000002a5
	///</summary>
	public class AffectsTo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AffectsTo);

		}
	}


	[NVP_Manifest(
		Id = "46B1834E-27AB-4C80-AC39-717199F561FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPart.DependsOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPart", 
		NodeName = "DependsOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002aa", 
		ViewType = "Data")]
	[NodeInput("SymPart", typeof(object))]

	///<summary>
	///0x000002aa
	///</summary>
	public class DependsOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DependsOn);

		}
	}


	[NVP_Manifest(
		Id = "4A4DEE7C-81D1-48AD-888D-1B6DCDCE8545", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPart.Class", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPart", 
		NodeName = "Class", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002a7", 
		ViewType = "Data")]
	[NodeInput("SymPart", typeof(object))]

	///<summary>
	///0x000002a7
	///</summary>
	public class Class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Class);

		}
	}


	[NVP_Manifest(
		Id = "461C4231-A9BD-4247-A64F-01F62DEF7972", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPart.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPart", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002b7", 
		ViewType = "Data")]
	[NodeInput("SymPart", typeof(object))]

	///<summary>
	///0x000002b7
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
		Id = "EC8DFA93-B927-40EC-A690-C6BCFA6E3628", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPart.SubType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPart", 
		NodeName = "SubType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000002b6", 
		ViewType = "Data")]
	[NodeInput("SymPart", typeof(object))]

	///<summary>
	///0x000002b6
	///</summary>
	public class SubType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SubType);

		}
	}
}
