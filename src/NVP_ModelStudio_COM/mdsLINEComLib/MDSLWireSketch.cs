using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Провод
///</summary>
namespace NVP_ModelStudio_COM._mdsLINEComLib.MDSLWireSketch 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLWireSketch_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLWireSketch _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLWireSketch;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLWireSketch_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLWireSketch _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLWireSketch;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
		Text = "Аварийный обрыв", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Аварийный обрыв
	///</summary>
	public class WireBreak : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WireBreak);

		}
	}


	[NVP_Manifest(
		Text = "Аварийный обрыв", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Аварийный обрыв
	///</summary>
	public class Set_WireBreak : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WireBreak = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Начальная точка", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
		Text = "Масса одной цепи первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Масса одной цепи первой гирлянды
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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
		Text = "Общая масса первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Общая масса первой гирлянды
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
		Text = "Угол наклона первой гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
		Text = "Имеется вторая гирлянда", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
		Text = "Масса одной цепи второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Масса одной цепи второй гирлянды
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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
		Text = "Общая масса второй гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Общая масса второй гирлянды
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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
		Text = "Имеются промежуточные гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Имеются промежуточные гирлянды
	///</summary>
	public class GarlandIntermEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermEnabled);

		}
	}


	[NVP_Manifest(
		Text = "Имеются промежуточные гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Имеются промежуточные гирлянды
	///</summary>
	public class Set_GarlandIntermEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandIntermEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Количество промежуточных гирлянд", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Количество промежуточных гирлянд
	///</summary>
	public class GarlandIntermCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermCount);

		}
	}


	[NVP_Manifest(
		Text = "Тип изолятора", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class GarlandIntermInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermInsulatorType);

		}
	}


	[NVP_Manifest(
		Text = "Тип изолятора", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class Set_GarlandIntermInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandIntermInsulatorType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Длина промежуточной гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Длина промежуточной гирлянды
	///</summary>
	public class GarlandIntermLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermLength);

		}
	}


	[NVP_Manifest(
		Text = "Длина промежуточной гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Длина промежуточной гирлянды
	///</summary>
	public class Set_GarlandIntermLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandIntermLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Масса одной цепи промежуточной гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Масса одной цепи промежуточной гирлянды
	///</summary>
	public class GarlandIntermWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermWeight);

		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class GarlandIntermDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermDiameter);

		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///мм)
	///</summary>
	public class Set_GarlandIntermDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandIntermDiameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Число цепей изоляторов промежуточной гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число цепей изоляторов промежуточной гирлянды
	///</summary>
	public class GarlandIntermChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermChainCount);

		}
	}


	[NVP_Manifest(
		Text = "Число цепей изоляторов промежуточной гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Число цепей изоляторов промежуточной гирлянды
	///</summary>
	public class Set_GarlandIntermChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandIntermChainCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Расположение цепей изоляторов промежуточной гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Расположение цепей изоляторов промежуточной гирлянды
	///</summary>
	public class GarlandIntermChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermChainLayout);

		}
	}


	[NVP_Manifest(
		Text = "Расположение цепей изоляторов промежуточной гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Расположение цепей изоляторов промежуточной гирлянды
	///</summary>
	public class Set_GarlandIntermChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandIntermChainLayout = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Расстояние между цепями изоляторов промежуточной гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Расстояние между цепями изоляторов промежуточной гирлянды
	///</summary>
	public class GarlandIntermChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermChainDistance);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние между цепями изоляторов промежуточной гирлянды", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Расстояние между цепями изоляторов промежуточной гирлянды
	///</summary>
	public class Set_GarlandIntermChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandIntermChainDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Общая масса промежуточной гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Общая масса промежуточной гирлянды
	///</summary>
	public class GarlandIntermTotalWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermTotalWeight);

		}
	}


	[NVP_Manifest(
		Text = "Угол наклона промежуточной гирлянды", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Угол наклона промежуточной гирлянды
	///</summary>
	public class GarlandIntermBettaAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandIntermBettaAngle);

		}
	}


	[NVP_Manifest(
		Text = "Наименование - провод", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Наименование - провод
	///</summary>
	public class LinkName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinkName);

		}
	}


	[NVP_Manifest(
		Text = "Наименование - первая гирлянда", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Наименование - первая гирлянда
	///</summary>
	public class StartGarlandName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartGarlandName);

		}
	}


	[NVP_Manifest(
		Text = "Наименование - вторая гирлянда", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Наименование - вторая гирлянда
	///</summary>
	public class EndGarlandName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndGarlandName);

		}
	}


	[NVP_Manifest(
		Text = "Наименование - гаситель вибрации", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Наименование - гаситель вибрации
	///</summary>
	public class SuppressorName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressorName);

		}
	}


	[NVP_Manifest(
		Text = "Наличие", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Наличие
	///</summary>
	public class SuppressorEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressorEnabled);

		}
	}


	[NVP_Manifest(
		Text = "Наличие", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Наличие
	///</summary>
	public class Set_SuppressorEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SuppressorEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Количество", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Количество
	///</summary>
	public class SuppressorCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressorCount);

		}
	}


	[NVP_Manifest(
		Text = "Гасители", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Гасители
	///</summary>
	public class Suppressors : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Suppressors);

		}
	}


	[NVP_Manifest(
		Text = "Гасители", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Гасители
	///</summary>
	public class Set_Suppressors : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Suppressors = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Место установки S1", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Место установки S1
	///</summary>
	public class SuppressorS1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressorS1);

		}
	}


	[NVP_Manifest(
		Text = "Место установки S2", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Место установки S2
	///</summary>
	public class SuppressorS2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressorS2);

		}
	}


	[NVP_Manifest(
		Text = "Место установки S3", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Место установки S3
	///</summary>
	public class SuppressorS3 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressorS3);

		}
	}


	[NVP_Manifest(
		Text = "Место установки S4", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Место установки S4
	///</summary>
	public class SuppressorS4 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SuppressorS4);

		}
	}


	[NVP_Manifest(
		Text = "Единицы измерения силы", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
		Text = "Модель провода", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
		Text = "Масса стяжек", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Масса стяжек
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
		Text = "Масса стяжек", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Масса стяжек
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
		Text = "Фаза для расчета", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Фаза для расчета
	///</summary>
	public class phaseName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.phaseName);

		}
	}


	[NVP_Manifest(
		Text = "Фаза для расчета", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Фаза для расчета
	///</summary>
	public class Set_phaseName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.phaseName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Режим отображения результатов", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
		Text = "Статус расчета исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Статус расчета исходного режима
	///</summary>
	public class InitialModeStatus : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialModeStatus);

		}
	}


	[NVP_Manifest(
		Text = "Выбор исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Выбор исходного режима
	///</summary>
	public class InitialModeOption : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InitialModeOption);

		}
	}


	[NVP_Manifest(
		Text = "Выбор исходного режима", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Выбор исходного режима
	///</summary>
	public class Set_InitialModeOption : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InitialModeOption = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Название исходного режима", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
		Text = "1й критический пролет", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///1й критический пролет
	///</summary>
	public class Critical_1_SpanLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Critical_1_SpanLength);

		}
	}


	[NVP_Manifest(
		Text = "2й критический пролет", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///2й критический пролет
	///</summary>
	public class Critical_2_SpanLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Critical_2_SpanLength);

		}
	}


	[NVP_Manifest(
		Text = "3й критический пролет", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///3й критический пролет
	///</summary>
	public class Critical_3_SpanLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Critical_3_SpanLength);

		}
	}


	[NVP_Manifest(
		Text = "Ограничение допустимого напряжения", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Ограничение допустимого напряжения
	///</summary>
	public class MaxStressLimitation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaxStressLimitation);

		}
	}


	[NVP_Manifest(
		Text = "Ограничение допустимого напряжения", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Ограничение допустимого напряжения
	///</summary>
	public class Set_MaxStressLimitation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MaxStressLimitation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Доп. напряжение в режиме максимальной нагрузки", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Доп. напряжение в режиме максимальной нагрузки
	///</summary>
	public class StressLim_MaxLoad : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StressLim_MaxLoad);

		}
	}


	[NVP_Manifest(
		Text = "Доп. напряжение в режиме максимальной нагрузки", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Доп. напряжение в режиме максимальной нагрузки
	///</summary>
	public class Set_StressLim_MaxLoad : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StressLim_MaxLoad = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Доп. напряжение в режиме минимальной температуры", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Доп. напряжение в режиме минимальной температуры
	///</summary>
	public class StressLim_MinTemp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StressLim_MinTemp);

		}
	}


	[NVP_Manifest(
		Text = "Доп. напряжение в режиме минимальной температуры", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Доп. напряжение в режиме минимальной температуры
	///</summary>
	public class Set_StressLim_MinTemp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StressLim_MinTemp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Доп. напряжение для среднегодового режима", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Доп. напряжение для среднегодового режима
	///</summary>
	public class StressLim_MidYear : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StressLim_MidYear);

		}
	}


	[NVP_Manifest(
		Text = "Доп. напряжение для среднегодового режима", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Доп. напряжение для среднегодового режима
	///</summary>
	public class Set_StressLim_MidYear : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StressLim_MidYear = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Ошибка при расчете провода", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]
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
		Text = "Н/м*кв.мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Н/м*кв.мм)
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
		Text = "Тяжения в расчетном режиме", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Тяжения в расчетном режиме
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
		Text = "Нагрузка на провод в расчетном режиме", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Нагрузка на провод в расчетном режиме
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
		Text = "Максимальная стрела провеса в расч. режиме", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Максимальная стрела провеса в расч. режиме
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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
		Text = "Приведенный центр тяжести", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
		Text = "Длина анкерного участка", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Длина анкерного участка
	///</summary>
	public class LengthSection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LengthSection);

		}
	}


	[NVP_Manifest(
		Text = "Приведенный пролет", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Приведенный пролет
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
		Text = "Габаритный пролет", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Габаритный пролет
	///</summary>
	public class GabaritSpanLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GabaritSpanLength);

		}
	}


	[NVP_Manifest(
		Text = "Режим расчета габаритного пролета", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Режим расчета габаритного пролета
	///</summary>
	public class GabaritCalcMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GabaritCalcMode);

		}
	}


	[NVP_Manifest(
		Text = "м)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
		Text = "Угол отклонения ветром", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
		Text = "Число цепей", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число цепей
	///</summary>
	public class ChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ChainCount);

		}
	}


	[NVP_Manifest(
		Text = "Число цепей", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Число цепей
	///</summary>
	public class Set_ChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ChainCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Число фаз", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число фаз
	///</summary>
	public class PhaseCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PhaseCount);

		}
	}


	[NVP_Manifest(
		Text = "м)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///м)
	///</summary>
	public class LengthPhase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LengthPhase);

		}
	}


	[NVP_Manifest(
		Text = "м)", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("phaseName", typeof(System.Object))]

	///<summary>
	///м)
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Число проводов", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число проводов
	///</summary>
	public class CountWire : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CountWire);

		}
	}


	[NVP_Manifest(
		Text = "Число пролетов", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число пролетов
	///</summary>
	public class CountSpan : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CountSpan);

		}
	}


	[NVP_Manifest(
		Text = "Число цепей", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число цепей
	///</summary>
	public class Chains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Chains);

		}
	}


	[NVP_Manifest(
		Text = "Число фаз", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Число фаз
	///</summary>
	public class Phases : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Phases);

		}
	}


	[NVP_Manifest(
		Text = "Допустимое тяжение для опоры", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
		Text = "Нормативные нагрузки", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
		Text = "Удельные расчетные нагрузки", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Удельные расчетные нагрузки
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
		Text = "method climateData", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
		Text = "Calculate mode by temp, wind, ice", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("Temperature", typeof(System.Double))]
	[NodeInput("Wind", typeof(System.Double))]
	[NodeInput("Ice", typeof(System.Double))]

	///<summary>
	///Calculate mode by temp, wind, ice
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
		Text = "CalculateMode by mode name", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("modeName", typeof(System.String))]

	///<summary>
	///CalculateMode by mode name
	///</summary>
	public class CalculateMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CalculateMode(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Пролеты", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Пролеты
	///</summary>
	public class Element1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element1);

		}
	}


	[NVP_Manifest(
		Text = "Пролеты", 
		ViewType = "Modifier")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Пролеты
	///</summary>
	public class Set_Element1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property NodeStart", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
	[NodeInput("MDSLWireSketch", typeof(object))]

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
		Text = "property BearingStart", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///property BearingStart
	///</summary>
	public class BearingStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BearingStart);

		}
	}


	[NVP_Manifest(
		Text = "property BearingEnd", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///property BearingEnd
	///</summary>
	public class BearingEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BearingEnd);

		}
	}


	[NVP_Manifest(
		Text = "property IsTros", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///property IsTros
	///</summary>
	public class IsTros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsTros);

		}
	}


	[NVP_Manifest(
		Text = "Единицы измерения силы", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///Единицы измерения силы
	///</summary>
	public class PowerCoefficient : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PowerCoefficient);

		}
	}


	[NVP_Manifest(
		Text = "ExistTros", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///ExistTros
	///</summary>
	public class ExistTros : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExistTros);

		}
	}


	[NVP_Manifest(
		Text = "TrosInSection", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///TrosInSection
	///</summary>
	public class TrosInSection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TrosInSection);

		}
	}


	[NVP_Manifest(
		Text = "method owner", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///method owner
	///</summary>
	public class owner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.owner);

		}
	}


	[NVP_Manifest(
		Text = "property IsOptical", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///property IsOptical
	///</summary>
	public class IsOptical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsOptical);

		}
	}


	[NVP_Manifest(
		Text = "ExistOptical", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///ExistOptical
	///</summary>
	public class ExistOptical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ExistOptical);

		}
	}


	[NVP_Manifest(
		Text = "OpticalInSection", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///OpticalInSection
	///</summary>
	public class OpticalInSection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OpticalInSection);

		}
	}


	[NVP_Manifest(
		Text = "TypeLink", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

	///<summary>
	///TypeLink
	///</summary>
	public class TypeLink : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TypeLink);

		}
	}


	[NVP_Manifest(
		Text = "method CurrentModeData", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
		Text = "method MinPoint_X", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("nSpanNum", typeof(System.Object))]

	///<summary>
	///method MinPoint_X
	///</summary>
	public class MinPoint_X : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinPoint_X(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "method MinPoint_Y", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("nSpanNum", typeof(System.Object))]

	///<summary>
	///method MinPoint_Y
	///</summary>
	public class MinPoint_Y : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MinPoint_Y(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "method SlackSpanMiddle", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("nSpan", typeof(System.Object))]
	[NodeInput("fTemper", typeof(System.Double))]

	///<summary>
	///method SlackSpanMiddle
	///</summary>
	public class SlackSpanMiddle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlackSpanMiddle(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Расчет монтажных стрел с учетом вытяжки", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("nSpan", typeof(System.Object))]
	[NodeInput("fTemper", typeof(System.Double))]

	///<summary>
	///Расчет монтажных стрел с учетом вытяжки
	///</summary>
	public class SlackSpanMount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlackSpanMount(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Расчет монтажных напряжений", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]
	[NodeInput("fTemper", typeof(System.Double))]

	///<summary>
	///Расчет монтажных напряжений
	///</summary>
	public class StressMount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StressMount(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Коэффициенты расчетных формул", 
		ViewType = "Data")]
	[NodeInput("MDSLWireSketch", typeof(object))]

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
