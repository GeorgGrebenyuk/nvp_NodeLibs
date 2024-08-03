using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECSurface Interface
///</summary>
namespace ironObjComLib.WrAECSurface 
{

	[NVP_Manifest(
		Id = "CF1AF914-A43A-4BC4-8A41-A27030F76582", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.WrAECSurface_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "_WrAECSurface_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECSurface_Constructor : INode 
	{
		public ironObjComLib.IWrAECSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "FFFDC103-9E92-449C-A198-8512961F0733", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.WrAECSurface_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "_WrAECSurface_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECSurface_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "AF13AF09-EFAE-4462-9140-733D0CB1A452", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AEC_PART_TYPE", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property AEC_PART_TYPE
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
		Id = "85AB0B6C-A8B9-4506-8712-E661E80B4126", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

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
		Id = "C2A1D66E-0BB2-4155-AAE7-222BEC641F16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
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
		Id = "6DDC8B51-6C44-4CA0-9DED-A1532CDC8F65", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property UnitPosition", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property UnitPosition
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
		Id = "CE791DD5-9330-486D-9498-DDBFB616011C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property UnitPosition", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property UnitPosition
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
		Id = "C5321A92-0879-4CC9-AA07-80123348E8C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Name", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Part_Name
	///</summary>
	public class Part_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Name);

		}
	}


	[NVP_Manifest(
		Id = "F494B080-EEBF-49C0-B785-E4CFD845A647", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Name", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Name
	///</summary>
	public class Set_Part_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "10125838-70B7-478E-95CE-0EEED8846CB3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Tag", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Part_Tag
	///</summary>
	public class Part_Tag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Tag);

		}
	}


	[NVP_Manifest(
		Id = "1546132E-6A79-4DA6-9CF5-F6AA2ED7A7F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Tag", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Tag
	///</summary>
	public class Set_Part_Tag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Tag = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A0F51A1A-214D-49FF-9272-64D0FB5A4E05", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Refdrawing", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Part_Refdrawing
	///</summary>
	public class Part_Refdrawing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Refdrawing);

		}
	}


	[NVP_Manifest(
		Id = "AFB40229-326A-4F6F-A888-2024535DE03C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Refdrawing", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Refdrawing
	///</summary>
	public class Set_Part_Refdrawing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Refdrawing = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8DB48DDC-2108-4C09-8524-726FE63E5847", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Part_Material
	///</summary>
	public class Part_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Material);

		}
	}


	[NVP_Manifest(
		Id = "7A607E73-BF66-4119-BDDE-487BAB443715", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Material
	///</summary>
	public class Set_Part_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Material = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "934F7CD5-D8FF-40D4-B255-6B987C4310DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material_Standard", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Part_Material_Standard
	///</summary>
	public class Part_Material_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Material_Standard);

		}
	}


	[NVP_Manifest(
		Id = "676E73EE-3C43-47AA-8A61-47BF1CCC66D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material_Standard", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Material_Standard
	///</summary>
	public class Set_Part_Material_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Material_Standard = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "42A86421-6661-42CF-A4C5-5B431DCD75B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Part_Weight
	///</summary>
	public class Part_Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Weight);

		}
	}


	[NVP_Manifest(
		Id = "749B4A52-02E9-4349-B1C6-E3B2E64E7EEB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Weight
	///</summary>
	public class Set_Part_Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Weight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AEAA1FD6-F8FA-45B0-9047-8DBA7ED5B249", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Comment", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Part_Comment
	///</summary>
	public class Part_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Comment);

		}
	}


	[NVP_Manifest(
		Id = "701708E7-99BB-481B-84F6-BE08632FF454", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Comment
	///</summary>
	public class Set_Part_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Comment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F9BFB5E2-7332-40CD-9E2C-DC9D72C86BCB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Include", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Explication_Include
	///</summary>
	public class Explication_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Include);

		}
	}


	[NVP_Manifest(
		Id = "34C778D6-95A9-4BD4-8BB0-EB92B8C59252", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Explication_Include
	///</summary>
	public class Set_Explication_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Include = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "93B2F48A-6DEE-4865-986C-0F358391237C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Number", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Explication_Number
	///</summary>
	public class Explication_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Number);

		}
	}


	[NVP_Manifest(
		Id = "F34C444C-7621-41CA-8D71-A9F3CCDC63B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Explication_Number
	///</summary>
	public class Set_Explication_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Number = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AFB49ED6-8EFB-44EF-8B07-C361B74BB2C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Group", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Explication_Group
	///</summary>
	public class Explication_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Group);

		}
	}


	[NVP_Manifest(
		Id = "B3CB2B4F-4F32-42FF-85A4-FC7AF79478CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Explication_Group
	///</summary>
	public class Set_Explication_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Group = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3D9F7B8A-DBC4-423F-9ADB-CDE16E8863D8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Comment", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Explication_Comment
	///</summary>
	public class Explication_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Comment);

		}
	}


	[NVP_Manifest(
		Id = "C62BFA07-9849-443D-963F-BA2A411B8BD6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Explication_Comment
	///</summary>
	public class Set_Explication_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Comment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "99DD8805-C6A4-445B-8820-834AB91AB9C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Include", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Bom_Include
	///</summary>
	public class Bom_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Include);

		}
	}


	[NVP_Manifest(
		Id = "4F74FF6A-9402-43E1-9058-106B8D3E60C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Bom_Include
	///</summary>
	public class Set_Bom_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Include = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DC49B6FC-9E53-43DC-8BB0-A13E19B1EE97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Number", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Bom_Number
	///</summary>
	public class Bom_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Number);

		}
	}


	[NVP_Manifest(
		Id = "174C09B7-63B5-4FC1-A8D1-04C0359852A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Number
	///</summary>
	public class Set_Bom_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Number = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9EAFAE76-1C12-4C01-ABF7-3638F8559FEE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Group", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Bom_Group
	///</summary>
	public class Bom_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Group);

		}
	}


	[NVP_Manifest(
		Id = "5606397C-1061-4731-8B60-919324B3675D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Group
	///</summary>
	public class Set_Bom_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Group = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C48F7BDA-76E7-405A-B3B3-ED33B5FCF55A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Qty", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Bom_Qty
	///</summary>
	public class Bom_Qty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Qty);

		}
	}


	[NVP_Manifest(
		Id = "EDFF5108-1781-46DB-9F31-DB168A142539", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Qty", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Qty
	///</summary>
	public class Set_Bom_Qty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Qty = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9B2D4172-DF90-4DE8-9F7D-93FB2BD9945F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Comment", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]

	///<summary>
	///property Bom_Comment
	///</summary>
	public class Bom_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Comment);

		}
	}


	[NVP_Manifest(
		Id = "08CA05F6-B3AB-4630-A8F2-C4D7ADE95E46", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.Set_Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "Set_Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Comment
	///</summary>
	public class Set_Bom_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Comment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "42324AA5-A37A-4E59-BE4B-D7E09F5318F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.GetArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "GetArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetArea", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("Element", typeof(System.Object))]
	[NodeInput("bodyOptions", typeof(System.Object))]

	///<summary>
	///method GetArea
	///</summary>
	public class GetArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetArea(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "113644E5-EB55-47CF-83A5-8BFA5F5DC405", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurface.GetVolume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurface", 
		NodeName = "GetVolume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetVolume", 
		ViewType = "Data")]
	[NodeInput("WrAECSurface", typeof(object))]
	[NodeInput("Element", typeof(System.Object))]
	[NodeInput("bodyOptions", typeof(System.Object))]

	///<summary>
	///method GetVolume
	///</summary>
	public class GetVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetVolume(inputs[1].Value,inputs[2].Value));

		}
	}
}
