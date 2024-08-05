using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECTrench Interface
///</summary>
namespace ironObjComLib.WrAECTrench 
{

	[NVP_Manifest(
		Id = "09CDBED8-AFAC-4CA3-9231-9E500FE1D403", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.WrAECTrench_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "_WrAECTrench_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECTrench_Constructor : INode 
	{
		public ironObjComLib.IWrAECTrench _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECTrench;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "55F6018B-9139-495B-AA11-F0F82FC00D63", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.WrAECTrench_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "_WrAECTrench_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECTrench_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECTrench _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECTrench;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "8CDF7E62-F298-4C65-A190-10CE96F36A7F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вызов диалога свойств", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Вызов диалога свойств
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
		Id = "E6FBD46C-4CBD-469D-B26E-82D469CD1D79", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вызов диалога свойств", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Вызов диалога свойств
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
		Id = "B97BEC2C-00CE-410F-B6E1-FDD69CAB4F24", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.TVolume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "TVolume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Объем выемки в м3", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Объем выемки в м3
	///</summary>
	public class TVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TVolume);

		}
	}


	[NVP_Manifest(
		Id = "686E0F69-F14F-4B77-9997-489424258571", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.TDigVolume", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "TDigVolume", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Объем засыпки в м3", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Объем засыпки в м3
	///</summary>
	public class TDigVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TDigVolume);

		}
	}


	[NVP_Manifest(
		Id = "942DE745-19F3-44EA-A1AB-D5D1B7338C93", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.TLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "TLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина в м", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Длина в м
	///</summary>
	public class TLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TLength);

		}
	}


	[NVP_Manifest(
		Id = "7246B8C0-8936-40FF-9DAA-A2836113CFC6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.DrawStartSlope", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "DrawStartSlope", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Рисовать начальный откос", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Рисовать начальный откос
	///</summary>
	public class DrawStartSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawStartSlope);

		}
	}


	[NVP_Manifest(
		Id = "C493F244-47C7-458A-BFA9-DDCC6FB6B7FC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.Set_DrawStartSlope", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "Set_DrawStartSlope", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Рисовать начальный откос", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Рисовать начальный откос
	///</summary>
	public class Set_DrawStartSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawStartSlope = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "66EF751E-420C-4461-8600-60EAD982ABBB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.AngleStartSlope", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "AngleStartSlope", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол начального откоса", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Угол начального откоса
	///</summary>
	public class AngleStartSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleStartSlope);

		}
	}


	[NVP_Manifest(
		Id = "FC1A65EB-396A-4296-AA9F-C88DAD5895B3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.Set_AngleStartSlope", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "Set_AngleStartSlope", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол начального откоса", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол начального откоса
	///</summary>
	public class Set_AngleStartSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AngleStartSlope = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FD796265-F35A-4801-96FD-B973DFEF07E2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.DrawEndSlope", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "DrawEndSlope", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Рисовать конечный откос", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Рисовать конечный откос
	///</summary>
	public class DrawEndSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawEndSlope);

		}
	}


	[NVP_Manifest(
		Id = "3E3E620E-7352-44D6-BC26-D132D505AE0F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.Set_DrawEndSlope", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "Set_DrawEndSlope", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Рисовать конечный откос", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Рисовать конечный откос
	///</summary>
	public class Set_DrawEndSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawEndSlope = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4507FE75-9AAA-4626-9E7B-32154375E67C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.AngleEndSlope", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "AngleEndSlope", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол конечного откоса", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Угол конечного откоса
	///</summary>
	public class AngleEndSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleEndSlope);

		}
	}


	[NVP_Manifest(
		Id = "90D44CA1-6981-496E-89E2-8F23EAA7EDCB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.Set_AngleEndSlope", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "Set_AngleEndSlope", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Угол конечного откоса", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол конечного откоса
	///</summary>
	public class Set_AngleEndSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AngleEndSlope = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E9D3DEF6-BD60-4265-8846-CFFA7DA65F1C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.ProjectPresent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "ProjectPresent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Проектная поверхность присутствует или нет", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Проектная поверхность присутствует или нет
	///</summary>
	public class ProjectPresent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProjectPresent);

		}
	}


	[NVP_Manifest(
		Id = "7133106C-951B-480C-BCA9-5AD0D07859A6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.DigOutOver", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "DigOutOver", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "По какой поверхности считать выемку", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///По какой поверхности считать выемку
	///</summary>
	public class DigOutOver : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DigOutOver);

		}
	}


	[NVP_Manifest(
		Id = "612EE392-7F8B-45C5-A113-90D1A6CC72A4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.Set_DigOutOver", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "Set_DigOutOver", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "По какой поверхности считать выемку", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///По какой поверхности считать выемку
	///</summary>
	public class Set_DigOutOver : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DigOutOver = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "67DB6817-12F9-4EA3-8281-2F43EA6B739C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.FillingOver", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "FillingOver", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "По какой поверхности считать засыпку", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///По какой поверхности считать засыпку
	///</summary>
	public class FillingOver : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FillingOver);

		}
	}


	[NVP_Manifest(
		Id = "8103903E-5015-4D73-9B05-86AF05E11630", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.Set_FillingOver", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "Set_FillingOver", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "По какой поверхности считать засыпку", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///По какой поверхности считать засыпку
	///</summary>
	public class Set_FillingOver : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FillingOver = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9F4B3C3F-C193-4F9B-8A8C-04A1EA8D3016", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.DrawOver", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "DrawOver", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Рисовать по линии поверхности или по проектной поверхности", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Рисовать по линии поверхности или по проектной поверхности
	///</summary>
	public class DrawOver : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawOver);

		}
	}


	[NVP_Manifest(
		Id = "6699E2C4-8E69-45EF-9B63-107958A61A51", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.Set_DrawOver", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "Set_DrawOver", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Рисовать по линии поверхности или по проектной поверхности", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Рисовать по линии поверхности или по проектной поверхности
	///</summary>
	public class Set_DrawOver : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawOver = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A17C893F-63F4-4D16-A0CE-025787737867", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.GeoMode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "GeoMode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Построение по геоданным", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Построение по геоданным
	///</summary>
	public class GeoMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GeoMode);

		}
	}


	[NVP_Manifest(
		Id = "B15BA82D-5511-449A-AE8C-2881E9F6AF53", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.GeoBad", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "GeoBad", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Требуется обновление геоданных", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Требуется обновление геоданных
	///</summary>
	public class GeoBad : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GeoBad);

		}
	}


	[NVP_Manifest(
		Id = "4221D45C-28D9-4964-8245-423318E124BD", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.DrawOverStep", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "DrawOverStep", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Строить сечения по рельефу или шагам", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Строить сечения по рельефу или шагам
	///</summary>
	public class DrawOverStep : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawOverStep);

		}
	}


	[NVP_Manifest(
		Id = "3258A55A-0BF8-4785-B1CC-CFB856EF7151", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.Set_DrawOverStep", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "Set_DrawOverStep", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Строить сечения по рельефу или шагам", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Строить сечения по рельефу или шагам
	///</summary>
	public class Set_DrawOverStep : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawOverStep = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "10CBA832-3C7E-4013-8CD1-644040288DA6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.PathStep", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "PathStep", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Шаг сечений", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Шаг сечений
	///</summary>
	public class PathStep : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PathStep);

		}
	}


	[NVP_Manifest(
		Id = "5CBDB74E-8A9E-4FE4-8EDD-E236979C981D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "ironObjComLib.WrAECTrench.Set_PathStep", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.ironObjComLib.WrAECTrench", 
		NodeName = "Set_PathStep", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Шаг сечений", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Шаг сечений
	///</summary>
	public class Set_PathStep : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PathStep = inputs[1].Value;
			return null;
		}
	}
}
