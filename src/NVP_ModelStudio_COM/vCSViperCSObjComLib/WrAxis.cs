using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAxis Interface
///</summary>
namespace vCSViperCSObjComLib.WrAxis 
{

	[NVP_Manifest(
		Id = "3E90F803-3BE9-4EF8-A7EB-E45365A07824", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.WrAxis_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "_WrAxis_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAxis_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrAxis _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrAxis;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "7D79D7BD-755B-46E4-ACA3-AE08378D4193", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.WrAxis_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "_WrAxis_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAxis_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrAxis _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrAxis;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "F027A42F-538F-41A8-A657-D5CAB693A3F5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

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
		Id = "75859D02-9F8D-4F8A-AEC8-E27076858620", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("WrAxis", typeof(object))]
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
		Id = "F0540661-1C65-4733-9B4A-13543F6A06A0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.EquipmentNodeStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "EquipmentNodeStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property EquipmentNodeStart", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///property EquipmentNodeStart
	///</summary>
	public class EquipmentNodeStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EquipmentNodeStart);

		}
	}


	[NVP_Manifest(
		Id = "E068EBC1-E3B7-44C9-A580-BBFF4B4B3C96", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.EquipmentNodeEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "EquipmentNodeEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property EquipmentNodeEnd", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///property EquipmentNodeEnd
	///</summary>
	public class EquipmentNodeEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EquipmentNodeEnd);

		}
	}


	[NVP_Manifest(
		Id = "571CFFC9-EE68-43B2-A1F3-4F5CD51C50B3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.HasEquipmentNodeStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "HasEquipmentNodeStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HasEquipmentNodeStart", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///property HasEquipmentNodeStart
	///</summary>
	public class HasEquipmentNodeStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasEquipmentNodeStart);

		}
	}


	[NVP_Manifest(
		Id = "078155A0-ECE1-4EC9-86D6-0C3750A2312B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.HasEquipmentNodeEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "HasEquipmentNodeEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property HasEquipmentNodeEnd", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///property HasEquipmentNodeEnd
	///</summary>
	public class HasEquipmentNodeEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasEquipmentNodeEnd);

		}
	}


	[NVP_Manifest(
		Id = "6BE4B0B2-EA16-46A8-9AB2-C96122CC40EA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.CountItems", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "CountItems", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Подсчет числа компонентов", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]
	[NodeInput("bTerminators", typeof(System.Object))]
	[NodeInput("bElbows", typeof(System.Object))]
	[NodeInput("bPipes", typeof(System.Object))]
	[NodeInput("bInlines", typeof(System.Object))]
	[NodeInput("bSupports", typeof(System.Object))]

	///<summary>
	///Подсчет числа компонентов
	///</summary>
	public class CountItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CountItems(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value));

		}
	}


	[NVP_Manifest(
		Id = "35AE0647-5101-4286-A0AE-41368D88A570", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.GetFirstComponent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "GetFirstComponent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Первый компонент", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Первый компонент
	///</summary>
	public class GetFirstComponent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFirstComponent);

		}
	}


	[NVP_Manifest(
		Id = "E4F6830E-D2ED-40E2-BF8E-44E382C7DB35", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.GetLastComponent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "GetLastComponent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Последний компонент", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Последний компонент
	///</summary>
	public class GetLastComponent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLastComponent);

		}
	}


	[NVP_Manifest(
		Id = "3850ACB8-AFE1-4BA5-959F-14706036E27D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.GetPrevComponent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "GetPrevComponent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Предыдущий компонент", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]
	[NodeInput("pCurrent", typeof(System.Object))]

	///<summary>
	///Предыдущий компонент
	///</summary>
	public class GetPrevComponent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPrevComponent(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "7D919541-DB83-461B-A7F7-171AF002A5AF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.GetNextComponent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "GetNextComponent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Следующий компонент", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]
	[NodeInput("pCurrent", typeof(System.Object))]

	///<summary>
	///Следующий компонент
	///</summary>
	public class GetNextComponent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetNextComponent(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "33C6A3E7-1F7F-4859-85F8-780AB27F5353", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.GetFromObjParamVal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "GetFromObjParamVal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметр объекта, подключенного в начале", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]
	[NodeInput("ParamName", typeof(System.String))]

	///<summary>
	///Параметр объекта, подключенного в начале
	///</summary>
	public class GetFromObjParamVal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFromObjParamVal(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "67DA5A67-6B7D-47E3-8431-0887025791E5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.GetToObjParamVal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "GetToObjParamVal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметр объекта, подключенного в конце", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]
	[NodeInput("ParamName", typeof(System.String))]

	///<summary>
	///Параметр объекта, подключенного в конце
	///</summary>
	public class GetToObjParamVal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetToObjParamVal(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "0734ED3C-3BB6-4CDC-A398-D23898D66FF1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.Components", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "Components", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Компоненты трубопровода", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Компоненты трубопровода
	///</summary>
	public class Components : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Components);

		}
	}


	[NVP_Manifest(
		Id = "3185F9AD-93F6-4E8F-AFF9-C9748D624E0C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.StartTee", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "StartTee", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Трубопровод, к которому подключено начало", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Трубопровод, к которому подключено начало
	///</summary>
	public class StartTee : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartTee);

		}
	}


	[NVP_Manifest(
		Id = "5BB0406A-BE84-4412-9A10-5A92F1DA4AD0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.EndTee", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "EndTee", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Tрубопровод, к которому подключен конец", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Tрубопровод, к которому подключен конец
	///</summary>
	public class EndTee : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndTee);

		}
	}


	[NVP_Manifest(
		Id = "1FAFB9CF-DB65-4983-BE9E-F2E00F34D146", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.HasStartTee", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "HasStartTee", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется трубопровод, к которому подключено начало", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Имеется трубопровод, к которому подключено начало
	///</summary>
	public class HasStartTee : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasStartTee);

		}
	}


	[NVP_Manifest(
		Id = "7BDFC30A-6E36-43B5-9282-ED2EFD171458", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.HasEndTee", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "HasEndTee", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется трубопровод, к которому подключен конец", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Имеется трубопровод, к которому подключен конец
	///</summary>
	public class HasEndTee : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasEndTee);

		}
	}


	[NVP_Manifest(
		Id = "6350CEDE-40FA-44FA-B320-D6256825B75F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrAxis.Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrAxis", 
		NodeName = "Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}
}
