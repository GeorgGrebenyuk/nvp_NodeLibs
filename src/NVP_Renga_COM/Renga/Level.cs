using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Level 
{

	[NVP_Manifest(
		Id = "92CF4532-7F1B-439A-9A40-214F749D48E9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Level.Level_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Level", 
		NodeName = "_Level_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Level_Constructor : INode 
	{
		public Renga.ILevel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILevel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "03FB70CB-F04A-4EB1-B440-5F8E747E03FE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Level.Level_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Level", 
		NodeName = "_Level_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Level_ConstructorCast : INode 
	{
		public Renga.ILevel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILevel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "E6C88C33-2863-4EDD-9F1C-383C77BC2041", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Level.Elevation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Level", 
		NodeName = "Elevation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Level", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Elevation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Elevation);

		}
	}


	[NVP_Manifest(
		Id = "A3BD200E-1559-483B-B65A-28FEA7B1B5F0", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Level.LevelName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Level", 
		NodeName = "LevelName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Level", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LevelName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LevelName);

		}
	}


	[NVP_Manifest(
		Id = "CAE5D64E-AB44-4840-BEE0-B90F588A41AC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Level.Placement", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Level", 
		NodeName = "Placement", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Level", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Placement : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Placement);

		}
	}
}
