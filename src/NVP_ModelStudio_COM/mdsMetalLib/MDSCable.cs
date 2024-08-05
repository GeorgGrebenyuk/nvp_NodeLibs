using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSCable Interface
///</summary>
namespace mdsMetalLib.MDSCable 
{

	[NVP_Manifest(
		Id = "4A156ED6-9CD9-4CFF-9193-C3E4145140C4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.MDSCable_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "_MDSCable_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSCable_Constructor : INode 
	{
		public mdsMetalLib.IMDSCable _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsMetalLib.IMDSCable;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "1A979553-8166-4939-A908-4B73DF625F30", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.MDSCable_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "_MDSCable_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSCable_ConstructorCast : INode 
	{
		public mdsMetalLib.IMDSCable _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsMetalLib.IMDSCable;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3A9D1EA9-C0BF-4E8A-A698-D158EFAB14BF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Описание кабеля", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Описание кабеля
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
		Id = "B1824D62-84D4-42C6-8B2C-D4DF2AE235E9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Описание кабеля", 
		ViewType = "Modifier")]
	[NodeInput("MDSCable", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Описание кабеля
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
		Id = "1256EC8F-B338-417B-BFF9-19864C838EE2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина в метрах", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Длина в метрах
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
		Id = "3B08822F-AAC6-441C-8BA5-169C38C7A5E3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.SegmentLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "SegmentLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина текущего участка в метрах", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Длина текущего участка в метрах
	///</summary>
	public class SegmentLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SegmentLength);

		}
	}


	[NVP_Manifest(
		Id = "895B71E5-1002-4C86-837B-FFBDD5A83917", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.Diameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "Diameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Диаметр в мм", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Диаметр в мм
	///</summary>
	public class Diameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Diameter);

		}
	}


	[NVP_Manifest(
		Id = "335F6BA0-5CEA-40D5-949A-C6E89CE80684", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Группа
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
		Id = "0AA93D03-A7F3-4D3C-BE5A-B8167C9EA279", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.StartDesc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "StartDesc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Начальная точка", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Начальная точка
	///</summary>
	public class StartDesc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartDesc);

		}
	}


	[NVP_Manifest(
		Id = "EE9894C9-9535-460D-96DB-E07289E5BB7F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.EndDesc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "EndDesc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Конечная точка", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Конечная точка
	///</summary>
	public class EndDesc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndDesc);

		}
	}


	[NVP_Manifest(
		Id = "DD3C6EA4-F233-46F9-A681-3AE8EF5F29A2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Параметры
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
		Id = "532131E8-CC94-48C5-BECB-9290DBA47783", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("MDSCable", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры
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
		Id = "F8937E8C-7294-4E0B-8B7E-E5B8C2EA00FE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.NodeStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "NodeStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Начало", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Начало
	///</summary>
	public class NodeStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NodeStart);

		}
	}


	[NVP_Manifest(
		Id = "0FDA8489-D20A-4674-9311-E70B9D7282E5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.NodeEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "NodeEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Конец", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Конец
	///</summary>
	public class NodeEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NodeEnd);

		}
	}


	[NVP_Manifest(
		Id = "DA345DB3-6B4F-4F7A-9205-082AD93B51BC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.SketchMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "SketchMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Режим эскиза", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Режим эскиза
	///</summary>
	public class SketchMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SketchMode);

		}
	}


	[NVP_Manifest(
		Id = "DDC82B5E-36B5-41D6-8E09-A110C723F2A3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.Set_SketchMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "Set_SketchMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Режим эскиза", 
		ViewType = "Modifier")]
	[NodeInput("MDSCable", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Режим эскиза
	///</summary>
	public class Set_SketchMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SketchMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "00FEC9F6-B6FE-4587-A29E-0808308B5D5A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.GetLengthOnLevel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "GetLengthOnLevel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вычисление длины кабеля между высотными отметками", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]
	[NodeInput("LevelMin", typeof(System.Double))]
	[NodeInput("LevelMax", typeof(System.Double))]

	///<summary>
	///Вычисление длины кабеля между высотными отметками
	///</summary>
	public class GetLengthOnLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLengthOnLevel(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "8824347E-6236-431D-8C9F-178D164CEC30", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsMetalLib.MDSCable.Journal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsMetalLib.MDSCable", 
		NodeName = "Journal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Кабельный журнал", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Кабельный журнал
	///</summary>
	public class Journal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Journal);

		}
	}
}
