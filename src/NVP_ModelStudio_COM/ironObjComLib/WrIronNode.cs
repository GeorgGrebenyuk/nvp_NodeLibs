using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrIronNode Interface
///</summary>
namespace NVP_ModelStudio_COM._ironObjComLib.WrIronNode 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronNode_Constructor : INode 
	{
		public ironObjComLib.IWrIronNode _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrIronNode;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronNode_ConstructorCast : INode 
	{
		public ironObjComLib.IWrIronNode _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrIronNode;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "method Item", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]

	///<summary>
	///method Item
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item);

		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]

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
	[NodeInput("WrIronNode", typeof(object))]
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
		Text = "property UnitName", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]

	///<summary>
	///property UnitName
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
		Text = "property UnitName", 
		ViewType = "Modifier")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property UnitName
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
		Text = "property GetAngle", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("axis1", typeof(System.Object))]
	[NodeInput("axis2", typeof(System.Object))]

	///<summary>
	///property GetAngle
	///</summary>
	public class GetAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAngle(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "property GetAngleXY", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("axis1", typeof(System.Object))]
	[NodeInput("axis2", typeof(System.Object))]

	///<summary>
	///property GetAngleXY
	///</summary>
	public class GetAngleXY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAngleXY(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "property GetAngleXZ", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("axis1", typeof(System.Object))]
	[NodeInput("axis2", typeof(System.Object))]

	///<summary>
	///property GetAngleXZ
	///</summary>
	public class GetAngleXZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAngleXZ(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Базовая точка", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]

	///<summary>
	///Базовая точка
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
		Text = "Тип положения базовой точки", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]

	///<summary>
	///Тип положения базовой точки
	///</summary>
	public class BasePositionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BasePositionType);

		}
	}


	[NVP_Manifest(
		Text = "Тип положения базовой точки", 
		ViewType = "Modifier")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип положения базовой точки
	///</summary>
	public class Set_BasePositionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BasePositionType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Положение базовой точки на металле", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]

	///<summary>
	///Положение базовой точки на металле
	///</summary>
	public class BasePositionValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BasePositionValue);

		}
	}


	[NVP_Manifest(
		Text = "Положение базовой точки на металле", 
		ViewType = "Modifier")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Положение базовой точки на металле
	///</summary>
	public class Set_BasePositionValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BasePositionValue = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Тип направления оси Z", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]

	///<summary>
	///Тип направления оси Z
	///</summary>
	public class AxisDirectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisDirectionType);

		}
	}


	[NVP_Manifest(
		Text = "Тип направления оси Z", 
		ViewType = "Modifier")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип направления оси Z
	///</summary>
	public class Set_AxisDirectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AxisDirectionType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method GetArea", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("Element", typeof(System.Object))]
	[NodeInput("bodyOptions", typeof(System.Object))]

	///<summary>
	///method GetArea
	///</summary>
	public class GetArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetArea(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "method GetVolume", 
		ViewType = "Data")]
	[NodeInput("WrIronNode", typeof(object))]
	[NodeInput("Element", typeof(System.Object))]
	[NodeInput("bodyOptions", typeof(System.Object))]

	///<summary>
	///method GetVolume
	///</summary>
	public class GetVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetVolume(inputs[1].Value,inputs[2].Value));

		}
	}
}
