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
		Id = "B4935494-E170-4465-B6F2-C2A4916DB638", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibObject.CADLibObject_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibObject", 
		NodeName = "_CADLibObject_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "207B6C05-32B3-414B-96F2-BA14F5B27134", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibObject.CADLibObject_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibObject", 
		NodeName = "_CADLibObject_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "A431A102-C9CB-4D61-992D-A15F30ECF1D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibObject.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibObject", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "7D052912-9566-4AD0-AEBF-50D9397CB9F1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibObject.Category", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibObject", 
		NodeName = "Category", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "349040FF-EE0B-4825-BC5C-9B3E6E72C176", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibObject.CategoryId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibObject", 
		NodeName = "CategoryId", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "6E68ECB7-9A74-4D56-A21E-FBF7E0B12995", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibObject.RootElement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibObject", 
		NodeName = "RootElement", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "E159E78C-B7D7-474C-A814-36C02AE0CBD9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibObject.GUID", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibObject", 
		NodeName = "GUID", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "A3DAD91D-FFA6-4164-96AD-C3A381547904", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibObject.ObjectId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibObject", 
		NodeName = "ObjectId", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "A54E0263-F44A-47DD-85D7-52C0F6F451EC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibObject.Children", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibObject", 
		NodeName = "Children", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "D8584451-EDFC-4125-925B-BEB5B0081A2C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibObject.GetGraphicsPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibObject", 
		NodeName = "GetGraphicsPath", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "F62A1D9A-3275-4233-864E-9EB98A31C0ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibObject.HasGraphics", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibObject", 
		NodeName = "HasGraphics", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "D5085500-37D2-4B1F-A0CE-51F22D0C5EEE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibObject.HasFileOfCategory", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibObject", 
		NodeName = "HasFileOfCategory", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "1EE36182-45FC-4F62-8FE9-AA80B9FFD5F6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibObject.ElementId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibObject", 
		NodeName = "ElementId", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "0E621C4F-60BA-494B-A92D-418660F8CA32", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibObject.ParentId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibObject", 
		NodeName = "ParentId", 
		NodeType = "Loaded", 
		CADType = "None", 
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
