using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.PlumbingFixtureStyle 
{

	[NVP_Manifest(
		Id = "A75A4B21-5B77-4F8E-B085-722349A2C3D1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PlumbingFixtureStyle.PlumbingFixtureStyle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PlumbingFixtureStyle", 
		NodeName = "_PlumbingFixtureStyle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PlumbingFixtureStyle_Constructor : INode 
	{
		public Renga.IPlumbingFixtureStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPlumbingFixtureStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "CCE36206-8710-4316-81EC-E924BD6C412A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PlumbingFixtureStyle.PlumbingFixtureStyle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PlumbingFixtureStyle", 
		NodeName = "_PlumbingFixtureStyle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PlumbingFixtureStyle_ConstructorCast : INode 
	{
		public Renga.IPlumbingFixtureStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPlumbingFixtureStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "248D8E89-DDD5-4C5F-A8D7-6CE51AE4D640", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PlumbingFixtureStyle.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PlumbingFixtureStyle", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PlumbingFixtureStyle", typeof(object))]

	///<summary>
	///
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
		Id = "81268660-88A4-495F-A0F7-B9FFAAE3ED65", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PlumbingFixtureStyle.Category", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PlumbingFixtureStyle", 
		NodeName = "Category", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PlumbingFixtureStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Category : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Category);

		}
	}
}
