using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrNodeElbow Interface
///</summary>
namespace vCSViperCSObjComLib.WrNodeElbow 
{

	[NVP_Manifest(
		Id = "C3DA141A-ED03-40D7-AB60-D9D2C18F7285", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.WrNodeElbow_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "_WrNodeElbow_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrNodeElbow_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrNodeElbow _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrNodeElbow;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "DE6AABAB-58CF-4D3A-AE24-02D666FFB005", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.WrNodeElbow_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "_WrNodeElbow_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrNodeElbow_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrNodeElbow _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrNodeElbow;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "86DB56F8-FEE2-43DD-81B3-046C842A31F2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PipeLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PipeLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Слой по умолчанию", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///Слой по умолчанию
	///</summary>
	public class PipeLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PipeLayer);

		}
	}


	[NVP_Manifest(
		Id = "8F649C6D-99B5-4691-8D40-F8AA1389D29D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_PipeLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_PipeLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Слой по умолчанию", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Слой по умолчанию
	///</summary>
	public class Set_PipeLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PipeLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "451D830C-85DB-452F-BBE4-1CF1D10B2242", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "28FE2B66-8BD3-4BB5-BF6D-2DA5047A9663", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "798C406D-DFA6-44A8-B715-34B79AA744C5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ViewMode", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property ViewMode
	///</summary>
	public class ViewMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewMode);

		}
	}


	[NVP_Manifest(
		Id = "F16C6226-975F-4823-9CFB-3E506B90EAB9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_ViewMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_ViewMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ViewMode", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ViewMode
	///</summary>
	public class Set_ViewMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8602891F-5F8D-47FC-968D-B9FC0DF460BF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.ElementAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "ElementAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ElementAxis", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property ElementAxis
	///</summary>
	public class ElementAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElementAxis);

		}
	}


	[NVP_Manifest(
		Id = "50929F74-5D66-4B01-B39D-539EB4BBB399", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_ElementAxis", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_ElementAxis", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property ElementAxis", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ElementAxis
	///</summary>
	public class Set_ElementAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ElementAxis = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3EACCFEF-F9BC-4804-AB48-08ED950EBB0E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Reverse", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Reverse", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Reverse", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Reverse
	///</summary>
	public class Reverse : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Reverse);

		}
	}


	[NVP_Manifest(
		Id = "A0278261-E4A3-4928-B467-C46F6BEA63A9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Reverse", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Reverse", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Reverse", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Reverse
	///</summary>
	public class Set_Reverse : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Reverse = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "435A6A41-54F2-4B9F-8CDF-1F39D9DB5156", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.AngleIsFixed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "AngleIsFixed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AngleIsFixed", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property AngleIsFixed
	///</summary>
	public class AngleIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleIsFixed);

		}
	}


	[NVP_Manifest(
		Id = "789DE1BC-1190-42D9-AEFA-1CBCC2037374", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_AngleIsFixed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_AngleIsFixed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property AngleIsFixed", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property AngleIsFixed
	///</summary>
	public class Set_AngleIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AngleIsFixed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6E24049A-5822-4877-B4A5-A210F35AC307", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.FixedAngleValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "FixedAngleValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property FixedAngleValue", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property FixedAngleValue
	///</summary>
	public class FixedAngleValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FixedAngleValue);

		}
	}


	[NVP_Manifest(
		Id = "EEB40E14-5327-4F86-A2E7-8BA0FB16707E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_FixedAngleValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_FixedAngleValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property FixedAngleValue", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property FixedAngleValue
	///</summary>
	public class Set_FixedAngleValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FixedAngleValue = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "453D4981-D6AD-4984-89D2-C59F64A06754", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PositionIsFixed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PositionIsFixed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PositionIsFixed", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property PositionIsFixed
	///</summary>
	public class PositionIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PositionIsFixed);

		}
	}


	[NVP_Manifest(
		Id = "2B597DD1-1B7F-4314-A5C1-8A9F50A55138", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_PositionIsFixed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_PositionIsFixed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PositionIsFixed", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PositionIsFixed
	///</summary>
	public class Set_PositionIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PositionIsFixed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8C51B344-3ED4-4493-8E9A-D211165AF15F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Position", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Position
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
		Id = "07C5D361-AF1F-42B0-BFFE-8FFDBEE49047", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Position", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Position
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
		Id = "5953D0AA-F509-4837-9029-B85C54BEB230", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.IsReducer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "IsReducer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property IsReducer", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property IsReducer
	///</summary>
	public class IsReducer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsReducer);

		}
	}


	[NVP_Manifest(
		Id = "0A5CD9FB-9B59-40F1-A5DE-C8B127E34F80", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_IsReducer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_IsReducer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property IsReducer", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property IsReducer
	///</summary>
	public class Set_IsReducer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IsReducer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "31ECB6BA-35EE-430D-AD7A-44686A40360A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PointStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PointStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Начальная точка", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///Начальная точка
	///</summary>
	public class PointStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PointStart);

		}
	}


	[NVP_Manifest(
		Id = "37219010-E632-418A-BE17-D348C13F5769", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PointEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PointEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Конечная точка", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///Конечная точка
	///</summary>
	public class PointEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PointEnd);

		}
	}


	[NVP_Manifest(
		Id = "3D76C7D5-8E2C-448F-B4CD-848BBA61E9DD", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.OrderOnLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "OrderOnLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер на линии", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///Номер на линии
	///</summary>
	public class OrderOnLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OrderOnLine);

		}
	}


	[NVP_Manifest(
		Id = "C7654DD3-E016-4DD2-BF74-1CB5A5073274", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Insulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Insulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Объект изоляции", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///Объект изоляции
	///</summary>
	public class Insulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Insulation);

		}
	}


	[NVP_Manifest(
		Id = "9A8BF5C7-0914-42FF-8B6C-CCEF20E56780", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Insulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Insulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Объект изоляции", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Объект изоляции
	///</summary>
	public class Set_Insulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Insulation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "66ADDBB9-558E-40FA-BFF2-45D528743B38", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.HasInsulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "HasInsulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наличие изоляции", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///Наличие изоляции
	///</summary>
	public class HasInsulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasInsulation);

		}
	}


	[NVP_Manifest(
		Id = "B24DBE90-465F-46FA-AA7E-CEDD1360A4BF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Name", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "CD8BB736-69A1-4D5C-9BC2-690C79576CF8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Name", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "658830E3-A1C6-46D0-9F3E-1F1C6481CE43", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Tag", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "0E85989D-1DAD-47DB-9546-7B3BDD882CBE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Tag", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "F627FD4A-709F-4858-A633-1CF3072A0500", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Manufacturer", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Part_Manufacturer
	///</summary>
	public class Part_Manufacturer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Manufacturer);

		}
	}


	[NVP_Manifest(
		Id = "39B08058-EB63-40B8-815C-E6B1FE396F04", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Manufacturer", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Manufacturer
	///</summary>
	public class Set_Part_Manufacturer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Manufacturer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EAAD0D14-D265-45B6-BB1E-653FDA0C5A0B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Standard", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Part_Standard
	///</summary>
	public class Part_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Standard);

		}
	}


	[NVP_Manifest(
		Id = "A88DA467-6FB5-44EE-BD22-EBD648898326", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Standard", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Standard
	///</summary>
	public class Set_Part_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Standard = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "17723E18-33F8-4131-AE4A-C775D1FA7250", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Refdrawing", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "75FEB2A8-0A21-4110-B2F5-3839512034F6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Refdrawing", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "F26708AE-507D-4A20-B4FF-9030A1116C84", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "E0059B09-854D-4C16-9D42-DCF6312DFBB5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "1E3F4C17-DAB2-4600-B531-67DC9C2228EB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material_Standard", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "B0C843BC-6618-4C68-96B9-AD271D8B57B3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Material_Standard", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "006187C3-CE18-4BEC-9BBA-E9D66461F06B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "4AF8B4A0-F5D3-482F-BFEC-CF68AB2C4CF0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "63A4A725-183E-4B9B-BA32-D66C24F260C8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Comment", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "ECE24DD2-9311-4B46-B96E-FC9C0FACAE64", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "6A20B339-EE67-42F2-B34B-60932BE46DBE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PartPipe_PN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PartPipe_PN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_PN", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property PartPipe_PN
	///</summary>
	public class PartPipe_PN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_PN);

		}
	}


	[NVP_Manifest(
		Id = "0F063DE7-C44A-4CDB-8BEE-FD7F008B33A9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_PartPipe_PN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_PartPipe_PN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_PN", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PartPipe_PN
	///</summary>
	public class Set_PartPipe_PN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_PN = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B12D42DD-96F4-44D7-8EC2-418BFFC1CF7F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PartPipe_DN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PartPipe_DN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property PartPipe_DN
	///</summary>
	public class PartPipe_DN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_DN);

		}
	}


	[NVP_Manifest(
		Id = "D20EECEB-5AC3-42F2-AE7E-B00B4A6EFB40", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_PartPipe_DN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_PartPipe_DN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_DN
	///</summary>
	public class Set_PartPipe_DN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_DN = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0CFBB797-BFB9-409C-BF93-588F355E772D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PartPipe_Diam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PartPipe_Diam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property PartPipe_Diam
	///</summary>
	public class PartPipe_Diam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Diam);

		}
	}


	[NVP_Manifest(
		Id = "F59510BD-C074-4201-AA52-F1E137784DEB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_PartPipe_Diam", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_PartPipe_Diam", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_Diam
	///</summary>
	public class Set_PartPipe_Diam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Diam = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "35302B88-2DDA-4954-817F-15FD7F1B314B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PartPipe_DN1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PartPipe_DN1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN1", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property PartPipe_DN1
	///</summary>
	public class PartPipe_DN1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_DN1);

		}
	}


	[NVP_Manifest(
		Id = "3910F7EB-B943-4E3D-B367-144327489247", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_PartPipe_DN1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_PartPipe_DN1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_DN1", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_DN1
	///</summary>
	public class Set_PartPipe_DN1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_DN1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "92F0308A-13D3-4444-9713-0373087EAB1C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PartPipe_Diam1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PartPipe_Diam1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam1", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property PartPipe_Diam1
	///</summary>
	public class PartPipe_Diam1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Diam1);

		}
	}


	[NVP_Manifest(
		Id = "5A6EF094-E0DA-4AA5-884B-9B8A0335853F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_PartPipe_Diam1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_PartPipe_Diam1", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Diam1", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_Diam1
	///</summary>
	public class Set_PartPipe_Diam1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Diam1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0AD29D29-B422-4D0D-908F-4D57F701CD34", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PartPipe_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PartPipe_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property PartPipe_Thickness
	///</summary>
	public class PartPipe_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Thickness);

		}
	}


	[NVP_Manifest(
		Id = "6A8C0051-1C50-436B-946C-000E88F12494", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_PartPipe_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_PartPipe_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PartPipe_Thickness
	///</summary>
	public class Set_PartPipe_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "765B0DD8-6187-4192-9550-34B99EC64614", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PartPipe_RadiusBend", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PartPipe_RadiusBend", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_RadiusBend", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property PartPipe_RadiusBend
	///</summary>
	public class PartPipe_RadiusBend : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_RadiusBend);

		}
	}


	[NVP_Manifest(
		Id = "55904CFA-FEA3-40FF-A695-987AA7912914", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_PartPipe_RadiusBend", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_PartPipe_RadiusBend", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_RadiusBend", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property PartPipe_RadiusBend
	///</summary>
	public class Set_PartPipe_RadiusBend : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_RadiusBend = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FCAAE7E2-485F-4CFB-AAE7-5B29C645CF8A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PartPipe_Angle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PartPipe_Angle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Angle", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property PartPipe_Angle
	///</summary>
	public class PartPipe_Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Angle);

		}
	}


	[NVP_Manifest(
		Id = "7F2BEBF0-8B0F-405F-BD1A-6AAF1AD13832", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_PartPipe_Angle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_PartPipe_Angle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Angle", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property PartPipe_Angle
	///</summary>
	public class Set_PartPipe_Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Angle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "34B9E1AB-9430-404F-B6C2-EFF59B19687A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PartPipe_L3", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PartPipe_L3", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_L3", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property PartPipe_L3
	///</summary>
	public class PartPipe_L3 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_L3);

		}
	}


	[NVP_Manifest(
		Id = "F34746A1-FB48-47AF-99FD-030BC866EDA1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_PartPipe_L3", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_PartPipe_L3", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_L3", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property PartPipe_L3
	///</summary>
	public class Set_PartPipe_L3 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_L3 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "00A67838-9F87-4815-97B8-D1E11800BF02", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PartPipe_L4", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PartPipe_L4", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_L4", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property PartPipe_L4
	///</summary>
	public class PartPipe_L4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_L4);

		}
	}


	[NVP_Manifest(
		Id = "ABEDED4B-19DA-4A04-9661-3C25069F79BB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_PartPipe_L4", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_PartPipe_L4", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_L4", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property PartPipe_L4
	///</summary>
	public class Set_PartPipe_L4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_L4 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "798966DF-3281-455C-A9EE-26C504FD98B0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PartPipe_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PartPipe_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Length", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property PartPipe_Length
	///</summary>
	public class PartPipe_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Length);

		}
	}


	[NVP_Manifest(
		Id = "9920F90F-CB5A-4EB0-876F-DC47DC8FA95E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_PartPipe_Length", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_PartPipe_Length", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property PartPipe_Length", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property PartPipe_Length
	///</summary>
	public class Set_PartPipe_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Length = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7C63BC56-CA92-4AE9-8B98-DF0D202B0241", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Group", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Part_Group
	///</summary>
	public class Part_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Group);

		}
	}


	[NVP_Manifest(
		Id = "F4ED29CD-3383-4C8D-A9E2-B7F7FC14669E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Group
	///</summary>
	public class Set_Part_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Group = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "38E92311-793C-41C4-AA3E-FC42EBEFDD2E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Type", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Part_Type
	///</summary>
	public class Part_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Type);

		}
	}


	[NVP_Manifest(
		Id = "15AEF4EF-0B8E-4B3B-9038-CC8C2955CFB6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Type", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Type
	///</summary>
	public class Set_Part_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Type = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "920B83DA-07C0-4186-9B55-050E713C8B1E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Reference", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Part_Reference
	///</summary>
	public class Part_Reference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Reference);

		}
	}


	[NVP_Manifest(
		Id = "44910488-16D5-42B3-A78F-35CFDCDEB2BF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Reference", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Reference
	///</summary>
	public class Set_Part_Reference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Reference = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "199FC73B-C293-44E4-8077-CE34E52B999E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Netto", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Part_Weight_Netto
	///</summary>
	public class Part_Weight_Netto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Weight_Netto);

		}
	}


	[NVP_Manifest(
		Id = "5B533469-3E4A-40BA-98F9-E92401D97A98", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Netto", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Weight_Netto
	///</summary>
	public class Set_Part_Weight_Netto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Weight_Netto = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "88C1D525-41AD-4F94-B70D-5BA00A2618F6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Bruto", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Part_Weight_Bruto
	///</summary>
	public class Part_Weight_Bruto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Weight_Bruto);

		}
	}


	[NVP_Manifest(
		Id = "C4DB93D0-487D-467B-A401-DCDE3AEB6D48", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Weight_Bruto", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Weight_Bruto
	///</summary>
	public class Set_Part_Weight_Bruto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Weight_Bruto = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CF255514-1A0A-489B-A1C1-8704A767BA18", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Insulation_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Part_Insulation_Thickness
	///</summary>
	public class Part_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Insulation_Thickness);

		}
	}


	[NVP_Manifest(
		Id = "BDF4198B-F0B3-42E4-8EFC-E4D76EB89A82", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Insulation_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Part_Insulation_Thickness
	///</summary>
	public class Set_Part_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Insulation_Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C49E80C6-7569-440C-92C8-E74704F54617", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Part_Insulation_Disableview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Part_Insulation_Disableview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Insulation_Disableview", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Part_Insulation_Disableview
	///</summary>
	public class Part_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Insulation_Disableview);

		}
	}


	[NVP_Manifest(
		Id = "59C48562-3D94-46F8-8523-8AC11DFB1F82", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Part_Insulation_Disableview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Part_Insulation_Disableview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Part_Insulation_Disableview", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Part_Insulation_Disableview
	///</summary>
	public class Set_Part_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Insulation_Disableview = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C62A438C-FB80-44A1-8199-6D3C1116F4C4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Axis_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Axis_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Axis_Insulation_Thickness
	///</summary>
	public class Axis_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_Thickness);

		}
	}


	[NVP_Manifest(
		Id = "42BAC522-445B-496E-880E-EDDC7B1C5C71", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Axis_Insulation_Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Axis_Insulation_Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Axis_Insulation_Thickness
	///</summary>
	public class Set_Axis_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BDC31DD8-206E-41A3-8168-6ED28BEFA6FE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Axis_Insulation_Disableview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Axis_Insulation_Disableview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Disableview", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Axis_Insulation_Disableview
	///</summary>
	public class Axis_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_Disableview);

		}
	}


	[NVP_Manifest(
		Id = "F44C887A-C16C-457B-8F4E-5BEC0944287D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Axis_Insulation_Disableview", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Axis_Insulation_Disableview", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_Disableview", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Axis_Insulation_Disableview
	///</summary>
	public class Set_Axis_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_Disableview = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1361C094-7BF0-422C-AA4F-B1B1E4571C4F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Axis_Insulation_LineInsulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Axis_Insulation_LineInsulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineInsulation", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Axis_Insulation_LineInsulation
	///</summary>
	public class Axis_Insulation_LineInsulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_LineInsulation);

		}
	}


	[NVP_Manifest(
		Id = "723EC1D4-C012-4DC0-96A2-3A00D5D96BAF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Axis_Insulation_LineInsulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Axis_Insulation_LineInsulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineInsulation", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Axis_Insulation_LineInsulation
	///</summary>
	public class Set_Axis_Insulation_LineInsulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_LineInsulation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1FA364BD-B16E-4E7B-95D3-5A968B757D61", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Axis_Insulation_LineTrace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Axis_Insulation_LineTrace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineTrace", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property Axis_Insulation_LineTrace
	///</summary>
	public class Axis_Insulation_LineTrace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_LineTrace);

		}
	}


	[NVP_Manifest(
		Id = "E50AB70D-DB41-48CD-9266-1D6294FC4C8A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Axis_Insulation_LineTrace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Axis_Insulation_LineTrace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Axis_Insulation_LineTrace", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Axis_Insulation_LineTrace
	///</summary>
	public class Set_Axis_Insulation_LineTrace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_LineTrace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "23DBB406-88CB-4AA9-A25F-BF10733F64E3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.GetAxisParamValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "GetAxisParamValue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetAxisParamValue", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("ParameterName", typeof(System.String))]

	///<summary>
	///method GetAxisParamValue
	///</summary>
	public class GetAxisParamValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAxisParamValue(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "3293F942-062B-49E4-B32D-AA46935180F1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Include", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "B822AD14-94B0-4237-AD4B-76A5E071A568", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "021E773D-8052-4F68-ADCC-8FF4433AFABE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Number", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "B38D87EE-27C1-449C-A440-6D66F035FDD1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "351B9C44-BDB7-4437-ABE2-B6498E3308E4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Group", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "69FC13F8-4799-4F03-9EC4-BCE7E1F50753", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "D86E562E-8C3C-4FC8-9358-7D20A48F7D14", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Comment", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "05694FDC-28BA-4E56-81B0-2B52C50EB594", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Explication_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "EE92F863-3B18-426D-91A6-23B6A0BB130E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Include", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "68EC324F-7136-4034-BEF5-2A8D7EBA2092", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "94B188DB-8CC9-45AC-A2D6-3422712A3BC9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Number", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "021DF20A-7030-48D2-8B34-5106302F1AE7", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "18BEBDD4-CAD9-4852-91D3-2032A599C6BA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Group", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "E4A09F1B-0528-4D3B-B71C-DDD19E73D990", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "C640F32E-A911-4AF7-81C6-01D65A638F21", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Qty", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "5B9A4A37-FB55-4E5C-A7C9-9505176291D9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Qty", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "C97CE524-6DAA-4D6E-8EF7-857C7F307B29", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Comment", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

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
		Id = "2AF7F69E-B2C5-463D-8DCF-3B893C39E9E2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Bom_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "C1CDB11A-2263-4885-B245-818C3CCDC259", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.PartPipe_Lock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "PartPipe_Lock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property LockComponent", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]

	///<summary>
	///property LockComponent
	///</summary>
	public class PartPipe_Lock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Lock);

		}
	}


	[NVP_Manifest(
		Id = "82A2A0D8-2372-430E-8F98-FBEB39142028", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.Set_PartPipe_Lock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "Set_PartPipe_Lock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property LockComponent", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeElbow", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property LockComponent
	///</summary>
	public class Set_PartPipe_Lock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Lock = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "24F7E4C0-BD39-47A2-A12E-680172B9EDF5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.GetArea", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "GetArea", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetArea", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
		Id = "79CBDEED-2012-4E26-8F46-67E124B82816", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "vCSViperCSObjComLib.WrNodeElbow.GetVolume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.vCSViperCSObjComLib.WrNodeElbow", 
		NodeName = "GetVolume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method GetVolume", 
		ViewType = "Data")]
	[NodeInput("WrNodeElbow", typeof(object))]
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
