using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.PlumbingFixtureStyleManager 
{

	[NVP_Manifest(
		Id = "1D62732C-84C7-48D7-B296-00F229D4758D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PlumbingFixtureStyleManager.PlumbingFixtureStyleManager_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PlumbingFixtureStyleManager", 
		NodeName = "_PlumbingFixtureStyleManager_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PlumbingFixtureStyleManager_Constructor : INode 
	{
		public Renga.IPlumbingFixtureStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IPlumbingFixtureStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "25C07639-9731-454C-ADAA-8BD8708CF51E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PlumbingFixtureStyleManager.PlumbingFixtureStyleManager_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PlumbingFixtureStyleManager", 
		NodeName = "_PlumbingFixtureStyleManager_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PlumbingFixtureStyleManager_ConstructorCast : INode 
	{
		public Renga.IPlumbingFixtureStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IPlumbingFixtureStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "0E832C91-FC0B-4AB1-BE63-5FBFD44071D5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PlumbingFixtureStyleManager.GetIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PlumbingFixtureStyleManager", 
		NodeName = "GetIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("PlumbingFixtureStyleManager", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetIds();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FE73B65F-C196-4FD0-9471-DB8382CDE14D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PlumbingFixtureStyleManager.Contains", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PlumbingFixtureStyleManager", 
		NodeName = "Contains", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PlumbingFixtureStyleManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class Contains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contains(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "D95D64A9-08D6-402A-9419-A1EA1FCDE32E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.PlumbingFixtureStyleManager.GetPlumbingFixtureStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.PlumbingFixtureStyleManager", 
		NodeName = "GetPlumbingFixtureStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("PlumbingFixtureStyleManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetPlumbingFixtureStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPlumbingFixtureStyle(inputs[1].Value));

		}
	}
}
