using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrReinfAsm Interface
///</summary>
namespace ironObjComLib.WrReinfAsm 
{

	[NVP_Manifest(
		Id = "042691A2-F360-44F3-AB2F-4C6A8ACC8139", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.WrReinfAsm_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "_WrReinfAsm_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrReinfAsm_Constructor : INode 
	{
		public ironObjComLib.IWrReinfAsm _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrReinfAsm;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "E1BA98EE-96F9-42D8-89BA-8995A370994C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.WrReinfAsm_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "_WrReinfAsm_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrReinfAsm_ConstructorCast : INode 
	{
		public ironObjComLib.IWrReinfAsm _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrReinfAsm;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "64E9BE38-2813-4055-B75D-D85E2905F758", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

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
		Id = "E0A8E11C-BE64-40B4-AF82-9747D8E59BF8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfAsm", typeof(object))]
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
		Id = "3769DB24-946D-4CEB-96F5-4083C38A0A49", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.Mark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "Mark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Mark", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

	///<summary>
	///property Mark
	///</summary>
	public class Mark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Mark);

		}
	}


	[NVP_Manifest(
		Id = "CC54B671-43DB-4D03-8869-A78F304696D4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Group", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

	///<summary>
	///property Group
	///</summary>
	public class Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Group);

		}
	}


	[NVP_Manifest(
		Id = "C1BC48EA-9C18-45BE-A271-994B51819900", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Parent", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

	///<summary>
	///property Parent
	///</summary>
	public class Parent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parent);

		}
	}


	[NVP_Manifest(
		Id = "12E82B59-686C-40F2-B835-36F6CED12373", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.Set_Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "Set_Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Parent", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfAsm", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Parent
	///</summary>
	public class Set_Parent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Parent = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9E959AA9-B675-4BF6-902C-19E86DC485E6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.X", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "X", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property X", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

	///<summary>
	///property X
	///</summary>
	public class X : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.X);

		}
	}


	[NVP_Manifest(
		Id = "4427AB23-CB89-427D-8392-27EA21B3F4C6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.Set_X", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "Set_X", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property X", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfAsm", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property X
	///</summary>
	public class Set_X : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.X = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "83A8F66D-2AA1-4A03-B7C7-45ABE86B34BD", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.Y", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "Y", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Y", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

	///<summary>
	///property Y
	///</summary>
	public class Y : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Y);

		}
	}


	[NVP_Manifest(
		Id = "4A6FD9AA-9868-4E89-943F-AEAD58C10245", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.Set_Y", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "Set_Y", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Y", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfAsm", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Y
	///</summary>
	public class Set_Y : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Y = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A3F7B4B0-64CA-4AA0-B20C-463854DE705C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.Z", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "Z", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Z", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

	///<summary>
	///property Z
	///</summary>
	public class Z : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Z);

		}
	}


	[NVP_Manifest(
		Id = "CBAAB195-40B0-4418-B028-32C54FE4EF3D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.Set_Z", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "Set_Z", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Z", 
		ViewType = "Modifier")]
	[NodeInput("WrReinfAsm", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Z
	///</summary>
	public class Set_Z : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Z = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9C5815AE-7D9E-4049-880A-4F205A919EB5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrReinfAsm.isMasterAssemblyReference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrReinfAsm", 
		NodeName = "isMasterAssemblyReference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "master assembly check", 
		ViewType = "Data")]
	[NodeInput("WrReinfAsm", typeof(object))]

	///<summary>
	///master assembly check
	///</summary>
	public class isMasterAssemblyReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isMasterAssemblyReference);

		}
	}
}
