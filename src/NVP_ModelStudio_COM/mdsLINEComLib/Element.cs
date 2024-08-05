using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IElement Interface
///</summary>
namespace mdsLINEComLib.Element 
{

	[NVP_Manifest(
		Id = "27AFB051-9E0A-4DB6-8B8D-FBDA692E8E2F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.Element_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
		NodeName = "_Element_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Element_Constructor : INode 
	{
		public mdsLINEComLib.IElement _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IElement;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "569FE642-550D-47A4-A190-8DC57D24032B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.Element_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
		NodeName = "_Element_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Element_ConstructorCast : INode 
	{
		public mdsLINEComLib.IElement _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IElement;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C931B9B7-7DA3-4002-9825-17BAFE843EEC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "23A3FB52-7E0F-4E5A-A4B7-EB8A6D41A25F", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "6E7FAE87-980A-4E84-B7DF-FB8FA5DA51B8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.Parameters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "A94D2FF5-FEC8-45CF-911A-416B90F76F99", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "1666EC23-E138-4903-8B2D-F7F64C50AEAE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.Set_Parent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "2225270F-EB56-42E0-A347-4F7E196FA884", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.SubElements", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "D760CDF6-6908-4E49-9710-09F9EE10BFC5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
		NodeName = "Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Подчиненные элементы", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]

	///<summary>
	///Подчиненные элементы
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
		Id = "03BEBF23-D15C-4A61-BC4A-94E7E987BD82", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.IsValid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "BB1BEF30-1B15-43C4-BCC3-C6C1B4C1B729", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.ElementId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "070404A5-B5B3-4AF3-92B0-B8D37C2FC6F5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.ObjectId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "0FA816A7-FDEA-401A-9778-31175C99AFAA", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.Implementation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "C8D8CF5A-5215-4480-A371-D342AB16412D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.CopyFrom", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "21672E53-5EBC-4D1E-A4D6-FBFBA04FBCFC", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.GetPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "EA46FE61-184E-4421-A108-DB9ABD3EAAFE", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.GetParentByLevel", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
		NodeName = "GetParentByLevel", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Путь до текущего элемента", 
		ViewType = "Data")]
	[NodeInput("Element", typeof(object))]
	[NodeInput("level", typeof(System.Object))]

	///<summary>
	///Путь до текущего элемента
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
		Id = "81425A86-A2C5-488F-9AC9-78A0A0B79CE8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.GetValue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "484B2C12-94E5-41E8-867F-3A0F83243E30", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.GetValueComment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "F865A620-DD11-4097-9BA6-9003B09A7056", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.AddChild", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
		Id = "4A5E37D4-9390-46D6-99A4-3648060B0E5A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLINEComLib.Element.HasParent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLINEComLib.Element", 
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
}
