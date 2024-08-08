using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Опора ЛЭП
///</summary>
namespace mdsLINEComLib.MDSLTower 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLTower_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLTower _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLTower;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLTower_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLTower _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLTower;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Профиль, которому принадлежит опора", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Профиль, которому принадлежит опора
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
		Text = "Предыдущая опора", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Предыдущая опора
	///</summary>
	public class prevBearing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.prevBearing);

		}
	}


	[NVP_Manifest(
		Text = "Следующая опора", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Следующая опора
	///</summary>
	public class nextBearing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.nextBearing);

		}
	}


	[NVP_Manifest(
		Text = "Имеется ли предыдущая опора", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Имеется ли предыдущая опора
	///</summary>
	public class isPrevBearing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isPrevBearing);

		}
	}


	[NVP_Manifest(
		Text = "Имеется ли следующая опора", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Имеется ли следующая опора
	///</summary>
	public class isNextBearing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isNextBearing);

		}
	}


	[NVP_Manifest(
		Text = "Номер опоры на профиле", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Номер опоры на профиле
	///</summary>
	public class numInLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.numInLine);

		}
	}


	[NVP_Manifest(
		Text = "Имеется ли профиль-владелец", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Имеется ли профиль-владелец
	///</summary>
	public class HasOwner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasOwner);

		}
	}


	[NVP_Manifest(
		Text = "Свойства опоры", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Свойства опоры
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
		Text = "Графическое представление опоры", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Графическое представление опоры
	///</summary>
	public class SketchFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SketchFirst);

		}
	}


	[NVP_Manifest(
		Text = "Провода на данной опоре", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]

	///<summary>
	///Провода на данной опоре
	///</summary>
	public class Wires : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Wires);

		}
	}


	[NVP_Manifest(
		Text = "Имеется ли провод на узле", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]
	[NodeInput("nodeName", typeof(System.String))]

	///<summary>
	///Имеется ли провод на узле
	///</summary>
	public class HasWireAtNode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasWireAtNode(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Получение провода по имени узла", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]
	[NodeInput("nodeName", typeof(System.String))]

	///<summary>
	///Получение провода по имени узла
	///</summary>
	public class FirstWireAtNode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FirstWireAtNode(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Получение провода по имени узла", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]
	[NodeInput("nodeName", typeof(System.String))]

	///<summary>
	///Получение провода по имени узла
	///</summary>
	public class WiresAtNode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WiresAtNode(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "method TowerData", 
		ViewType = "Data")]
	[NodeInput("MDSLTower", typeof(object))]
	[NodeInput("modeName", typeof(System.String))]
	[NodeInput("WindAngle", typeof(System.Object))]

	///<summary>
	///method TowerData
	///</summary>
	public class TowerData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TowerData(inputs[1].Value,inputs[2].Value));

		}
	}
}
