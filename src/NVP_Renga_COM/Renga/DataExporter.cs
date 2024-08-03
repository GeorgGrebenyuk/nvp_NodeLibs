using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.DataExporter 
{

	[NVP_Manifest(
		Id = "EDC243A9-82BF-448E-BC6E-BAD0D5A90DC2", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DataExporter.DataExporter_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DataExporter", 
		NodeName = "_DataExporter_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class DataExporter_Constructor : INode 
	{
		public Renga.IDataExporter _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IDataExporter;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "735B605D-1A71-48C2-96BF-E0B97FDA4F8C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DataExporter.DataExporter_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DataExporter", 
		NodeName = "_DataExporter_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class DataExporter_ConstructorCast : INode 
	{
		public Renga.IDataExporter _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IDataExporter;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "04415ECE-92D0-4B38-9745-AE431596C7A7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DataExporter.GetObjects3D", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DataExporter", 
		NodeName = "GetObjects3D", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("DataExporter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetObjects3D : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObjects3D);

		}
	}


	[NVP_Manifest(
		Id = "DDCCE686-D296-46D1-9C67-BAA639D2324D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.DataExporter.GetGrids", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.DataExporter", 
		NodeName = "GetGrids", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("DataExporter", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetGrids : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetGrids);

		}
	}
}
