using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ICADLibrary Interface
///</summary>
namespace NVP_ModelStudio_COM._mdsLibManagerLib.CADLibrary 
{

	[NVP_Manifest(
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
