using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSCable Interface
///</summary>
namespace mdsMetalLib.MDSCable 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSCable_Constructor : INode 
	{
		public mdsMetalLib.IMDSCable _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsMetalLib.IMDSCable;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSCable_ConstructorCast : INode 
	{
		public mdsMetalLib.IMDSCable _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsMetalLib.IMDSCable;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Описание кабеля", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Описание кабеля
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Text = "Описание кабеля", 
		ViewType = "Modifier")]
	[NodeInput("MDSCable", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Описание кабеля
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Длина в метрах", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Длина в метрах
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
		Text = "Длина текущего участка в метрах", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Длина текущего участка в метрах
	///</summary>
	public class SegmentLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SegmentLength);

		}
	}


	[NVP_Manifest(
		Text = "Диаметр в мм", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Диаметр в мм
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
		Text = "Группа", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Группа
	///</summary>
	public class Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Group);

		}
	}


	[NVP_Manifest(
		Text = "Начальная точка", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Начальная точка
	///</summary>
	public class StartDesc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartDesc);

		}
	}


	[NVP_Manifest(
		Text = "Конечная точка", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Конечная точка
	///</summary>
	public class EndDesc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndDesc);

		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

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
	[NodeInput("MDSCable", typeof(object))]
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
		Text = "Начало", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Начало
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
		Text = "Конец", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Конец
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
		Text = "Режим эскиза", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Режим эскиза
	///</summary>
	public class SketchMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SketchMode);

		}
	}


	[NVP_Manifest(
		Text = "Режим эскиза", 
		ViewType = "Modifier")]
	[NodeInput("MDSCable", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Режим эскиза
	///</summary>
	public class Set_SketchMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SketchMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Вычисление длины кабеля между высотными отметками", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]
	[NodeInput("LevelMin", typeof(System.Double))]
	[NodeInput("LevelMax", typeof(System.Double))]

	///<summary>
	///Вычисление длины кабеля между высотными отметками
	///</summary>
	public class GetLengthOnLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLengthOnLevel(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Кабельный журнал", 
		ViewType = "Data")]
	[NodeInput("MDSCable", typeof(object))]

	///<summary>
	///Кабельный журнал
	///</summary>
	public class Journal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Journal);

		}
	}
}
