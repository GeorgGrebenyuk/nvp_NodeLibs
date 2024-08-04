using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ImstProjectDocFrame Interface
///</summary>
namespace mstProjectCOMLib.mstProjectDocFrame 
{

	[NVP_Manifest(
		Id = "9A448790-0F11-4133-92CC-A874F40DF08A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.mstProjectDocFrame_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "_mstProjectDocFrame_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstProjectDocFrame_Constructor : INode 
	{
		public mstProjectCOMLib.ImstProjectDocFrame _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mstProjectCOMLib.ImstProjectDocFrame;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "305C215A-54CA-4F84-A183-CA866D42EB24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.mstProjectDocFrame_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "_mstProjectDocFrame_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class mstProjectDocFrame_ConstructorCast : INode 
	{
		public mstProjectCOMLib.ImstProjectDocFrame _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mstProjectCOMLib.ImstProjectDocFrame;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "61D1488C-3DB5-4766-96B3-8E529C2C0938", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "9F018A5F-DB4F-4ADC-91AD-DF49ACDC68CD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("mstProjectDocFrame", typeof(object))]
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
		Id = "909A9EF5-A440-4F2F-8BCE-B8E4DE4BDC9E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.ParametricData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "ParametricData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметрические данные", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "4B905F87-A3A4-4B0C-90AF-50AB990BF45B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.UnitPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "UnitPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Положение объекта", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "3D4D7725-6C95-4551-9105-88FC726E5612", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.UnitName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "UnitName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование объекта", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "11E2BA12-F197-4BD1-8E8D-6B2EE3C5A84A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Part_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Part_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "363D9FD3-A722-4530-AE76-F12284BA792D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Part_Tag", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Part_Tag", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "модель)", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "8476949E-F56A-4FA0-B6DA-CFFF83BD2822", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Part_Manufacturer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Part_Manufacturer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Производитель", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "9C556B07-B6C4-4DEB-8F15-975FD97D710C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Part_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Part_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нормативный документ", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "ED952470-FCEB-4B8D-B873-6455642575F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Part_Refdrawing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Part_Refdrawing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ссылочный чертеж", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "1E2C8BCC-59B8-45C6-BA44-366992326880", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Part_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Part_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Материал", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "A2FA4CDA-7D63-4491-B1BE-BE07AACB83C3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Part_Material_Standard", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Part_Material_Standard", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нормативный документ на материал", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "D81F6B44-4DBF-43D8-A936-3E2595F5D5C8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Part_Weight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Part_Weight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "D1FF1DC8-DA7B-4AE4-8B64-1FC9015F5B31", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Part_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Part_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "649BBA2F-530F-4FB8-A289-0EF356EDF2FD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Part_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Part_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа изделий", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "963D4493-CB2C-4D57-B4C7-E7D7E2874BB4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Part_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Part_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип изделия", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "C6597936-A2B8-48A4-A497-5A7CA6B975AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Part_Reference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Part_Reference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Код ОКП", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "9A5B6B4A-02E6-4A37-811C-02609CC06BE2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Part_Weight_Netto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Part_Weight_Netto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес нетто", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "EDFB058F-A2ED-4645-BDD7-52C0A0518531", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Part_Weight_Bruto", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Part_Weight_Bruto", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вес бруто", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "11ECE920-78C9-4695-A07A-291DCF40D559", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Explication_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Explication_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Включение в экспликацию", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "B04C8499-F47B-4B34-B0F3-85440F8B4439", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Explication_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Explication_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Позиция по экспликации", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "B384DC19-DB81-4C60-83E7-2DBA50617518", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Explication_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Explication_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа по экспликации", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "F4201F0B-7DDA-457E-8BC5-244CA4E72F63", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Explication_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Explication_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания к экспликации", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "696619EB-5538-446B-B39C-DAFF9FDBFFB7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Bom_Include", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Bom_Include", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Включение в спецификацию", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "5F832179-CE3F-4B68-8992-402655E695CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Bom_Number", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Bom_Number", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Позиция по спецификации", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "B11226F8-6CBE-4F43-9D32-31E1A494639A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Bom_Group", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Bom_Group", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Группа по спецификации", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "A84D6842-5545-4DA9-8CBD-E4C02602EB71", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Bom_Qty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Bom_Qty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Количество", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
		Id = "CA61C6D6-82D7-4D73-ADE4-69176C279F4C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mstProjectCOMLib.mstProjectDocFrame.Bom_Comment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mstProjectCOMLib.mstProjectDocFrame", 
		NodeName = "Bom_Comment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Примечания к спецификации", 
		ViewType = "Data")]
	[NodeInput("mstProjectDocFrame", typeof(object))]

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
}
