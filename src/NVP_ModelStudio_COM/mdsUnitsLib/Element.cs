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
		Id = "F40DB3EE-F95B-4D2B-BC8B-26BC87F71602", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.Element_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "_Element_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "1CDF6F2F-8EEE-4EEA-AA83-17AA3F64A83E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.Element_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "_Element_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "20AA5AEF-135A-4073-BE3B-78F6CBB0256B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "879B9FEC-2116-41C7-9EB3-0523F44CE085", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "7E0A15C3-55A4-4F4D-8F88-80DFE1E105E7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.Parameters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "Parameters", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "037F6765-0B63-4AEA-ADD8-95D71D3271A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "73E65D7E-553C-4236-88D3-351D1133E219", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.Set_Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "Set_Parent", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "66638530-C3EF-40EA-98F9-DC40D9B557A5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.SubElements", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "SubElements", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "1A4C536A-79CA-48C2-BA39-A009A472DCC5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "Description", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "89A22D9F-CEB6-48CC-826A-5176477813CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.IsValid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "IsValid", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "6C6D13E2-C6E6-4762-B717-88E81EE76533", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.ElementId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "ElementId", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "CBA21185-D21A-44D1-A030-49D49F64F51D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.ObjectId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "ObjectId", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "8FCBFBEC-96E0-4357-A906-BA1AC6A16740", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.Implementation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "Implementation", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "CE84EEFF-87F8-45D0-AA7A-7C65139CE776", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.CopyFrom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "CopyFrom", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "D3878579-4B28-4685-AABB-D524331910A3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.GetPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "GetPath", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "25ABB5AA-D678-451F-93A3-77D0E261DF25", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.GetParentByLevel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "GetParentByLevel", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "783ACFE1-565D-4A3C-8924-F67E67C6BABE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.GetValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "GetValue", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "7004DF94-7678-410F-8E02-682EC2196106", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.GetValueComment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "GetValueComment", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "053D758A-009A-4601-A13B-AA39B431768F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.AddChild", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "AddChild", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "FBDEA3CA-D590-4509-9662-3248BE17E642", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.HasParent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "HasParent", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "6398DDE0-2795-4809-BCAC-F2331E34638B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.Element.GetById", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.Element", 
		NodeName = "GetById", 
		NodeType = "Loaded", 
		CADType = "None", 
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
