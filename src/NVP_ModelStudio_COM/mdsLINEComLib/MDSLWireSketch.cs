using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Провод
///</summary>
namespace mdsLINEComLib.MDSLWireSketch 
{

	[NVP_Manifest(
		Id = "2603F69B-E5AB-4BA6-A5F3-66B24A7E759F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.MDSLWireSketch_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "_MDSLWireSketch_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLWireSketch_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLWireSketch _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLWireSketch;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "2988475F-53DC-4F0B-871B-E0E944A20177", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.MDSLWireSketch_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "_MDSLWireSketch_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLWireSketch_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLWireSketch _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLWireSketch;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "5049AF60-10CE-4D40-915B-AB367CC5687A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
		Id = "CC0314F5-41EB-457F-81F3-AFDE95CA2969", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
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
		Id = "39E04E2F-D158-4007-8BF2-7F9254C79DA4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.WireBreak", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "WireBreak", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Аварийный обрыв", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Аварийный обрыв
	///</summary>
	public class WireBreak : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WireBreak);

		}
	}


	[NVP_Manifest(
		Id = "52CAF7CB-0767-48AC-A96B-6723CEF94E24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_WireBreak", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_WireBreak", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Аварийный обрыв", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Аварийный обрыв
	///</summary>
	public class Set_WireBreak : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WireBreak = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "07FC68EE-6B3C-41AB-83E4-E1B8C7C4ED13", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.StartPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "StartPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Начальная точка", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Начальная точка
	///</summary>
	public class StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartPoint);

		}
	}


	[NVP_Manifest(
		Id = "C7399088-B7CC-4EF5-B28F-16325F5195B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.EndPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "EndPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Конечная точка", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Конечная точка
	///</summary>
	public class EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndPoint);

		}
	}


	[NVP_Manifest(
		Id = "794CEB81-0CD0-4C50-8DE2-08C1BEF7618E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandStartEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandStartEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется первая гирлянда", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Имеется первая гирлянда
	///</summary>
	public class GarlandStartEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartEnabled);

		}
	}


	[NVP_Manifest(
		Id = "43D4ACC7-7291-4AEA-851E-CEF2233F3F25", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandStartEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandStartEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется первая гирлянда", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Имеется первая гирлянда
	///</summary>
	public class Set_GarlandStartEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "26D488E0-64C3-4849-A293-A61A1E9181AC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandStartLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandStartLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Длина первой гирлянды
	///</summary>
	public class GarlandStartLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartLength);

		}
	}


	[NVP_Manifest(
		Id = "D1BEE1D4-D4E5-4A54-86E8-6AA42CE62951", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandStartLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandStartLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина первой гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Длина первой гирлянды
	///</summary>
	public class Set_GarlandStartLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "21962877-9C57-46E0-B65D-2D7D89D7EAB1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandStartWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandStartWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса одной цепи первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Масса одной цепи первой гирлянды
	///</summary>
	public class GarlandStartWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartWeight);

		}
	}


	[NVP_Manifest(
		Id = "79A25428-CB23-497D-AB6F-4C7CA0E6B6D5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandStartDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandStartDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class GarlandStartDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartDiameter);

		}
	}


	[NVP_Manifest(
		Id = "10ED86C4-5DFF-4DFD-8593-81E262BB3CF0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandStartDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandStartDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///мм)
	///</summary>
	public class Set_GarlandStartDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartDiameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7E6C7C71-BC3E-47F4-8F69-7BC2E8F7E98A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandStartChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandStartChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число цепей изоляторов первой гирлянды
	///</summary>
	public class GarlandStartChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartChainCount);

		}
	}


	[NVP_Manifest(
		Id = "D9376AF9-645B-4B7F-B540-91E9834C96AE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandStartChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandStartChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов первой гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Число цепей изоляторов первой гирлянды
	///</summary>
	public class Set_GarlandStartChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartChainCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "79F63189-3379-4FC3-8AF6-A1BDC52F106F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandStartChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandStartChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Расположение цепей изоляторов первой гирлянды
	///</summary>
	public class GarlandStartChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartChainLayout);

		}
	}


	[NVP_Manifest(
		Id = "276EAA34-7843-45CD-9E7C-3EDCBA2EFF2F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandStartChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandStartChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов первой гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Расположение цепей изоляторов первой гирлянды
	///</summary>
	public class Set_GarlandStartChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartChainLayout = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "75319DEA-B9CE-4FB5-A694-9FA450E087AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandStartChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandStartChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Расстояние между цепями изоляторов первой гирлянды
	///</summary>
	public class GarlandStartChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartChainDistance);

		}
	}


	[NVP_Manifest(
		Id = "FC680ADA-8B4E-40A3-B224-6F1B3F086C95", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandStartChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandStartChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов первой гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расстояние между цепями изоляторов первой гирлянды
	///</summary>
	public class Set_GarlandStartChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartChainDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1F0F9563-4903-4AA9-AC15-3F8B85DE552E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandStartTotalWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandStartTotalWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Общая масса первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Общая масса первой гирлянды
	///</summary>
	public class GarlandStartTotalWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartTotalWeight);

		}
	}


	[NVP_Manifest(
		Id = "D047CB1B-CBF2-4EBF-9434-E84FB922CCBA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandStartBettaAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandStartBettaAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол наклона первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Угол наклона первой гирлянды
	///</summary>
	public class GarlandStartBettaAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartBettaAngle);

		}
	}


	[NVP_Manifest(
		Id = "AA4C0846-D7F7-4BFC-8D93-F28765DCBE05", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandEndEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandEndEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется вторая гирлянда", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Имеется вторая гирлянда
	///</summary>
	public class GarlandEndEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndEnabled);

		}
	}


	[NVP_Manifest(
		Id = "E326D151-EF31-49AC-BBA3-F10C7324967F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandEndEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandEndEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется вторая гирлянда", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Имеется вторая гирлянда
	///</summary>
	public class Set_GarlandEndEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "284B8DEE-C549-4EFD-AB7E-98A857DB437D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandEndLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandEndLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Длина второй гирлянды
	///</summary>
	public class GarlandEndLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndLength);

		}
	}


	[NVP_Manifest(
		Id = "7469492F-509E-435E-859F-691217213F50", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandEndLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandEndLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина второй гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Длина второй гирлянды
	///</summary>
	public class Set_GarlandEndLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AA0C31C1-DB30-4797-9F78-9C85294EBDCC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandEndWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandEndWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса одной цепи второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Масса одной цепи второй гирлянды
	///</summary>
	public class GarlandEndWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndWeight);

		}
	}


	[NVP_Manifest(
		Id = "631A490A-21CA-4264-8A5A-5E6BA2E57C6E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandEndDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandEndDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class GarlandEndDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndDiameter);

		}
	}


	[NVP_Manifest(
		Id = "7CD8FDDF-FA11-4FC2-A06A-64B48C8F2FE2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandEndDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandEndDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///мм)
	///</summary>
	public class Set_GarlandEndDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndDiameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C45F996A-88E4-4949-8BA5-6A974F3CADA5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandEndChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandEndChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число цепей изоляторов второй гирлянды
	///</summary>
	public class GarlandEndChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndChainCount);

		}
	}


	[NVP_Manifest(
		Id = "5765521E-70AC-4854-B2B0-A0732AD817F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandEndChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandEndChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов второй гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Число цепей изоляторов второй гирлянды
	///</summary>
	public class Set_GarlandEndChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndChainCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "49153F41-0390-42AF-A2B6-13BDA4593076", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandEndChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandEndChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Расположение цепей изоляторов второй гирлянды
	///</summary>
	public class GarlandEndChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndChainLayout);

		}
	}


	[NVP_Manifest(
		Id = "E2ED571F-A024-44DC-A766-0650FDC17588", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandEndChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandEndChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов второй гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Расположение цепей изоляторов второй гирлянды
	///</summary>
	public class Set_GarlandEndChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndChainLayout = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "665D62DF-6E57-4C79-B8EA-140D6F35F7D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandEndChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandEndChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Расстояние между цепями изоляторов второй гирлянды
	///</summary>
	public class GarlandEndChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndChainDistance);

		}
	}


	[NVP_Manifest(
		Id = "ADA6411E-F0A4-46E8-A09B-60706F47391F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandEndChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandEndChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов второй гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расстояние между цепями изоляторов второй гирлянды
	///</summary>
	public class Set_GarlandEndChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndChainDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "01489BAE-A791-4D4A-A084-E4E7D8BD77F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandEndTotalWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandEndTotalWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Общая масса второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Общая масса второй гирлянды
	///</summary>
	public class GarlandEndTotalWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndTotalWeight);

		}
	}


	[NVP_Manifest(
		Id = "5A6D0BB5-CC8A-4BA9-B288-63BFCCC1E7A2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandEndBettaAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandEndBettaAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол наклона второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Угол наклона второй гирлянды
	///</summary>
	public class GarlandEndBettaAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndBettaAngle);

		}
	}


	[NVP_Manifest(
		Id = "9EEEFD43-BFB3-4C93-90BF-7BA6A49A1524", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandIntermEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandIntermEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеются промежуточные гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Имеются промежуточные гирлянды
	///</summary>
	public class GarlandIntermEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermEnabled);

		}
	}


	[NVP_Manifest(
		Id = "E4FDBE6F-2809-4BFC-8638-628E7DEE6C1D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandIntermEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandIntermEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеются промежуточные гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Имеются промежуточные гирлянды
	///</summary>
	public class Set_GarlandIntermEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandIntermEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8E4A2B2A-F981-4A70-B346-78AF2E7D9109", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandIntermCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandIntermCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Количество промежуточных гирлянд", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Количество промежуточных гирлянд
	///</summary>
	public class GarlandIntermCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermCount);

		}
	}


	[NVP_Manifest(
		Id = "D28888E5-F200-48B9-A0FF-04975AD67326", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandIntermInsulatorType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandIntermInsulatorType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип изолятора", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class GarlandIntermInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermInsulatorType);

		}
	}


	[NVP_Manifest(
		Id = "575A27BD-6B78-4C79-8BC0-2A4DD0B7D5EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandIntermInsulatorType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandIntermInsulatorType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип изолятора", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class Set_GarlandIntermInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandIntermInsulatorType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7FA30B4B-C82F-4B96-90CD-782446DC2B15", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandIntermLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandIntermLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина промежуточной гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Длина промежуточной гирлянды
	///</summary>
	public class GarlandIntermLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermLength);

		}
	}


	[NVP_Manifest(
		Id = "53D71561-494B-417C-A2D3-1AAD349DE56F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandIntermLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandIntermLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина промежуточной гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Длина промежуточной гирлянды
	///</summary>
	public class Set_GarlandIntermLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandIntermLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6AF17E64-8D16-4D92-8E07-BBF2CA3C10FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandIntermWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandIntermWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса одной цепи промежуточной гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Масса одной цепи промежуточной гирлянды
	///</summary>
	public class GarlandIntermWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermWeight);

		}
	}


	[NVP_Manifest(
		Id = "311CCF24-293B-49EE-A479-535A1C4022E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandIntermDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandIntermDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class GarlandIntermDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermDiameter);

		}
	}


	[NVP_Manifest(
		Id = "E6A48250-8459-4D03-89CF-881869A9D517", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandIntermDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandIntermDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///мм)
	///</summary>
	public class Set_GarlandIntermDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandIntermDiameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BF0ACC3C-3941-4A1A-A255-6E04A0B95720", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandIntermChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandIntermChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов промежуточной гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число цепей изоляторов промежуточной гирлянды
	///</summary>
	public class GarlandIntermChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermChainCount);

		}
	}


	[NVP_Manifest(
		Id = "DD1B621F-EA25-43C2-9A20-858394CD78EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandIntermChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandIntermChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов промежуточной гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Число цепей изоляторов промежуточной гирлянды
	///</summary>
	public class Set_GarlandIntermChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandIntermChainCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4DD15B40-0E22-4CEB-8738-65EFD654A52B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandIntermChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandIntermChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов промежуточной гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Расположение цепей изоляторов промежуточной гирлянды
	///</summary>
	public class GarlandIntermChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermChainLayout);

		}
	}


	[NVP_Manifest(
		Id = "7DBF4C45-8E05-43A2-BF77-8582B0F4CA27", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandIntermChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandIntermChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов промежуточной гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Расположение цепей изоляторов промежуточной гирлянды
	///</summary>
	public class Set_GarlandIntermChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandIntermChainLayout = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3B0848FB-F714-4EF5-94E2-0F4C51AAA65E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandIntermChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandIntermChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов промежуточной гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Расстояние между цепями изоляторов промежуточной гирлянды
	///</summary>
	public class GarlandIntermChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermChainDistance);

		}
	}


	[NVP_Manifest(
		Id = "0E6D6065-AB9A-4E4C-92AD-26DF9DE810F3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_GarlandIntermChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_GarlandIntermChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов промежуточной гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Расстояние между цепями изоляторов промежуточной гирлянды
	///</summary>
	public class Set_GarlandIntermChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandIntermChainDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2C026B32-D312-4CED-818C-1C71AD7D08CF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandIntermTotalWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandIntermTotalWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Общая масса промежуточной гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Общая масса промежуточной гирлянды
	///</summary>
	public class GarlandIntermTotalWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermTotalWeight);

		}
	}


	[NVP_Manifest(
		Id = "EE4A9E34-B988-42A6-B10C-7F03E45D131D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GarlandIntermBettaAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GarlandIntermBettaAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол наклона промежуточной гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Угол наклона промежуточной гирлянды
	///</summary>
	public class GarlandIntermBettaAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermBettaAngle);

		}
	}


	[NVP_Manifest(
		Id = "A4A2C728-373E-45C9-9787-2C3310FEE711", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.LinkName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "LinkName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование - провод", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Наименование - провод
	///</summary>
	public class LinkName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinkName);

		}
	}


	[NVP_Manifest(
		Id = "465350BB-FF56-4815-9A88-590F2D9E4F1E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.StartGarlandName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "StartGarlandName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование - первая гирлянда", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Наименование - первая гирлянда
	///</summary>
	public class StartGarlandName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartGarlandName);

		}
	}


	[NVP_Manifest(
		Id = "80703C7D-8F27-4B16-B382-C516D9C7501A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.EndGarlandName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "EndGarlandName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование - вторая гирлянда", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Наименование - вторая гирлянда
	///</summary>
	public class EndGarlandName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndGarlandName);

		}
	}


	[NVP_Manifest(
		Id = "A9034AA8-772A-4B9E-874D-9ADE51300455", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SuppressorName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SuppressorName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование - гаситель вибрации", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Наименование - гаситель вибрации
	///</summary>
	public class SuppressorName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressorName);

		}
	}


	[NVP_Manifest(
		Id = "185A6B65-9DAD-46E7-8707-191CE4711845", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SuppressorEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SuppressorEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наличие", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Наличие
	///</summary>
	public class SuppressorEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressorEnabled);

		}
	}


	[NVP_Manifest(
		Id = "2CA8A3DC-B690-47D1-AC2A-F9787B8DB04E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_SuppressorEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_SuppressorEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наличие", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Наличие
	///</summary>
	public class Set_SuppressorEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SuppressorEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EE4F418F-2F94-4C44-8CA7-B0596FD8921A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SuppressorCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SuppressorCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Количество", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Количество
	///</summary>
	public class SuppressorCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressorCount);

		}
	}


	[NVP_Manifest(
		Id = "720E22A7-12CD-4DF6-AACD-AE50D11D3788", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Suppressors", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Suppressors", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Гасители", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Гасители
	///</summary>
	public class Suppressors : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Suppressors);

		}
	}


	[NVP_Manifest(
		Id = "83E670D7-05B8-46CC-83A3-8E64059DE7A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_Suppressors", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_Suppressors", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Гасители", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Гасители
	///</summary>
	public class Set_Suppressors : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Suppressors = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7052B5BB-B44B-457E-BB94-C28E4146BD80", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SuppressorS1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SuppressorS1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Место установки S1", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Место установки S1
	///</summary>
	public class SuppressorS1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressorS1);

		}
	}


	[NVP_Manifest(
		Id = "DF7BABC7-D3CC-4BCA-8CEC-A0146F6D4958", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SuppressorS2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SuppressorS2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Место установки S2", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Место установки S2
	///</summary>
	public class SuppressorS2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressorS2);

		}
	}


	[NVP_Manifest(
		Id = "89333685-1F4A-4128-9172-95C034AD65F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SuppressorS3", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SuppressorS3", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Место установки S3", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Место установки S3
	///</summary>
	public class SuppressorS3 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressorS3);

		}
	}


	[NVP_Manifest(
		Id = "97962F74-0D7F-419E-9D91-2DA99626A6FD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SuppressorS4", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SuppressorS4", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Место установки S4", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Место установки S4
	///</summary>
	public class SuppressorS4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressorS4);

		}
	}


	[NVP_Manifest(
		Id = "BED4E53B-055F-4487-B5FB-17A449D9A440", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.PowerUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "PowerUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Единицы измерения силы", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Единицы измерения силы
	///</summary>
	public class PowerUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PowerUnits);

		}
	}


	[NVP_Manifest(
		Id = "1932CA1E-090C-40E0-B63A-8EAF5F007366", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_PowerUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_PowerUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Единицы измерения силы", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Единицы измерения силы
	///</summary>
	public class Set_PowerUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PowerUnits = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D6C9AC20-2575-4D36-BB6A-9E8213F41709", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Model", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Model", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Модель провода", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Модель провода
	///</summary>
	public class Model : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Model);

		}
	}


	[NVP_Manifest(
		Id = "DA3E4249-3499-48E3-B9C4-5948CAD0C0CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Section", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Section", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "кв. мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///кв. мм)
	///</summary>
	public class Section : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Section);

		}
	}


	[NVP_Manifest(
		Id = "037A37DB-0DAC-4D69-98A6-EA90D429DF5D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Diameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Diameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///мм)
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
		Id = "15C5DEFD-B98A-49B5-8EB3-255DFEF4AFA4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Mass", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Mass", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "кг/км)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///кг/км)
	///</summary>
	public class Mass : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Mass);

		}
	}


	[NVP_Manifest(
		Id = "E1DE1700-D2AB-44B0-AE0C-2FEF49DE8EE7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SigmaTn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SigmaTn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Сигма tн", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Сигма tн
	///</summary>
	public class SigmaTn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SigmaTn);

		}
	}


	[NVP_Manifest(
		Id = "E5AB633E-8142-46FC-9A7D-12AF448154FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SigmaTm", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SigmaTm", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Сигма tм", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Сигма tм
	///</summary>
	public class SigmaTm : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SigmaTm);

		}
	}


	[NVP_Manifest(
		Id = "A8D9B02E-6C50-4121-9DE7-A5D6658C605E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SigmaTe", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SigmaTe", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Сигма tэ", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Сигма tэ
	///</summary>
	public class SigmaTe : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SigmaTe);

		}
	}


	[NVP_Manifest(
		Id = "D207DD7E-5B48-42A3-96CB-88E7232778DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.E", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "E", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "E - модуль упругости", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///E - модуль упругости
	///</summary>
	public class E : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.E);

		}
	}


	[NVP_Manifest(
		Id = "8D086ED7-3E0D-4F64-8CB7-AA174D31471D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.F", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "F", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Мод. нач. F", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Мод. нач. F
	///</summary>
	public class F : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.F);

		}
	}


	[NVP_Manifest(
		Id = "968CEBC4-6220-441B-8388-769570B69E8C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.D", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "D", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Мод. пред. F", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Мод. пред. F
	///</summary>
	public class D : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.D);

		}
	}


	[NVP_Manifest(
		Id = "011CCB26-3C27-406D-AD2B-F5B6FC615770", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Alpha", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Alpha", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "1e-6/град. С)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///1e-6/град. С)
	///</summary>
	public class Alpha : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Alpha);

		}
	}


	[NVP_Manifest(
		Id = "470D9A20-7A76-4A0D-824B-8BB8AF350E8C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.FactoryLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "FactoryLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "м)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///м)
	///</summary>
	public class FactoryLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FactoryLength);

		}
	}


	[NVP_Manifest(
		Id = "F14B4387-18CE-4A18-B5D8-10595E501157", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SplitPhase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SplitPhase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число проводов расщепленной фазы", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число проводов расщепленной фазы
	///</summary>
	public class SplitPhase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SplitPhase);

		}
	}


	[NVP_Manifest(
		Id = "C1778639-2FFA-471F-BF06-8EED63594319", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_SplitPhase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_SplitPhase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число проводов расщепленной фазы", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Число проводов расщепленной фазы
	///</summary>
	public class Set_SplitPhase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SplitPhase = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8321FE79-9AEB-46B2-9465-5B3265DA947E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SplitDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SplitDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class SplitDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SplitDistance);

		}
	}


	[NVP_Manifest(
		Id = "8395623C-FBC5-465B-9562-A2C32D1D335E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_SplitDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_SplitDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///мм)
	///</summary>
	public class Set_SplitDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SplitDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C26B5267-D7FE-4E23-9FAE-D7A66614F44E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.ClampingDensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "ClampingDensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число стяжек на 10 м", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число стяжек на 10 м
	///</summary>
	public class ClampingDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClampingDensity);

		}
	}


	[NVP_Manifest(
		Id = "FDC55206-E45F-4D24-8E5F-91344EB464BF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_ClampingDensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_ClampingDensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число стяжек на 10 м", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Число стяжек на 10 м
	///</summary>
	public class Set_ClampingDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClampingDensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1DF691C5-18C7-4773-975E-676CEB699642", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.ClampingWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "ClampingWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса стяжек", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Масса стяжек
	///</summary>
	public class ClampingWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClampingWeight);

		}
	}


	[NVP_Manifest(
		Id = "9A36CD30-E6AE-4FE9-A2A6-3B9321B2895D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_ClampingWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_ClampingWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса стяжек", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Масса стяжек
	///</summary>
	public class Set_ClampingWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClampingWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "07190FC0-1F45-4B42-B84E-1D07EBAB55AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.phaseName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "phaseName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Фаза для расчета", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Фаза для расчета
	///</summary>
	public class phaseName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.phaseName);

		}
	}


	[NVP_Manifest(
		Id = "F22A1014-F7EA-4E6F-AA9D-811E8ED0E902", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_phaseName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_phaseName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Фаза для расчета", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Фаза для расчета
	///</summary>
	public class Set_phaseName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.phaseName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "377205F7-68F5-44DA-95A5-C3C5DCAB5F14", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.TotalResultDataMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "TotalResultDataMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Режим отображения результатов", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Режим отображения результатов
	///</summary>
	public class TotalResultDataMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TotalResultDataMode);

		}
	}


	[NVP_Manifest(
		Id = "2A5F84EB-E813-4DD1-A4F3-77FEFD235300", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_TotalResultDataMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_TotalResultDataMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Режим отображения результатов", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Режим отображения результатов
	///</summary>
	public class Set_TotalResultDataMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TotalResultDataMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B9452FF9-3A1D-4257-AE13-FBFDD57C86F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.InitialModeStatus", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "InitialModeStatus", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Статус расчета исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Статус расчета исходного режима
	///</summary>
	public class InitialModeStatus : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialModeStatus);

		}
	}


	[NVP_Manifest(
		Id = "A1F6D0CA-A1C5-40AF-B8A4-E366C15487F1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.InitialModeOption", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "InitialModeOption", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Выбор исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Выбор исходного режима
	///</summary>
	public class InitialModeOption : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialModeOption);

		}
	}


	[NVP_Manifest(
		Id = "706DE8F5-C788-4CB6-A32D-EF4CFFE1C01E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_InitialModeOption", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_InitialModeOption", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Выбор исходного режима", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Выбор исходного режима
	///</summary>
	public class Set_InitialModeOption : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InitialModeOption = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FABEAD10-7AB0-4D0C-A368-E46297C4749E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.InitialModeName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "InitialModeName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Название исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Название исходного режима
	///</summary>
	public class InitialModeName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialModeName);

		}
	}


	[NVP_Manifest(
		Id = "EC8AE382-253D-4A36-BED9-457871C288EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.InitialModeSigma", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "InitialModeSigma", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Сигма исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Сигма исходного режима
	///</summary>
	public class InitialModeSigma : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialModeSigma);

		}
	}


	[NVP_Manifest(
		Id = "3504D41E-2AC7-4518-874C-77BC1E97DA4B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.InitialModeGamma", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "InitialModeGamma", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Гамма исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Гамма исходного режима
	///</summary>
	public class InitialModeGamma : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialModeGamma);

		}
	}


	[NVP_Manifest(
		Id = "D93CEB40-C10A-4B0E-A13A-319FB9C8FB57", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.InitialModeT", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "InitialModeT", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Температура исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Температура исходного режима
	///</summary>
	public class InitialModeT : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialModeT);

		}
	}


	[NVP_Manifest(
		Id = "00426C1E-2F21-4014-9D97-A0651838640C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Critical_1_SpanLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Critical_1_SpanLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "1й критический пролет", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///1й критический пролет
	///</summary>
	public class Critical_1_SpanLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Critical_1_SpanLength);

		}
	}


	[NVP_Manifest(
		Id = "B3492D80-1F4E-4099-AF1F-0A2F486B2CD6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Critical_2_SpanLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Critical_2_SpanLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "2й критический пролет", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///2й критический пролет
	///</summary>
	public class Critical_2_SpanLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Critical_2_SpanLength);

		}
	}


	[NVP_Manifest(
		Id = "560793FF-D1A1-4065-97AA-44570ED71D1F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Critical_3_SpanLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Critical_3_SpanLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "3й критический пролет", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///3й критический пролет
	///</summary>
	public class Critical_3_SpanLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Critical_3_SpanLength);

		}
	}


	[NVP_Manifest(
		Id = "37AA4723-864E-417C-9112-876F9A8855A2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.MaxStressLimitation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "MaxStressLimitation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ограничение допустимого напряжения", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Ограничение допустимого напряжения
	///</summary>
	public class MaxStressLimitation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaxStressLimitation);

		}
	}


	[NVP_Manifest(
		Id = "BB1FCA76-8D7E-4341-A44D-1D2BA1E0F3C8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_MaxStressLimitation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_MaxStressLimitation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ограничение допустимого напряжения", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Ограничение допустимого напряжения
	///</summary>
	public class Set_MaxStressLimitation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MaxStressLimitation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "560D8034-987D-4624-858A-FE24D9FBD0BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.StressLim_MaxLoad", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "StressLim_MaxLoad", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Доп. напряжение в режиме максимальной нагрузки", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Доп. напряжение в режиме максимальной нагрузки
	///</summary>
	public class StressLim_MaxLoad : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StressLim_MaxLoad);

		}
	}


	[NVP_Manifest(
		Id = "7A0AE575-B08B-4E86-B329-D01F6010AE86", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_StressLim_MaxLoad", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_StressLim_MaxLoad", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Доп. напряжение в режиме максимальной нагрузки", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Доп. напряжение в режиме максимальной нагрузки
	///</summary>
	public class Set_StressLim_MaxLoad : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StressLim_MaxLoad = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "034AD1A0-8EF9-4C06-9676-784995559E3B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.StressLim_MinTemp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "StressLim_MinTemp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Доп. напряжение в режиме минимальной температуры", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Доп. напряжение в режиме минимальной температуры
	///</summary>
	public class StressLim_MinTemp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StressLim_MinTemp);

		}
	}


	[NVP_Manifest(
		Id = "08CDCEC0-1BAA-4C55-8787-BE8C9E7BE841", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_StressLim_MinTemp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_StressLim_MinTemp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Доп. напряжение в режиме минимальной температуры", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Доп. напряжение в режиме минимальной температуры
	///</summary>
	public class Set_StressLim_MinTemp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StressLim_MinTemp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C95BF7A2-2EDD-4AC7-A984-81721FFE9FF7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.StressLim_MidYear", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "StressLim_MidYear", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Доп. напряжение для среднегодового режима", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Доп. напряжение для среднегодового режима
	///</summary>
	public class StressLim_MidYear : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StressLim_MidYear);

		}
	}


	[NVP_Manifest(
		Id = "214D6354-8B50-4CEF-A40A-EF2B4BECB803", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_StressLim_MidYear", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_StressLim_MidYear", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Доп. напряжение для среднегодового режима", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Доп. напряжение для среднегодового режима
	///</summary>
	public class Set_StressLim_MidYear : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StressLim_MidYear = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4B8572BD-AC44-4835-919D-B07C5AD85D32", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.CalculationError", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "CalculationError", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ошибка при расчете провода", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Ошибка при расчете провода
	///</summary>
	public class CalculationError : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CalculationError);

		}
	}


	[NVP_Manifest(
		Id = "EFB16DAA-7DD8-4A21-9811-26E1845D4D14", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.ModeIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "ModeIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Режим расчета", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Режим расчета
	///</summary>
	public class ModeIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ModeIndex);

		}
	}


	[NVP_Manifest(
		Id = "86CB079E-B0FB-4F67-8114-CC67AC747D9A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_ModeIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_ModeIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Режим расчета", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Режим расчета
	///</summary>
	public class Set_ModeIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ModeIndex = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "31208810-7C5B-498A-9E27-732720F0EFAC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SigmaCoeff", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SigmaCoeff", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Н/м*кв.мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Н/м*кв.мм)
	///</summary>
	public class SigmaCoeff : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SigmaCoeff);

		}
	}


	[NVP_Manifest(
		Id = "1907C14A-6A63-4ECB-AD24-8B161A0644B9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Stress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Stress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тяжения в расчетном режиме", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Тяжения в расчетном режиме
	///</summary>
	public class Stress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Stress);

		}
	}


	[NVP_Manifest(
		Id = "BA19D641-7241-4200-BAD3-C45774BFA1C0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GammaCoeff", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GammaCoeff", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нагрузка на провод в расчетном режиме", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Нагрузка на провод в расчетном режиме
	///</summary>
	public class GammaCoeff : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GammaCoeff);

		}
	}


	[NVP_Manifest(
		Id = "909D1264-E6E8-4510-966F-79932C4C96C8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SlackMax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SlackMax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Максимальная стрела провеса в расч. режиме", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Максимальная стрела провеса в расч. режиме
	///</summary>
	public class SlackMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlackMax);

		}
	}


	[NVP_Manifest(
		Id = "8146D98F-113D-4625-8E89-E975F7B60D91", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Slack", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Slack", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Стрела провеса", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Стрела провеса
	///</summary>
	public class Slack : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Slack);

		}
	}


	[NVP_Manifest(
		Id = "38C8D153-F1C2-478F-A375-CC361EC21EB2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.CentroidHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "CentroidHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Приведенный центр тяжести", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Приведенный центр тяжести
	///</summary>
	public class CentroidHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CentroidHeight);

		}
	}


	[NVP_Manifest(
		Id = "2837F27C-2E7F-45DC-9646-5F9C448FA031", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.LengthSection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "LengthSection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина анкерного участка", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Длина анкерного участка
	///</summary>
	public class LengthSection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LengthSection);

		}
	}


	[NVP_Manifest(
		Id = "4487ABFA-CCFA-4005-BA14-A28CB4262D80", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SpanLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SpanLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Приведенный пролет", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Приведенный пролет
	///</summary>
	public class SpanLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SpanLength);

		}
	}


	[NVP_Manifest(
		Id = "8AC03492-D111-41EA-8F19-559D7B668958", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GabaritSpanLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GabaritSpanLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Габаритный пролет", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Габаритный пролет
	///</summary>
	public class GabaritSpanLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GabaritSpanLength);

		}
	}


	[NVP_Manifest(
		Id = "F24C4897-2996-4BFA-A7EF-81D97A47C39E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GabaritCalcMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GabaritCalcMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Режим расчета габаритного пролета", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Режим расчета габаритного пролета
	///</summary>
	public class GabaritCalcMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GabaritCalcMode);

		}
	}


	[NVP_Manifest(
		Id = "85AD11A4-BEBE-4D4F-A468-5309E251B901", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.LengthMax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "LengthMax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "м)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///м)
	///</summary>
	public class LengthMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LengthMax);

		}
	}


	[NVP_Manifest(
		Id = "8C98C183-2193-4577-A355-E056834AC556", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.WindAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "WindAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол отклонения ветром", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Угол отклонения ветром
	///</summary>
	public class WindAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindAngle);

		}
	}


	[NVP_Manifest(
		Id = "59C90EDB-509C-4005-B607-9994495E81A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.ChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "ChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число цепей
	///</summary>
	public class ChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ChainCount);

		}
	}


	[NVP_Manifest(
		Id = "DED27C38-B0FF-42FE-B23D-01699B8FF17E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_ChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_ChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Число цепей
	///</summary>
	public class Set_ChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ChainCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2C1961DD-04F3-4394-9EFA-29FF00940889", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.PhaseCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "PhaseCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число фаз", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число фаз
	///</summary>
	public class PhaseCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PhaseCount);

		}
	}


	[NVP_Manifest(
		Id = "08FBFA84-4848-4236-8D30-AB72DED6076A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.LengthPhase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "LengthPhase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "м)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///м)
	///</summary>
	public class LengthPhase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LengthPhase);

		}
	}


	[NVP_Manifest(
		Id = "E433E785-34B8-45AF-A331-6D8736033B2B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "м)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("phaseName", typeof(System.Object))]

	///<summary>
	///м)
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "88107576-6C7A-4460-89B6-51025997099C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.CountWire", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "CountWire", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число проводов", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число проводов
	///</summary>
	public class CountWire : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CountWire);

		}
	}


	[NVP_Manifest(
		Id = "F60B6462-0EC1-4BE1-8412-7FBEFDCF75CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.CountSpan", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "CountSpan", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число пролетов", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число пролетов
	///</summary>
	public class CountSpan : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CountSpan);

		}
	}


	[NVP_Manifest(
		Id = "A943E257-4BEF-422B-B677-6B9BB04BA5A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Chains", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Chains", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число цепей
	///</summary>
	public class Chains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Chains);

		}
	}


	[NVP_Manifest(
		Id = "5472E8AA-7A44-4B91-8396-CEBA448B2B1F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Phases", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Phases", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число фаз", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число фаз
	///</summary>
	public class Phases : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Phases);

		}
	}


	[NVP_Manifest(
		Id = "5BFB59F7-95D4-43AA-9E01-7150E70ECAAD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SupportStressMax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SupportStressMax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Допустимое тяжение для опоры", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Допустимое тяжение для опоры
	///</summary>
	public class SupportStressMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SupportStressMax);

		}
	}


	[NVP_Manifest(
		Id = "A97DFC87-2284-4B6F-8C31-B2FE61A36358", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GammaStdNorm", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GammaStdNorm", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нормативные нагрузки", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Нормативные нагрузки
	///</summary>
	public class GammaStdNorm : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GammaStdNorm);

		}
	}


	[NVP_Manifest(
		Id = "3CB3C9E1-8591-4C24-9C0B-274D67814C82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GammaStdCalc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GammaStdCalc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расчетные нагрузки", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Расчетные нагрузки
	///</summary>
	public class GammaStdCalc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GammaStdCalc);

		}
	}


	[NVP_Manifest(
		Id = "439D4A4B-04C2-4F46-A236-DF173CF72C1B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.GammaStdSpec", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "GammaStdSpec", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Удельные расчетные нагрузки", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Удельные расчетные нагрузки
	///</summary>
	public class GammaStdSpec : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GammaStdSpec);

		}
	}


	[NVP_Manifest(
		Id = "F7CA3698-B2E8-4736-8C93-1A2D435BBEDA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.climateData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "climateData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method climateData", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///method climateData
	///</summary>
	public class climateData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.climateData);

		}
	}


	[NVP_Manifest(
		Id = "F82821AB-28F1-4E85-80D9-2E4E3209698C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Calculate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Calculate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Calculate mode by temp, wind, ice", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("Temperature", typeof(System.Double))]
	[NodeInput("Wind", typeof(System.Double))]
	[NodeInput("Ice", typeof(System.Double))]

	///<summary>
	///Calculate mode by temp, wind, ice
	///</summary>
	public class Calculate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Calculate(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "C34E8EAA-4261-4EDF-AC10-F94308957FEC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.CalculateMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "CalculateMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "CalculateMode by mode name", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("modeName", typeof(System.String))]

	///<summary>
	///CalculateMode by mode name
	///</summary>
	public class CalculateMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CalculateMode(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "4B5F77C4-19A6-4B4C-B9E8-F92659784B4C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Element1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Element1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Пролеты", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Пролеты
	///</summary>
	public class Element1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element1);

		}
	}


	[NVP_Manifest(
		Id = "F4EB6930-A826-4C91-8A7B-3AE048E52E6C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Set_Element1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Set_Element1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Пролеты", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Пролеты
	///</summary>
	public class Set_Element1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2B250491-DE67-4212-A684-E94A8502BD57", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.NodeStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "NodeStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NodeStart", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///property NodeStart
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
		Id = "955241A0-A647-4EBC-B093-7CAC07252924", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.NodeEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "NodeEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NodeEnd", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///property NodeEnd
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
		Id = "43D28FAD-8BF7-44B9-B313-50451E5E00F3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.Nodes", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "Nodes", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Nodes", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///property Nodes
	///</summary>
	public class Nodes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Nodes);

		}
	}


	[NVP_Manifest(
		Id = "AF9A5A65-DEB0-4313-80AE-FCE20BB99126", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.BearingStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "BearingStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property BearingStart", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///property BearingStart
	///</summary>
	public class BearingStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BearingStart);

		}
	}


	[NVP_Manifest(
		Id = "0775E97F-CB44-4FEF-8F0A-DCD657205EA2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.BearingEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "BearingEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property BearingEnd", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///property BearingEnd
	///</summary>
	public class BearingEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BearingEnd);

		}
	}


	[NVP_Manifest(
		Id = "B0E0191E-4C70-4EE0-B522-5731B5BBFD03", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.IsTros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "IsTros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property IsTros", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///property IsTros
	///</summary>
	public class IsTros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsTros);

		}
	}


	[NVP_Manifest(
		Id = "10EFC192-7ADB-43C5-83E7-5A0F1F840250", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.PowerCoefficient", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "PowerCoefficient", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Единицы измерения силы", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Единицы измерения силы
	///</summary>
	public class PowerCoefficient : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PowerCoefficient);

		}
	}


	[NVP_Manifest(
		Id = "8C758919-CD56-42BF-BDB4-25C01241FA2B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.ExistTros", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "ExistTros", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "ExistTros", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///ExistTros
	///</summary>
	public class ExistTros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExistTros);

		}
	}


	[NVP_Manifest(
		Id = "25FD2031-5E10-4EBF-A42D-7FC875721586", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.TrosInSection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "TrosInSection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TrosInSection", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///TrosInSection
	///</summary>
	public class TrosInSection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TrosInSection);

		}
	}


	[NVP_Manifest(
		Id = "1005B74E-B7B5-4EA5-BF9F-987C45A43F47", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.owner", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "owner", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method owner", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///method owner
	///</summary>
	public class owner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.owner);

		}
	}


	[NVP_Manifest(
		Id = "0C638CC0-8C7E-4795-9023-D0A73C936ED3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.IsOptical", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "IsOptical", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property IsOptical", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///property IsOptical
	///</summary>
	public class IsOptical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsOptical);

		}
	}


	[NVP_Manifest(
		Id = "D80FB939-C5F8-4194-B99B-3426DEC61CFC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.ExistOptical", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "ExistOptical", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "ExistOptical", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///ExistOptical
	///</summary>
	public class ExistOptical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExistOptical);

		}
	}


	[NVP_Manifest(
		Id = "971D1543-5B62-44B5-88B6-070921D61BCE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.OpticalInSection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "OpticalInSection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "OpticalInSection", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///OpticalInSection
	///</summary>
	public class OpticalInSection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OpticalInSection);

		}
	}


	[NVP_Manifest(
		Id = "A57E12C0-50E2-4333-B5A8-4077F00A1054", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.TypeLink", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "TypeLink", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TypeLink", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///TypeLink
	///</summary>
	public class TypeLink : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TypeLink);

		}
	}


	[NVP_Manifest(
		Id = "502786A5-7FB8-4145-9FC1-49D9FC27E592", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.CurrentModeData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "CurrentModeData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method CurrentModeData", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///method CurrentModeData
	///</summary>
	public class CurrentModeData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurrentModeData);

		}
	}


	[NVP_Manifest(
		Id = "6B79E85B-BC3E-4DEC-B86C-17C7AEB92799", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.MinPoint_X", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "MinPoint_X", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method MinPoint_X", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("nSpanNum", typeof(System.Object))]

	///<summary>
	///method MinPoint_X
	///</summary>
	public class MinPoint_X : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinPoint_X(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "78AD958F-DC9D-4DF8-9D15-AB0888450842", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.MinPoint_Y", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "MinPoint_Y", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method MinPoint_Y", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("nSpanNum", typeof(System.Object))]

	///<summary>
	///method MinPoint_Y
	///</summary>
	public class MinPoint_Y : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinPoint_Y(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "B6EBA398-6FDD-47B6-92ED-8F4EB64D0678", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SlackSpanMiddle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SlackSpanMiddle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method SlackSpanMiddle", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("nSpan", typeof(System.Object))]
	[NodeInput("fTemper", typeof(System.Double))]

	///<summary>
	///method SlackSpanMiddle
	///</summary>
	public class SlackSpanMiddle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlackSpanMiddle(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "3202602F-6A5E-4FB0-A28C-F6CE0ED6E318", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.SlackSpanMount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "SlackSpanMount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расчет монтажных стрел с учетом вытяжки", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("nSpan", typeof(System.Object))]
	[NodeInput("fTemper", typeof(System.Double))]

	///<summary>
	///Расчет монтажных стрел с учетом вытяжки
	///</summary>
	public class SlackSpanMount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlackSpanMount(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "93D21FDD-C286-4E19-8B6A-3E3EC6B9DC23", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.StressMount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "StressMount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расчет монтажных напряжений", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("fTemper", typeof(System.Double))]

	///<summary>
	///Расчет монтажных напряжений
	///</summary>
	public class StressMount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StressMount(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "88B569D1-5995-4731-B00D-407B80782839", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLWireSketch.CalcCoeffs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLWireSketch", 
		NodeName = "CalcCoeffs", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Коэффициенты расчетных формул", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Коэффициенты расчетных формул
	///</summary>
	public class CalcCoeffs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CalcCoeffs);

		}
	}
}
