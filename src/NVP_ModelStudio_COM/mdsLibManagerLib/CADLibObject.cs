using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ICADLibObject Interface
///</summary>
namespace mdsLibManagerLib.CADLibObject 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class CADLibObject_Constructor : INode 
	{
		public mdsLibManagerLib.ICADLibObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLibManagerLib.ICADLibObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class CADLibObject_ConstructorCast : INode 
	{
		public mdsLibManagerLib.ICADLibObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLibManagerLib.ICADLibObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Имя объекта", 
		ViewType = "Data")]
	[NodeInput("CADLibObject", typeof(object))]

	///<summary>
	///Имя объекта
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
		Text = "Системное имя категории", 
		ViewType = "Data")]
	[NodeInput("CADLibObject", typeof(object))]

	///<summary>
	///Системное имя категории
	///</summary>
	public class Category : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Category);

		}
	}


	[NVP_Manifest(
		Text = "Идентификатор категории", 
		ViewType = "Data")]
	[NodeInput("CADLibObject", typeof(object))]

	///<summary>
	///Идентификатор категории
	///</summary>
	public class CategoryId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CategoryId);

		}
	}


	[NVP_Manifest(
		Text = "Параметры объекта", 
		ViewType = "Data")]
	[NodeInput("CADLibObject", typeof(object))]

	///<summary>
	///Параметры объекта
	///</summary>
	public class RootElement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RootElement);

		}
	}


	[NVP_Manifest(
		Text = "GUID объекта", 
		ViewType = "Data")]
	[NodeInput("CADLibObject", typeof(object))]

	///<summary>
	///GUID объекта
	///</summary>
	public class GUID : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GUID);

		}
	}


	[NVP_Manifest(
		Text = "Идентификатор объекта", 
		ViewType = "Data")]
	[NodeInput("CADLibObject", typeof(object))]

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
		Text = "Подчиненные элементы", 
		ViewType = "Data")]
	[NodeInput("CADLibObject", typeof(object))]

	///<summary>
	///Подчиненные элементы
	///</summary>
	public class Children : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Children);

		}
	}


	[NVP_Manifest(
		Text = "Путь к файлу указанной категории", 
		ViewType = "Data")]
	[NodeInput("CADLibObject", typeof(object))]
	[NodeInput("FileCategory", typeof(System.String))]

	///<summary>
	///Путь к файлу указанной категории
	///</summary>
	public class GetGraphicsPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGraphicsPath(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Наличие графики", 
		ViewType = "Data")]
	[NodeInput("CADLibObject", typeof(object))]

	///<summary>
	///Наличие графики
	///</summary>
	public class HasGraphics : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasGraphics);

		}
	}


	[NVP_Manifest(
		Text = "Наличие файла заданной категории", 
		ViewType = "Data")]
	[NodeInput("CADLibObject", typeof(object))]
	[NodeInput("Category", typeof(System.String))]

	///<summary>
	///Наличие файла заданной категории
	///</summary>
	public class HasFileOfCategory : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasFileOfCategory(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Идентификатор элемента", 
		ViewType = "Data")]
	[NodeInput("CADLibObject", typeof(object))]

	///<summary>
	///Идентификатор элемента
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
		Text = "Идентификатор родителя", 
		ViewType = "Data")]
	[NodeInput("CADLibObject", typeof(object))]

	///<summary>
	///Идентификатор родителя
	///</summary>
	public class ParentId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ParentId);

		}
	}
}
