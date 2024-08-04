using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrConcreteColumn Interface
///</summary>
namespace ironObjComLib.WrConcreteColumn 
{

	[NVP_Manifest(
		Id = "796278D8-9BFE-4171-9ED3-B757E17983FE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.WrConcreteColumn_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "_WrConcreteColumn_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrConcreteColumn_Constructor : INode 
	{
		public ironObjComLib.IWrConcreteColumn _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrConcreteColumn;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "EBD1A53D-26CD-4E15-920C-D6D397173FEC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.WrConcreteColumn_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "_WrConcreteColumn_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrConcreteColumn_ConstructorCast : INode 
	{
		public ironObjComLib.IWrConcreteColumn _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrConcreteColumn;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "430BDE9A-55DF-436B-91B9-D37ED3365035", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrConcreteColumn", typeof(object))]

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
		Id = "AF46DC71-FAB0-401D-8872-2E1C180B80F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteColumn", typeof(object))]
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
		Id = "433C867A-1911-4630-A138-A378649962AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Parent", 
		ViewType = "Data")]
	[NodeInput("WrConcreteColumn", typeof(object))]

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
		Id = "E39B2B3F-812C-48A4-965D-C7665619FCD8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.Set_Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "Set_Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Parent", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteColumn", typeof(object))]
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
		Id = "AC63CB21-B2B7-42DB-AF9B-21675F1A7033", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Name", 
		ViewType = "Data")]
	[NodeInput("WrConcreteColumn", typeof(object))]

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
		Id = "4ED4AAAB-D8FF-4539-9105-8396A1FEB515", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Name", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteColumn", typeof(object))]
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
		Id = "5619A20C-4041-4CBF-BE01-30082F342379", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.ProfileName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "ProfileName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ProfileName", 
		ViewType = "Data")]
	[NodeInput("WrConcreteColumn", typeof(object))]

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
		Id = "D56F2848-86AC-4D73-ABE0-E0D77E941E9E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.Set_ProfileName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "Set_ProfileName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ProfileName", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteColumn", typeof(object))]
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
		Id = "92F9F8F3-E171-4448-BD92-128AED5C9D19", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Length", 
		ViewType = "Data")]
	[NodeInput("WrConcreteColumn", typeof(object))]

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
		Id = "5602B569-846E-4BE3-9656-BFA097A2230C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.Set_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "Set_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Length", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteColumn", typeof(object))]
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
		Id = "B90FCF2A-2C42-49CE-A2A8-4CB8DD111C67", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Weight", 
		ViewType = "Data")]
	[NodeInput("WrConcreteColumn", typeof(object))]

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
		Id = "4B568CE8-6C3B-415B-A5F8-15A43085EEC1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.Mark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "Mark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Mark", 
		ViewType = "Data")]
	[NodeInput("WrConcreteColumn", typeof(object))]

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
		Id = "1EEB50D5-581B-4979-A64C-F75867C179A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.Set_Mark", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "Set_Mark", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Mark", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteColumn", typeof(object))]
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
		Id = "8A23CD7A-571F-48D2-9961-4100D592C001", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.StartPt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "StartPt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property StartPoint", 
		ViewType = "Data")]
	[NodeInput("WrConcreteColumn", typeof(object))]

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
		Id = "6E29A847-E4EC-4CA3-A2C3-1DBBFEAF37F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.Set_StartPt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "Set_StartPt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property StartPoint", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteColumn", typeof(object))]
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
		Id = "89E2DA9E-3E27-44D1-B0D7-C2A45F157729", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.EndPt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "EndPt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property EndPoint", 
		ViewType = "Data")]
	[NodeInput("WrConcreteColumn", typeof(object))]

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
		Id = "7C44CE0F-00A8-47CB-ABC6-3FCC0B7B12DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrConcreteColumn.Set_EndPt", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrConcreteColumn", 
		NodeName = "Set_EndPt", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property EndPoint", 
		ViewType = "Modifier")]
	[NodeInput("WrConcreteColumn", typeof(object))]
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
