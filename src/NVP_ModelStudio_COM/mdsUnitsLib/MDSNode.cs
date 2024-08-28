using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSNode Interface
///</summary>
namespace NVP_ModelStudio_COM._mdsUnitsLib.MDSNode 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSNode_Constructor : INode 
	{
		public mdsUnitsLib.IMDSNode _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSNode;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSNode_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSNode _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSNode;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Наименование стыка", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Наименование стыка
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
		Text = "Наименование стыка", 
		ViewType = "Modifier")]
	[NodeInput("MDSNode", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Наименование стыка
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
		Text = "Точка вставки", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Точка вставки
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Text = "Точка вставки", 
		ViewType = "Modifier")]
	[NodeInput("MDSNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Точка вставки
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Направление", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Направление
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	[NVP_Manifest(
		Text = "Направление", 
		ViewType = "Modifier")]
	[NodeInput("MDSNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Направление
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Радиус", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Радиус
	///</summary>
	public class Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Radius);

		}
	}


	[NVP_Manifest(
		Text = "Радиус", 
		ViewType = "Modifier")]
	[NodeInput("MDSNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Радиус
	///</summary>
	public class Set_Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Radius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Длина вектора направления", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Длина вектора направления
	///</summary>
	public class DirectionLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DirectionLength);

		}
	}


	[NVP_Manifest(
		Text = "Длина вектора направления", 
		ViewType = "Modifier")]
	[NodeInput("MDSNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Длина вектора направления
	///</summary>
	public class Set_DirectionLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DirectionLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

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
	[NodeInput("MDSNode", typeof(object))]
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
		Text = "Тип стыка", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Тип стыка
	///</summary>
	public class NodeType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NodeType);

		}
	}


	[NVP_Manifest(
		Text = "Тип стыка", 
		ViewType = "Modifier")]
	[NodeInput("MDSNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип стыка
	///</summary>
	public class Set_NodeType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NodeType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Объект-владелец", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Объект-владелец
	///</summary>
	public class OwnerObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OwnerObject);

		}
	}


	[NVP_Manifest(
		Text = "Существует ли объект-владелец", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Существует ли объект-владелец
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
		Text = "Связь-владелец", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Связь-владелец
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
		Text = "Существует ли связь-владелец", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Существует ли связь-владелец
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
		Text = "Подключенные связи", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Подключенные связи
	///</summary>
	public class Links : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Links);

		}
	}


	[NVP_Manifest(
		Text = "Коллекция связанных объектов, удовлетворяющих условию", 
		ViewType = "Data")]
	[NodeInput("MDSNode", typeof(object))]

	///<summary>
	///Коллекция связанных объектов, удовлетворяющих условию
	///</summary>
	public class GetConnections : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetConnections);

		}
	}
}
