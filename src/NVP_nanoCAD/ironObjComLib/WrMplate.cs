using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrmplate Interface
///</summary>
namespace ironObjComLib.WrMplate 
{

	[NVP_Manifest(
		Id = "4B346148-D822-4BDC-9FC8-71F2E57E069D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.WrMplate_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "_WrMplate_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMplate_Constructor : INode 
	{
		public ironObjComLib.IWrMplate _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrMplate;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "92B78052-8433-45F1-8B41-3227C771BC68", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.WrMplate_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "_WrMplate_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrMplate_ConstructorCast : INode 
	{
		public ironObjComLib.IWrMplate _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrMplate;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "182B6D58-2629-446E-851D-2F63EC24C809", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

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
		Id = "10246CA7-47EC-46EE-AAA8-A2107C34FF98", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrMplate", typeof(object))]
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
		Id = "A669F3BC-CB16-44E9-8EED-94D893B06E25", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PART_TAG", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property PART_TAG
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
		Id = "746D6863-5462-4E16-B0C9-8FA09BFD6194", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.part_standatd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "part_standatd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PART_STANDARD", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property PART_STANDARD
	///</summary>
	public class part_standatd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.part_standatd);

		}
	}


	[NVP_Manifest(
		Id = "E0AF3DBB-F50E-4339-A518-F139FFE1E56C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.Set_part_standatd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "Set_part_standatd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PART_STANDARD", 
		ViewType = "Modifier")]
	[NodeInput("WrMplate", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PART_STANDARD
	///</summary>
	public class Set_part_standatd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.part_standatd = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "65CC0345-026D-495E-BC6D-1D6442013480", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.part_material_class", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "part_material_class", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PART_MATERIAL_CLASS", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property PART_MATERIAL_CLASS
	///</summary>
	public class part_material_class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.part_material_class);

		}
	}


	[NVP_Manifest(
		Id = "6DA8244D-6108-45B5-8685-AC1C60552471", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.Set_part_material_class", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "Set_part_material_class", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PART_MATERIAL_CLASS", 
		ViewType = "Modifier")]
	[NodeInput("WrMplate", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PART_MATERIAL_CLASS
	///</summary>
	public class Set_part_material_class : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.part_material_class = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "80967E59-CF01-49D8-ADCE-693B787D7345", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PART_MATERIAL", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property PART_MATERIAL
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
		Id = "ED542E76-D0C8-4565-8C85-61E3AAD6C8EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.Set_Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "Set_Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PART_MATERIAL", 
		ViewType = "Modifier")]
	[NodeInput("WrMplate", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PART_MATERIAL
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
		Id = "7D7FD6C3-911B-4BD5-87A2-8A0BCB9B42DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PART_MATERIAL_STANDARD", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property PART_MATERIAL_STANDARD
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
		Id = "4B405233-89E6-47C6-865F-E6666BEF45DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.Set_Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "Set_Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PART_MATERIAL_STANDARD", 
		ViewType = "Modifier")]
	[NodeInput("WrMplate", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PART_MATERIAL_STANDARD
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
		Id = "3C970908-74B2-484E-897E-41D4DADABDFF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PART_WEIGHT", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property PART_WEIGHT
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
		Id = "FE992FD0-BE2D-4DBE-A284-F400F0C08977", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.part_height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "part_height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property height", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property height
	///</summary>
	public class part_height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.part_height);

		}
	}


	[NVP_Manifest(
		Id = "2E57E684-7249-4A59-AB6F-EB3815CEADB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.Set_part_height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "Set_part_height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property height", 
		ViewType = "Modifier")]
	[NodeInput("WrMplate", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property height
	///</summary>
	public class Set_part_height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.part_height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EF911FD3-7513-4772-A663-13C981B3518E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.dimLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "dimLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property dimLength", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property dimLength
	///</summary>
	public class dimLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.dimLength);

		}
	}


	[NVP_Manifest(
		Id = "31AD6C94-EA0F-47A1-864B-0101F8F65426", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrMplate.dimWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrMplate", 
		NodeName = "dimWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property dimWidth", 
		ViewType = "Data")]
	[NodeInput("WrMplate", typeof(object))]

	///<summary>
	///property dimWidth
	///</summary>
	public class dimWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.dimWidth);

		}
	}
}
