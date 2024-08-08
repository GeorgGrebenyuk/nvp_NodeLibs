using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IElement Interface
///</summary>
namespace mdsUnitsLib.Element 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Element_Constructor : INode 
	{
		public mdsUnitsLib.IElement _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IElement;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Element_ConstructorCast : INode 
	{
		public mdsUnitsLib.IElement _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IElement;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Имя элемента", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]

	///<summary>
	///Имя элемента
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
		Text = "Имя элемента", 
		ViewType = "Modifier")]
	[NodeInput("Element", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Имя элемента
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
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]

	///<summary>
	///Параметры
	///</summary>
	public class Parameters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parameters);

		}
	}


	[NVP_Manifest(
		Text = "Родительский элемент", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]

	///<summary>
	///Родительский элемент
	///</summary>
	public class Parent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parent);

		}
	}


	[NVP_Manifest(
		Text = "Родительский элемент", 
		ViewType = "Modifier")]
	[NodeInput("Element", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Родительский элемент
	///</summary>
	public class Set_Parent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Parent = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Подчиненные элементы", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]

	///<summary>
	///Подчиненные элементы
	///</summary>
	public class SubElements : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SubElements);

		}
	}


	[NVP_Manifest(
		Text = "Описание", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]

	///<summary>
	///Описание
	///</summary>
	public class Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Description);

		}
	}


	[NVP_Manifest(
		Text = "Действительный ли элемент", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]

	///<summary>
	///Действительный ли элемент
	///</summary>
	public class IsValid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsValid);

		}
	}


	[NVP_Manifest(
		Text = "Уникальный номер", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]

	///<summary>
	///Уникальный номер
	///</summary>
	public class ElementId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElementId);

		}
	}


	[NVP_Manifest(
		Text = "Идентификатор объекта", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]

	///<summary>
	///Идентификатор объекта
	///</summary>
	public class ObjectId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectId);

		}
	}


	[NVP_Manifest(
		Text = "property Implementation", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]

	///<summary>
	///property Implementation
	///</summary>
	public class Implementation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Implementation);

		}
	}


	[NVP_Manifest(
		Text = "Копировать данные", 
		ViewType = "Modifier")]
	[NodeInput("Element", typeof(object))]
	[NodeInput("pSrc", typeof(System.Object))]

	///<summary>
	///Копировать данные
	///</summary>
	public class CopyFrom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CopyFrom(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Путь до текущего элемента", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]
	[NodeInput("divider", typeof(System.String))]

	///<summary>
	///Путь до текущего элемента
	///</summary>
	public class GetPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPath(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Получение родителя заданного уровня", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]
	[NodeInput("level", typeof(System.Object))]

	///<summary>
	///Получение родителя заданного уровня
	///</summary>
	public class GetParentByLevel : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetParentByLevel(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Значение параметра", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]
	[NodeInput("parameter", typeof(System.String))]

	///<summary>
	///Значение параметра
	///</summary>
	public class GetValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetValue(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Комментарий к значению параметра", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]
	[NodeInput("parameter", typeof(System.String))]

	///<summary>
	///Комментарий к значению параметра
	///</summary>
	public class GetValueComment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetValueComment(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Добавить подчиненный элемент", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Добавить подчиненный элемент
	///</summary>
	public class AddChild : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddChild(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Имеется ли валидный родитель", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]

	///<summary>
	///Имеется ли валидный родитель
	///</summary>
	public class HasParent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasParent);

		}
	}


	[NVP_Manifest(
		Text = "Получение подобъекта по идентификатору", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]
	[NodeInput("nElementId", typeof(System.Object))]

	///<summary>
	///Получение подобъекта по идентификатору
	///</summary>
	public class GetById : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetById(inputs[1].Value));

		}
	}
}
