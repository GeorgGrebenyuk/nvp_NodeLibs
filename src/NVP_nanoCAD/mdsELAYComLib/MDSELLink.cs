using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSELLink Interface
///</summary>
namespace mdsELAYComLib.MDSELLink 
{

	[NVP_Manifest(
		Id = "86F247D1-2390-4409-ADCE-50FAFB6CDF70", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.MDSELLink_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "_MDSELLink_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSELLink_Constructor : INode 
	{
		public mdsELAYComLib.IMDSELLink _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsELAYComLib.IMDSELLink;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "4E62F4F5-494A-4B0C-ACD1-D02C336777B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.MDSELLink_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "_MDSELLink_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSELLink_ConstructorCast : INode 
	{
		public mdsELAYComLib.IMDSELLink _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsELAYComLib.IMDSELLink;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "34EE9240-FD6F-413E-A402-ADBEAF50EBEE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "E60FEA68-61CE-4897-8EDE-F1565EA2C4C5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "44BBEA8B-77A7-4A84-BC8E-A67EA124E111", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.StartPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "StartPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Начальная точка", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "A38C2140-D08E-431E-BF40-37A29540154A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.EndPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "EndPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Конечная точка", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "E8A3F4CD-EAD2-42EE-A183-87F5E816D1F0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandStartEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandStartEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется первая гирлянда", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "90ADBD58-BB1D-4B78-87FA-CA8115A4DCBE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandStartEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandStartEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется первая гирлянда", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "DA01AB14-735A-4F94-A2FE-E0AFBD5749B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandStartLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandStartLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "B737DCFC-F63F-421A-A582-7853CA37D1ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandStartLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandStartLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина первой гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "731ABCEB-FFEC-4B1B-9DF7-F7C188444396", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandStartWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandStartWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "z гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///z гирлянды
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
		Id = "A95BE386-DC5F-467E-9394-3EFF05BB1190", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandStartDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandStartDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "B8C92DC0-CB55-46F7-B5E4-E71AB0B9B884", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandStartDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandStartDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "4824D073-E543-4137-9BEF-03A0A5E34B79", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandStartChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandStartChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "A24BA3F6-6EE6-455D-90AA-D6F6C5BDAE06", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandStartChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandStartChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов первой гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "59DF1103-1874-45B8-9191-334A4C14EAB7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandStartChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandStartChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "54020653-4964-4523-8D8F-B10611C2A617", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandStartChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandStartChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов первой гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "1D9593E9-D32C-41F1-A14A-6C51C3CF3E51", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandStartChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandStartChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "4A0BE76A-CCF1-43C4-BAB7-77065B927D85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandStartChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandStartChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов первой гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "6CE6615E-234B-4AA0-A8E8-55AC58752035", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandStartTotalWeightWithoutIce", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandStartTotalWeightWithoutIce", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса первой гирлянды без гололеда, кгс", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Масса первой гирлянды без гололеда, кгс
	///</summary>
	public class GarlandStartTotalWeightWithoutIce : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartTotalWeightWithoutIce);

		}
	}


	[NVP_Manifest(
		Id = "696E0128-D3C3-49C8-B9FD-FA0EE6D9A2C2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandStartTotalWeightWithoutIce", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandStartTotalWeightWithoutIce", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса первой гирлянды без гололеда, кгс", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Масса первой гирлянды без гололеда, кгс
	///</summary>
	public class Set_GarlandStartTotalWeightWithoutIce : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartTotalWeightWithoutIce = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C3ED4921-9E1D-4148-934F-D78052953652", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandStartTotalWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandStartTotalWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Общий вес первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Общий вес первой гирлянды
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
		Id = "3CC3B181-AEBB-4853-8927-CE38ABBA7768", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandStartTotalWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandStartTotalWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Общий вес первой гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Общий вес первой гирлянды
	///</summary>
	public class Set_GarlandStartTotalWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartTotalWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6DA3D279-AB0C-4276-8F07-3597DE1EA9ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandStartBettaAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandStartBettaAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол наклона первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "93FB70A3-E969-43BA-839A-BBCC08416D0A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandStartDecorationDist", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandStartDecorationDist", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние до узла ответвительной арматуры, мм", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Расстояние до узла ответвительной арматуры, мм
	///</summary>
	public class GarlandStartDecorationDist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartDecorationDist);

		}
	}


	[NVP_Manifest(
		Id = "79522462-CCCE-4FC4-8DE9-8AFB93C4309E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandStartDecorationDist", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandStartDecorationDist", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние до узла ответвительной арматуры, мм", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расстояние до узла ответвительной арматуры, мм
	///</summary>
	public class Set_GarlandStartDecorationDist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartDecorationDist = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A4CFC46C-5C3A-4957-A7C2-9AAC0E775D17", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandEndEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandEndEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется вторая гирлянда", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "1A6F8CAA-52A6-4EE1-91AD-714525C84865", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandEndEnabled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandEndEnabled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется вторая гирлянда", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "45CDAF03-FD6F-461B-A17F-513A527BB81A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandEndLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandEndLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "C45A5B30-9E02-487D-92E6-9B16337FA038", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandEndLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandEndLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина второй гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "FFE19D1D-6738-407A-A995-B3EBC97E1FBE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandEndWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandEndWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес одной цепи второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Вес одной цепи второй гирлянды
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
		Id = "582117AA-93CD-4893-A0EE-5B87211D7E1F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandEndDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandEndDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "4DF318C2-EE71-4C8D-94F1-F7C40955CBB2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandEndDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandEndDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "73CF1726-535B-4DE5-B640-056046D29D68", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandEndChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandEndChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "D4E63538-7B19-48BB-BD9D-B075B9EFB0A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandEndChainCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandEndChainCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число цепей изоляторов второй гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "8DE66E76-503F-4263-B9AD-2A3FA7C43638", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandEndChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandEndChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "355AB524-74ED-4F0D-94E7-283A31FC1EB4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandEndChainLayout", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandEndChainLayout", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расположение цепей изоляторов второй гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "4516940A-BA7F-4BCB-9BD9-8861C1F84676", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandEndChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandEndChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "250BB55B-77AB-4CB2-B8A0-ACF9ADC5F2E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandEndChainDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandEndChainDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между цепями изоляторов второй гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "216F0128-0600-4530-99A7-7B0F84B519E8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandEndTotalWeightWithoutIce", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandEndTotalWeightWithoutIce", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса второй гирлянды без гололеда, кгс", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Масса второй гирлянды без гололеда, кгс
	///</summary>
	public class GarlandEndTotalWeightWithoutIce : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndTotalWeightWithoutIce);

		}
	}


	[NVP_Manifest(
		Id = "C054070A-FE2A-40B1-B176-7138A53B2F7F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandEndTotalWeightWithoutIce", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandEndTotalWeightWithoutIce", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масса второй гирлянды без гололеда, кгс", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Масса второй гирлянды без гололеда, кгс
	///</summary>
	public class Set_GarlandEndTotalWeightWithoutIce : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndTotalWeightWithoutIce = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0B34A21C-433F-45A0-9F28-0611A6E403DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandEndTotalWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandEndTotalWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Общий вес второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Общий вес второй гирлянды
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
		Id = "14B93013-0F03-4EFF-810C-E662A363BCCD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandEndBettaAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandEndBettaAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол наклона второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "DAF02870-0ED5-4973-9605-7DAED5AF4677", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GarlandEndDecorationDist", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GarlandEndDecorationDist", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние до узла ответвительной арматуры, мм", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Расстояние до узла ответвительной арматуры, мм
	///</summary>
	public class GarlandEndDecorationDist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndDecorationDist);

		}
	}


	[NVP_Manifest(
		Id = "52BEE51C-62AE-4114-945F-AB7C045EE1D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_GarlandEndDecorationDist", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_GarlandEndDecorationDist", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние до узла ответвительной арматуры, мм", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расстояние до узла ответвительной арматуры, мм
	///</summary>
	public class Set_GarlandEndDecorationDist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndDecorationDist = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B51FAA45-0C24-4020-A73C-1D2EE1410F43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.PowerUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "PowerUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Единицы измерения силы", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "180409DF-3964-401F-9C47-518541CB7071", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_PowerUnits", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_PowerUnits", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Единицы измерения силы", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "E7EECB08-79E7-42D2-A6D2-51F052956ABE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Calculate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Calculate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Calculate", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("Temperature", typeof(System.Double))]
	[NodeInput("Wind", typeof(System.Double))]
	[NodeInput("Ice", typeof(System.Double))]

	///<summary>
	///method Calculate
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
		Id = "B512E44E-1073-4766-BEC1-677DE2CE214B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Model", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Model", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Модель провода", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "00A5FD57-9C15-44AD-9F3B-41C594BF2C06", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Section", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Section", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "кв. мм)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "C7C27A52-7926-4089-A722-11B8A6D94BFA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Diameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Diameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "C7C2409A-6F8F-40C2-A6C1-0CE5BAB33045", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Mass", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Mass", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "кг/км)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "0A9573EF-7685-4387-8164-44008521C210", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.SigmaTn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "SigmaTn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Сигма tн", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "51A47404-B62E-43D4-9DDB-9FA0EAC59E6D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.SigmaTm", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "SigmaTm", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Сигма tм", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "CDEA2A7E-D483-4593-BE50-E3124BD7AD11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.SigmaTe", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "SigmaTe", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Сигма tэ", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "A0BBC4F2-88B7-4F08-8094-ED9897FBAABD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.E", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "E", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "E - модуль упругости", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "6BB9E6CF-FD02-4BD6-B345-EA6F371E5F63", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.F", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "F", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Мод. нач. F", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "F7F3033B-E387-41F7-96AE-7DBC819B9977", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.D", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "D", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Мод. пред. F", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "02889061-3052-48D5-9610-520F1EFB3ADD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Alpha", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Alpha", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "1e-6/град. С)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "D5009092-4702-4090-AD72-860A431DCCC3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.FactoryLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "FactoryLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "м)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "F82A01E5-C153-4F05-9E37-AAFD5686B841", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.SplitPhase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "SplitPhase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число проводов расщепленной фазы", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "A1A1D661-4452-4678-ACB1-7907A7C6C56F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_SplitPhase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_SplitPhase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число проводов расщепленной фазы", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "23127072-C9BD-4833-9E4E-261ECAB96B23", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.SplitDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "SplitDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "A7A3A01E-9AC1-4EB1-A0CA-DF6A59655ABD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_SplitDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_SplitDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "2B0906E9-C8E0-486C-8E22-6EF816B46080", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.ClampingDensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "ClampingDensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число стяжек на 10 м", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "E8ECD07C-155B-4574-B6BD-0C9C1890F0C9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_ClampingDensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_ClampingDensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Число стяжек на 10 м", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "DCDB9158-3277-4B6B-AE91-89073CB6500F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.ClampingWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "ClampingWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес стяжек", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Вес стяжек
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
		Id = "9CEEECDF-5578-41F6-9FCD-23488C89B898", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_ClampingWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_ClampingWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес стяжек", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Вес стяжек
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
		Id = "31821B66-8FC6-4E64-9D1B-76495469ECF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.TotalResultDataMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "TotalResultDataMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Режим отображения результатов", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "92DF3F81-2B9A-4D27-88FF-93F9961CE65C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_TotalResultDataMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_TotalResultDataMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Режим отображения результатов", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "90FA24F6-335F-46C9-828E-A8AD77AAA02B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.CalculationError", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "CalculationError", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ошибка при расчете провода", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "57708A31-8F6B-4A96-BFA8-3CA5A6296308", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.ModeIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "ModeIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Режим расчета", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "0CF816E4-92A1-4082-B80B-FFCC0C7086BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_ModeIndex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_ModeIndex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Режим расчета", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
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
		Id = "90923A7A-ED2A-4E30-8B82-E79CDB6F9A15", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.SpanLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "SpanLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина пролета", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Длина пролета
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
		Id = "5704A482-28F3-4F10-B1C3-63C758DB7364", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.CentroidHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "CentroidHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Приведенный центр тяжести", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "10F4A1FC-B278-412D-84EB-2262EA23865D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.InitialModeName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "InitialModeName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Название исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "88B15A6F-1D21-47B6-A24D-F331D4C57DE0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.InitialModeSigma", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "InitialModeSigma", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Сигма исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "2AD25C48-E2A7-4B34-BE3C-E721B490D812", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.InitialModeGamma", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "InitialModeGamma", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Гамма исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "FBF10AA6-A92D-4B84-ACD3-98876D209948", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.InitialModeT", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "InitialModeT", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Температура исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "02B5F0EC-CF79-4937-A15F-B28BD29FB696", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.SigmaCoeff", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "SigmaCoeff", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ед.силы/мм?)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Ед.силы/мм?)
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
		Id = "C55C5791-D327-422D-940B-94F44CBD61C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GammaCoeff", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GammaCoeff", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нагрузка на провод", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Нагрузка на провод
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
		Id = "954344F6-BE35-42DD-A26C-C254EFBF3C23", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.LengthMax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "LengthMax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "м)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "7504033E-D702-4319-B2BF-F9DAE5B453DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "м)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///м)
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
		Id = "394D9E0C-7734-468A-87FD-ADC1FBDD929F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "м)", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///м)
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
		Id = "4F187766-9D7B-41FF-A766-88E9E8D3EDCA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GammaStdNorm", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GammaStdNorm", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нормативные нагрузки", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "E3314C9A-EA78-40ED-9846-458D93D2A781", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GammaStdCalc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GammaStdCalc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расчетные нагрузки", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "9A10E6E1-46C5-4C60-BF9D-A503EBDE51B3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.GammaStdSpec", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "GammaStdSpec", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Удельные нагрузки", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Удельные нагрузки
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
		Id = "8E270972-AE77-47B1-8DFE-93DC8313AE68", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.SlackMax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "SlackMax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Максимальная стрела провеса для всех режимов", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Максимальная стрела провеса для всех режимов
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
		Id = "A90AC107-4CF6-4294-A7FB-7575996683FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Slack", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Slack", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Стрела провеса", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "7EFDB8ED-ABA2-4241-9EDF-5AA721C443B2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_Slack", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_Slack", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Стрела провеса", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Стрела провеса
	///</summary>
	public class Set_Slack : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Slack = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "11CA5557-46ED-41E4-AB6D-6F52D9B995F5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.WindAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "WindAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол отклонения ветром", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "EC033898-6BAC-4784-8DFB-0100F544E57A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.SupportStressMax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "SupportStressMax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Допустимое тяжение для опоры", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "E89C7605-11B0-43DE-A014-E5219A451FD7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Stress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Stress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Текущее значение тяжения", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Текущее значение тяжения
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
		Id = "04B2E3FE-4839-4517-B5AD-421A3AF1EBB2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.MaxStress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "MaxStress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Способ задания тяжения", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Способ задания тяжения
	///</summary>
	public class MaxStress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaxStress);

		}
	}


	[NVP_Manifest(
		Id = "E73D7492-596C-46B0-83C0-E4F74B908FA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_MaxStress", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_MaxStress", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Способ задания тяжения", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Способ задания тяжения
	///</summary>
	public class Set_MaxStress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MaxStress = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "385A9BD1-9E8D-4726-962A-D8DD17BAD8FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.StressMaxValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "StressMaxValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Максимальное тяжение", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Максимальное тяжение
	///</summary>
	public class StressMaxValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StressMaxValue);

		}
	}


	[NVP_Manifest(
		Id = "83B79820-82DA-46B6-8BBF-AB4B4DBC533D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_StressMaxValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_StressMaxValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Максимальное тяжение", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Максимальное тяжение
	///</summary>
	public class Set_StressMaxValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StressMaxValue = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "46867E94-B466-4505-B4CC-E3CF3EE67D04", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.TensionMaxValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "TensionMaxValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Максимальное напряжение", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Максимальное напряжение
	///</summary>
	public class TensionMaxValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TensionMaxValue);

		}
	}


	[NVP_Manifest(
		Id = "AF12437F-B6F7-4212-820A-45437264BF2B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Set_TensionMaxValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Set_TensionMaxValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Максимальное напряжение", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Максимальное напряжение
	///</summary>
	public class Set_TensionMaxValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TensionMaxValue = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2CC0B5B0-7D0C-47BD-8BA8-9DD16949D904", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.NodeStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "NodeStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NodeStart", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "10DDD3F1-85FB-41B9-934E-B609B7A94119", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.NodeEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "NodeEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NodeEnd", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "18DBD126-B58C-48EE-BEC0-FFDB784E945D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.Nodes", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "Nodes", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Nodes", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "F7536145-299F-4C45-8B88-CFD26806B003", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.climateData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "climateData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method climateData", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "A2B1B9BE-807C-454B-BD02-3C77E5788D30", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.StartLevel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "StartLevel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота начальной точки подвеса, м", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Высота начальной точки подвеса, м
	///</summary>
	public class StartLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartLevel);

		}
	}


	[NVP_Manifest(
		Id = "58111BFA-C20F-402A-BDF7-457C153C950F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.EndLevel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "EndLevel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота конечной точки подвеса, м", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Высота конечной точки подвеса, м
	///</summary>
	public class EndLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndLevel);

		}
	}


	[NVP_Manifest(
		Id = "75C8EF97-C7AA-40B3-B4B8-AE8B8084A9CB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.CurrentModeData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "CurrentModeData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method CurrentModeData", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
		Id = "EC41C467-401D-4F78-B46F-8B124C30E393", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.CalculateByMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "CalculateByMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method CalculateByMode", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("nMode", typeof(System.Object))]

	///<summary>
	///method CalculateByMode
	///</summary>
	public class CalculateByMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CalculateByMode(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "8840B54A-948E-41AD-93D8-571908CB7822", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsELAYComLib.MDSELLink.CalcCoeffs", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsELAYComLib.MDSELLink", 
		NodeName = "CalcCoeffs", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Коэффициенты расчетных формул", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
