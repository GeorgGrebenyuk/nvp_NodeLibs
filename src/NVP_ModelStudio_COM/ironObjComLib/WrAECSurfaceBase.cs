using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECSurfaceBase Interface
///</summary>
namespace ironObjComLib.WrAECSurfaceBase 
{

	[NVP_Manifest(
		Id = "52CA8DF2-6C7D-4801-A0B5-7E33443D431B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.WrAECSurfaceBase_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "_WrAECSurfaceBase_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECSurfaceBase_Constructor : INode 
	{
		public ironObjComLib.IWrAECSurfaceBase _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECSurfaceBase;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D29E1BC4-2CB0-43A1-A212-6FF44E7AAC1C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.WrAECSurfaceBase_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "_WrAECSurfaceBase_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECSurfaceBase_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECSurfaceBase _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECSurfaceBase;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A13C2B10-8C65-4B12-BAE1-7A22304BBE09", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "873D0756-3190-485F-B464-49775012AA7D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "BF8D3113-EAF0-4E58-AE4F-85BDC7E4E609", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property UnitPosition", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "DB2A8824-C0FD-4307-AD16-97783544FB3C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property UnitPosition", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "DA5913EE-EE99-4C67-8C8D-08B3767E8BDE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Name", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "0D4DBCE0-4703-4843-BA38-A80546193E67", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Name", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "E9F5EF0B-2E75-4A0F-9D42-606345307D80", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Tag", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "F66E3CF3-1C5A-4B17-B748-7EAEE19529E6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Tag", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "0373AA57-7A5B-4842-A77B-AFCAB414BADF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Refdrawing", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "1FA42240-88BF-417A-829E-BEDB080A4B09", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Refdrawing", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "44DCDDC3-055E-47E7-958A-D58EF3B7A8C1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "E2AF5B7B-B23C-4F03-B62F-633514CC814F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "D4C88278-9697-4BCB-8A40-724D5F4D8527", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material_Standard", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "D2D7008B-F23D-440C-BDC4-497BF8FF3150", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material_Standard", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "96607E9A-9727-46CC-9D1F-9952A81AE64A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "F7DB846E-E73C-469E-9A4D-A5768BE3B0C1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "3BA95623-96DE-44B6-B6F8-14D412EEB89A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Comment", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "CC8A30C0-F353-4D61-9ACF-296B1A35CD9B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "384B6E32-00CA-440C-BC46-AF7C83146213", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Include", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "DA0EA42C-E3BB-4B29-BA80-D897CA2AEE46", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "89307432-233A-447A-A867-DD653050E1B0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Number", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "87025921-D887-4526-AA45-3ED055CD0543", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "9F1A662D-F8DF-4630-ACDF-BD3E560048F6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Group", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "7329C432-892A-4C9F-8EBE-FCB120991AE0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "D9CF2629-CC98-479A-8761-5C8A17A6378C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Comment", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "E48E1F4D-76E5-4BA0-BB1A-EB62C2C32A02", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "41C0D5BB-1295-422C-8493-ADEA4372FFC1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Include", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "CBD05638-FA31-4A6A-99C6-2B784317F3E3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "B0ADC1D9-E50B-4B66-A573-8813DEAA935F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Number", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "48111CB3-47B6-4E9A-885A-227ED0CEFB65", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "D5CF6891-C030-4924-86B6-B41FAB7D7475", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Group", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "A8FF586A-DF06-4444-8C7A-61E41515BD5C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "8D720E42-B632-47B1-AEFE-9CAFCC2A2D6F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Qty", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "0376655F-E1F0-44C6-B247-F965172D5CCC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Qty", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "C5B9EC18-8166-44F2-9A7A-A5284234B066", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Comment", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

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
		Id = "B9153CDD-E372-462B-959D-02A1F8095EC2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "B4CC7C5D-BF6E-4B46-A050-6A2BC6EEE31D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.DislAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "DislAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AEC_PART_EXC_AXIS", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

	///<summary>
	///property AEC_PART_EXC_AXIS
	///</summary>
	public class DislAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DislAxis);

		}
	}


	[NVP_Manifest(
		Id = "2CA386BE-0752-46D2-A679-804C30C84BB0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_DislAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_DislAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AEC_PART_EXC_AXIS", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///property AEC_PART_EXC_AXIS
	///</summary>
	public class Set_DislAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DislAxis = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7A762C6B-B233-43F4-B76C-35260B4179CA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.DislAxisOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "DislAxisOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AEC_PART_EXC_OFFSET", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]

	///<summary>
	///property AEC_PART_EXC_OFFSET
	///</summary>
	public class DislAxisOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DislAxisOffset);

		}
	}


	[NVP_Manifest(
		Id = "90A89BBE-ECCA-468A-BE1D-834B2A1B3A8F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.Set_DislAxisOffset", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "Set_DislAxisOffset", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AEC_PART_EXC_OFFSET", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///property AEC_PART_EXC_OFFSET
	///</summary>
	public class Set_DislAxisOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DislAxisOffset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "713C68BB-038E-4193-A103-437A2F4B669F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.GetArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "GetArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetArea", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
		Id = "84E9CB9D-E50D-4629-8148-F3A32A857E5E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECSurfaceBase.GetVolume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECSurfaceBase", 
		NodeName = "GetVolume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetVolume", 
		ViewType = "Data")]
	[NodeInput("WrAECSurfaceBase", typeof(object))]
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
