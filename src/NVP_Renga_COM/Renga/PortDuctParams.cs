using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.PortDuctParams 
{

	[NVP_Manifest(
		Id = "224DFFCD-D085-44E0-9D44-8E69E69EFFEB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PortDuctParams.PortDuctParams_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PortDuctParams", 
		NodeName = "_PortDuctParams_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PortDuctParams_Constructor : INode 
	{
		public Renga.IPortDuctParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPortDuctParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "7EBFE532-1BD5-4377-AF0C-A1463A42F3DC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PortDuctParams.PortDuctParams_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PortDuctParams", 
		NodeName = "_PortDuctParams_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PortDuctParams_ConstructorCast : INode 
	{
		public Renga.IPortDuctParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPortDuctParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "77A49B3C-D933-4BB1-B1C5-6D4E2DE147CE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PortDuctParams.ConnectionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PortDuctParams", 
		NodeName = "ConnectionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PortDuctParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ConnectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConnectionType);

		}
	}


	[NVP_Manifest(
		Id = "2FAA8A2D-B8D1-49C9-931A-FFF0CABABC29", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PortDuctParams.DuctFormType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PortDuctParams", 
		NodeName = "DuctFormType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PortDuctParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class DuctFormType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DuctFormType);

		}
	}


	[NVP_Manifest(
		Id = "80D41C1D-D3E5-4B6C-959B-FF7061E311C1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PortDuctParams.NominalDiameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PortDuctParams", 
		NodeName = "NominalDiameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PortDuctParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class NominalDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NominalDiameter);

		}
	}


	[NVP_Manifest(
		Id = "D9A68868-208D-4F93-AD7F-4C0E6C9B4E60", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PortDuctParams.NominalWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PortDuctParams", 
		NodeName = "NominalWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PortDuctParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class NominalWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NominalWidth);

		}
	}


	[NVP_Manifest(
		Id = "6179F372-1189-4B82-9F32-0C0C8D6D7220", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PortDuctParams.NominalHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PortDuctParams", 
		NodeName = "NominalHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PortDuctParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class NominalHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NominalHeight);

		}
	}
}
