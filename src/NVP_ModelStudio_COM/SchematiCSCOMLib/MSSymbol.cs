using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMSSymbol Interface
///</summary>
namespace SchematiCSCOMLib.MSSymbol 
{

	[NVP_Manifest(
		Id = "3AE836D8-3A05-47CB-87FF-CEA3ABAD910A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.MSSymbol_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "_MSSymbol_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSSymbol_Constructor : INode 
	{
		public SchematiCSCOMLib.IMSSymbol _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as SchematiCSCOMLib.IMSSymbol;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "E229679F-708E-4472-94F1-93ED3C0C761D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.MSSymbol_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "_MSSymbol_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSSymbol_ConstructorCast : INode 
	{
		public SchematiCSCOMLib.IMSSymbol _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as SchematiCSCOMLib.IMSSymbol;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "EEC15F29-3B7A-4BF0-A324-2E9D0FA6C255", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Данные объекта", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Данные объекта
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
		Id = "4E686610-54D2-47A4-A5F8-B75DB779C1CF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Данные объекта", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Данные объекта
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
		Id = "120013B3-6363-4C97-8E1E-771865A62C4A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.ParametricData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "ParametricData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметрические данные", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Параметрические данные
	///</summary>
	public class ParametricData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParametricData);

		}
	}


	[NVP_Manifest(
		Id = "572624BF-A2BC-4558-8405-FF60396E6DD6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_ParametricData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_ParametricData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметрические данные", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметрические данные
	///</summary>
	public class Set_ParametricData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ParametricData = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "91F1F0C2-C9CA-4B2A-B53A-98716865E03F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.SegmentData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "SegmentData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Данные сегмента", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Данные сегмента
	///</summary>
	public class SegmentData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SegmentData);

		}
	}


	[NVP_Manifest(
		Id = "7D3B9786-0A61-4DD4-959E-F16F3B8EAEA7", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.LineData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "LineData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Данные линии", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Данные линии
	///</summary>
	public class LineData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineData);

		}
	}


	[NVP_Manifest(
		Id = "CC06A175-E822-4FC4-827E-0EB242E4E6FD", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.UnitPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "UnitPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Положение объекта", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Положение объекта
	///</summary>
	public class UnitPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitPosition);

		}
	}


	[NVP_Manifest(
		Id = "33004411-82D7-4F68-9E0D-668F69C83BEB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_UnitPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_UnitPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Положение объекта", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Положение объекта
	///</summary>
	public class Set_UnitPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnitPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9AB4C5DB-6429-480F-866E-CD5626108CA7", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.UnitName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "UnitName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование объекта", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Наименование объекта
	///</summary>
	public class UnitName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitName);

		}
	}


	[NVP_Manifest(
		Id = "E9976E9E-5AAA-438E-A947-9834204ADBB1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_UnitName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_UnitName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование объекта", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Наименование объекта
	///</summary>
	public class Set_UnitName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UnitName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C5994BF2-2CE4-4E8B-83BA-1632C23E63F2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Nodes", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Nodes", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Узлы объекта", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Узлы объекта
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
		Id = "5E6B02E6-FC79-4B25-BE14-A6CB20C41937", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.HasOwnerLink", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "HasOwnerLink", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Принадлежит ли объект связи", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Принадлежит ли объект связи
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
		Id = "C258F821-EFE4-4E9B-B44D-63E9E93F1C4F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.OwnerLink", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "OwnerLink", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Связь, которой принадлежит объект", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Связь, которой принадлежит объект
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
		Id = "7A297555-3F77-4151-87CE-E777D635E52F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Наименование
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
		Id = "F5F19831-E44D-490D-9739-AAE1929ACB25", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Наименование
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
		Id = "17D41EF3-5DB5-4919-85DA-F37F05026319", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "модель)", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///модель)
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
		Id = "3D1B80A9-9251-4695-BE1D-430E36C3B92C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "модель)", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///модель)
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
		Id = "74BEFB47-C97F-4796-88B2-4E003049488C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Производитель", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Производитель
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
		Id = "0FC0A042-F4B2-49EA-8C52-D06DE1C7AC79", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Производитель", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Производитель
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
		Id = "1B996209-DE07-482D-919A-DD1039674C7E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нормативный документ", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Нормативный документ
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
		Id = "E0AC02AF-9AA4-4817-8149-3080461008B5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нормативный документ", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Нормативный документ
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
		Id = "58EA78BC-E56F-4E61-BCA5-FC50FC26A098", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ссылочный чертеж", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Ссылочный чертеж
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
		Id = "0F5912C2-98D0-43F9-922F-CC9C43AC4395", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ссылочный чертеж", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Ссылочный чертеж
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
		Id = "8A51F118-C278-462B-84D8-48A97CBBAE36", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Материал", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Материал
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
		Id = "D6A1E5F2-EFFD-433A-AE9C-21E474AEAAC6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Материал", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Материал
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
		Id = "0545EF4B-4298-42FA-8E01-F452B9E15858", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нормативный документ на материал", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Нормативный документ на материал
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
		Id = "96620ECE-84E8-4BFD-8293-AE3671128C24", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нормативный документ на материал", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Нормативный документ на материал
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
		Id = "A3A0007C-EC49-47DF-8A31-F1BD81DCF620", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Вес
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
		Id = "DD7222BC-93BD-4489-BCC8-CFAD4F4E9726", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Вес
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
		Id = "30B1DE3D-4EA3-463C-80A7-AC9F63E6284D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Примечания
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
		Id = "DDF4383E-EB7A-468E-8509-2E8E1AFC2267", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Примечания
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
		Id = "67F3F99C-E378-419B-A512-58FE612CF945", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа изделий", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Группа изделий
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
		Id = "1326CE45-DE0C-4550-8D36-93A3E12753CE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа изделий", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Группа изделий
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
		Id = "360CBC7A-C141-48AB-8B20-E966DAE38A8D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип изделия", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Тип изделия
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
		Id = "D934AB5F-4BBF-4B78-85A8-0F006C64B7A1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип изделия", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Тип изделия
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
		Id = "E7CE2602-1C52-4447-9079-997B8B5122A2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Код ОКП", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Код ОКП
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
		Id = "9DE4BF4F-0E03-4851-99FC-5E4C9D0EDDEC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Код ОКП", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Код ОКП
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
		Id = "61782D1D-A700-40CB-AE75-618A6DFFCC1E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес нетто", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Вес нетто
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
		Id = "73FE405F-807E-4946-AB10-EC58DC5126BA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес нетто", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Вес нетто
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
		Id = "0F1AAE62-BFC6-4E39-A7CB-7806BF0E5376", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес бруто", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Вес бруто
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
		Id = "A87D6461-E3F4-445A-A1F2-BB350EBD8472", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес бруто", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Вес бруто
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
		Id = "352EC3F9-064E-4161-B47B-5FE0DB2EA7FF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Включение в экспликацию", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Включение в экспликацию
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
		Id = "178FC0BD-E3C2-4FE1-AEB4-BB32476971E3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Включение в экспликацию", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Включение в экспликацию
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
		Id = "E014CB8C-0F1B-4E57-A285-C6C69CDFB900", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Позиция по экспликации", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Позиция по экспликации
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
		Id = "BA522114-4B03-48D9-BC13-2CD696DA7DD8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Позиция по экспликации", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Позиция по экспликации
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
		Id = "0E18CFB3-30FE-42C5-8ADE-D530F7EEAF85", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа по экспликации", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Группа по экспликации
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
		Id = "ED142539-8D78-4387-997E-570D7A6783D4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа по экспликации", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Группа по экспликации
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
		Id = "A7A37C66-105F-455B-9A64-56D5A685DAC1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания к экспликации", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Примечания к экспликации
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
		Id = "B3C5AC5B-79C5-4A32-B628-9C37A4567014", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания к экспликации", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Примечания к экспликации
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
		Id = "0D9E839A-F87F-4CDB-9878-183111FD7767", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Включение в спецификацию", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Включение в спецификацию
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
		Id = "5567EA30-7970-4BA1-86B5-F73BCEFE18AA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Включение в спецификацию", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Включение в спецификацию
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
		Id = "F3DE5883-AF91-4ED4-9D85-0A0270EF930F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Позиция по спецификации", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Позиция по спецификации
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
		Id = "EBB4048B-811C-4A82-ACC4-294810BCA048", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Позиция по спецификации", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Позиция по спецификации
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
		Id = "5D7A782D-89F8-474E-BAE6-B9DFBF1780F2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа по спецификации", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Группа по спецификации
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
		Id = "EEE6289B-A1AD-4CFF-AFC8-6405CBE0BBB7", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа по спецификации", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Группа по спецификации
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
		Id = "1A595ABF-EC46-4E1B-89F3-852647751B9F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Количество", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Количество
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
		Id = "B1477790-30D6-413D-B96C-55586A6736D9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Количество", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Количество
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
		Id = "574A0840-2992-42EA-B830-A76092FB7207", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания к спецификации", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Примечания к спецификации
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
		Id = "091AC6B5-854C-4105-A9F6-6DC184191C30", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания к спецификации", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Примечания к спецификации
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
		Id = "F29EEFCC-83D4-41B3-80E0-0E9DCF40DC41", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.InlineType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "InlineType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вид арматуры: 0-обычная, 1-угловая, 2-изоляция, 3-индикатор, 4-[не инлайн, только для чтения]", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Вид арматуры: 0-обычная, 1-угловая, 2-изоляция, 3-индикатор, 4-[не инлайн, только для чтения]
	///</summary>
	public class InlineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InlineType);

		}
	}


	[NVP_Manifest(
		Id = "51589873-CCAF-4025-8511-5AC14EB95963", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_InlineType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_InlineType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вид арматуры: 0-обычная, 1-угловая, 2-изоляция, 3-индикатор, 4-[не инлайн, только для чтения]", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Вид арматуры: 0-обычная, 1-угловая, 2-изоляция, 3-индикатор, 4-[не инлайн, только для чтения]
	///</summary>
	public class Set_InlineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InlineType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E430E502-C33D-4E8D-89E3-06043948DB83", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.LinkSensitive", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "LinkSensitive", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ориентировать по связи", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Ориентировать по связи
	///</summary>
	public class LinkSensitive : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinkSensitive);

		}
	}


	[NVP_Manifest(
		Id = "CF64B5D3-A90D-4838-BC54-646D040D10CE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_LinkSensitive", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_LinkSensitive", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ориентировать по связи", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Ориентировать по связи
	///</summary>
	public class Set_LinkSensitive : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinkSensitive = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "82DD05C7-7593-4DAD-9CE7-72626A0BACA1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.FlowOrientation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "FlowOrientation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Учёт направления потока", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Учёт направления потока
	///</summary>
	public class FlowOrientation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FlowOrientation);

		}
	}


	[NVP_Manifest(
		Id = "733558D9-0DEF-4F07-B209-9C7FE22129EE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_FlowOrientation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_FlowOrientation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Учёт направления потока", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Учёт направления потока
	///</summary>
	public class Set_FlowOrientation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FlowOrientation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "438C3DEB-2077-41E7-BED5-6903265EDA72", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.OrderOnLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "OrderOnLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Порядок на связи", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Порядок на связи
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
		Id = "953C2DC6-E42A-4975-A9B5-F8FB3118FA41", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.ReversedDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "ReversedDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Признак развернутого Inline", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Признак развернутого Inline
	///</summary>
	public class ReversedDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReversedDirection);

		}
	}


	[NVP_Manifest(
		Id = "9962C634-11A1-41A4-B239-9EB55B4FD307", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_ReversedDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_ReversedDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Признак развернутого Inline", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Признак развернутого Inline
	///</summary>
	public class Set_ReversedDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ReversedDirection = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9180AFCF-52A3-4706-A894-6882C5B1B64A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.ReversedOrientation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "ReversedOrientation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Признак перевернутого Inline", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Признак перевернутого Inline
	///</summary>
	public class ReversedOrientation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ReversedOrientation);

		}
	}


	[NVP_Manifest(
		Id = "404B5DD8-C69C-43B8-890A-58E956BC6755", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_ReversedOrientation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_ReversedOrientation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Признак перевернутого Inline", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Признак перевернутого Inline
	///</summary>
	public class Set_ReversedOrientation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ReversedOrientation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DDF7F1DC-57F1-4E40-A9B9-92B4BDCF030A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.InlineTransparent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "InlineTransparent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Прозрачность", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Прозрачность
	///</summary>
	public class InlineTransparent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InlineTransparent);

		}
	}


	[NVP_Manifest(
		Id = "AA97B08C-D02A-48BC-A022-910EA3DBE82E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.Set_InlineTransparent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "Set_InlineTransparent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Прозрачность", 
		ViewType = "Modifier")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Прозрачность
	///</summary>
	public class Set_InlineTransparent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InlineTransparent = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F32186B3-B579-4C55-8F54-3704AA59CB4F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.PrevSegDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "PrevSegDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Направление предыдущего сегмента", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Направление предыдущего сегмента
	///</summary>
	public class PrevSegDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrevSegDirection);

		}
	}


	[NVP_Manifest(
		Id = "B8382F8C-D644-4E44-ADE2-FA0125E03801", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.SegDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "SegDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Направление текущего сегмента", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]

	///<summary>
	///Направление текущего сегмента
	///</summary>
	public class SegDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SegDirection);

		}
	}


	[NVP_Manifest(
		Id = "AFB0EA1A-926F-4EBB-84FD-DB6F2D15BB10", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSSymbol.GetReducerDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSSymbol", 
		NodeName = "GetReducerDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "если пустой - берётся из настроек)", 
		ViewType = "Data")]
	[NodeInput("MSSymbol", typeof(object))]
	[NodeInput("strDirectionParamName", typeof(System.String))]

	///<summary>
	///если пустой - берётся из настроек)
	///</summary>
	public class GetReducerDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetReducerDirection(inputs[1].Value));

		}
	}
}
