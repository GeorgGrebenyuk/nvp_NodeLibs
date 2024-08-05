using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ImstProjectDummy Interface
///</summary>
namespace mstProjectCOMLib.mstProjectDummy 
{

	[NVP_Manifest(
		Id = "1BA5BD61-6A27-46D8-9330-CDCC2BAAFFD6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.mstProjectDummy_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "_mstProjectDummy_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstProjectDummy_Constructor : INode 
	{
		public mstProjectCOMLib.ImstProjectDummy _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mstProjectCOMLib.ImstProjectDummy;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "00026221-8939-450F-A37D-3DBAAA336F9B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.mstProjectDummy_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "_mstProjectDummy_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstProjectDummy_ConstructorCast : INode 
	{
		public mstProjectCOMLib.ImstProjectDummy _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mstProjectCOMLib.ImstProjectDummy;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "89821053-767D-4835-B88D-9700D632F1E1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "D5BA23C4-E550-4DEE-BD28-80FA83D2A833", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("mstProjectDummy", typeof(object))]
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
		Id = "B2B86109-3839-48D9-A6D2-BAE387FC33C4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.ParametricData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "ParametricData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметрические данные", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "8C588BC4-E0A8-4CAB-A00D-4026E38D3610", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.UnitPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "UnitPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Положение объекта", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "391CE7F2-999F-4653-8FA0-34A02EFA3393", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.UnitName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "UnitName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование объекта", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "DD126E4C-5014-41E2-9936-C279724F25AD", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.AxisLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "AxisLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина осевой", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

	///<summary>
	///Длина осевой
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
		Id = "A6AFF346-45A6-419B-A8C5-2D48F3FA25B2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "8D7F2E93-73E4-4D8E-8A80-B3518D270B5A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "модель)", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "99EA33BC-14B7-4C70-A9E6-4385835E8DB0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Производитель", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "BA2F49CA-6C95-4B27-97BC-D3EDA57BDDFF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нормативный документ", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "5297B5FD-0249-4FAA-8045-D609F4559B74", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ссылочный чертеж", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "D0179833-EC17-4A93-BF2D-2D5BF29C28C1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Материал", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "A39ACBCA-5B44-4ACF-9F26-2A644EA9591D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нормативный документ на материал", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "2B81F6F4-B017-4177-8EFC-B7E2C29AF188", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "36E998DB-DA46-4DE8-9328-844CFF3F8FC2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "0CEA213A-511D-4E2C-A44C-1EC5C000CCE6", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа изделий", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "1EBAFD7E-8F64-4F11-B729-9CFAF958C3F2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип изделия", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "D2C02E7E-6A23-426A-A180-598F8D543F5C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Код ОКП", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "30E6601E-3780-42A4-8D93-CF2F011DC3E5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес нетто", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "2698801C-DE86-46AE-935C-34D93416C5C1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес бруто", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "9251CD4F-973F-4691-BFCE-0604F91271E4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Включение в экспликацию", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "8269DCF1-A27E-4B4C-913F-45FE2E8919F3", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Позиция по экспликации", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "3F65C034-BDC7-4B11-9ACB-D37AF3C26C6A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа по экспликации", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "68B98374-CAF7-427F-A18D-F8337ADEF5D5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания к экспликации", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "9B81DA30-8887-4B81-BE55-37FD9A407AC7", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Включение в спецификацию", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "2677FDC9-F8FE-4D01-952F-78F515F45660", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Позиция по спецификации", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "0072CA12-DB25-410D-AB2A-0B5D020CC99C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа по спецификации", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "D3239A96-92B9-44F6-B73C-0CDAB471A18C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Количество", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "549A627E-EA0D-48E2-9147-46E8A8CD4839", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания к спецификации", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

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
		Id = "408DBF74-3395-45F5-8EE4-19087038FA2C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.AxisNodeStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "AxisNodeStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Начало", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

	///<summary>
	///Начало
	///</summary>
	public class AxisNodeStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisNodeStart);

		}
	}


	[NVP_Manifest(
		Id = "D9D25222-E692-40DF-87C6-5F298B8BBD80", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDummy.AxisNodeEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDummy", 
		NodeName = "AxisNodeEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Конец", 
		ViewType = "Data")]
	[NodeInput("mstProjectDummy", typeof(object))]

	///<summary>
	///Конец
	///</summary>
	public class AxisNodeEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisNodeEnd);

		}
	}
}
