using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSNode Interface
///</summary>
namespace mdsUnitsLib.MDSNode 
{

	[NVP_Manifest(
		Id = "2D437C9C-FCA3-4992-BCB5-2CE350F18933", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.MDSNode_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "_MDSNode_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSNode_Constructor : INode 
	{
		public mdsUnitsLib.IMDSNode _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSNode;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "60CC9BCE-A10E-470E-AECB-2807F3C7ED40", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.MDSNode_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "_MDSNode_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSNode_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSNode _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSNode;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "E8E398D2-8F78-46C1-A076-53C02D31A6E2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование стыка", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Наименование стыка
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
		Id = "BFC1BD4F-12CC-4F62-8D4F-F327FDCB15CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование стыка", 
		ViewType = "Modifier")]
	[NodeInput("MDSNode", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Наименование стыка
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
		Id = "F29E5F67-17E1-4EB2-A3ED-8C03AC942059", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Точка вставки", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Точка вставки
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
		Id = "C25BAF0E-4FE0-4D91-ABA6-199533A1344F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Точка вставки", 
		ViewType = "Modifier")]
	[NodeInput("MDSNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Точка вставки
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
		Id = "371A6C51-D6EB-42CC-950B-15FEE40537EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Направление", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Направление
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
		Id = "F7725A33-52DE-4E87-92BE-AE3CDF18E64D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Направление", 
		ViewType = "Modifier")]
	[NodeInput("MDSNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Направление
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
		Id = "71249FBC-5E83-4872-AC26-FDDC9613B096", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Радиус", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Радиус
	///</summary>
	public class Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Radius);

		}
	}


	[NVP_Manifest(
		Id = "11EB3454-CD2A-4FA3-9696-0E7AE3862CCC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.Set_Radius", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "Set_Radius", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Радиус", 
		ViewType = "Modifier")]
	[NodeInput("MDSNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Радиус
	///</summary>
	public class Set_Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Radius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "10B54476-1595-46DC-9394-9BD61CEF9004", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.DirectionLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "DirectionLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина вектора направления", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Длина вектора направления
	///</summary>
	public class DirectionLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DirectionLength);

		}
	}


	[NVP_Manifest(
		Id = "CE49506A-04DE-4D34-9FB5-E142A4B30849", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.Set_DirectionLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "Set_DirectionLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина вектора направления", 
		ViewType = "Modifier")]
	[NodeInput("MDSNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Длина вектора направления
	///</summary>
	public class Set_DirectionLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DirectionLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "351D08B3-8F3A-4E63-A95C-932979A16A21", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

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
		Id = "FCCAA547-6E65-4C5A-8DAA-1D655923D4EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("MDSNode", typeof(object))]
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
		Id = "5B09C13C-6325-491E-A96F-38E3AC518744", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.NodeType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "NodeType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип стыка", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Тип стыка
	///</summary>
	public class NodeType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NodeType);

		}
	}


	[NVP_Manifest(
		Id = "43B29230-44E1-427C-923E-01A52EC56216", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.Set_NodeType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "Set_NodeType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип стыка", 
		ViewType = "Modifier")]
	[NodeInput("MDSNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип стыка
	///</summary>
	public class Set_NodeType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NodeType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1D4B46B4-158A-4440-82EF-BD7A954DFF97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.OwnerObject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "OwnerObject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Объект-владелец", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Объект-владелец
	///</summary>
	public class OwnerObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OwnerObject);

		}
	}


	[NVP_Manifest(
		Id = "23675789-9D60-4595-A694-C0975AE6BCF5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.HasOwner", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "HasOwner", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Существует ли объект-владелец", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Существует ли объект-владелец
	///</summary>
	public class HasOwner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasOwner);

		}
	}


	[NVP_Manifest(
		Id = "CB96F511-F946-48A3-BDD1-502B852B2FDD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.OwnerLink", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "OwnerLink", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Связь-владелец", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Связь-владелец
	///</summary>
	public class OwnerLink : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OwnerLink);

		}
	}


	[NVP_Manifest(
		Id = "A3E1747C-DB6E-4CEE-833E-F664615EDC80", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.HasOwnerLink", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "HasOwnerLink", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Существует ли связь-владелец", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Существует ли связь-владелец
	///</summary>
	public class HasOwnerLink : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasOwnerLink);

		}
	}


	[NVP_Manifest(
		Id = "2DE0A3DA-C64E-4A6A-9134-6711D2DF163D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.Links", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "Links", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Подключенные связи", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Подключенные связи
	///</summary>
	public class Links : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Links);

		}
	}


	[NVP_Manifest(
		Id = "03B7C32E-7A66-4516-936F-99E49011BABC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSNode.GetConnections", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSNode", 
		NodeName = "GetConnections", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Коллекция связанных объектов, удовлетворяющих условию", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Коллекция связанных объектов, удовлетворяющих условию
	///</summary>
	public class GetConnections : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetConnections);

		}
	}
}
