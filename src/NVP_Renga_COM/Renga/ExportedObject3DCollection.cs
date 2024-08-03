using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ExportedObject3DCollection 
{

	[NVP_Manifest(
		Id = "91FC881A-8A54-4E17-965B-DA40F7BB0DF8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ExportedObject3DCollection.ExportedObject3DCollection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ExportedObject3DCollection", 
		NodeName = "_ExportedObject3DCollection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ExportedObject3DCollection_Constructor : INode 
	{
		public Renga.IExportedObject3DCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IExportedObject3DCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "CB2CD30A-A314-4F74-B194-D0FEF6E679B8", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ExportedObject3DCollection.ExportedObject3DCollection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ExportedObject3DCollection", 
		NodeName = "_ExportedObject3DCollection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ExportedObject3DCollection_ConstructorCast : INode 
	{
		public Renga.IExportedObject3DCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IExportedObject3DCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "491570B8-EA0C-4C3F-B90C-0E5BF0E78739", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ExportedObject3DCollection.Get", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ExportedObject3DCollection", 
		NodeName = "Get", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ExportedObject3DCollection", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class Get : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Get(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "2549FA27-89D2-4FC1-9943-FE074586A342", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ExportedObject3DCollection.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ExportedObject3DCollection", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ExportedObject3DCollection", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}
}
