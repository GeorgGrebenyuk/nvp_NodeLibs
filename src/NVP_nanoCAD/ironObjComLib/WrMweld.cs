using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrMweld Interface
///</summary>
namespace ironObjComLib.WrMweld 
{

	[NVP_Manifest(
		Id = "63911A1B-B457-4C0E-A041-0AC34A2CF863", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.WrMweld_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "_WrMweld_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMweld_Constructor : INode 
	{
		public ironObjComLib.IWrMweld _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrMweld;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "1B566AB3-4547-4A6A-AA68-0DC8F83CC0AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.WrMweld_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "_WrMweld_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMweld_ConstructorCast : INode 
	{
		public ironObjComLib.IWrMweld _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrMweld;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "337AEED5-E5CA-4D59-A0FD-430AC7C1D7AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrMweld", typeof(object))]

	///<summary>
	///property Element
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Id = "1A639334-0859-438C-BB24-071B9A900F8B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrMweld", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Element
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F01187CF-E042-4A8B-9FEA-CF61884B9CB8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.continuousness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "continuousness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property CONTINUOUSNESS", 
		ViewType = "Data")]
	[NodeInput("WrMweld", typeof(object))]

	///<summary>
	///property CONTINUOUSNESS
	///</summary>
	public class continuousness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.continuousness);

		}
	}


	[NVP_Manifest(
		Id = "D34026AA-E6EE-4575-9E8C-E7BFDB6963DA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.Set_continuousness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "Set_continuousness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property CONTINUOUSNESS", 
		ViewType = "Modifier")]
	[NodeInput("WrMweld", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property CONTINUOUSNESS
	///</summary>
	public class Set_continuousness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.continuousness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "21F1B953-6A1C-4EA4-AD0B-ADE92AABC457", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.joint_type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "joint_type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property JOINT_TYPE", 
		ViewType = "Data")]
	[NodeInput("WrMweld", typeof(object))]

	///<summary>
	///property JOINT_TYPE
	///</summary>
	public class joint_type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.joint_type);

		}
	}


	[NVP_Manifest(
		Id = "8C5A6B17-C01A-4E5B-A532-B6A8C8C45D20", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.Set_joint_type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "Set_joint_type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property JOINT_TYPE", 
		ViewType = "Modifier")]
	[NodeInput("WrMweld", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property JOINT_TYPE
	///</summary>
	public class Set_joint_type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.joint_type = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "25A3640B-A726-4F7A-89A1-18004682CC46", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.convention", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "convention", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property CONVENTION", 
		ViewType = "Data")]
	[NodeInput("WrMweld", typeof(object))]

	///<summary>
	///property CONVENTION
	///</summary>
	public class convention : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.convention);

		}
	}


	[NVP_Manifest(
		Id = "2E7AEA01-DFD2-4DF5-B5FD-9EC92F80FD0A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.Set_convention", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "Set_convention", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property CONVENTION", 
		ViewType = "Modifier")]
	[NodeInput("WrMweld", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property CONVENTION
	///</summary>
	public class Set_convention : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.convention = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B3055252-5A5E-4ECE-A21B-89A8D7171603", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.production_type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "production_type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PRODUCTION_TYPE", 
		ViewType = "Data")]
	[NodeInput("WrMweld", typeof(object))]

	///<summary>
	///property PRODUCTION_TYPE
	///</summary>
	public class production_type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.production_type);

		}
	}


	[NVP_Manifest(
		Id = "E4545D98-761B-4693-BFD8-42DD91D3F5DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.Set_production_type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "Set_production_type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PRODUCTION_TYPE", 
		ViewType = "Modifier")]
	[NodeInput("WrMweld", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PRODUCTION_TYPE
	///</summary>
	public class Set_production_type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.production_type = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BA14DAF7-70F7-4539-B753-37ED66DE5A7F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.cathetus", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "cathetus", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property CATHETUS_LENGTH", 
		ViewType = "Data")]
	[NodeInput("WrMweld", typeof(object))]

	///<summary>
	///property CATHETUS_LENGTH
	///</summary>
	public class cathetus : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.cathetus);

		}
	}


	[NVP_Manifest(
		Id = "CA0A13D4-23A5-4AAF-9A27-1E49F95718AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.Set_cathetus", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "Set_cathetus", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property CATHETUS_LENGTH", 
		ViewType = "Modifier")]
	[NodeInput("WrMweld", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property CATHETUS_LENGTH
	///</summary>
	public class Set_cathetus : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.cathetus = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "58CEA363-24F6-4BAD-AA00-B12C8C773095", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMweld.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMweld", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property LENGTH", 
		ViewType = "Data")]
	[NodeInput("WrMweld", typeof(object))]

	///<summary>
	///property LENGTH
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}
}
