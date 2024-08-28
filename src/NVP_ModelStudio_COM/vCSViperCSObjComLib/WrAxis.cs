using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAxis Interface
///</summary>
namespace NVP_ModelStudio_COM._vCSViperCSObjComLib.WrAxis 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAxis_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrAxis _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrAxis;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAxis_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrAxis _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrAxis;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Параметры
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
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("WrAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры
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
		Text = "property EquipmentNodeStart", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///property EquipmentNodeStart
	///</summary>
	public class EquipmentNodeStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EquipmentNodeStart);

		}
	}


	[NVP_Manifest(
		Text = "property EquipmentNodeEnd", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///property EquipmentNodeEnd
	///</summary>
	public class EquipmentNodeEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EquipmentNodeEnd);

		}
	}


	[NVP_Manifest(
		Text = "property HasEquipmentNodeStart", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///property HasEquipmentNodeStart
	///</summary>
	public class HasEquipmentNodeStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasEquipmentNodeStart);

		}
	}


	[NVP_Manifest(
		Text = "property HasEquipmentNodeEnd", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///property HasEquipmentNodeEnd
	///</summary>
	public class HasEquipmentNodeEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasEquipmentNodeEnd);

		}
	}


	[NVP_Manifest(
		Text = "Подсчет числа компонентов", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]
	[NodeInput("bTerminators", typeof(System.Object))]
	[NodeInput("bElbows", typeof(System.Object))]
	[NodeInput("bPipes", typeof(System.Object))]
	[NodeInput("bInlines", typeof(System.Object))]
	[NodeInput("bSupports", typeof(System.Object))]

	///<summary>
	///Подсчет числа компонентов
	///</summary>
	public class CountItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CountItems(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value));

		}
	}


	[NVP_Manifest(
		Text = "Первый компонент", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Первый компонент
	///</summary>
	public class GetFirstComponent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFirstComponent);

		}
	}


	[NVP_Manifest(
		Text = "Последний компонент", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Последний компонент
	///</summary>
	public class GetLastComponent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLastComponent);

		}
	}


	[NVP_Manifest(
		Text = "Предыдущий компонент", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]
	[NodeInput("pCurrent", typeof(System.Object))]

	///<summary>
	///Предыдущий компонент
	///</summary>
	public class GetPrevComponent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPrevComponent(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Следующий компонент", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]
	[NodeInput("pCurrent", typeof(System.Object))]

	///<summary>
	///Следующий компонент
	///</summary>
	public class GetNextComponent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetNextComponent(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Параметр объекта, подключенного в начале", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]
	[NodeInput("ParamName", typeof(System.String))]

	///<summary>
	///Параметр объекта, подключенного в начале
	///</summary>
	public class GetFromObjParamVal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetFromObjParamVal(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Параметр объекта, подключенного в конце", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]
	[NodeInput("ParamName", typeof(System.String))]

	///<summary>
	///Параметр объекта, подключенного в конце
	///</summary>
	public class GetToObjParamVal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetToObjParamVal(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Компоненты трубопровода", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Компоненты трубопровода
	///</summary>
	public class Components : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Components);

		}
	}


	[NVP_Manifest(
		Text = "Трубопровод, к которому подключено начало", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Трубопровод, к которому подключено начало
	///</summary>
	public class StartTee : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartTee);

		}
	}


	[NVP_Manifest(
		Text = "Tрубопровод, к которому подключен конец", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Tрубопровод, к которому подключен конец
	///</summary>
	public class EndTee : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndTee);

		}
	}


	[NVP_Manifest(
		Text = "Имеется трубопровод, к которому подключено начало", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Имеется трубопровод, к которому подключено начало
	///</summary>
	public class HasStartTee : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasStartTee);

		}
	}


	[NVP_Manifest(
		Text = "Имеется трубопровод, к которому подключен конец", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///Имеется трубопровод, к которому подключен конец
	///</summary>
	public class HasEndTee : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasEndTee);

		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("WrAxis", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}
}
