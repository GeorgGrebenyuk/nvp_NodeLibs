using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSELCollision Interface
///</summary>
namespace mdsUnitsLib.MDSELCollision 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSELCollision_Constructor : INode 
	{
		public mdsUnitsLib.IMDSELCollision _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSELCollision;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSELCollision_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSELCollision _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSELCollision;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Наименование коллизии", 
		ViewType = "Data")]
	[NodeInput("MDSELCollision", typeof(object))]

	///<summary>
	///Наименование коллизии
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
		Text = "Наименование коллизии", 
		ViewType = "Modifier")]
	[NodeInput("MDSELCollision", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Наименование коллизии
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
		Text = "Причина коллизии", 
		ViewType = "Data")]
	[NodeInput("MDSELCollision", typeof(object))]

	///<summary>
	///Причина коллизии
	///</summary>
	public class Cause : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Cause);

		}
	}


	[NVP_Manifest(
		Text = "Причина коллизии", 
		ViewType = "Modifier")]
	[NodeInput("MDSELCollision", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Причина коллизии
	///</summary>
	public class Set_Cause : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Cause = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Тип коллизии", 
		ViewType = "Data")]
	[NodeInput("MDSELCollision", typeof(object))]

	///<summary>
	///Тип коллизии
	///</summary>
	public class CollisionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CollisionType);

		}
	}


	[NVP_Manifest(
		Text = "Тип коллизии", 
		ViewType = "Modifier")]
	[NodeInput("MDSELCollision", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Тип коллизии
	///</summary>
	public class Set_CollisionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CollisionType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Расстояние коллизии", 
		ViewType = "Data")]
	[NodeInput("MDSELCollision", typeof(object))]

	///<summary>
	///Расстояние коллизии
	///</summary>
	public class CollisionDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CollisionDistance);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние коллизии", 
		ViewType = "Modifier")]
	[NodeInput("MDSELCollision", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Расстояние коллизии
	///</summary>
	public class Set_CollisionDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CollisionDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Первая группа", 
		ViewType = "Data")]
	[NodeInput("MDSELCollision", typeof(object))]

	///<summary>
	///Первая группа
	///</summary>
	public class Group1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Group1);

		}
	}


	[NVP_Manifest(
		Text = "Первая группа", 
		ViewType = "Modifier")]
	[NodeInput("MDSELCollision", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Первая группа
	///</summary>
	public class Set_Group1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Group1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Вторая группа", 
		ViewType = "Data")]
	[NodeInput("MDSELCollision", typeof(object))]

	///<summary>
	///Вторая группа
	///</summary>
	public class Group2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Group2);

		}
	}


	[NVP_Manifest(
		Text = "Вторая группа", 
		ViewType = "Modifier")]
	[NodeInput("MDSELCollision", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Вторая группа
	///</summary>
	public class Set_Group2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Group2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Профиль проверки", 
		ViewType = "Data")]
	[NodeInput("MDSELCollision", typeof(object))]

	///<summary>
	///Профиль проверки
	///</summary>
	public class ProfileName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProfileName);

		}
	}


	[NVP_Manifest(
		Text = "Профиль проверки", 
		ViewType = "Modifier")]
	[NodeInput("MDSELCollision", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Профиль проверки
	///</summary>
	public class Set_ProfileName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProfileName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MDSELCollision", typeof(object))]

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
	[NodeInput("MDSELCollision", typeof(object))]
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
		Text = "Описание первого объекта", 
		ViewType = "Data")]
	[NodeInput("MDSELCollision", typeof(object))]

	///<summary>
	///Описание первого объекта
	///</summary>
	public class ObjectNameFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectNameFirst);

		}
	}


	[NVP_Manifest(
		Text = "Описание второго объекта", 
		ViewType = "Data")]
	[NodeInput("MDSELCollision", typeof(object))]

	///<summary>
	///Описание второго объекта
	///</summary>
	public class ObjectNameSecond : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectNameSecond);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние", 
		ViewType = "Data")]
	[NodeInput("MDSELCollision", typeof(object))]

	///<summary>
	///Расстояние
	///</summary>
	public class Distance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Distance);

		}
	}


	[NVP_Manifest(
		Text = "Первый объект", 
		ViewType = "Data")]
	[NodeInput("MDSELCollision", typeof(object))]

	///<summary>
	///Первый объект
	///</summary>
	public class ObjectFirst : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectFirst);

		}
	}


	[NVP_Manifest(
		Text = "Второй объект", 
		ViewType = "Data")]
	[NodeInput("MDSELCollision", typeof(object))]

	///<summary>
	///Второй объект
	///</summary>
	public class ObjectSecond : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectSecond);

		}
	}
}
