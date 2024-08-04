using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrIronAxis Interface
///</summary>
namespace ironObjComLib.WrIronAxis 
{

	[NVP_Manifest(
		Id = "97E0FDE6-493A-48A1-A0F4-6790CF543C91", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.WrIronAxis_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "_WrIronAxis_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronAxis_Constructor : INode 
	{
		public ironObjComLib.IWrIronAxis _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrIronAxis;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "67599410-FF69-431B-B5B8-FCA36444441E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.WrIronAxis_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "_WrIronAxis_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronAxis_ConstructorCast : INode 
	{
		public ironObjComLib.IWrIronAxis _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrIronAxis;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A4813392-750A-449B-BA2F-73FEE6364FA4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

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
		Id = "DA99319D-0346-43E5-800B-A069BF5FEDAA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
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
		Id = "4961E93C-5181-4CD6-B809-E35ACA7B9ADA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.OffsetStartZ", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "OffsetStartZ", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "A)", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///A)
	///</summary>
	public class OffsetStartZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetStartZ);

		}
	}


	[NVP_Manifest(
		Id = "FEC3C5FA-5C77-4AFA-A3A7-CFCA19C929DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_OffsetStartZ", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_OffsetStartZ", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "A)", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///A)
	///</summary>
	public class Set_OffsetStartZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetStartZ = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F275D29C-3FD0-4BD1-A423-BDBBC32B571D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.OffsetEndZ", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "OffsetEndZ", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "B)", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///B)
	///</summary>
	public class OffsetEndZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetEndZ);

		}
	}


	[NVP_Manifest(
		Id = "8FE116FD-37A1-41CC-82D8-0BE2FC0A4810", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_OffsetEndZ", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_OffsetEndZ", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "B)", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///B)
	///</summary>
	public class Set_OffsetEndZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetEndZ = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DE273183-01BE-4461-B3B4-B49627535205", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.AngleRotationDegrees", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "AngleRotationDegrees", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Угол вращения", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Угол вращения
	///</summary>
	public class AngleRotationDegrees : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleRotationDegrees);

		}
	}


	[NVP_Manifest(
		Id = "A6D3255B-489B-4EA8-B049-0EADC201A916", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_AngleRotationDegrees", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_AngleRotationDegrees", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Угол вращения", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Угол вращения
	///</summary>
	public class Set_AngleRotationDegrees : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AngleRotationDegrees = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0A932AE6-B78A-4B9D-9430-EFF96E71B259", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.StartPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "StartPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property StartPoint", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property StartPoint
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
		Id = "ECE9CEB0-C1F0-4144-ADC2-DBAED774E69B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_StartPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_StartPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property StartPoint", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property StartPoint
	///</summary>
	public class Set_StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D95961F9-EFD6-4322-8E1B-048108C166A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.EndPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "EndPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property EndPoint", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property EndPoint
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
		Id = "C26E38D6-2F36-4633-8E11-6934B00D0206", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_EndPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_EndPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property EndPoint", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property EndPoint
	///</summary>
	public class Set_EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6B11AF96-BE8B-4ED4-AF70-71CB672FAB09", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.AxisLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "AxisLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Длина оси", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Длина оси
	///</summary>
	public class AxisLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisLength);

		}
	}


	[NVP_Manifest(
		Id = "2E92571E-9DDC-48B3-B20F-9BBBB597B777", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_AxisLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_AxisLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Длина оси", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Длина оси
	///</summary>
	public class Set_AxisLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AxisLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9423A618-8171-4DBE-9033-364D201FEE97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.ConstructionLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "ConstructionLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Длина стороительная", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Длина стороительная
	///</summary>
	public class ConstructionLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConstructionLength);

		}
	}


	[NVP_Manifest(
		Id = "EDDB21CB-6B2C-49AD-9584-4E70F3E1A44B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_ConstructionLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_ConstructionLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Длина стороительная", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Длина стороительная
	///</summary>
	public class Set_ConstructionLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ConstructionLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1171D73F-55DB-47C2-891F-B283570407AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.OffsetMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "OffsetMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Режим смещения", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Режим смещения
	///</summary>
	public class OffsetMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetMode);

		}
	}


	[NVP_Manifest(
		Id = "FFAD6A6D-E1B6-4CF6-8211-4FDFBC623527", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_OffsetMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_OffsetMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Режим смещения", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Режим смещения
	///</summary>
	public class Set_OffsetMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "71DBACC2-32CA-4DE6-B856-633BC900C890", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.SnapMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "SnapMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Режим привязки", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Режим привязки
	///</summary>
	public class SnapMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapMode);

		}
	}


	[NVP_Manifest(
		Id = "97416818-5312-45BB-B6A3-45348EB0BE34", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_SnapMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_SnapMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Режим привязки", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Режим привязки
	///</summary>
	public class Set_SnapMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "90EF1FC7-733A-4B0D-BD7B-8A115DF2AF51", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.SnapStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "SnapStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Привязка Start", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Привязка Start
	///</summary>
	public class SnapStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapStart);

		}
	}


	[NVP_Manifest(
		Id = "4EFAF5A6-026A-4CBB-9351-8EAA469E8317", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_SnapStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_SnapStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Привязка Start", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Привязка Start
	///</summary>
	public class Set_SnapStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapStart = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8D0A566D-9BB5-4BD2-95D8-7F12FB6BC978", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.SnapEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "SnapEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Привязка End", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Привязка End
	///</summary>
	public class SnapEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapEnd);

		}
	}


	[NVP_Manifest(
		Id = "2FC24CFE-ED48-45A9-9696-77B260FB1ED5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_SnapEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_SnapEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Привязка End", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Привязка End
	///</summary>
	public class Set_SnapEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapEnd = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C778180B-739C-4E0B-89CF-E4B88969092A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.OffsetStartX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "OffsetStartX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение Start X", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение Start X
	///</summary>
	public class OffsetStartX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetStartX);

		}
	}


	[NVP_Manifest(
		Id = "704CD20C-4872-4F28-813C-5D7615121C54", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_OffsetStartX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_OffsetStartX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение Start X", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение Start X
	///</summary>
	public class Set_OffsetStartX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetStartX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3BF0951D-26CE-4C83-96B5-F7A25D1AAF77", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.OffsetStartY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "OffsetStartY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение Start Y", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение Start Y
	///</summary>
	public class OffsetStartY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetStartY);

		}
	}


	[NVP_Manifest(
		Id = "6C15F4B3-F067-4450-A5DE-EE514F3FC054", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_OffsetStartY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_OffsetStartY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение Start Y", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение Start Y
	///</summary>
	public class Set_OffsetStartY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetStartY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F44B6848-7F30-42B9-9FCB-94E039318F46", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.OffsetEndX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "OffsetEndX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение End X", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение End X
	///</summary>
	public class OffsetEndX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetEndX);

		}
	}


	[NVP_Manifest(
		Id = "3108E7D6-2550-40D2-BDCE-F5C8A392A12C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_OffsetEndX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_OffsetEndX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение End X", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение End X
	///</summary>
	public class Set_OffsetEndX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetEndX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7A03E198-6334-4E86-AF42-04904B6BB68E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.OffsetEndY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "OffsetEndY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение End Y", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение End Y
	///</summary>
	public class OffsetEndY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetEndY);

		}
	}


	[NVP_Manifest(
		Id = "BA6DD5A3-E8BE-4A47-8D9C-C66D36EAC654", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_OffsetEndY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_OffsetEndY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение End Y", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение End Y
	///</summary>
	public class Set_OffsetEndY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetEndY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AB7A4DDF-2777-48C6-9E3A-C977CC96A867", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.RelativeStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "RelativeStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RelativeStart", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property RelativeStart
	///</summary>
	public class RelativeStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RelativeStart);

		}
	}


	[NVP_Manifest(
		Id = "7AFC9BFC-4BB3-4B16-B305-122C8C51C016", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_RelativeStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_RelativeStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RelativeStart", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property RelativeStart
	///</summary>
	public class Set_RelativeStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RelativeStart = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4B1622F7-1B0B-4DA3-A0F1-86364FF79B92", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.RelativeDistStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "RelativeDistStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RelativeDistStart", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property RelativeDistStart
	///</summary>
	public class RelativeDistStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RelativeDistStart);

		}
	}


	[NVP_Manifest(
		Id = "B4F58FDF-010D-44D9-B848-F8DCEC418256", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_RelativeDistStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_RelativeDistStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RelativeDistStart", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property RelativeDistStart
	///</summary>
	public class Set_RelativeDistStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RelativeDistStart = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "378F1F1F-9652-4EA0-8DF4-64F3E05BF51B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.OffsetStartPtX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "OffsetStartPtX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение точки Start X", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение точки Start X
	///</summary>
	public class OffsetStartPtX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetStartPtX);

		}
	}


	[NVP_Manifest(
		Id = "A5EF078D-1FEE-40D5-8276-77DB3AF42C6E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_OffsetStartPtX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_OffsetStartPtX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение точки Start X", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение точки Start X
	///</summary>
	public class Set_OffsetStartPtX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetStartPtX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F6C83501-AE65-4E1A-98B6-24F0E26DF583", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.OffsetStartPtY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "OffsetStartPtY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение точки Start Y", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение точки Start Y
	///</summary>
	public class OffsetStartPtY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetStartPtY);

		}
	}


	[NVP_Manifest(
		Id = "74D1B883-5983-4D7E-B1C1-C918DE69101A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_OffsetStartPtY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_OffsetStartPtY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение точки Start Y", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение точки Start Y
	///</summary>
	public class Set_OffsetStartPtY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetStartPtY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "298D514E-02A8-4576-8B46-E0267A784FEC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.RelativeEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "RelativeEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RelativeEnd", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property RelativeEnd
	///</summary>
	public class RelativeEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RelativeEnd);

		}
	}


	[NVP_Manifest(
		Id = "6AEA0E53-2C74-4FA6-A3C3-8EFAC8512E84", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_RelativeEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_RelativeEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RelativeEnd", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property RelativeEnd
	///</summary>
	public class Set_RelativeEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RelativeEnd = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E34ED427-1161-4821-BC1B-170CD7A67906", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.RelativeDistEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "RelativeDistEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RelativeDistEnd", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property RelativeDistEnd
	///</summary>
	public class RelativeDistEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RelativeDistEnd);

		}
	}


	[NVP_Manifest(
		Id = "4F702821-C657-461F-8271-624484725398", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_RelativeDistEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_RelativeDistEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property RelativeDistEnd", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property RelativeDistEnd
	///</summary>
	public class Set_RelativeDistEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RelativeDistEnd = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7F5BF809-D47B-4B17-A03E-6F758F76791C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.OffsetEndPtX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "OffsetEndPtX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение точки End X", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение точки End X
	///</summary>
	public class OffsetEndPtX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetEndPtX);

		}
	}


	[NVP_Manifest(
		Id = "A38C5C2D-83C5-4595-964E-D3A5D68CDA4D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_OffsetEndPtX", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_OffsetEndPtX", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение точки End X", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение точки End X
	///</summary>
	public class Set_OffsetEndPtX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetEndPtX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4AADA72B-0DAD-4BCE-A0AF-869B0FB3D406", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.OffsetEndPtY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "OffsetEndPtY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение точки End Y", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение точки End Y
	///</summary>
	public class OffsetEndPtY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetEndPtY);

		}
	}


	[NVP_Manifest(
		Id = "D86BD3AC-A7FE-4AE7-B181-6BBEF366FFCA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_OffsetEndPtY", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_OffsetEndPtY", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Смещение точки End Y", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение точки End Y
	///</summary>
	public class Set_OffsetEndPtY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetEndPtY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C5467546-CCAB-4E59-B522-B36CD4A2B98F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.NumDependencies", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "NumDependencies", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NumDependencies", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property NumDependencies
	///</summary>
	public class NumDependencies : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumDependencies);

		}
	}


	[NVP_Manifest(
		Id = "9DBA0A49-CF8C-48D3-A3DA-EE5D2F81159E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.Set_NumDependencies", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "Set_NumDependencies", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property NumDependencies", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property NumDependencies
	///</summary>
	public class Set_NumDependencies : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NumDependencies = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7D1197E8-A1F7-45FC-9538-D2C9932581B5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.GetArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "GetArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetArea", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]
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
		Id = "BF6D8F6D-E28C-4D8A-99E2-1262E63DA7C3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrIronAxis.GetVolume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrIronAxis", 
		NodeName = "GetVolume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetVolume", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]
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
