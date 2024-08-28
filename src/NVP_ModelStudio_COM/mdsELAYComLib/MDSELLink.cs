using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSELLink Interface
///</summary>
namespace NVP_ModelStudio_COM._mdsELAYComLib.MDSELLink 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSELLink_Constructor : INode 
	{
		public mdsELAYComLib.IMDSELLink _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsELAYComLib.IMDSELLink;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSELLink_ConstructorCast : INode 
	{
		public mdsELAYComLib.IMDSELLink _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsELAYComLib.IMDSELLink;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

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
	[NodeInput("MDSELLink", typeof(object))]
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
		Text = "Начальная точка", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Начальная точка
	///</summary>
	public class StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartPoint);

		}
	}


	[NVP_Manifest(
		Text = "Конечная точка", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Конечная точка
	///</summary>
	public class EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndPoint);

		}
	}


	[NVP_Manifest(
		Text = "Имеется первая гирлянда", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Имеется первая гирлянда
	///</summary>
	public class GarlandStartEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartEnabled);

		}
	}


	[NVP_Manifest(
		Text = "Имеется первая гирлянда", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Имеется первая гирлянда
	///</summary>
	public class Set_GarlandStartEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Длина первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Длина первой гирлянды
	///</summary>
	public class GarlandStartLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartLength);

		}
	}


	[NVP_Manifest(
		Text = "Длина первой гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Длина первой гирлянды
	///</summary>
	public class Set_GarlandStartLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "z гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///z гирлянды
	///</summary>
	public class GarlandStartWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartWeight);

		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class GarlandStartDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartDiameter);

		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///мм)
	///</summary>
	public class Set_GarlandStartDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartDiameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Число цепей изоляторов первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Число цепей изоляторов первой гирлянды
	///</summary>
	public class GarlandStartChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartChainCount);

		}
	}


	[NVP_Manifest(
		Text = "Число цепей изоляторов первой гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Число цепей изоляторов первой гирлянды
	///</summary>
	public class Set_GarlandStartChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartChainCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Расположение цепей изоляторов первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Расположение цепей изоляторов первой гирлянды
	///</summary>
	public class GarlandStartChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartChainLayout);

		}
	}


	[NVP_Manifest(
		Text = "Расположение цепей изоляторов первой гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Расположение цепей изоляторов первой гирлянды
	///</summary>
	public class Set_GarlandStartChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartChainLayout = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Расстояние между цепями изоляторов первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Расстояние между цепями изоляторов первой гирлянды
	///</summary>
	public class GarlandStartChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartChainDistance);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние между цепями изоляторов первой гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расстояние между цепями изоляторов первой гирлянды
	///</summary>
	public class Set_GarlandStartChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartChainDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Масса первой гирлянды без гололеда, кгс", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Масса первой гирлянды без гололеда, кгс
	///</summary>
	public class GarlandStartTotalWeightWithoutIce : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartTotalWeightWithoutIce);

		}
	}


	[NVP_Manifest(
		Text = "Масса первой гирлянды без гололеда, кгс", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Масса первой гирлянды без гололеда, кгс
	///</summary>
	public class Set_GarlandStartTotalWeightWithoutIce : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartTotalWeightWithoutIce = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Общий вес первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Общий вес первой гирлянды
	///</summary>
	public class GarlandStartTotalWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartTotalWeight);

		}
	}


	[NVP_Manifest(
		Text = "Общий вес первой гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Общий вес первой гирлянды
	///</summary>
	public class Set_GarlandStartTotalWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartTotalWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Угол наклона первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Угол наклона первой гирлянды
	///</summary>
	public class GarlandStartBettaAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartBettaAngle);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние до узла ответвительной арматуры, мм", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Расстояние до узла ответвительной арматуры, мм
	///</summary>
	public class GarlandStartDecorationDist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandStartDecorationDist);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние до узла ответвительной арматуры, мм", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расстояние до узла ответвительной арматуры, мм
	///</summary>
	public class Set_GarlandStartDecorationDist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandStartDecorationDist = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Имеется вторая гирлянда", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Имеется вторая гирлянда
	///</summary>
	public class GarlandEndEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndEnabled);

		}
	}


	[NVP_Manifest(
		Text = "Имеется вторая гирлянда", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Имеется вторая гирлянда
	///</summary>
	public class Set_GarlandEndEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Длина второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Длина второй гирлянды
	///</summary>
	public class GarlandEndLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndLength);

		}
	}


	[NVP_Manifest(
		Text = "Длина второй гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Длина второй гирлянды
	///</summary>
	public class Set_GarlandEndLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Вес одной цепи второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Вес одной цепи второй гирлянды
	///</summary>
	public class GarlandEndWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndWeight);

		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class GarlandEndDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndDiameter);

		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///мм)
	///</summary>
	public class Set_GarlandEndDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndDiameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Число цепей изоляторов второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Число цепей изоляторов второй гирлянды
	///</summary>
	public class GarlandEndChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndChainCount);

		}
	}


	[NVP_Manifest(
		Text = "Число цепей изоляторов второй гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Число цепей изоляторов второй гирлянды
	///</summary>
	public class Set_GarlandEndChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndChainCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Расположение цепей изоляторов второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Расположение цепей изоляторов второй гирлянды
	///</summary>
	public class GarlandEndChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndChainLayout);

		}
	}


	[NVP_Manifest(
		Text = "Расположение цепей изоляторов второй гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Расположение цепей изоляторов второй гирлянды
	///</summary>
	public class Set_GarlandEndChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndChainLayout = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Расстояние между цепями изоляторов второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Расстояние между цепями изоляторов второй гирлянды
	///</summary>
	public class GarlandEndChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndChainDistance);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние между цепями изоляторов второй гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расстояние между цепями изоляторов второй гирлянды
	///</summary>
	public class Set_GarlandEndChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndChainDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Масса второй гирлянды без гололеда, кгс", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Масса второй гирлянды без гололеда, кгс
	///</summary>
	public class GarlandEndTotalWeightWithoutIce : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndTotalWeightWithoutIce);

		}
	}


	[NVP_Manifest(
		Text = "Масса второй гирлянды без гололеда, кгс", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Масса второй гирлянды без гололеда, кгс
	///</summary>
	public class Set_GarlandEndTotalWeightWithoutIce : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndTotalWeightWithoutIce = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Общий вес второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Общий вес второй гирлянды
	///</summary>
	public class GarlandEndTotalWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndTotalWeight);

		}
	}


	[NVP_Manifest(
		Text = "Угол наклона второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Угол наклона второй гирлянды
	///</summary>
	public class GarlandEndBettaAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndBettaAngle);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние до узла ответвительной арматуры, мм", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Расстояние до узла ответвительной арматуры, мм
	///</summary>
	public class GarlandEndDecorationDist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandEndDecorationDist);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние до узла ответвительной арматуры, мм", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расстояние до узла ответвительной арматуры, мм
	///</summary>
	public class Set_GarlandEndDecorationDist : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandEndDecorationDist = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Единицы измерения силы", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Единицы измерения силы
	///</summary>
	public class PowerUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PowerUnits);

		}
	}


	[NVP_Manifest(
		Text = "Единицы измерения силы", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Единицы измерения силы
	///</summary>
	public class Set_PowerUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PowerUnits = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method Calculate", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("Temperature", typeof(System.Double))]
	[NodeInput("Wind", typeof(System.Double))]
	[NodeInput("Ice", typeof(System.Double))]

	///<summary>
	///method Calculate
	///</summary>
	public class Calculate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Calculate(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Text = "Модель провода", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Модель провода
	///</summary>
	public class Model : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Model);

		}
	}


	[NVP_Manifest(
		Text = "кв. мм)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///кв. мм)
	///</summary>
	public class Section : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Section);

		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class Diameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Diameter);

		}
	}


	[NVP_Manifest(
		Text = "кг/км)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///кг/км)
	///</summary>
	public class Mass : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Mass);

		}
	}


	[NVP_Manifest(
		Text = "Сигма tн", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Сигма tн
	///</summary>
	public class SigmaTn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SigmaTn);

		}
	}


	[NVP_Manifest(
		Text = "Сигма tм", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Сигма tм
	///</summary>
	public class SigmaTm : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SigmaTm);

		}
	}


	[NVP_Manifest(
		Text = "Сигма tэ", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Сигма tэ
	///</summary>
	public class SigmaTe : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SigmaTe);

		}
	}


	[NVP_Manifest(
		Text = "E - модуль упругости", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///E - модуль упругости
	///</summary>
	public class E : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.E);

		}
	}


	[NVP_Manifest(
		Text = "Мод. нач. F", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Мод. нач. F
	///</summary>
	public class F : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.F);

		}
	}


	[NVP_Manifest(
		Text = "Мод. пред. F", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Мод. пред. F
	///</summary>
	public class D : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.D);

		}
	}


	[NVP_Manifest(
		Text = "1e-6/град. С)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///1e-6/град. С)
	///</summary>
	public class Alpha : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Alpha);

		}
	}


	[NVP_Manifest(
		Text = "м)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///м)
	///</summary>
	public class FactoryLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FactoryLength);

		}
	}


	[NVP_Manifest(
		Text = "Число проводов расщепленной фазы", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Число проводов расщепленной фазы
	///</summary>
	public class SplitPhase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SplitPhase);

		}
	}


	[NVP_Manifest(
		Text = "Число проводов расщепленной фазы", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Число проводов расщепленной фазы
	///</summary>
	public class Set_SplitPhase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SplitPhase = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class SplitDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SplitDistance);

		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///мм)
	///</summary>
	public class Set_SplitDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SplitDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Число стяжек на 10 м", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Число стяжек на 10 м
	///</summary>
	public class ClampingDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClampingDensity);

		}
	}


	[NVP_Manifest(
		Text = "Число стяжек на 10 м", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Число стяжек на 10 м
	///</summary>
	public class Set_ClampingDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClampingDensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Вес стяжек", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Вес стяжек
	///</summary>
	public class ClampingWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClampingWeight);

		}
	}


	[NVP_Manifest(
		Text = "Вес стяжек", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Вес стяжек
	///</summary>
	public class Set_ClampingWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClampingWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Режим отображения результатов", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Режим отображения результатов
	///</summary>
	public class TotalResultDataMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TotalResultDataMode);

		}
	}


	[NVP_Manifest(
		Text = "Режим отображения результатов", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Режим отображения результатов
	///</summary>
	public class Set_TotalResultDataMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TotalResultDataMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Ошибка при расчете провода", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Ошибка при расчете провода
	///</summary>
	public class CalculationError : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CalculationError);

		}
	}


	[NVP_Manifest(
		Text = "Режим расчета", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Режим расчета
	///</summary>
	public class ModeIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ModeIndex);

		}
	}


	[NVP_Manifest(
		Text = "Режим расчета", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Режим расчета
	///</summary>
	public class Set_ModeIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ModeIndex = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Длина пролета", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Длина пролета
	///</summary>
	public class SpanLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SpanLength);

		}
	}


	[NVP_Manifest(
		Text = "Приведенный центр тяжести", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Приведенный центр тяжести
	///</summary>
	public class CentroidHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CentroidHeight);

		}
	}


	[NVP_Manifest(
		Text = "Название исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Название исходного режима
	///</summary>
	public class InitialModeName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialModeName);

		}
	}


	[NVP_Manifest(
		Text = "Сигма исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Сигма исходного режима
	///</summary>
	public class InitialModeSigma : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialModeSigma);

		}
	}


	[NVP_Manifest(
		Text = "Гамма исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Гамма исходного режима
	///</summary>
	public class InitialModeGamma : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialModeGamma);

		}
	}


	[NVP_Manifest(
		Text = "Температура исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Температура исходного режима
	///</summary>
	public class InitialModeT : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialModeT);

		}
	}


	[NVP_Manifest(
		Text = "Ед.силы/мм?)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Ед.силы/мм?)
	///</summary>
	public class SigmaCoeff : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SigmaCoeff);

		}
	}


	[NVP_Manifest(
		Text = "Нагрузка на провод", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Нагрузка на провод
	///</summary>
	public class GammaCoeff : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GammaCoeff);

		}
	}


	[NVP_Manifest(
		Text = "м)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///м)
	///</summary>
	public class LengthMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LengthMax);

		}
	}


	[NVP_Manifest(
		Text = "м)", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///м)
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}


	[NVP_Manifest(
		Text = "м)", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///м)
	///</summary>
	public class Set_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Length = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Нормативные нагрузки", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Нормативные нагрузки
	///</summary>
	public class GammaStdNorm : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GammaStdNorm);

		}
	}


	[NVP_Manifest(
		Text = "Расчетные нагрузки", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Расчетные нагрузки
	///</summary>
	public class GammaStdCalc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GammaStdCalc);

		}
	}


	[NVP_Manifest(
		Text = "Удельные нагрузки", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Удельные нагрузки
	///</summary>
	public class GammaStdSpec : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GammaStdSpec);

		}
	}


	[NVP_Manifest(
		Text = "Максимальная стрела провеса для всех режимов", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Максимальная стрела провеса для всех режимов
	///</summary>
	public class SlackMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlackMax);

		}
	}


	[NVP_Manifest(
		Text = "Стрела провеса", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Стрела провеса
	///</summary>
	public class Slack : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Slack);

		}
	}


	[NVP_Manifest(
		Text = "Стрела провеса", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Стрела провеса
	///</summary>
	public class Set_Slack : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Slack = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Угол отклонения ветром", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Угол отклонения ветром
	///</summary>
	public class WindAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WindAngle);

		}
	}


	[NVP_Manifest(
		Text = "Допустимое тяжение для опоры", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Допустимое тяжение для опоры
	///</summary>
	public class SupportStressMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SupportStressMax);

		}
	}


	[NVP_Manifest(
		Text = "Текущее значение тяжения", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Текущее значение тяжения
	///</summary>
	public class Stress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Stress);

		}
	}


	[NVP_Manifest(
		Text = "Способ задания тяжения", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Способ задания тяжения
	///</summary>
	public class MaxStress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaxStress);

		}
	}


	[NVP_Manifest(
		Text = "Способ задания тяжения", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Способ задания тяжения
	///</summary>
	public class Set_MaxStress : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MaxStress = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Максимальное тяжение", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Максимальное тяжение
	///</summary>
	public class StressMaxValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StressMaxValue);

		}
	}


	[NVP_Manifest(
		Text = "Максимальное тяжение", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Максимальное тяжение
	///</summary>
	public class Set_StressMaxValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StressMaxValue = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Максимальное напряжение", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Максимальное напряжение
	///</summary>
	public class TensionMaxValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TensionMaxValue);

		}
	}


	[NVP_Manifest(
		Text = "Максимальное напряжение", 
		ViewType = "Modifier")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Максимальное напряжение
	///</summary>
	public class Set_TensionMaxValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TensionMaxValue = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property NodeStart", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///property NodeStart
	///</summary>
	public class NodeStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NodeStart);

		}
	}


	[NVP_Manifest(
		Text = "property NodeEnd", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///property NodeEnd
	///</summary>
	public class NodeEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NodeEnd);

		}
	}


	[NVP_Manifest(
		Text = "property Nodes", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///property Nodes
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
		Text = "method climateData", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///method climateData
	///</summary>
	public class climateData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.climateData);

		}
	}


	[NVP_Manifest(
		Text = "Высота начальной точки подвеса, м", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Высота начальной точки подвеса, м
	///</summary>
	public class StartLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartLevel);

		}
	}


	[NVP_Manifest(
		Text = "Высота конечной точки подвеса, м", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Высота конечной точки подвеса, м
	///</summary>
	public class EndLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndLevel);

		}
	}


	[NVP_Manifest(
		Text = "method CurrentModeData", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///method CurrentModeData
	///</summary>
	public class CurrentModeData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurrentModeData);

		}
	}


	[NVP_Manifest(
		Text = "method CalculateByMode", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]
	[NodeInput("nMode", typeof(System.Object))]

	///<summary>
	///method CalculateByMode
	///</summary>
	public class CalculateByMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CalculateByMode(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Коэффициенты расчетных формул", 
		ViewType = "Data")]
	[NodeInput("MDSELLink", typeof(object))]

	///<summary>
	///Коэффициенты расчетных формул
	///</summary>
	public class CalcCoeffs : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CalcCoeffs);

		}
	}
}
