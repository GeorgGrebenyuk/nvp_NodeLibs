using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ContextMenuItem 
{

	[NVP_Manifest(
		Id = "E3469915-0712-4909-8AE7-0F57F08E1017", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ContextMenuItem.ContextMenuItem_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ContextMenuItem", 
		NodeName = "_ContextMenuItem_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ContextMenuItem_Constructor : INode 
	{
		public Renga.IContextMenuItem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IContextMenuItem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "1480136A-5251-4A68-854A-12079164DAC9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ContextMenuItem.ContextMenuItem_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ContextMenuItem", 
		NodeName = "_ContextMenuItem_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ContextMenuItem_ConstructorCast : INode 
	{
		public Renga.IContextMenuItem _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IContextMenuItem;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
