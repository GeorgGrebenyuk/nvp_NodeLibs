using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.enum_PipeConnectionType 
{


	[NVP_Manifest(
		Id = "CBC99BB5-B8EC-4755-851D-7CE61705DD4C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_PipeConnectionType.enum_PipeConnectionType_Weld", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_PipeConnectionType", 
		NodeName = "enum_PipeConnectionType_Weld", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_PipeConnectionType_Weld : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.PipeConnectionType.PipeConnectionType_Weld);

		}
	}


	[NVP_Manifest(
		Id = "A6470D7B-EDB9-4E12-9205-F6BB51C998DD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_PipeConnectionType.enum_PipeConnectionType_Flange", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_PipeConnectionType", 
		NodeName = "enum_PipeConnectionType_Flange", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_PipeConnectionType_Flange : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.PipeConnectionType.PipeConnectionType_Flange);

		}
	}


	[NVP_Manifest(
		Id = "F8E9184C-3ED2-4D94-AA61-4ABBA453FF16", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_PipeConnectionType.enum_PipeConnectionType_Compressed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_PipeConnectionType", 
		NodeName = "enum_PipeConnectionType_Compressed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_PipeConnectionType_Compressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.PipeConnectionType.PipeConnectionType_Compressed);

		}
	}


	[NVP_Manifest(
		Id = "D969BF25-DCC5-46FC-AD67-1A3F833DC8E3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_PipeConnectionType.enum_PipeConnectionType_Socket", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_PipeConnectionType", 
		NodeName = "enum_PipeConnectionType_Socket", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_PipeConnectionType_Socket : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.PipeConnectionType.PipeConnectionType_Socket);

		}
	}


	[NVP_Manifest(
		Id = "65A13C96-F923-4302-BE2B-9AC42046D269", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_PipeConnectionType.enum_PipeConnectionType_Thread", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_PipeConnectionType", 
		NodeName = "enum_PipeConnectionType_Thread", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_PipeConnectionType_Thread : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.PipeConnectionType.PipeConnectionType_Thread);

		}
	}


	[NVP_Manifest(
		Id = "CD14D693-06D2-40CD-A95A-D301FF3E1F15", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_PipeConnectionType.enum_PipeConnectionType_QuickConnection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_PipeConnectionType", 
		NodeName = "enum_PipeConnectionType_QuickConnection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_PipeConnectionType_QuickConnection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.PipeConnectionType.PipeConnectionType_QuickConnection);

		}
	}


	[NVP_Manifest(
		Id = "07526B6C-3C0B-44A1-9680-7EC2467A28AA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_PipeConnectionType.enum_PipeConnectionType_Glue", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_PipeConnectionType", 
		NodeName = "enum_PipeConnectionType_Glue", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_PipeConnectionType_Glue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.PipeConnectionType.PipeConnectionType_Glue);

		}
	}


	[NVP_Manifest(
		Id = "17CCCF8B-825A-4568-847D-063807E97106", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_PipeConnectionType.enum_PipeConnectionType_FusionWelding", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_PipeConnectionType", 
		NodeName = "enum_PipeConnectionType_FusionWelding", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_PipeConnectionType_FusionWelding : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.PipeConnectionType.PipeConnectionType_FusionWelding);

		}
	}


	[NVP_Manifest(
		Id = "3D94A632-D9CE-4F5B-B229-24B6CE9CAEFB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.enum_PipeConnectionType.enum_PipeConnectionType_Grooved", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.enum_PipeConnectionType", 
		NodeName = "enum_PipeConnectionType_Grooved", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_PipeConnectionType_Grooved : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(Renga.PipeConnectionType.PipeConnectionType_Grooved);

		}
	}
}
