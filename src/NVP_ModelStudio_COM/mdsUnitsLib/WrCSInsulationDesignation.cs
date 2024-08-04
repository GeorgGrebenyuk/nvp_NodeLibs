using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrCSInsulationDesignation Interface
///</summary>
namespace mdsUnitsLib.WrCSInsulationDesignation 
{

	[NVP_Manifest(
		Id = "960EF019-B7D4-4457-97B2-37480D476C6A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.WrCSInsulationDesignation_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "_WrCSInsulationDesignation_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrCSInsulationDesignation_Constructor : INode 
	{
		public mdsUnitsLib.IWrCSInsulationDesignation _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IWrCSInsulationDesignation;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "DE90EAF1-8133-48BC-84A2-FE15C55F7B40", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.WrCSInsulationDesignation_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "_WrCSInsulationDesignation_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrCSInsulationDesignation_ConstructorCast : INode 
	{
		public mdsUnitsLib.IWrCSInsulationDesignation _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IWrCSInsulationDesignation;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "832B0ADC-C083-444F-90B5-FCB832F0635D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Step", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Step", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Шаг штриховки", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Шаг штриховки
	///</summary>
	public class Step : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Step);

		}
	}


	[NVP_Manifest(
		Id = "70366F77-1AF0-4112-B25B-98B59166B207", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_Step", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_Step", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Шаг штриховки", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Шаг штриховки
	///</summary>
	public class Set_Step : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Step = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EF302062-FC89-4B1F-99F1-E1A397C17106", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Angle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Angle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол штриховки", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Угол штриховки
	///</summary>
	public class Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Angle);

		}
	}


	[NVP_Manifest(
		Id = "2F5F3587-1113-4894-BD39-C159D25845D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_Angle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_Angle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол штриховки", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол штриховки
	///</summary>
	public class Set_Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Angle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FE9EFC29-A16A-4193-B4C1-BE057E44DB16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.TraceryType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "TraceryType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип узора", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Тип узора
	///</summary>
	public class TraceryType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TraceryType);

		}
	}


	[NVP_Manifest(
		Id = "D0FC5CA0-1895-4CE0-8E39-F8E3E6E6DCDD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_TraceryType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_TraceryType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип узора", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип узора
	///</summary>
	public class Set_TraceryType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TraceryType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A64CF8D1-4B16-4459-BC6C-1C0E6EE77DC8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.IsViewUpLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "IsViewUpLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Показывать верхнюю границу?", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Показывать верхнюю границу?
	///</summary>
	public class IsViewUpLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsViewUpLine);

		}
	}


	[NVP_Manifest(
		Id = "0D73A205-5CC1-450E-9538-B5670A2231CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_IsViewUpLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_IsViewUpLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Показывать верхнюю границу?", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Показывать верхнюю границу?
	///</summary>
	public class Set_IsViewUpLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IsViewUpLine = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5E8EEC95-76C7-4887-A4AF-548C7DAAB487", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.DistBetweenPlines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "DistBetweenPlines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между границами", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Расстояние между границами
	///</summary>
	public class DistBetweenPlines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DistBetweenPlines);

		}
	}


	[NVP_Manifest(
		Id = "716B3291-01E3-430F-A71C-2E40DC33D85C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_DistBetweenPlines", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_DistBetweenPlines", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расстояние между границами", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расстояние между границами
	///</summary>
	public class Set_DistBetweenPlines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DistBetweenPlines = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "628909D7-C383-40C9-AC7E-6A05488FC9DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.IsViewDownLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "IsViewDownLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Показывать нижнюю границу?", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Показывать нижнюю границу?
	///</summary>
	public class IsViewDownLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsViewDownLine);

		}
	}


	[NVP_Manifest(
		Id = "6562F58D-3A9D-4ABE-9D87-7CB37A26899C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_IsViewDownLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_IsViewDownLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Показывать нижнюю границу?", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Показывать нижнюю границу?
	///</summary>
	public class Set_IsViewDownLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IsViewDownLine = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E616E759-6B00-4B7A-B1EC-7BEA707803C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.LineTypeUp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "LineTypeUp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип линии верхней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Тип линии верхней границы
	///</summary>
	public class LineTypeUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeUp);

		}
	}


	[NVP_Manifest(
		Id = "2B9B0061-602C-4957-839E-827FAF1EACDA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_LineTypeUp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_LineTypeUp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип линии верхней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип линии верхней границы
	///</summary>
	public class Set_LineTypeUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeUp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E1E04085-412E-4F99-8919-8C2AE5E68F36", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.LineTypeDown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "LineTypeDown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип линии нижней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Тип линии нижней границы
	///</summary>
	public class LineTypeDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeDown);

		}
	}


	[NVP_Manifest(
		Id = "E87AACA3-7F70-4F8D-9F1C-5867AB570D87", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_LineTypeDown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_LineTypeDown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип линии нижней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип линии нижней границы
	///</summary>
	public class Set_LineTypeDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeDown = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2DCEF9CD-6087-4342-AE38-E14495CD224B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.LineTypeTracery", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "LineTypeTracery", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип линии узора", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Тип линии узора
	///</summary>
	public class LineTypeTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeTracery);

		}
	}


	[NVP_Manifest(
		Id = "B675885A-B632-4E19-AC6C-A34032D9BB24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_LineTypeTracery", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_LineTypeTracery", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип линии узора", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип линии узора
	///</summary>
	public class Set_LineTypeTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeTracery = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7496EC2B-313C-4469-BEC9-FA697C38FD11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.LineTypeScaleUp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "LineTypeScaleUp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масштаб линии верхней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Масштаб линии верхней границы
	///</summary>
	public class LineTypeScaleUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeScaleUp);

		}
	}


	[NVP_Manifest(
		Id = "47D440BD-8F24-4626-B527-CB66ABBEE312", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_LineTypeScaleUp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_LineTypeScaleUp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масштаб линии верхней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Масштаб линии верхней границы
	///</summary>
	public class Set_LineTypeScaleUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeScaleUp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F9C4E25F-A5E9-4EE1-BCC8-4E60B9F87311", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.LineTypeScaleDown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "LineTypeScaleDown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масштаб линии нижней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Масштаб линии нижней границы
	///</summary>
	public class LineTypeScaleDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeScaleDown);

		}
	}


	[NVP_Manifest(
		Id = "6D04565B-85E1-4576-A7C3-A7922690FEE8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_LineTypeScaleDown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_LineTypeScaleDown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масштаб линии нижней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Масштаб линии нижней границы
	///</summary>
	public class Set_LineTypeScaleDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeScaleDown = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "86423B6C-31CF-49C7-B8E0-8969CD829237", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.LineTypeScaleTracery", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "LineTypeScaleTracery", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масштаб линии узора", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Масштаб линии узора
	///</summary>
	public class LineTypeScaleTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeScaleTracery);

		}
	}


	[NVP_Manifest(
		Id = "55946FD5-D835-44A8-B811-69DA8E1352BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_LineTypeScaleTracery", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_LineTypeScaleTracery", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Масштаб линии узора", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Масштаб линии узора
	///</summary>
	public class Set_LineTypeScaleTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeScaleTracery = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "61683AFC-2F26-4D58-9239-F6096F922C1A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.LineWeightUp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "LineWeightUp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес линии верхней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Вес линии верхней границы
	///</summary>
	public class LineWeightUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineWeightUp);

		}
	}


	[NVP_Manifest(
		Id = "64A1297F-FFC8-4A0B-B1A9-5B27AFA2CA51", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_LineWeightUp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_LineWeightUp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес линии верхней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Вес линии верхней границы
	///</summary>
	public class Set_LineWeightUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineWeightUp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "71B93F63-CF79-42FD-B321-FC195C917560", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.LineWeightDown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "LineWeightDown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес линии нижней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Вес линии нижней границы
	///</summary>
	public class LineWeightDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineWeightDown);

		}
	}


	[NVP_Manifest(
		Id = "E36FB829-C7FB-4B89-A258-B01AF33C9804", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_LineWeightDown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_LineWeightDown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес линии нижней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Вес линии нижней границы
	///</summary>
	public class Set_LineWeightDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineWeightDown = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "11383F61-EB3E-4482-97AB-226C82C4666F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.LineWeightTracery", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "LineWeightTracery", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес линии узора", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Вес линии узора
	///</summary>
	public class LineWeightTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineWeightTracery);

		}
	}


	[NVP_Manifest(
		Id = "E30804C2-9994-45FE-8B54-74D1715DBBA4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_LineWeightTracery", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_LineWeightTracery", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес линии узора", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Вес линии узора
	///</summary>
	public class Set_LineWeightTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineWeightTracery = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "40964525-1724-4C41-B74E-00E7C9D73B64", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.ColorUp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "ColorUp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Цвет линии верхней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Цвет линии верхней границы
	///</summary>
	public class ColorUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorUp);

		}
	}


	[NVP_Manifest(
		Id = "C62C0A35-4A1F-4464-AFB3-319F5E076EAA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_ColorUp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_ColorUp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Цвет линии верхней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Цвет линии верхней границы
	///</summary>
	public class Set_ColorUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorUp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B76023A9-B23C-4F03-8771-2DF87F687C08", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.ColorDown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "ColorDown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Цвет линии нижней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Цвет линии нижней границы
	///</summary>
	public class ColorDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorDown);

		}
	}


	[NVP_Manifest(
		Id = "5BEA78B9-062E-484E-BC9D-F9143FE57B8A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_ColorDown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_ColorDown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Цвет линии нижней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Цвет линии нижней границы
	///</summary>
	public class Set_ColorDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorDown = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "25319E5B-BC69-45E6-8A01-92AF1B17EA03", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.ColorTracery", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "ColorTracery", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Цвет линии узора", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Цвет линии узора
	///</summary>
	public class ColorTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorTracery);

		}
	}


	[NVP_Manifest(
		Id = "20CD4CA8-B5BC-43C1-B929-68FFFF467FE4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.WrCSInsulationDesignation.Set_ColorTracery", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.WrCSInsulationDesignation", 
		NodeName = "Set_ColorTracery", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Цвет линии узора", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Цвет линии узора
	///</summary>
	public class Set_ColorTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorTracery = inputs[1].Value;
			return null;
		}
	}
}
