using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Room 
{

	[NVP_Manifest(
		Id = "9B281D18-B40C-4863-9E35-6587F019FB51", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Room.Room_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Room", 
		NodeName = "_Room_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Room_Constructor : INode 
	{
		public Renga.IRoom _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IRoom;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "57F93977-9FCF-4489-9E2A-E59796E59E4A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Room.Room_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Room", 
		NodeName = "_Room_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Room_ConstructorCast : INode 
	{
		public Renga.IRoom _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IRoom;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "06128718-7E52-40F9-A39F-F6CECD0A72A1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Room.RoomName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Room", 
		NodeName = "RoomName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Room", typeof(object))]

	///<summary>
	///
	///</summary>
	public class RoomName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RoomName);

		}
	}


	[NVP_Manifest(
		Id = "E8358FC4-F073-4A39-8C6B-2DB5F1FC7C43", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Room.RoomNumber", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Room", 
		NodeName = "RoomNumber", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Room", typeof(object))]

	///<summary>
	///
	///</summary>
	public class RoomNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RoomNumber);

		}
	}


	[NVP_Manifest(
		Id = "DD819AF7-EF71-4BA2-8796-B140547F331E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Room.MarkerPosition", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Room", 
		NodeName = "MarkerPosition", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Room", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MarkerPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MarkerPosition);

		}
	}
}
