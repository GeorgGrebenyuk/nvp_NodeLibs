using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Опора ЛЭП
///</summary>
namespace mdsLINEComLib.MDSLTower 
{

	[NVP_Manifest(
		Id = "128649D9-79B3-4FD1-9E14-7B02E94F8198", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.MDSLTower_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "_MDSLTower_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLTower_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLTower _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLTower;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B7D51779-DF20-4974-BA01-A68DEF5D30A8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.MDSLTower_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "_MDSLTower_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLTower_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLTower _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLTower;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "ADE55066-1518-457A-B879-216BF60F2F32", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.owner", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "owner", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Профиль, которому принадлежит опора", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Профиль, которому принадлежит опора
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
		Id = "378CCD22-27EC-4F81-8755-40549ED15C41", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.prevBearing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "prevBearing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Предыдущая опора", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Предыдущая опора
	///</summary>
	public class prevBearing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.prevBearing);

		}
	}


	[NVP_Manifest(
		Id = "F673559E-AF3F-481A-B5AE-717025E3C321", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.nextBearing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "nextBearing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Следующая опора", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Следующая опора
	///</summary>
	public class nextBearing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.nextBearing);

		}
	}


	[NVP_Manifest(
		Id = "C2E2EFB5-8848-438B-9D90-7957E6BF98B9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.isPrevBearing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "isPrevBearing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется ли предыдущая опора", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Имеется ли предыдущая опора
	///</summary>
	public class isPrevBearing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isPrevBearing);

		}
	}


	[NVP_Manifest(
		Id = "AD6A4F66-2CF8-4CF9-ABE4-6B1104B97121", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.isNextBearing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "isNextBearing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется ли следующая опора", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Имеется ли следующая опора
	///</summary>
	public class isNextBearing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isNextBearing);

		}
	}


	[NVP_Manifest(
		Id = "07C255A3-2CD2-44DB-B378-DE737E57FB47", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.numInLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "numInLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер опоры на профиле", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Номер опоры на профиле
	///</summary>
	public class numInLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.numInLine);

		}
	}


	[NVP_Manifest(
		Id = "67815A4A-4157-4C50-ABE7-5E905813702E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.HasOwner", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "HasOwner", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется ли профиль-владелец", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Имеется ли профиль-владелец
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
		Id = "48717425-7E5A-4EA3-9FF4-5F7DFF3DB87D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Свойства опоры", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Свойства опоры
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
		Id = "9CB760F1-0412-4D33-9717-9FECE775AEF1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.SketchFirst", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "SketchFirst", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Графическое представление опоры", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Графическое представление опоры
	///</summary>
	public class SketchFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SketchFirst);

		}
	}


	[NVP_Manifest(
		Id = "BA16F8E7-F8E1-4D4F-932B-9786A36E79BB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.Wires", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "Wires", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Провода на данной опоре", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Провода на данной опоре
	///</summary>
	public class Wires : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Wires);

		}
	}


	[NVP_Manifest(
		Id = "65432ADC-5679-48B2-92EA-56CCE9269CE7", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.HasWireAtNode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "HasWireAtNode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется ли провод на узле", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]
	[NodeInput("nodeName", typeof(System.String))]

	///<summary>
	///Имеется ли провод на узле
	///</summary>
	public class HasWireAtNode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasWireAtNode(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "299260D1-EB6B-4072-8279-1417E236A7E9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.FirstWireAtNode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "FirstWireAtNode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Получение провода по имени узла", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]
	[NodeInput("nodeName", typeof(System.String))]

	///<summary>
	///Получение провода по имени узла
	///</summary>
	public class FirstWireAtNode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FirstWireAtNode(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "8E1D9979-A0A3-4F09-BA3D-0EA249EB5E04", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.WiresAtNode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "WiresAtNode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Получение провода по имени узла", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]
	[NodeInput("nodeName", typeof(System.String))]

	///<summary>
	///Получение провода по имени узла
	///</summary>
	public class WiresAtNode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WiresAtNode(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "842D8AA4-1758-4510-A0EF-330FF6F48E37", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.MDSLTower.TowerData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.MDSLTower", 
		NodeName = "TowerData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method TowerData", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]
	[NodeInput("modeName", typeof(System.String))]
	[NodeInput("WindAngle", typeof(System.Object))]

	///<summary>
	///method TowerData
	///</summary>
	public class TowerData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TowerData(inputs[1].Value,inputs[2].Value));

		}
	}
}
