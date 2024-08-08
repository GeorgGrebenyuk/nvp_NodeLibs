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
