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
		Id = "5394FB6D-6464-4AFC-98B1-C87ECCEABD09", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.MDSELCollision_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "_MDSELCollision_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "3CB517FC-0CBA-4756-8C45-8C43BB13141B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.MDSELCollision_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "_MDSELCollision_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
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
		Id = "51B687E1-EAE2-44C9-BCA2-9626BBB52057", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "81280830-4C77-4E9B-BB24-C07E0A971BDF", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "91A98CC0-0695-46F3-A636-D70E349ED908", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.Cause", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "Cause", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "08DACACA-BDDC-45B6-9341-BA302779BA35", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.Set_Cause", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "Set_Cause", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "9A60212B-80B8-4B55-913F-A452E6BE02CB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.CollisionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "CollisionType", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "699A67BB-38FC-4AF2-9E80-1F43B39A997B", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.Set_CollisionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "Set_CollisionType", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "DC7DD39B-BEDC-4640-9A75-9E977EA4D697", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.CollisionDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "CollisionDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "D30AC568-DCCD-4D85-9715-A96E33BE4D97", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.Set_CollisionDistance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "Set_CollisionDistance", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "D361B4B8-C6D7-4A01-9D43-2333700FA70D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.Group1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "Group1", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "E6653D7C-A06F-442C-9A90-BF8550FCE5B8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.Set_Group1", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "Set_Group1", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "63EE1EA7-3905-4F66-A2A6-A196D5163017", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.Group2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "Group2", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "E64A6075-EDA7-4F9E-9CAA-9C31B00A9D4A", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.Set_Group2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "Set_Group2", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "C780A645-B5FE-4F9C-89A2-6162C4B0FD8E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.ProfileName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "ProfileName", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "D01DA0E2-6DA9-4CE3-BFD4-AD85AE4D0B9D", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.Set_ProfileName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "Set_ProfileName", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "9CD13DF0-8EC8-4EEB-A7EE-7DC3FF7F2D1E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "FAF7BAC7-304A-4775-BDF7-72CC1A2DF261", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "C178BE23-1229-4CF1-87D0-AFB913586067", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.ObjectNameFirst", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "ObjectNameFirst", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "01008122-18AA-43D5-B3CE-0C0502699C93", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.ObjectNameSecond", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "ObjectNameSecond", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "35A1B9E3-E29A-4BF4-8714-315699E8EF00", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.Distance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "Distance", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "27023F80-6EBA-4D22-A81A-97BC8D078F44", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.ObjectFirst", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "ObjectFirst", 
		NodeType = "Loaded", 
		CADType = "None", 
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
		Id = "CBBD0344-485F-4D63-AB94-8FB5161F1D08", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSELCollision.ObjectSecond", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSELCollision", 
		NodeName = "ObjectSecond", 
		NodeType = "Loaded", 
		CADType = "None", 
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
