using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ICADLibrary Interface
///</summary>
namespace mdsLibManagerLib.CADLibrary 
{

	[NVP_Manifest(
		Id = "BD5B98FA-082E-472E-9386-C3FC50BDF051", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibrary.CADLibrary_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibrary", 
		NodeName = "_CADLibrary_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class CADLibrary_Constructor : INode 
	{
		public mdsLibManagerLib.ICADLibrary _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLibManagerLib.ICADLibrary;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "6F5E20E5-2FE2-4D88-ACF4-63AD1BC5BE2E", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibrary.CADLibrary_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibrary", 
		NodeName = "_CADLibrary_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class CADLibrary_ConstructorCast : INode 
	{
		public mdsLibManagerLib.ICADLibrary _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLibManagerLib.ICADLibrary;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C59FF85B-2320-4BFA-9FDA-94CFC2398B5C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibrary.IsConnected", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibrary", 
		NodeName = "IsConnected", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Проверка соединения", 
		ViewType = "Data")]
	[NodeInput("CADLibrary", typeof(object))]

	///<summary>
	///Проверка соединения
	///</summary>
	public class IsConnected : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsConnected);

		}
	}


	[NVP_Manifest(
		Id = "3A99F366-2104-4002-8142-46C8647F4B33", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibrary.GetLibObject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibrary", 
		NodeName = "GetLibObject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Получение объекта по идентификатору", 
		ViewType = "Data")]
	[NodeInput("CADLibrary", typeof(object))]
	[NodeInput("Identifier", typeof(System.Object))]

	///<summary>
	///Получение объекта по идентификатору
	///</summary>
	public class GetLibObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLibObject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "FA3EA09F-48F6-4B5D-AA21-283FC02CAD03", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibrary.GetLibQuery", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibrary", 
		NodeName = "GetLibQuery", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Создание запроса к базе", 
		ViewType = "Data")]
	[NodeInput("CADLibrary", typeof(object))]

	///<summary>
	///Создание запроса к базе
	///</summary>
	public class GetLibQuery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLibQuery);

		}
	}


	[NVP_Manifest(
		Id = "38D56C08-A261-4977-BE14-71235737EFA2", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsLibManagerLib.CADLibrary.Insert", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsLibManagerLib.CADLibrary", 
		NodeName = "Insert", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вставка объекта из базы", 
		ViewType = "Data")]
	[NodeInput("CADLibrary", typeof(object))]
	[NodeInput("Identifier", typeof(System.Object))]
	[NodeInput("Constraints", typeof(System.Object))]
	[NodeInput("TaskData", typeof(System.Object))]

	///<summary>
	///Вставка объекта из базы
	///</summary>
	public class Insert : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Insert(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}
}
