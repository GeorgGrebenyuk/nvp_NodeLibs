using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ImstProjectDummy Interface
///</summary>
namespace NVP_ModelStudio_COM._mstProjectCOMLib.mstProjectDummy 
{

	[NVP_Manifest(
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
