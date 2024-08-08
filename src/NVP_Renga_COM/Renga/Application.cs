using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Application 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Application_Constructor : INode 
	{
		public Renga.IApplication _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IApplication;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Application_ConstructorCast : INode 
	{
		public Renga.IApplication _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IApplication;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Enable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Enable();
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Disable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Disable();
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Application", typeof(object))]
	[NodeInput("pEnabled", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Enabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Enabled);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetMainWindowHandle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMainWindowHandle);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ActiveView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveView);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class UI : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UI);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasProject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasProject);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Project : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Project);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Selection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Selection);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetCurrentLocale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCurrentLocale);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CreateProject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateProject);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]
	[NodeInput("fileName", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class CreateProjectFromTemplate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateProjectFromTemplate(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]
	[NodeInput("fileName", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class ImportIfcProject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ImportIfcProject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]
	[NodeInput("fileName", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class OpenProject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OpenProject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]
	[NodeInput("discardChanges", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class CloseProject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CloseProject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Quit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Quit();
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Visible);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Application", typeof(object))]
	[NodeInput("pVisible", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Visible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class CreateIfcExportSettings : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateIfcExportSettings);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Application", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Version : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Version);

		}
	}
}
