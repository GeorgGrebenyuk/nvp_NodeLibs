using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrConcreteBeam Interface
///</summary>
namespace ironObjComLib.WrConcreteBeam 
{

	[NVP_Manifest(
		Id = "322EC7D0-49D9-4EAD-AF58-315AA7D56960", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.WrConcreteBeam_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "_WrConcreteBeam_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrConcreteBeam_Constructor : INode 
	{
		public ironObjComLib.IWrConcreteBeam _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrConcreteBeam;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D66A6E90-AC74-47F7-A651-6DEA2B90B59C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.WrConcreteBeam_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "_WrConcreteBeam_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrConcreteBeam_ConstructorCast : INode 
	{
		public ironObjComLib.IWrConcreteBeam _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrConcreteBeam;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "33BD01FC-A763-4E82-A8CD-58B20CDBD68A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

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
		Id = "A074B564-AE3F-4441-B7C3-836296175AA8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteBeam", typeof(object))]
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
		Id = "3ABC8E00-E757-4BDD-BEBC-2804C0A7225D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Parent", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

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
		Id = "4AA42800-99A2-4397-B059-251160A2EAF6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.Set_Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "Set_Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Parent", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteBeam", typeof(object))]
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
		Id = "53D7D35F-0645-4AE9-A1CC-EA5A39460415", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Name", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

	///<summary>
	///property Name
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "02FD9FBB-D25C-4EA4-92F4-C81258F16BBD", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Name", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteBeam", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Name
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AA833FBE-3767-4B16-88FF-1A6E9EBAE362", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.ProfileName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "ProfileName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ProfileName", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

	///<summary>
	///property ProfileName
	///</summary>
	public class ProfileName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProfileName);

		}
	}


	[NVP_Manifest(
		Id = "2BD8B2CD-4C6C-4026-9284-CA04CCC9203A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.Set_ProfileName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "Set_ProfileName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ProfileName", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteBeam", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property ProfileName
	///</summary>
	public class Set_ProfileName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProfileName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F896CA67-9C20-4406-A833-91C0E1A69181", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Length", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

	///<summary>
	///property Length
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}


	[NVP_Manifest(
		Id = "7A14191D-5518-4E36-A48F-255C020EDF60", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.Set_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "Set_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Length", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteBeam", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Length
	///</summary>
	public class Set_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Length = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CF9B55C1-14AA-41F3-8CEE-B024A3FB9331", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Weight", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

	///<summary>
	///property Weight
	///</summary>
	public class Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Weight);

		}
	}


	[NVP_Manifest(
		Id = "33C75E1D-CEEF-4500-8683-AF73EDA18BBF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.Mark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "Mark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Mark", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

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
		Id = "652C9F82-5AEF-49E4-8A65-40437D0B2AE4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.Set_Mark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "Set_Mark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Mark", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteBeam", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Mark
	///</summary>
	public class Set_Mark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Mark = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1BDAE6EA-291E-4667-9587-672E509D80FB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.StartPt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "StartPt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property StartPoint", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

	///<summary>
	///property StartPoint
	///</summary>
	public class StartPt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartPt);

		}
	}


	[NVP_Manifest(
		Id = "F44CBAC1-8B0C-4054-A012-6B73FA1F7A03", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.Set_StartPt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "Set_StartPt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property StartPoint", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteBeam", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property StartPoint
	///</summary>
	public class Set_StartPt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartPt = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2346EAF6-906D-4D0D-8DFF-02F81975B30F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.EndPt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "EndPt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property EndPoint", 
		ViewType = "Data")]
	[NodeInput("WrConcreteBeam", typeof(object))]

	///<summary>
	///property EndPoint
	///</summary>
	public class EndPt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndPt);

		}
	}


	[NVP_Manifest(
		Id = "34619AF4-4870-41B8-B934-653B93E6C793", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteBeam.Set_EndPt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteBeam", 
		NodeName = "Set_EndPt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property EndPoint", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteBeam", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property EndPoint
	///</summary>
	public class Set_EndPt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndPt = inputs[1].Value;
			return null;
		}
	}
}
