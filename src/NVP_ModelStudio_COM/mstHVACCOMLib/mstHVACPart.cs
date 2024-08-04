using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ImstHVACPart Interface
///</summary>
namespace mstHVACCOMLib.mstHVACPart 
{

	[NVP_Manifest(
		Id = "620F7F7F-C411-460D-A73E-502F4A20A04B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.mstHVACPart_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "_mstHVACPart_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstHVACPart_Constructor : INode 
	{
		public mstHVACCOMLib.ImstHVACPart _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mstHVACCOMLib.ImstHVACPart;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "3434109E-711B-4BA4-8078-AB5E207FC000", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.mstHVACPart_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "_mstHVACPart_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstHVACPart_ConstructorCast : INode 
	{
		public mstHVACCOMLib.ImstHVACPart _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mstHVACCOMLib.ImstHVACPart;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "ED1F3548-72DC-4268-8C2E-0F85F5268457", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Данные объекта", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "FEFF0878-3B92-4ED7-A042-2343A24751C5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Данные объекта", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "D6A2F50D-5E39-40CB-8F00-0B9841D9D478", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.ParametricData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "ParametricData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметрические данные", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "25D068B9-AE4C-4D2A-83EC-74B08ADD1909", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_ParametricData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_ParametricData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметрические данные", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "C0D4EDB8-9DC3-4EF9-A17A-2F269607F6A5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.UnitPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "UnitPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Положение объекта", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "156255FE-7B9C-4B6A-B608-DB35044DBD32", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_UnitPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_UnitPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Положение объекта", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "CBDAC3C9-583F-4B12-AB20-11CA2714EF4B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.UnitName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "UnitName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование объекта", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "2608D492-A380-4BE8-B2CC-DFB7F42293A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_UnitName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_UnitName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование объекта", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "90482D27-0521-4CE4-AFA1-1A732AFA2C34", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "66DC6DAE-0225-4C2C-BC15-357EC86D7BA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "D20DA15C-3016-44EE-A64B-19ABD8B90EDB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "модель)", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "58C6398A-8924-4398-94EA-A79898C8E80E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "модель)", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "6DFA5CD1-86D6-4639-A455-DC11DEF39651", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Производитель", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "06B42B23-021A-4624-A85D-A2728E63FD7F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Производитель", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "A67842E6-CFBA-43D0-820F-5CEE3EF6714A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нормативный документ", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "79937B5A-AFF8-445E-8325-9221479842D4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нормативный документ", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "B5D95887-95BC-40CA-A95C-1BB0676C0229", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ссылочный чертеж", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "FA5A36A3-7D30-4A76-B7DF-4D93EB7E42C9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ссылочный чертеж", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "58CA54FF-EB47-464E-86E2-D88DC1A940FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Материал", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "14B5B404-3EE7-4E66-B380-85C5EAFF56F1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Материал", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "4B8A453B-3EDB-463F-9565-C541D626EFC7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нормативный документ на материал", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "57E4194B-1981-4326-A301-BDDE3ECD7236", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нормативный документ на материал", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "AFF27A10-4E41-4058-AA08-18F1D062D043", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "C761480B-79D5-43AD-9A91-531A85A39974", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "9F4C6B6D-9EDA-42D7-8B1F-05CC8C744FA5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "FDC05688-845A-4BFE-8F35-8059517ECD23", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "874B5A0E-888A-40D6-A6AA-4286BB409F0F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа изделий", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "B56826B1-0905-4197-9BDA-0923C4380C18", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа изделий", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "72331965-A8FD-422E-A786-7FBA77560526", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип изделия", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "9D8E5F79-4DD8-411D-9202-D46149B8EF0E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип изделия", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "F7433131-201D-49E9-B3F5-3A104EA0AE9C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Код ОКП", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "B4BAA739-4382-4C10-8121-4F1BC374973A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Код ОКП", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "6FFB2076-E552-4312-8E09-2446350682B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес нетто", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "F2B18963-DD4D-4D25-878E-0D4178BD7C9E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес нетто", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "18563EF6-4BBC-405D-BD0A-DDA8719C7F40", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес бруто", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "F5DC75C5-0E56-481C-AC07-7F7FCD347F23", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес бруто", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "924347D9-A92A-47DA-8A18-5C15628A34BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Включение в экспликацию", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "7AB3B64D-A085-485C-89A9-08B1E69F5C22", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Включение в экспликацию", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "DE079FD5-AB2B-4054-9163-D17AC7AE0A11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Позиция по экспликации", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "C7322DE6-1560-4239-A23C-8F10284B5EE8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Позиция по экспликации", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "36CBBE01-70C3-44DE-818E-EA402AB3F412", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа по экспликации", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "E2B0E309-16BB-43FE-8489-2ABDEC8C315E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа по экспликации", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "2091B413-E9B4-4FE8-904A-F06E9A51F103", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания к экспликации", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "14253058-C5FE-49D0-BD90-FAB533977626", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания к экспликации", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "E8A45810-B619-4FDB-8D25-A3EF73D29548", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Включение в спецификацию", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "DDFFD567-E787-4065-B90B-7D6DD350D0DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Включение в спецификацию", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "C164A72A-F3EF-48C3-A8B2-91A8A4985E07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Позиция по спецификации", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "5D902762-379F-45BF-8B98-508CFEB0AD31", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Позиция по спецификации", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "065CC399-4911-4ADE-87CB-792C2B29B012", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа по спецификации", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "756C05B2-D04D-43A1-AC16-A9DF94615526", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа по спецификации", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "08175DB6-1BDC-4132-B1A1-527C2FD8900F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Количество", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "CC1F6B51-9001-4428-9352-F355B84923EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Количество", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
		Id = "B77DDA29-B9AE-4CFA-B6FF-32AEA0B9EBE2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания к спецификации", 
		ViewType = "Data")]
	[NodeInput("mstHVACPart", typeof(object))]

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
		Id = "340303C3-FE3D-48A1-A4E2-15331FF43339", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstHVACCOMLib.mstHVACPart.Set_Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstHVACCOMLib.mstHVACPart", 
		NodeName = "Set_Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания к спецификации", 
		ViewType = "Modifier")]
	[NodeInput("mstHVACPart", typeof(object))]
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
}
