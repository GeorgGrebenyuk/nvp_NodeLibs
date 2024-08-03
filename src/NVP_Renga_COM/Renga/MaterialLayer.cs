using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.MaterialLayer 
{

	[NVP_Manifest(
		Id = "F9E569C3-FCCF-456E-AC58-EF2CCD631FE7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.MaterialLayer.MaterialLayer_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.MaterialLayer", 
		NodeName = "_MaterialLayer_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MaterialLayer_Constructor : INode 
	{
		public Renga.IMaterialLayer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IMaterialLayer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8DBB0B36-09DF-4C11-824F-3CA6B712BFF4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.MaterialLayer.MaterialLayer_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.MaterialLayer", 
		NodeName = "_MaterialLayer_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MaterialLayer_ConstructorCast : INode 
	{
		public Renga.IMaterialLayer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IMaterialLayer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "800AEAD6-391B-4AA5-B4E0-90B5304354C1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.MaterialLayer.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.MaterialLayer", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("MaterialLayer", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		Id = "E3282609-F16D-4ABD-8099-21BDD7630CDD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.MaterialLayer.Thickness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.MaterialLayer", 
		NodeName = "Thickness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("MaterialLayer", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	[NVP_Manifest(
		Id = "82869C06-F42B-4C0D-B442-EAD1BA847742", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.MaterialLayer.Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.MaterialLayer", 
		NodeName = "Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("MaterialLayer", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Material);

		}
	}
}
