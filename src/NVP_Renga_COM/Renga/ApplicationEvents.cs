using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ApplicationEvents 
{

	[NVP_Manifest(
		Id = "F0D245FD-16DA-4CFD-9D59-149305D6D8CC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ApplicationEvents.ApplicationEvents_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ApplicationEvents", 
		NodeName = "_ApplicationEvents_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ApplicationEvents_Constructor : INode 
	{
		public Renga._IApplicationEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga._IApplicationEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "EC440516-747C-4E6F-BDB8-943F53214F75", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ApplicationEvents.ApplicationEvents_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ApplicationEvents", 
		NodeName = "_ApplicationEvents_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ApplicationEvents_ConstructorCast : INode 
	{
		public Renga._IApplicationEvents _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga._IApplicationEvents;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A67AAFF8-E950-4B91-BCDC-FA23067E8147", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ApplicationEvents.OnBeforeApplicationClose", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ApplicationEvents", 
		NodeName = "OnBeforeApplicationClose", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ApplicationEvents", typeof(object))]
	[NodeInput("pEvent", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class OnBeforeApplicationClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnBeforeApplicationClose(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "370B2BD7-C406-448B-B085-6C9A94D8F415", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ApplicationEvents.OnBeforeProjectClose", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ApplicationEvents", 
		NodeName = "OnBeforeProjectClose", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ApplicationEvents", typeof(object))]
	[NodeInput("pEvent", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class OnBeforeProjectClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnBeforeProjectClose(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CF2ADB7C-24C6-4C43-A263-96F3123BC878", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ApplicationEvents.OnProjectCreated", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ApplicationEvents", 
		NodeName = "OnProjectCreated", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ApplicationEvents", typeof(object))]

	///<summary>
	///
	///</summary>
	public class OnProjectCreated : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnProjectCreated();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "610B6E33-9142-42E0-BBA4-8E021710A3CE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ApplicationEvents.OnProjectOpened", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ApplicationEvents", 
		NodeName = "OnProjectOpened", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ApplicationEvents", typeof(object))]
	[NodeInput("filePath_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class OnProjectOpened : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnProjectOpened(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "92B41250-87A0-4A61-A547-7951E6D67A0C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ApplicationEvents.OnProjectSaved", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ApplicationEvents", 
		NodeName = "OnProjectSaved", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ApplicationEvents", typeof(object))]
	[NodeInput("filePath_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class OnProjectSaved : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnProjectSaved(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2D0ACBDE-1F64-4B01-B59E-9DE5B8C12D59", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ApplicationEvents.OnProjectClosed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ApplicationEvents", 
		NodeName = "OnProjectClosed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ApplicationEvents", typeof(object))]

	///<summary>
	///
	///</summary>
	public class OnProjectClosed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OnProjectClosed();
			return null;
		}
	}
}
