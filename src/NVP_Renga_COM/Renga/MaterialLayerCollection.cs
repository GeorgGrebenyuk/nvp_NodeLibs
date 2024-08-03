using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.MaterialLayerCollection 
{

	[NVP_Manifest(
		Id = "3D84B147-4147-4687-AE35-E4F98AD9F67F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.MaterialLayerCollection.MaterialLayerCollection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.MaterialLayerCollection", 
		NodeName = "_MaterialLayerCollection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MaterialLayerCollection_Constructor : INode 
	{
		public Renga.IMaterialLayerCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IMaterialLayerCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "9FF3C303-8D97-48EE-B141-530D94939AC5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.MaterialLayerCollection.MaterialLayerCollection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.MaterialLayerCollection", 
		NodeName = "_MaterialLayerCollection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MaterialLayerCollection_ConstructorCast : INode 
	{
		public Renga.IMaterialLayerCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IMaterialLayerCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "81A0206C-B827-4F6E-9C19-263D868CBEE6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.MaterialLayerCollection.Get", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.MaterialLayerCollection", 
		NodeName = "Get", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("MaterialLayerCollection", typeof(object))]
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
		Id = "1E9237E3-ECF2-4659-A11A-9B674B48B91E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.MaterialLayerCollection.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.MaterialLayerCollection", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("MaterialLayerCollection", typeof(object))]

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
